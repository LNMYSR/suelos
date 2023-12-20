using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAlertas.Entity
{
    public class PoligonoEntity
    {
        private string _CVE;
        private string _CVM;
        private string _Nombre;
        private string _Poligono;

        public string CVE { get => _CVE; set => _CVE = value; }
        public string CVM { get => _CVM; set => _CVM = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Poligono { get => _Poligono; set => _Poligono = value; }

        public PoligonoEntity() { }
        public PoligonoEntity(string CVE, string CVM, string Nombre, string Poligono) {
            this._CVE = CVE;
            this._CVM = CVM;
            this._Nombre = Nombre;
            this._Poligono = Poligono;
        }
    }
}
