using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SistemaAlertas.Provider
{
    public class Provider
    {
        public static SueloProvider Suelo
        {
            get { return SueloProvider.Intance; }
        }
        public static PoligonoProvider Poligono
        {
            get { return PoligonoProvider.Intance; }
        }
        
    }
}
