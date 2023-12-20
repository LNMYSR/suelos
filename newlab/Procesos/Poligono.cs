using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace newlab.Procesos
{
    public class Poligono
    {
        private string _Nombre;

        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }

        private string _Polygon;

        public string Polygon
        {
            get { return _Polygon; }
            set { _Polygon = value; }
        }

        public Poligono() { }
        public Poligono(string Nombre, string Polygon)
        {
            this._Nombre = Nombre;
            this._Polygon = Polygon;
        }

        public static string GetLista(string poligono)
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
    }
}