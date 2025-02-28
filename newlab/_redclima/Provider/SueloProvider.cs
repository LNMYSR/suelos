using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//add
using System.Runtime.Remoting;
using System.Configuration;
using SistemaAlertas.Entity;
using System.Data;
namespace SistemaAlertas.Provider
{
    public abstract class SueloProvider:DataAccess
    {
        private static ObjectHandle obj; //manejador de objeto.
        private static SueloProvider _Intance = null;

        public static SueloProvider Intance
        {
            get
            {
                if (_Intance == null)
                {
                    obj = Activator.CreateInstance(
                        ConfigurationManager.AppSettings["SueloDLL"],
                        ConfigurationManager.AppSettings["SueloClass"]);
                    _Intance = (SueloProvider)obj.Unwrap();
                }
                return _Intance;
            }
            set => _Intance = value;
        }
        public SueloProvider() { }
        public abstract List<SueloEntity> getSueloDataByMun(string cve, string cvm, List<string> profundidades);
        public virtual SueloEntity GetSueloDataFromReader(IDataReader reader, List<string> profundidades)
        {
            SueloEntity entity = null;
            try
            {
                entity = new SueloEntity();
                entity.Latitud = reader["latitud"] == System.DBNull.Value ? 0 : Convert.ToSingle(reader["latitud"]);
                entity.Longitud = reader["longitud"] == System.DBNull.Value ? 0 : Convert.ToSingle(reader["longitud"]);
                //foreach (string prof in profundidades) {
                //    entity.GetType().GetProperty(prof).SetValue(null,reader["logitud"] == System.DBNull.Value ? 0 : Convert.ToSingle(reader["longitud"]));
                //}
                //bdod
                if (profundidades.Contains("bulkdensity_blk0_5"))
                {
                    entity.Bdod_a = reader["bulkdensity_blk0_5"] == System.DBNull.Value ? 0 : Convert.ToSingle(reader["bulkdensity_blk0_5"]);
                }
                if (profundidades.Contains("bulkdensity_blk_5_15"))
                {
                    entity.Bdod_b = reader["bulkdensity_blk_5_15"] == System.DBNull.Value ? 0 : Convert.ToSingle(reader["bulkdensity_blk_5_15"]);
                }
                if (profundidades.Contains("bulkdensity_blk_15_30"))
                {
                    entity.Bdod_c = reader["bulkdensity_blk_15_30"] == System.DBNull.Value ? 0 : Convert.ToSingle(reader["bulkdensity_blk_15_30"]);
                }
                if (profundidades.Contains("bulkdensity_blk_30_60"))
                {
                    entity.Bdod_d = reader["bulkdensity_blk_30_60"] == System.DBNull.Value ? 0 : Convert.ToSingle(reader["bulkdensity_blk_30_60"]);
                }
                if (profundidades.Contains("bulkdensity_blk60_100"))
                {
                    entity.Bdod_e = reader["bulkdensity_blk60_100"] == System.DBNull.Value ? 0 : Convert.ToSingle(reader["bulkdensity_blk60_100"]);
                }
                if (profundidades.Contains("bulkdensity_blk100_200"))
                {
                    entity.Bdod_f = reader["bulkdensity_blk100_200"] == System.DBNull.Value ? 0 : Convert.ToSingle(reader["bulkdensity_blk100_200"]);
                }
                //clay
                if (profundidades.Contains("claycontent_clay0_5"))
                {
                    entity.Clay_a = reader["claycontent_clay0_5"] == System.DBNull.Value ? 0 : Convert.ToSingle(reader["claycontent_clay0_5"]);
                }
                if (profundidades.Contains("claycontent_clay5_15"))
                {
                    entity.Clay_b = reader["claycontent_clay5_15"] == System.DBNull.Value ? 0 : Convert.ToSingle(reader["claycontent_clay5_15"]);
                }
                if (profundidades.Contains("claycontent_clay15_30"))
                {
                    entity.Clay_c = reader["claycontent_clay15_30"] == System.DBNull.Value ? 0 : Convert.ToSingle(reader["claycontent_clay15_30"]);
                }
                if (profundidades.Contains("claycontent_clay30_60"))
                {
                    entity.Clay_d = reader["claycontent_clay30_60"] == System.DBNull.Value ? 0 : Convert.ToSingle(reader["claycontent_clay30_60"]);
                }
                if (profundidades.Contains("claycontent_clay60_100"))
                {
                    entity.Clay_e = reader["claycontent_clay60_100"] == System.DBNull.Value ? 0 : Convert.ToSingle(reader["claycontent_clay60_100"]);
                }
                if (profundidades.Contains("claycontent_clay100_200"))
                {
                    entity.Clay_f = reader["claycontent_clay100_200"] == System.DBNull.Value ? 0 : Convert.ToSingle(reader["claycontent_clay100_200"]);
                }
                //cec
                if (profundidades.Contains("cic_cec0_5"))
                {
                    entity.Cec_a = reader["cic_cec0_5"] == System.DBNull.Value ? 0 : Convert.ToSingle(reader["cic_cec0_5"]);
                }
                if (profundidades.Contains("cic_cec5_15"))
                {
                    entity.Cec_b = reader["cic_cec5_15"] == System.DBNull.Value ? 0 : Convert.ToSingle(reader["cic_cec5_15"]);
                }
                if (profundidades.Contains("cic_cec15_30"))
                {
                    entity.Cec_c = reader["cic_cec15_30"] == System.DBNull.Value ? 0 : Convert.ToSingle(reader["cic_cec15_30"]);
                }
                if (profundidades.Contains("cic_cec30_60"))
                {
                    entity.Cec_d = reader["cic_cec30_60"] == System.DBNull.Value ? 0 : Convert.ToSingle(reader["cic_cec30_60"]);
                }
                if (profundidades.Contains("cic_cec60_100"))
                {
                    entity.Cec_e = reader["cic_cec60_100"] == System.DBNull.Value ? 0 : Convert.ToSingle(reader["cic_cec60_100"]);
                }
                if (profundidades.Contains("cic_cec100_200"))
                {
                    entity.Cec_f = reader["cic_cec100_200"] == System.DBNull.Value ? 0 : Convert.ToSingle(reader["cic_cec100_200"]);
                }
                //coa
                if (profundidades.Contains("coarsefragments_coa0_5"))
                {
                    entity.Coa_a = reader["coarsefragments_coa0_5"] == System.DBNull.Value ? 0 : Convert.ToSingle(reader["coarsefragments_coa0_5"]);
                }
                if (profundidades.Contains("coarsefragments_coa5_15"))
                {
                    entity.Coa_b = reader["coarsefragments_coa5_15"] == System.DBNull.Value ? 0 : Convert.ToSingle(reader["coarsefragments_coa5_15"]);
                }
                if (profundidades.Contains("coarsefragments_coa15_30"))
                {
                    entity.Coa_c = reader["coarsefragments_coa15_30"] == System.DBNull.Value ? 0 : Convert.ToSingle(reader["coarsefragments_coa15_30"]);
                }
                if (profundidades.Contains("coarsefragments_coa30_60"))
                {
                    entity.Coa_d = reader["coarsefragments_coa30_60"] == System.DBNull.Value ? 0 : Convert.ToSingle(reader["coarsefragments_coa30_60"]);
                }
                if (profundidades.Contains("coarsefragments_coa60_100"))
                {
                    entity.Coa_e = reader["coarsefragments_coa60_100"] == System.DBNull.Value ? 0 : Convert.ToSingle(reader["coarsefragments_coa60_100"]);
                }
                if (profundidades.Contains("coarsefragments_coa100_200"))
                {
                    entity.Coa_f = reader["coarsefragments_coa100_200"] == System.DBNull.Value ? 0 : Convert.ToSingle(reader["coarsefragments_coa100_200"]);
                }
                //nitrogen
                if (profundidades.Contains("nitrogen_n0_5"))
                {
                    entity.N_a = reader["nitrogen_n0_5"] == System.DBNull.Value ? 0 : Convert.ToSingle(reader["nitrogen_n0_5"]);
                }
                if (profundidades.Contains("nitrogen_n5_15"))
                {
                    entity.N_b = reader["nitrogen_n5_15"] == System.DBNull.Value ? 0 : Convert.ToSingle(reader["nitrogen_n5_15"]);
                }
                if (profundidades.Contains("nitrogen_n15_30"))
                {
                    entity.N_c = reader["nitrogen_n15_30"] == System.DBNull.Value ? 0 : Convert.ToSingle(reader["nitrogen_n15_30"]);
                }
                if (profundidades.Contains("nitrogen_n30_60"))
                {
                    entity.N_d = reader["nitrogen_n30_60"] == System.DBNull.Value ? 0 : Convert.ToSingle(reader["nitrogen_n30_60"]);
                }
                if (profundidades.Contains("nitrogen_n60_100"))
                {
                    entity.N_e = reader["nitrogen_n60_100"] == System.DBNull.Value ? 0 : Convert.ToSingle(reader["nitrogen_n60_100"]);
                }
                if (profundidades.Contains("nitrogen_n100_200"))
                {
                    entity.N_f = reader["nitrogen_n100_200"] == System.DBNull.Value ? 0 : Convert.ToSingle(reader["nitrogen_n100_200"]);
                }
                //ocd
                if (profundidades.Contains("organicacarbondensity_ocd0_5"))
                {
                    entity.Ocd_a = reader["organicacarbondensity_ocd0_5"] == System.DBNull.Value ? 0 : Convert.ToSingle(reader["organicacarbondensity_ocd0_5"]);
                }
                if (profundidades.Contains("organicacarbondensity_ocd5_15"))
                {
                    entity.Ocd_b = reader["organicacarbondensity_ocd5_15"] == System.DBNull.Value ? 0 : Convert.ToSingle(reader["organicacarbondensity_ocd5_15"]);
                }
                if (profundidades.Contains("organicacarbondensity_ocd15_30"))
                {
                    entity.Ocd_c = reader["organicacarbondensity_ocd15_30"] == System.DBNull.Value ? 0 : Convert.ToSingle(reader["organicacarbondensity_ocd15_30"]);
                }
                if (profundidades.Contains("organicacarbondensity_ocd30_60"))
                {
                    entity.Ocd_d = reader["organicacarbondensity_ocd30_60"] == System.DBNull.Value ? 0 : Convert.ToSingle(reader["organicacarbondensity_ocd30_60"]);
                }
                if (profundidades.Contains("organicacarbondensity_ocd60_100"))
                {
                    entity.Ocd_e = reader["organicacarbondensity_ocd60_100"] == System.DBNull.Value ? 0 : Convert.ToSingle(reader["organicacarbondensity_ocd60_100"]);
                }
                if (profundidades.Contains("organicacarbondensity_ocd100_200"))
                {
                    entity.Ocd_f = reader["organicacarbondensity_ocd100_200"] == System.DBNull.Value ? 0 : Convert.ToSingle(reader["organicacarbondensity_ocd100_200"]);
                }
                //ph
                if (profundidades.Contains("phwater_ph0_5"))
                {
                    entity.Ph_a = reader["phwater_ph0_5"] == System.DBNull.Value ? 0 : Convert.ToSingle(reader["phwater_ph0_5"]);
                }
                if (profundidades.Contains("phwater_ph5_15"))
                {
                    entity.Ph_b = reader["phwater_ph5_15"] == System.DBNull.Value ? 0 : Convert.ToSingle(reader["phwater_ph5_15"]);
                }
                if (profundidades.Contains("phwater_ph15_30"))
                {
                    entity.Ph_c = reader["phwater_ph15_30"] == System.DBNull.Value ? 0 : Convert.ToSingle(reader["phwater_ph15_30"]);
                }
                if (profundidades.Contains("phwater_ph30_60"))
                {
                    entity.Ph_d = reader["phwater_ph30_60"] == System.DBNull.Value ? 0 : Convert.ToSingle(reader["phwater_ph30_60"]);
                }
                if (profundidades.Contains("phwater_ph60_100"))
                {
                    entity.Ph_e = reader["phwater_ph60_100"] == System.DBNull.Value ? 0 : Convert.ToSingle(reader["phwater_ph60_100"]);
                }
                if (profundidades.Contains("phwater_ph100_200"))
                {
                    entity.Ph_f = reader["phwater_ph100_200"] == System.DBNull.Value ? 0 : Convert.ToSingle(reader["phwater_ph100_200"]);
                }
                //sand
                if (profundidades.Contains("sand_snd0_5"))
                {
                    entity.Snd_a = reader["sand_snd0_5"] == System.DBNull.Value ? 0 : Convert.ToSingle(reader["sand_snd0_5"]);
                }
                if (profundidades.Contains("sand_snd5_15"))
                {
                    entity.Snd_b = reader["sand_snd5_15"] == System.DBNull.Value ? 0 : Convert.ToSingle(reader["sand_snd5_15"]);
                }
                if (profundidades.Contains("sand_snd15_30"))
                {
                    entity.Snd_c = reader["sand_snd15_30"] == System.DBNull.Value ? 0 : Convert.ToSingle(reader["sand_snd15_30"]);
                }
                if (profundidades.Contains("sand_snd30_60"))
                {
                    entity.Snd_d = reader["sand_snd30_60"] == System.DBNull.Value ? 0 : Convert.ToSingle(reader["sand_snd30_60"]);
                }
                if (profundidades.Contains("sand_snd60_100"))
                {
                    entity.Snd_e = reader["sand_snd60_100"] == System.DBNull.Value ? 0 : Convert.ToSingle(reader["sand_snd60_100"]);
                }
                if (profundidades.Contains("sand_snd100_200"))
                {
                    entity.Snd_f = reader["sand_snd100_200"] == System.DBNull.Value ? 0 : Convert.ToSingle(reader["sand_snd100_200"]);
                }
                //silt
                if (profundidades.Contains("silt_slt0_5"))
                {
                    entity.Slt_a = reader["silt_slt0_5"] == System.DBNull.Value ? 0 : Convert.ToSingle(reader["silt_slt0_5"]);
                }
                if (profundidades.Contains("silt_slt5_15"))
                {
                    entity.Slt_b = reader["silt_slt5_15"] == System.DBNull.Value ? 0 : Convert.ToSingle(reader["silt_slt5_15"]);
                }
                if (profundidades.Contains("silt_slt15_30"))
                {
                    entity.Slt_c = reader["silt_slt15_30"] == System.DBNull.Value ? 0 : Convert.ToSingle(reader["silt_slt15_30"]);
                }
                if (profundidades.Contains("silt_slt30_60"))
                {
                    entity.Slt_d = reader["silt_slt30_60"] == System.DBNull.Value ? 0 : Convert.ToSingle(reader["silt_slt30_60"]);
                }
                if (profundidades.Contains("silt_slt60_100"))
                {
                    entity.Slt_e = reader["silt_slt60_100"] == System.DBNull.Value ? 0 : Convert.ToSingle(reader["silt_slt60_100"]);
                }
                if (profundidades.Contains("silt_slt100_200"))
                {
                    entity.Slt_f = reader["silt_slt100_200"] == System.DBNull.Value ? 0 : Convert.ToSingle(reader["silt_slt100_200"]);
                }
                //soc
                if (profundidades.Contains("soilorganiccarbon_soc0_5"))
                {
                    entity.Soc_a = reader["soilorganiccarbon_soc0_5"] == System.DBNull.Value ? 0 : Convert.ToSingle(reader["soilorganiccarbon_soc0_5"]);
                }
                if (profundidades.Contains("soilorganiccarbon_soc5_15"))
                {
                    entity.Soc_b = reader["soilorganiccarbon_soc5_15"] == System.DBNull.Value ? 0 : Convert.ToSingle(reader["soilorganiccarbon_soc5_15"]);
                }
                if (profundidades.Contains("soilorganiccarbon_soc15_30"))
                {
                    entity.Soc_c = reader["soilorganiccarbon_soc15_30"] == System.DBNull.Value ? 0 : Convert.ToSingle(reader["soilorganiccarbon_soc15_30"]);
                }
                if (profundidades.Contains("soilorganiccarbon_soc30_60"))
                {
                    entity.Soc_d = reader["soilorganiccarbon_soc30_60"] == System.DBNull.Value ? 0 : Convert.ToSingle(reader["soilorganiccarbon_soc30_60"]);
                }
                if (profundidades.Contains("soilorganiccarbon_soc60_100"))
                {
                    entity.Soc_e = reader["soilorganiccarbon_soc60_100"] == System.DBNull.Value ? 0 : Convert.ToSingle(reader["soilorganiccarbon_soc60_100"]);
                }
                if (profundidades.Contains("soilorganiccarbon_soc100_200"))
                {
                    entity.Soc_f = reader["soilorganiccarbon_soc100_200"] == System.DBNull.Value ? 0 : Convert.ToSingle(reader["soilorganiccarbon_soc100_200"]);
                }
                //socs
                if (profundidades.Contains("soilorganiccarbonstock_socs"))
                {
                    entity.Soc_f = reader["soilorganiccarbonstock_socs_0_30"] == System.DBNull.Value ? 0 : Convert.ToSingle(reader["soilorganiccarbonstock_socs_0_30"]);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error...", ex);
            }
            return entity;
        }
    }
}
