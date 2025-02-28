using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Agregados
using SistemaAlertas.Entity;

namespace SistemaAlertas.Business
{
    public class Suelo
    {
        private float _Latitud;
        private float _Longitud;
        private float _Bdod_a;
        private float _Bdod_b;
        private float _Bdod_c;
        private float _Bdod_d;
        private float _Bdod_e;
        private float _Bdod_f;
        private float _Clay_a;
        private float _Clay_b;
        private float _Clay_c;
        private float _Clay_d;
        private float _Clay_e;
        private float _Clay_f;
        private float _Cec_a;
        private float _Cec_b;
        private float _Cec_c;
        private float _Cec_d;
        private float _Cec_e;
        private float _Cec_f;
        //coa
        private float _Coa_a;
        private float _Coa_b;
        private float _Coa_c;
        private float _Coa_d;
        private float _Coa_e;
        private float _Coa_f;
        //nitrogen
        private float _N_a;
        private float _N_b;
        private float _N_c;
        private float _N_d;
        private float _N_e;
        private float _N_f;
        //ocd
        private float _Ocd_a;
        private float _Ocd_b;
        private float _Ocd_c;
        private float _Ocd_d;
        private float _Ocd_e;
        private float _Ocd_f;
        //ph
        private float _Ph_a;
        private float _Ph_b;
        private float _Ph_c;
        private float _Ph_d;
        private float _Ph_e;
        private float _Ph_f;
        //sand
        private float _Snd_a;
        private float _Snd_b;
        private float _Snd_c;
        private float _Snd_d;
        private float _Snd_e;
        private float _Snd_f;
        //silt
        private float _Slt_a;
        private float _Slt_b;
        private float _Slt_c;
        private float _Slt_d;
        private float _Slt_e;
        private float _Slt_f;
        //soc
        private float _Soc_a;
        private float _Soc_b;
        private float _Soc_c;
        private float _Soc_d;
        private float _Soc_e;
        private float _Soc_f;
        //socs
        private float _SocS_a;

        public float Latitud { get => _Latitud; set => _Latitud = value; }
        public float Longitud { get => _Longitud; set => _Longitud = value; }
        public float Bdod_a { get => _Bdod_a; set => _Bdod_a = value; }
        public float Bdod_b { get => _Bdod_b; set => _Bdod_b = value; }
        public float Bdod_c { get => _Bdod_c; set => _Bdod_c = value; }
        public float Bdod_d { get => _Bdod_d; set => _Bdod_d = value; }
        public float Bdod_e { get => _Bdod_e; set => _Bdod_e = value; }
        public float Bdod_f { get => _Bdod_f; set => _Bdod_f = value; }
        public float Clay_a { get => _Clay_a; set => _Clay_a = value; }
        public float Clay_b { get => _Clay_b; set => _Clay_b = value; }
        public float Clay_c { get => _Clay_c; set => _Clay_c = value; }
        public float Clay_d { get => _Clay_d; set => _Clay_d = value; }
        public float Clay_e { get => _Clay_e; set => _Clay_e = value; }
        public float Clay_f { get => _Clay_f; set => _Clay_f = value; }
        public float Cec_a { get => _Cec_a; set => _Cec_a = value; }
        public float Cec_b { get => _Cec_b; set => _Cec_b = value; }
        public float Cec_c { get => _Cec_c; set => _Cec_c = value; }
        public float Cec_d { get => _Cec_d; set => _Cec_d = value; }
        public float Cec_e { get => _Cec_e; set => _Cec_e = value; }
        public float Cec_f { get => _Cec_f; set => _Cec_f = value; }
        //coa
        public float Coa_a { get => _Coa_a; set => _Coa_a = value; }
        public float Coa_b { get => _Coa_b; set => _Coa_b = value; }
        public float Coa_c { get => _Coa_c; set => _Coa_c = value; }
        public float Coa_d { get => _Coa_d; set => _Coa_d = value; }
        public float Coa_e { get => _Coa_e; set => _Coa_e = value; }
        public float Coa_f { get => _Coa_f; set => _Coa_f = value; }
        //nitrogen
        public float N_a { get => _N_a; set => _N_a = value; }
        public float N_b { get => _N_b; set => _N_b = value; }
        public float N_c { get => _N_c; set => _N_c = value; }
        public float N_d { get => _N_d; set => _N_d = value; }
        public float N_e { get => _N_e; set => _N_e = value; }
        public float N_f { get => _N_f; set => _N_f = value; }
        //ocd
        public float Ocd_a { get => _Ocd_a; set => _Ocd_a = value; }
        public float Ocd_b { get => _Ocd_b; set => _Ocd_b = value; }
        public float Ocd_c { get => _Ocd_c; set => _Ocd_c = value; }
        public float Ocd_d { get => _Ocd_d; set => _Ocd_d = value; }
        public float Ocd_e { get => _Ocd_e; set => _Ocd_e = value; }
        public float Ocd_f { get => _Ocd_f; set => _Ocd_f = value; }
        //ph
        public float Ph_a { get => _Ph_a; set => _Ph_a = value; }
        public float Ph_b { get => _Ph_b; set => _Ph_b = value; }
        public float Ph_c { get => _Ph_c; set => _Ph_c = value; }
        public float Ph_d { get => _Ph_d; set => _Ph_d = value; }
        public float Ph_e { get => _Ph_e; set => _Ph_e = value; }
        public float Ph_f { get => _Ph_f; set => _Ph_f = value; }
        //sand
        public float Snd_a { get => _Snd_a; set => _Snd_a = value; }
        public float Snd_b { get => _Snd_b; set => _Snd_b = value; }
        public float Snd_c { get => _Snd_c; set => _Snd_c = value; }
        public float Snd_d { get => _Snd_d; set => _Snd_d = value; }
        public float Snd_e { get => _Snd_e; set => _Snd_e = value; }
        public float Snd_f { get => _Snd_f; set => _Snd_f = value; }
        //silt
        public float Slt_a { get => _Slt_a; set => _Slt_a = value; }
        public float Slt_b { get => _Slt_b; set => _Slt_b = value; }
        public float Slt_c { get => _Slt_c; set => _Slt_c = value; }
        public float Slt_d { get => _Slt_d; set => _Slt_d = value; }
        public float Slt_e { get => _Slt_e; set => _Slt_e = value; }
        public float Slt_f { get => _Slt_f; set => _Slt_f = value; }
        //soc
        public float Soc_a { get => _Soc_a; set => _Soc_a = value; }
        public float Soc_b { get => _Soc_b; set => _Soc_b = value; }
        public float Soc_c { get => _Soc_c; set => _Soc_c = value; }
        public float Soc_d { get => _Soc_d; set => _Soc_d = value; }
        public float Soc_e { get => _Soc_e; set => _Soc_e = value; }
        public float Soc_f { get => _Soc_f; set => _Soc_f = value; }
        //socs
        public float SocS_a { get => _SocS_a; set => _SocS_a = value; }

        public Suelo() { }
        public Suelo(float Latitud, float Longitud,
            float Bdod_a, float Bdod_b, float Bdod_c, float Bdod_d, float Bdod_e, float Bdod_f,
            float Clay_a, float Clay_b, float Clay_c, float Clay_d, float Clay_e, float Clay_f,
            float Cec_a, float Cec_b, float Cec_c, float Cec_d, float Cec_e, float Cec_f,
            float Coa_a, float Coa_b, float Coa_c, float Coa_d, float Coa_e, float Coa_f,
            float N_a, float N_b, float N_c, float N_d, float N_e, float N_f,
            float Ocd_a, float Ocd_b, float Ocd_c, float Ocd_d, float Ocd_e, float Ocd_f,
            float Ph_a, float Ph_b, float Ph_c, float Ph_d, float Ph_e, float Ph_f,
            float Snd_a, float Snd_b, float Snd_c, float Snd_d, float Snd_e, float Snd_f,
            float Slt_a, float Slt_b, float Slt_c, float Slt_d, float Slt_e, float Slt_f,
            float Soc_a, float Soc_b, float Soc_c, float Soc_d, float Soc_e, float Soc_f,
            float SocS_a
            )
        {
            this._Latitud = Latitud;
            this._Longitud = Longitud;
            this._Bdod_a = Bdod_a;
            this._Bdod_b = Bdod_b;
            this._Bdod_c = Bdod_c;
            this._Bdod_d = Bdod_d;
            this._Bdod_e = Bdod_e;
            this._Bdod_f = Bdod_f;
            this._Clay_a = Clay_a;
            this._Clay_b = Clay_b;
            this._Clay_c = Clay_c;
            this._Clay_d = Clay_d;
            this._Clay_e = Clay_e;
            this._Clay_f = Clay_f;
            this._Cec_a = Cec_a;
            this._Cec_b = Cec_b;
            this._Cec_c = Cec_c;
            this._Cec_d = Cec_d;
            this._Cec_e = Cec_e;
            this._Cec_f = Cec_f;
            //coa
            this._Coa_a = Coa_a;
            this._Coa_b = Coa_b;
            this._Coa_c = Coa_c;
            this._Coa_d = Coa_d;
            this._Coa_e = Coa_e;
            this._Coa_f = Coa_f;
            //n
            this._N_a = N_a;
            this._N_b = N_b;
            this._N_c = N_c;
            this._N_d = N_d;
            this._N_e = N_e;
            this._N_f = N_f;
            //ocd
            this._Ocd_a = Ocd_a;
            this._Ocd_b = Ocd_b;
            this._Ocd_c = Ocd_c;
            this._Ocd_d = Ocd_d;
            this._Ocd_e = Ocd_e;
            this._Ocd_f = Ocd_f;
            //ph
            this._Ph_a = Ph_a;
            this._Ph_b = Ph_b;
            this._Ph_c = Ph_c;
            this._Ph_d = Ph_d;
            this._Ph_e = Ph_e;
            this._Ph_f = Ph_f;
            //sand
            this._Snd_a = Snd_a;
            this._Snd_b = Snd_b;
            this._Snd_c = Snd_c;
            this._Snd_d = Snd_d;
            this._Snd_e = Snd_e;
            this._Snd_f = Snd_f;
            //slt
            this._Slt_a = Slt_a;
            this._Slt_b = Slt_b;
            this._Slt_c = Slt_c;
            this._Slt_d = Slt_d;
            this._Slt_e = Slt_e;
            this._Slt_f = Slt_f;
            //soc
            this._Soc_a = Soc_a;
            this._Soc_b = Soc_b;
            this._Soc_c = Soc_c;
            this._Soc_d = Soc_d;
            this._Soc_e = Soc_e;
            this._Soc_f = Soc_f;
            //socs
            this._SocS_a = SocS_a;
        }
        public static List<Suelo> DatosSuelo(string cve, string cvm, List<string> profundidades)
        {
            List<Suelo> ListaSuelo = new List<Suelo>();
            foreach (SueloEntity get in Provider.Provider.Suelo.getSueloDataByMun(cve,cvm,profundidades))
            {
                Suelo esTrucEstado = new Suelo(get.Latitud,get.Longitud,get.Bdod_a,get.Bdod_b,get.Bdod_c,get.Bdod_d,get.Bdod_e,get.Bdod_f,get.Clay_a,get.Clay_b,get.Clay_c,get.Clay_d,get.Clay_e,get.Clay_f, get.Cec_a, get.Cec_b, get.Cec_c, get.Cec_d, get.Cec_e, get.Cec_f,
                    get.Coa_a, get.Coa_b, get.Coa_c, get.Coa_d, get.Coa_e, get.Coa_f, get.N_a, get.N_b, get.N_c, get.N_d, get.N_e, get.N_f, get.Ocd_a, get.Ocd_b, get.Ocd_c, get.Ocd_d, get.Ocd_e, get.Ocd_f,
                    get.Ph_a, get.Ph_b, get.Ph_c, get.Ph_d, get.Ph_e, get.Ph_f, get.Snd_a, get.Snd_b, get.Snd_c, get.Snd_d, get.Snd_e, get.Snd_f, get.Slt_a, get.Slt_b, get.Slt_c, get.Slt_d, get.Slt_e, get.Slt_f,
                    get.Soc_a, get.Soc_b, get.Soc_c, get.Soc_d, get.Soc_e, get.Soc_f, get.SocS_a);
                ListaSuelo.Add(esTrucEstado);
            }
            return ListaSuelo;
        }
    }
}
