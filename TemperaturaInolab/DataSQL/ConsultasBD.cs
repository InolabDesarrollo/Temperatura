using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Microsoft.Web.WebView2.Core;
using static System.Net.Mime.MediaTypeNames;
using System.Text.RegularExpressions;

namespace TemperaturaInolab.DataSQL
{
    internal class ConsultasBD
    {
        public string Conexion;
        public string strSQL;
        SqlConnection Conn;
        SqlCommand Cmd;

        string ConBDServer = "Data Source=INOLABSERVER03;Initial Catalog=Browser;Persist Security Info=True;User ID=ventas;Password=V3ntas_17";
        string ConBDPruebas = "Data Source=INOLABSERVER03;Initial Catalog=DocumentacionPruebas;Persist Security Info=True;User ID=ventas;Password=V3ntas_17";

        public List<string[,]> DatosUnificados { get => unificados; set => unificados = value; }
        public List<string> GetSensores { get => Sensores; set => Sensores = value; }
        public List<string> GetArchivos = new List<string>();//archivos

        //VAlores de sensores
        public List<string> GetDates = new List<string>();
        public List<string> GetTemperatura = new List<string>();
        public List<string> GetHumedad = new List<string>();

        private List<string> Sensores = new List<string>();
        private static List<string[,]> unificados = new List<string[,]>();

        string date = "", temperatura = "", humedad = "";

        string[] partDate1;
        string[] partDate2;

        public string[,] MatrizDatosView = null;// no se utliza, prueba de datos para impresion

        public SqlDataReader getLogin(int tipoBD, string usuario)
        {
            strSQL = "Select * from Usuarios where Activo = 1 and Usuario= '" + usuario + "'";

            try
            {
                return ExecuteReader(strSQL, tipoBD);
            }
            catch(Exception ex)
            {
                throw new Exception("Error al Recuperar Cadena SQL getLogin: " + ex.Message + " - " + ex.ToString());
            }
        }


        public void ReadDatosElitechHumedadTemperatura(OpenFileDialog filedialog)
        {
            try
            {
                int index = 0;

                foreach (string str in filedialog.FileNames)
                {
                    var fileName = System.IO.Path.GetFileName(str);
                    string[] name = fileName.Split(".");

                    GetSensores.Add(name[0]);
                    GetArchivos.Add(Path.GetFullPath(str));

                    Console.WriteLine("Documentos: " + name[0] + "\n");

                    using (var reader = new StreamReader(GetArchivos[index]))
                    {
                        int index2 = 0;

                        while (!reader.EndOfStream)
                        {
                            var line = reader.ReadLine();
                            if (line.Contains("<Time>") && line.Contains("</Time>"))
                            {
                                partDate1 = line.Substring(12, 22).Split("T");
                                partDate2 = partDate1[1].Split("-");
                                date = partDate1[0] + " " + partDate2[0];

                                GetDates.Add(date);
                            }
                            else if (line.Contains("<Value1>") && line.Contains("</Value1>"))
                            {
                                string[] valores = line.Substring(14).Split("<");
                                temperatura = valores[0];
                                GetTemperatura.Add(temperatura);
                            }
                            else if (line.Contains("<Value2") && line.Contains("</Value2"))
                            {
                                string[] valores = line.Substring(14).Split("<");
                                humedad = valores[0];
                                GetHumedad.Add(humedad);
                            }
                            index2++;
                        }
                    }
                    string[,] unificarDTH = new string[GetDates.Count, 3];
                    for (int i = 0; i < GetDates.Count; i++)
                    {
                        unificarDTH[i, 0] = GetDates[i];
                        unificarDTH[i, 1] = GetTemperatura[i];
                        unificarDTH[i, 2] = GetHumedad[i];
                    }

                    DatosUnificados.Add(unificarDTH);
                    index++;

                }
            }
            catch(Exception ex)
            {
                throw new Exception("Error al Leer Datos ReadDatosElitechHumedadTemperatura: " + ex.Message + " - " + ex.ToString());
            }            
        }


        public string[,] acomodoDatosHumedadTemperatura(List<string[,]> datos)
        {
            int columns = 0, rows = 0;

            for(int i = 0; i < datos.Count; i++) 
            {
                if (datos[i] != null)
                {
                    int columna = datos[i].GetLength(1);
                    int filas = datos[i].GetLength(0);
                    columns += columna;
                    if(rows < filas)
                    {
                        rows = filas;
                    }
                }
            }

            string[,] unificar = new string[rows, columns];

            int newColumn = 0;

            for(int i = 0; i < datos.Count; i++)
            {
                if (datos[i] != null)
                {
                    int c = datos[i].GetLength(1);
                    int r = datos[i].GetLength(0);
                    for (int j = 0; j <= r -1; j++)
                    {
                        for (int k = 0; k <= c - 1; k++)
                        {
                            unificar[j, newColumn + k] = datos[i][j, k];
                        }
                    }
                    newColumn += c;
                }
                else
                {
                    MessageBox.Show("Sin datos " + i);
                }
            }

            return unificar;
        }


        public DataTable setGridHumedadTemperatura(string[,] datos)
        {
            DataTable dt = new DataTable();

            for(int i = 0; i < datos.GetLength(1); i++)
            {
                dt.Columns.Add("Column" + (i + 1));
            }

            for(int j = 0; j < datos.GetLength(0); j++)
            {
                DataRow row = dt.NewRow();
                for(int k = 0; k < datos.GetLength(1); k++)
                {
                    row[k] = datos[j,k];
                }
                dt.Rows.Add(row);
            }
            return dt;
        }

      

        //public void RecoleccionDatosElitech(OpenFileDialog filedialog)
        //{
        //    int index = 0;
        //    foreach(string file in filedialog.FileNames)
        //    {
        //        var fileName = System.IO.Path.GetFileName(file);
        //        string[] name = fileName.Split(".");

        //        DatosSensores.Add(name[0]);
        //        GetArchivos.Add(Path.GetFullPath(file));

        //        using (var reader = new StreamReader(GetArchivos[index]))
        //        {
        //            int index2 = 0;
        //            while(!reader.EndOfStream)
        //            {
        //                var line = reader.ReadLine();
        //                if(line.Contains("<Time>") && line.Contains("</Time>"))
        //                {
        //                    string[] dateA = line.Substring(12, 25).Split("T");
        //                    string[] dateB = dateA[1].Split("-");
        //                    date = dateA[0] + " " + dateB[0];

        //                    GetDates.Add(date);
        //                }
        //                else if(line.Contains("<Value1>") && line.Contains("</Value1>"))
        //                {
        //                    string[] valores = line.Substring(14).Split("<");
        //                    valor = valores[0];

        //                    GetValores.Add(valor);
        //                }
        //                index2++;
        //            }
        //        }

        //        string[,] datosUnificados = new string[GetDates.Count, 2];
        //        for(int i = 0; i < GetDates.Count; i++)
        //        {
        //            datosUnificados[i, 0] = GetDates[i];
        //            datosUnificados[i, 1] = GetValores[i];
        //        }
        //        DatosUnificados.Add(datosUnificados);

        //        index++;
        //    }
        //}


        //***********************************************************************************************************************
        //*******************EJECUTA CONSULTAS
        public SqlDataReader ExecuteReader(string QueryString, int tipoConn)
        {
            if(tipoConn == 1)
            {
                Conexion = ConBDServer;
            }
            if(tipoConn == 2)
            {
                Conexion = ConBDPruebas;
            }

            Conn = new SqlConnection(Conexion);
            Conn.Open();

            Cmd = new SqlCommand(QueryString,Conn);
            SqlDataReader leer = Cmd.ExecuteReader();

            try
            {
                return leer;
            }
            catch(Exception ex)
            {
                throw new Exception("Error al Recuperar ExecuteReader: " + ex.Message + " - " + ex.ToString());
            }
        }

    }
}
