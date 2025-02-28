using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text;
using SistemaAlertas.Business;
using System.Net;
namespace newlab.DatosIndirectos
{
    public partial class MSMx : System.Web.UI.Page
    {
        private string lista_polygonos;
        protected string Lista_polygonos { get { return lista_polygonos; } set { lista_polygonos = value; } }
        protected static string mensaje;

        protected void Page_Load(object sender, EventArgs e)
        {
            mensaje = "<li class='list-group-item list-group-item-secondary'>¡Gracias por registrarte!</li><br />";
            switch (DropDownListVariable.SelectedValue)
            {
                case "bulkdensity":
                    CheckBoxListBdod.Visible = true;
                    CheckBoxListClay.Visible = false;
                    CheckBoxListCec.Visible = false;
                    CheckBoxListCoa.Visible = false;
                    CheckBoxListN.Visible = false;
                    CheckBoxListOcd.Visible = false;
                    CheckBoxListPh.Visible = false;
                    CheckBoxListSnd.Visible = false;
                    CheckBoxListSoc.Visible = false;
                    CheckBoxListSlt.Visible = false;
                    CheckBoxListSocS.Visible = false;
                    break;
                case "claycontent":
                    CheckBoxListBdod.Visible = false;
                    CheckBoxListClay.Visible = true;
                    CheckBoxListCec.Visible = false;
                    CheckBoxListCoa.Visible = false;
                    CheckBoxListOcd.Visible = false;
                    CheckBoxListPh.Visible = false;
                    CheckBoxListSnd.Visible = false;
                    CheckBoxListSlt.Visible = false;
                    CheckBoxListSoc.Visible = false;
                    CheckBoxListN.Visible = false;
                    CheckBoxListSocS.Visible = false;
                    break;
                case "cic-cec":
                    CheckBoxListBdod.Visible = false;
                    CheckBoxListClay.Visible = false;
                    CheckBoxListCec.Visible = true;
                    CheckBoxListN.Visible = false;
                    CheckBoxListOcd.Visible = false;
                    CheckBoxListPh.Visible = false;
                    CheckBoxListSnd.Visible = false;
                    CheckBoxListSlt.Visible = false;
                    CheckBoxListSoc.Visible = false;
                    CheckBoxListCoa.Visible = false;
                    CheckBoxListSocS.Visible = false;
                    break;
                case "coarsefragments_coa":
                    CheckBoxListBdod.Visible = false;
                    CheckBoxListClay.Visible = false;
                    CheckBoxListN.Visible = false;
                    CheckBoxListCec.Visible = false;
                    CheckBoxListOcd.Visible = false;
                    CheckBoxListPh.Visible = false;
                    CheckBoxListSnd.Visible = false;
                    CheckBoxListSlt.Visible = false;
                    CheckBoxListSoc.Visible = false;
                    CheckBoxListCoa.Visible = true;
                    CheckBoxListSocS.Visible = false;
                    break;
                case "nitrogen_n":
                    CheckBoxListBdod.Visible = false;
                    CheckBoxListClay.Visible = false;
                    CheckBoxListCec.Visible = false;
                    CheckBoxListCoa.Visible = false;
                    CheckBoxListOcd.Visible = false;
                    CheckBoxListPh.Visible = false;
                    CheckBoxListSnd.Visible = false;
                    CheckBoxListSlt.Visible = false;
                    CheckBoxListSoc.Visible = false;
                    CheckBoxListN.Visible = true;
                    CheckBoxListSocS.Visible = false;
                    break;
                case "organicacarbondensity_ocd":
                    CheckBoxListBdod.Visible = false;
                    CheckBoxListClay.Visible = false;
                    CheckBoxListCec.Visible = false;
                    CheckBoxListCoa.Visible = false;
                    CheckBoxListN.Visible = false;
                    CheckBoxListPh.Visible = false;
                    CheckBoxListSnd.Visible = false;
                    CheckBoxListSlt.Visible = false;
                    CheckBoxListSoc.Visible = false;
                    CheckBoxListOcd.Visible = true;
                    CheckBoxListSocS.Visible = false;
                    break;
                case "phwater_ph":
                    CheckBoxListBdod.Visible = false;
                    CheckBoxListClay.Visible = false;
                    CheckBoxListCec.Visible = false;
                    CheckBoxListCoa.Visible = false;
                    CheckBoxListN.Visible = false;
                    CheckBoxListOcd.Visible = false;
                    CheckBoxListSnd.Visible = false;
                    CheckBoxListSlt.Visible = false;
                    CheckBoxListSoc.Visible = false;
                    CheckBoxListPh.Visible = true;
                    CheckBoxListSocS.Visible = false;
                    break;
                case "sand_snd":
                    CheckBoxListBdod.Visible = false;
                    CheckBoxListClay.Visible = false;
                    CheckBoxListCec.Visible = false;
                    CheckBoxListCoa.Visible = false;
                    CheckBoxListN.Visible = false;
                    CheckBoxListOcd.Visible = false;
                    CheckBoxListPh.Visible = false;
                    CheckBoxListSlt.Visible = false;
                    CheckBoxListSoc.Visible = false;
                    CheckBoxListSnd.Visible = true;
                    CheckBoxListSocS.Visible = false;
                    break;
                case "silt_slt":
                    CheckBoxListBdod.Visible = false;
                    CheckBoxListClay.Visible = false;
                    CheckBoxListCec.Visible = false;
                    CheckBoxListCoa.Visible = false;
                    CheckBoxListN.Visible = false;
                    CheckBoxListOcd.Visible = false;
                    CheckBoxListPh.Visible = false;
                    CheckBoxListSoc.Visible = false;
                    CheckBoxListSnd.Visible = false;
                    CheckBoxListSlt.Visible = true;
                    CheckBoxListSocS.Visible = false;
                    break;
                case "soilorganiccarbon_soc":
                    CheckBoxListBdod.Visible = false;
                    CheckBoxListClay.Visible = false;
                    CheckBoxListCec.Visible = false;
                    CheckBoxListCoa.Visible = false;
                    CheckBoxListN.Visible = false;
                    CheckBoxListOcd.Visible = false;
                    CheckBoxListPh.Visible = false;
                    CheckBoxListSnd.Visible = false;
                    CheckBoxListSlt.Visible = false;
                    CheckBoxListSoc.Visible = true;
                    CheckBoxListSocS.Visible = false;
                    break;
                case "soilorganiccarbonstock_socs":
                    CheckBoxListBdod.Visible = false;
                    CheckBoxListClay.Visible = false;
                    CheckBoxListCec.Visible = false;
                    CheckBoxListCoa.Visible = false;
                    CheckBoxListN.Visible = false;
                    CheckBoxListOcd.Visible = false;
                    CheckBoxListPh.Visible = false;
                    CheckBoxListSnd.Visible = false;
                    CheckBoxListSlt.Visible = false;
                    CheckBoxListSoc.Visible = false;
                    CheckBoxListSocS.Visible = true;
                    break;

                default:
                    break;
            }
        }

        protected void ImageButtonCSV_Click(object sender, ImageClickEventArgs e)
        {
            string Estado = DropDownListEstado.SelectedValue;
            string Municipio = DropDownListMuicipio.SelectedValue;
            List<string> profunidades=new List<string>();
            foreach (ListItem item in CheckBoxListBdod.Items)
            {
                if (item.Selected)
                {
                    profunidades.Add(item.Value);
                }
            }
            foreach (ListItem item in CheckBoxListClay.Items)
            {
                if (item.Selected)
                {
                    profunidades.Add(item.Value);
                }
            }
            foreach (ListItem item in CheckBoxListCec.Items)
            {
                if (item.Selected)
                {
                    profunidades.Add(item.Value);
                }
            }
            foreach (ListItem item in CheckBoxListCoa.Items)
            {
                if (item.Selected)
                {
                    profunidades.Add(item.Value);
                }
            }
            foreach (ListItem item in CheckBoxListN.Items)
            {
                if (item.Selected)
                {
                    profunidades.Add(item.Value);
                }
            }
            foreach (ListItem item in CheckBoxListOcd.Items)
            {
                if (item.Selected)
                {
                    profunidades.Add(item.Value);
                }
            }
            foreach (ListItem item in CheckBoxListPh.Items)
            {
                if (item.Selected)
                {
                    profunidades.Add(item.Value);
                }
            }
            foreach (ListItem item in CheckBoxListSnd.Items)
            {
                if (item.Selected)
                {
                    profunidades.Add(item.Value);
                }
            }
            foreach (ListItem item in CheckBoxListSlt.Items)
            {
                if (item.Selected)
                {
                    profunidades.Add(item.Value);
                }
            }
            foreach (ListItem item in CheckBoxListSoc.Items)
            {
                if (item.Selected)
                {
                    profunidades.Add(item.Value);
                }
            }
            foreach (ListItem item in CheckBoxListSocS.Items)
            {
                if (item.Selected)
                {
                    profunidades.Add(item.Value);
                }
            }
            //CSV
            Response.Clear();
            Response.Buffer = true;
            Response.AddHeader("content-disposition", "attachment;filename=municipio_" +Municipio+ ".csv");
            Response.Charset = "";
            Response.ContentType = "application/text";
            StringBuilder columnbind = new StringBuilder();
            columnbind.Append("Latitud,");
            columnbind.Append("Longitud");
            foreach (string prof in profunidades) {
                columnbind.Append(","+prof);
            }
            columnbind.Append("\r\n");
            List<Suelo> datos = Suelo.DatosSuelo(Estado,Municipio,profunidades);

            foreach (Suelo row in datos)
            {
                columnbind.Append(row.Latitud);
                columnbind.Append("," + row.Longitud);
                if (CheckBoxListBdod.Items[0].Selected) {columnbind.Append("," + row.Bdod_a);}
                if (CheckBoxListBdod.Items[1].Selected) { columnbind.Append("," + row.Bdod_b); }
                if (CheckBoxListBdod.Items[2].Selected) { columnbind.Append("," + row.Bdod_c); }
                if (CheckBoxListBdod.Items[3].Selected) { columnbind.Append("," + row.Bdod_d); }
                if (CheckBoxListBdod.Items[4].Selected) { columnbind.Append("," + row.Bdod_e); }
                if (CheckBoxListBdod.Items[5].Selected) { columnbind.Append("," + row.Bdod_f); }

                if (CheckBoxListClay.Items[0].Selected) { columnbind.Append("," + row.Clay_a); }
                if (CheckBoxListClay.Items[1].Selected) { columnbind.Append("," + row.Clay_b); }
                if (CheckBoxListClay.Items[2].Selected) { columnbind.Append("," + row.Clay_c); }
                if (CheckBoxListClay.Items[3].Selected) { columnbind.Append("," + row.Clay_d); }
                if (CheckBoxListClay.Items[4].Selected) { columnbind.Append("," + row.Clay_e); }
                if (CheckBoxListClay.Items[5].Selected) { columnbind.Append("," + row.Clay_f); }

                if (CheckBoxListCec.Items[0].Selected) { columnbind.Append("," + row.Cec_a); }
                if (CheckBoxListCec.Items[1].Selected) { columnbind.Append("," + row.Cec_b); }
                if (CheckBoxListCec.Items[2].Selected) { columnbind.Append("," + row.Cec_c); }
                if (CheckBoxListCec.Items[3].Selected) { columnbind.Append("," + row.Cec_d); }
                if (CheckBoxListCec.Items[4].Selected) { columnbind.Append("," + row.Cec_e); }
                if (CheckBoxListCec.Items[5].Selected) { columnbind.Append("," + row.Cec_f); }
                
                if (CheckBoxListCoa.Items[0].Selected) { columnbind.Append("," + row.Coa_a); }
                if (CheckBoxListCoa.Items[1].Selected) { columnbind.Append("," + row.Coa_b); }
                if (CheckBoxListCoa.Items[2].Selected) { columnbind.Append("," + row.Coa_c); }
                if (CheckBoxListCoa.Items[3].Selected) { columnbind.Append("," + row.Coa_d); }
                if (CheckBoxListCoa.Items[4].Selected) { columnbind.Append("," + row.Coa_e); }
                if (CheckBoxListCoa.Items[5].Selected) { columnbind.Append("," + row.Coa_f); }
                
                if (CheckBoxListN.Items[0].Selected) { columnbind.Append("," + row.N_a); }
                if (CheckBoxListN.Items[1].Selected) { columnbind.Append("," + row.N_b); }
                if (CheckBoxListN.Items[2].Selected) { columnbind.Append("," + row.N_c); }
                if (CheckBoxListN.Items[3].Selected) { columnbind.Append("," + row.N_d); }
                if (CheckBoxListN.Items[4].Selected) { columnbind.Append("," + row.N_e); }
                if (CheckBoxListN.Items[5].Selected) { columnbind.Append("," + row.N_f); }
                
                if (CheckBoxListOcd.Items[0].Selected) { columnbind.Append("," + row.Ocd_a); }
                if (CheckBoxListOcd.Items[1].Selected) { columnbind.Append("," + row.Ocd_b); }
                if (CheckBoxListOcd.Items[2].Selected) { columnbind.Append("," + row.Ocd_c); }
                if (CheckBoxListOcd.Items[3].Selected) { columnbind.Append("," + row.Ocd_d); }
                if (CheckBoxListOcd.Items[4].Selected) { columnbind.Append("," + row.Ocd_e); }
                if (CheckBoxListOcd.Items[5].Selected) { columnbind.Append("," + row.Ocd_f); }
                
                if (CheckBoxListPh.Items[0].Selected) { columnbind.Append("," + row.Ph_a); }
                if (CheckBoxListPh.Items[1].Selected) { columnbind.Append("," + row.Ph_b); }
                if (CheckBoxListPh.Items[2].Selected) { columnbind.Append("," + row.Ph_c); }
                if (CheckBoxListPh.Items[3].Selected) { columnbind.Append("," + row.Ph_d); }
                if (CheckBoxListPh.Items[4].Selected) { columnbind.Append("," + row.Ph_e); }
                if (CheckBoxListPh.Items[5].Selected) { columnbind.Append("," + row.Ph_f); }
                
                if (CheckBoxListSnd.Items[0].Selected) { columnbind.Append("," + row.Snd_a); }
                if (CheckBoxListSnd.Items[1].Selected) { columnbind.Append("," + row.Snd_b); }
                if (CheckBoxListSnd.Items[2].Selected) { columnbind.Append("," + row.Snd_c); }
                if (CheckBoxListSnd.Items[3].Selected) { columnbind.Append("," + row.Snd_d); }
                if (CheckBoxListSnd.Items[4].Selected) { columnbind.Append("," + row.Snd_e); }
                if (CheckBoxListSnd.Items[5].Selected) { columnbind.Append("," + row.Snd_f); }
                
                if (CheckBoxListSlt.Items[0].Selected) { columnbind.Append("," + row.Slt_a); }
                if (CheckBoxListSlt.Items[1].Selected) { columnbind.Append("," + row.Slt_b); }
                if (CheckBoxListSlt.Items[2].Selected) { columnbind.Append("," + row.Slt_c); }
                if (CheckBoxListSlt.Items[3].Selected) { columnbind.Append("," + row.Slt_d); }
                if (CheckBoxListSlt.Items[4].Selected) { columnbind.Append("," + row.Slt_e); }
                if (CheckBoxListSlt.Items[5].Selected) { columnbind.Append("," + row.Slt_f); }
                
                if (CheckBoxListSoc.Items[0].Selected) { columnbind.Append("," + row.Soc_a); }
                if (CheckBoxListSoc.Items[1].Selected) { columnbind.Append("," + row.Soc_b); }
                if (CheckBoxListSoc.Items[2].Selected) { columnbind.Append("," + row.Soc_c); }
                if (CheckBoxListSoc.Items[3].Selected) { columnbind.Append("," + row.Soc_d); }
                if (CheckBoxListSoc.Items[4].Selected) { columnbind.Append("," + row.Soc_e); }
                if (CheckBoxListSoc.Items[5].Selected) { columnbind.Append("," + row.Soc_f); }

                if (CheckBoxListSocS.Items[0].Selected) { columnbind.Append("," + row.SocS_a); }


                columnbind.Append("\r\n");
            }
            Response.Output.Write(columnbind.ToString());
            Response.Flush();
            Response.End();

        }

        protected void DropDownListMuicipio_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Poligono> Consulta = Poligono.PolygonsMunicipio(DropDownListMuicipio.SelectedValue);
            foreach (Poligono get in Consulta)
            {
                string mpol = Procesos.Poligono.GetLista(get.Polygon);
                Lista_polygonos = mpol + ",";
            }
            Lista_polygonos = "[" + Lista_polygonos + "]";

        }

        protected void ButtonMapa_Click(object sender, EventArgs e)
        {

            List<Poligono> Consulta = Poligono.PolygonsMunicipio(DropDownListMuicipio.SelectedValue);
            foreach (Poligono get in Consulta)
            {
                string mpol = Procesos.Poligono.GetLista(get.Polygon);
                Lista_polygonos = mpol + ",";
            }
            Lista_polygonos = "[" + Lista_polygonos + "]";
        }

        protected void ButtonLimpiar_Click(object sender, EventArgs e)
        {
            CheckBoxListBdod.ClearSelection();
            CheckBoxListClay.ClearSelection();
            CheckBoxListCec.ClearSelection();
            CheckBoxListCoa.ClearSelection();
            CheckBoxListN.ClearSelection();
            CheckBoxListOcd.ClearSelection();
            CheckBoxListPh.ClearSelection();
            CheckBoxListSnd.ClearSelection();
            CheckBoxListSlt.ClearSelection();
            CheckBoxListSoc.ClearSelection();
            CheckBoxListSocS.ClearSelection();
        }
        protected void ImageButtonTiff_Click(object sender, ImageClickEventArgs e)
        {
            string Estado = DropDownListEstado.SelectedValue;
            List<string> profunidades = new List<string>();
            foreach (ListItem item in CheckBoxListBdod.Items)
            {
                if (item.Selected)
                {
                    profunidades.Add(item.Value);
                }
            }
            foreach (ListItem item in CheckBoxListClay.Items)
            {
                if (item.Selected)
                {
                    profunidades.Add(item.Value);
                }
            }
            foreach (ListItem item in CheckBoxListCec.Items)
            {
                if (item.Selected)
                {
                    profunidades.Add(item.Value);
                }
            }
            foreach (ListItem item in CheckBoxListCoa.Items)
            {
                if (item.Selected)
                {
                    profunidades.Add(item.Value);
                }
            }
            foreach (ListItem item in CheckBoxListN.Items)
            {
                if (item.Selected)
                {
                    profunidades.Add(item.Value);
                }
            }
            foreach (ListItem item in CheckBoxListOcd.Items)
            {
                if (item.Selected)
                {
                    profunidades.Add(item.Value);
                }
            }
            foreach (ListItem item in CheckBoxListPh.Items)
            {
                if (item.Selected)
                {
                    profunidades.Add(item.Value);
                }
            }
            foreach (ListItem item in CheckBoxListSnd.Items)
            {
                if (item.Selected)
                {
                    profunidades.Add(item.Value);
                }
            }
            foreach (ListItem item in CheckBoxListSlt.Items)
            {
                if (item.Selected)
                {
                    profunidades.Add(item.Value);
                }
            }
            foreach (ListItem item in CheckBoxListSoc.Items)
            {
                if (item.Selected)
                {
                    profunidades.Add(item.Value);
                }
            }
            foreach (ListItem item in CheckBoxListSocS.Items)
            {
                if (item.Selected)
                {
                    profunidades.Add(item.Value);
                }
            }
            if (profunidades.Count() > 0)
            {
                string urlArchivo = string.Format("https://clima.inifap.gob.mx/suelos/cent_{0}_{1}.tif", Estado, profunidades[0]);
                using (WebClient client = new WebClient())
                {
                    byte[] archivoBytes;
                    try
                    {
                        archivoBytes = client.DownloadData(urlArchivo);
                    }
                    catch (WebException ex)
                    {
                        Response.Write("Error al descargar el archivo: " + ex.Message);
                        return;
                    }

                    string nombreArchivo = string.Format("cent_{0}_{1}.tif", Estado, profunidades[0]);

                    // Enviar el archivo al navegador
                    Response.Clear();
                    Response.ContentType = "application/octet-stream";
                    Response.AddHeader("Content-Disposition", "attachment; filename=" + nombreArchivo);
                    Response.BinaryWrite(archivoBytes);
                    Response.End();
                }
            }
        }
    }
}