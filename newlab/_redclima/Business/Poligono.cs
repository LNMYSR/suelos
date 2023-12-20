using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Agregados
using SistemaAlertas.Entity;

namespace SistemaAlertas.Business
{
    public class Poligono
    {
        private string _CVE;
        private string _CVM;
        private string _Nombre;
        private string _Polygon;

        public string CVE { get => _CVE; set => _CVE = value; }
        public string CVM { get => _CVM; set => _CVM = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Polygon { get => _Polygon; set => _Polygon = value; }

        public Poligono() { }
        public Poligono(string CVE, string CVM, string Nombre, string Poligono)
        {
            this._CVE = CVE;
            this._CVM = CVM;
            this._Nombre = Nombre;
            this._Polygon = Poligono;
        }

        public static List<Poligono> Estados() {
            List<Poligono> ListaEdo = new List<Poligono>();
            foreach (PoligonoEntity get in Provider.Provider.Poligono.getEstados())
            {
                Poligono esTrucEstado = new Poligono(get.CVE,null,get.Nombre,null);
                ListaEdo.Add(esTrucEstado);
            }
            return ListaEdo;
        }
        public static List<Poligono> Municipios(string cve)
        {
            List<Poligono> ListaMun = new List<Poligono>();
            foreach (PoligonoEntity get in Provider.Provider.Poligono.getMunicipios(cve))
            {
                ListaMun.Add(new Poligono(null, get.CVM, get.Nombre, null));
            }
            return ListaMun;
        }
        public static List<Poligono> PolygonsMunicipio(string cvm)
        {
            List<Poligono> ListaMun = new List<Poligono>();
            foreach (PoligonoEntity get in Provider.Provider.Poligono.getPolygonMunicipios(cvm))
            {
                ListaMun.Add(new Poligono(null, null,null,get.Poligono));
            }
            return ListaMun;
        }


    }
}
