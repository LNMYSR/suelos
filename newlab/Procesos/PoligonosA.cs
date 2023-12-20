using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace newlab.Procesos
{
    public class PoligonosA
    {
        private string _Nombre;

        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }

        private string _Poligono;

        public string Poligono
        {
            get { return _Poligono; }
            set { _Poligono = value; }
        }

        public PoligonosA() { }
        public PoligonosA(string Nombre, string Poligono)
        {
            this._Nombre = Nombre;
            this._Poligono = Poligono;
        }
        public static string GetListaPuntos(string poligono, out string referencia)
        {
            string paquete = "";
            referencia = "";
            try
            {
                if (poligono[0] == 'M')
                {
                    string prepaquete;
                    poligono = poligono.Replace("MULTIPOLYGON ", "");
                    poligono = poligono.Remove(0, 1);
                    poligono = poligono.Remove(poligono.Count() - 1, 1);
                    List<string> result = poligono.Split(new string[] { "((" }, StringSplitOptions.None).ToList();
                    result.RemoveAt(0);
                    foreach (string get in result)
                    {
                        List<string> resget = (" " + (get.Remove(get.Count() - 4, 3))).Split(',').ToList();
                        resget.RemoveAt(resget.Count() - 1);
                        prepaquete = "";
                        foreach (string rget in resget)
                        {
                            string[] array = rget.Split(' ');
                            prepaquete += "[" + array[2] + "," + array[1] + "],";
                        }

                        paquete += "[" + prepaquete + "],";
                    }
                    referencia = (result[1].Split(','))[1].Split(' ')[2] + "," + (result[1].Split(','))[1].Split(' ')[1];
                }
                else
                {
                    poligono = poligono.Trim(new Char[] { 'P', 'O', 'L', 'Y', 'G', 'O', 'N', ' ', '(', '(' });
                    poligono = poligono.TrimEnd(new Char[] { ')', ')' });
                    string[] result = (" " + poligono).Split(',');
                    foreach (string get in result)
                    {
                        string[] array = get.Split(' ');
                        paquete += "[" + array[2] + "," + array[1] + "],";
                    }
                    referencia = result[1].Split(' ')[2] + "," + result[1].Split(' ')[1];
                }
            }
            catch (Exception ex) { }
            return paquete;
        }
        public static string GetListaPuntosX(string poligono)
        {
            string paquete = "";
            try
            {
                    poligono = poligono.Trim(new Char[] { 'P', 'O', 'L', 'Y', 'G', 'O', 'N', ' ' });
                    poligono = poligono.Replace('(', '[');
                    paquete = poligono.Replace(')', ']');
                    paquete = paquete.Replace(",", "],[");
                    paquete = paquete.Replace("[ ", "[");
                    paquete = paquete.Replace(" ", ",");
            }
            catch (Exception ex) { }
            return paquete;
        }
        public static string GetListaPuntosY(string poligono)
        {
            string paquete = "";
            try
            {
                    poligono = poligono.Trim(new Char[] { 'P', 'O', 'L', 'Y', 'G', 'O', 'N', ' '});
                    //poligono = poligono.TrimEnd(new Char[] { ')' });
                    poligono = poligono.Replace('(', '[');
                    paquete = poligono.Replace(')', ']');
                    paquete = paquete.Replace(",", "],[");
                    paquete = paquete.Replace("[ ", "[");
                    paquete = paquete.Replace(" ", ",");
            }
            catch (Exception ex) { }
            return paquete;
        }

    }

}