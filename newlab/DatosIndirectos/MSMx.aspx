<%@ Page Title="" Language="C#" MasterPageFile="~/Lab.Master" AutoEventWireup="true" CodeBehind="MSMx.aspx.cs" Inherits="newlab.DatosIndirectos.MSMx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <%-- REF --%>
    <link rel="stylesheet" href="https://unpkg.com/leaflet@1.9.3/dist/leaflet.css"
        integrity="sha256-kLaT2GOSpHechhsozzB+flnD+zUyjE2LlfWPgU04xyI="
        crossorigin="" />
    <script src="https://unpkg.com/leaflet@1.9.3/dist/leaflet.js"
        integrity="sha256-WBkoXOwTeyKclOHuWtc+i2uENFpDZ9YPdf5Hf+D7ewM="
        crossorigin=""></script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/js/bootstrap.bundle.min.js" 
        integrity="sha384-C6RzsynM9kWDrMNeT87bh95OGNyZPhcTNXj1NW7RuBCsyN/o0jlpcV8Qyq46cDfL" crossorigin="anonymous"></script>
    <style>
        #map {
            width: 100%;
            height: 580px;
            box-shadow: 5px 5px 5px #888;
        }

        .chkChoice input {
            margin-left: -20px;
        }

        .chkChoice td {
            padding-left: 20px;
        }
    </style>
    <div class="container">
        <div class="row">
            <div class="col-sm-12" style="text-align: center;">
                <h1>MSMx <span class="badge badge-secondary" style="background-color:chocolate;"><img src="../Images/icon/suelo4.png" style="height:65px; width:60px;" /> <button type="button" class="btn btn-success" style="background-color:forestgreen;" data-toggle="modal" data-target="#exampleModalCenter">INFORMACIÓN GENERAL</button></span></h1> 
            </div>
        </div>
        <br />
        <div class="row">
            <div class="col-sm-12">
                <ul class="list-group">
                    <li class="list-group-item active text-center" style="align-content: center; background-color: deepskyblue;">
                        Guía de Manejo del Sistema
                    </li>
                    <li class="list-group-item">1. Elija un Estado, un Municipio y el tipo de variable que desea descargar.</li>
                    <li class="list-group-item">2. Para añadir una variable a su lista de descarga, haga clic en las profundidades deseadas.<br />
                        <ol type="A">
                            <li>Modifique la variable y seleccione las profundidades si desea añadir más variables a su lista de descarga.</li>
                            <li>Para descartar variables, puede desmarcar las profundidades no deseadas una a una.</li>
                            <li>Puede vaciar su lista de selección presionando el botón "Limpiar Lista".</li>
                        </ol>
                    </li>
                     <li class="list-group-item">
                        3. Para obtener la imagen TIFF de una característica específica del suelo, es necesario seleccionar un estado, una variable y únicamente una profundidad. <br />
                        En consecuencia, se sugieren los siguientes pasos:<br />
                        <ol type="A">
                            <li>Seleccione un estado; puede omitir la selección del municipio, ya que no tiene relevancia en este procedimiento.</li>
                            <li>Seleccione una variable; observe que la lista de profundidades ha cambiado.</li>
                            <li>Se sugiere limpiar la lista antes de pasar al siguiente paso. En caso de encontrar dos profundidades seleccionadas de la misma o diferente variable, el sistema seguirá la orden de la primera que encuentre al realizar la descarga.</li>
                            <li>Seleccione únicamente una profundidad para la variable.</li>
                        </ol>
                    </li>
                    <%=mensaje %>
                </ul>
            </div>
        </div>
        <div class="row">
            <div class="col-sm-12">
                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                    <ContentTemplate>
                        <b>ESTADO:</b>
                        <asp:DropDownList CssClass="form-control" ID="DropDownListEstado" runat="server" DataSourceID="ObjectDataSourceEstado" DataTextField="Nombre" DataValueField="CVE" AutoPostBack="true"></asp:DropDownList>
                        <asp:ObjectDataSource ID="ObjectDataSourceEstado" runat="server" SelectMethod="Estados" TypeName="SistemaAlertas.Business.Poligono"></asp:ObjectDataSource>
                        <b>MUNICIPIO:</b>
                        <asp:DropDownList  CssClass="form-control"  ID="DropDownListMuicipio" runat="server" DataSourceID="ObjectDataSourceMunicipio" DataTextField="Nombre" DataValueField="CVM" AutoPostBack="true" OnSelectedIndexChanged="DropDownListMuicipio_SelectedIndexChanged"></asp:DropDownList>
                        <b>VARIABLE:</b>
                        <asp:DropDownList  CssClass="form-control"  ID="DropDownListVariable" runat="server" AutoPostBack="true">
                            <asp:ListItem Value="bulkdensity">bdod</asp:ListItem>
                            <asp:ListItem Value="claycontent">clay</asp:ListItem>
                            <asp:ListItem Value="cic-cec">cec</asp:ListItem>
                            <asp:ListItem Value="coarsefragments_coa">coa</asp:ListItem>
                            <asp:ListItem Value="nitrogen_n">nitrogen</asp:ListItem>
                            <asp:ListItem Value="organicacarbondensity_ocd">ocd</asp:ListItem>
                            <asp:ListItem Value="phwater_ph">ph water</asp:ListItem>
                            <asp:ListItem Value="sand_snd">sand</asp:ListItem>
                            <asp:ListItem Value="silt_slt">silt</asp:ListItem>
                            <asp:ListItem Value="soilorganiccarbon_soc">soc</asp:ListItem>
                        </asp:DropDownList>

                        <br />
                        <h4>Selecciona la(s) profundidad(es) de la variable:</h4>
                        <asp:CheckBoxList ID="CheckBoxListBdod" runat="server" Visible="false">
                            <asp:ListItem Text="BulkDensity (bdod) de 0 a 5 cm" Value="bulkdensity_blk0_5" />
                            <asp:ListItem Text="BulkDensity (bdod) de 5 a 15 cm" Value="bulkdensity_blk_5_15" />
                            <asp:ListItem Text="BulkDensity (bdod) de 15 a 30 cm" Value="bulkdensity_blk_15_30" />
                            <asp:ListItem Text="BulkDensity (bdod) de 30 a 60 cm" Value="bulkdensity_blk_30_60" />
                            <asp:ListItem Text="BulkDensity (bdod) de 60 a 100 cm" Value="bulkdensity_blk60_100" />
                            <asp:ListItem Text="BulkDensity (bdod) de 100 a 200 cm" Value="bulkdensity_blk100_200" />
                        </asp:CheckBoxList>
                        <asp:CheckBoxList ID="CheckBoxListClay" runat="server" Visible="false">
                            <asp:ListItem Text="ClayContent (clay) de 0 a 5 cm" Value="claycontent_clay0_5" />
                            <asp:ListItem Text="ClayContent (clay) de 5 a 15 cm" Value="claycontent_clay5_15" />
                            <asp:ListItem Text="ClayContent (clay) de 15 a 30 cm" Value="claycontent_clay15_30" />
                            <asp:ListItem Text="ClayContent (clay) de 30 a 60 cm" Value="claycontent_clay30_60" />
                            <asp:ListItem Text="ClayContent (clay) de 60 a 100 cm" Value="claycontent_clay60_100" />
                            <asp:ListItem Text="ClayContent (clay) de 100 a 200 cm" Value="claycontent_clay100_200" />
                        </asp:CheckBoxList>
                        <asp:CheckBoxList ID="CheckBoxListCec" runat="server" Visible="false">
                            <asp:ListItem Text="Capacidad de Intercambio Catiónico (cec) de 0 a 5 cm" Value="cic_cec0_5" />
                            <asp:ListItem Text="Capacidad de Intercambio Catiónico (cec) de 5 a 15 cm" Value="cic_cec5_15" />
                            <asp:ListItem Text="Capacidad de Intercambio Catiónico (cec) de 15 a 30 cm" Value="cic_cec15_30" />
                            <asp:ListItem Text="Capacidad de Intercambio Catiónico (cec) de 30 a 60 cm" Value="cic_cec30_60" />
                            <asp:ListItem Text="Capacidad de Intercambio Catiónico (cec) de 60 a 100 cm" Value="cic_cec60_100" />
                            <asp:ListItem Text="Capacidad de Intercambio Catiónico (cec) de 100 a 200 cm" Value="cic_cec100_200" />
                        </asp:CheckBoxList>
                        <asp:CheckBoxList ID="CheckBoxListCoa" runat="server" Visible="false">
                            <asp:ListItem Text="Coarse Fragments (coa) de 0 a 5 cm" Value="coarsefragments_coa0_5" />
                            <asp:ListItem Text="Coarse Fragments (coa) de 5 a 15 cm" Value="coarsefragments_coa5_15" />
                            <asp:ListItem Text="Coarse Fragments (coa) de 15 a 30 cm" Value="coarsefragments_coa15_30" />
                            <asp:ListItem Text="Coarse Fragments (coa) de 30 a 60 cm" Value="coarsefragments_coa30_60" />
                            <asp:ListItem Text="Coarse Fragments (coa) de 60 a 100 cm" Value="coarsefragments_coa60_100" />
                            <asp:ListItem Text="Coarse Fragments (coa) de 100 a 200 cm" Value="coarsefragments_coa100_200" />
                        </asp:CheckBoxList>
                        <asp:CheckBoxList ID="CheckBoxListN" runat="server" Visible="false">
                            <asp:ListItem Text="Nitrogen (n) de 0 a 5 cm" Value="nitrogen_n0_5" />
                            <asp:ListItem Text="Nitrogen (n) de 5 a 15 cm" Value="nitrogen_n5_15" />
                            <asp:ListItem Text="Nitrogen (n) de 15 a 30 cm" Value="nitrogen_n15_30" />
                            <asp:ListItem Text="Nitrogen (n) de 30 a 60 cm" Value="nitrogen_n30_60" />
                            <asp:ListItem Text="Nitrogen (n) de 60 a 100 cm" Value="nitrogen_n60_100" />
                            <asp:ListItem Text="Nitrogen (n) de 100 a 200 cm" Value="nitrogen_n100_200" />
                        </asp:CheckBoxList>
                        <asp:CheckBoxList ID="CheckBoxListOcd" runat="server" Visible="false">
                            <asp:ListItem Text="Organic Carbon Density (ocd) de 0 a 5 cm" Value="organicacarbondensity_ocd0_5" />
                            <asp:ListItem Text="Organic Carbon Density (ocd) de 5 a 15 cm" Value="organicacarbondensity_ocd5_15" />
                            <asp:ListItem Text="Organic Carbon Density (ocd) de 15 a 30 cm" Value="organicacarbondensity_ocd15_30" />
                            <asp:ListItem Text="Organic Carbon Density (ocd) de 30 a 60 cm" Value="organicacarbondensity_ocd30_60" />
                            <asp:ListItem Text="Organic Carbon Density (ocd) de 60 a 100 cm" Value="organicacarbondensity_ocd60_100" />
                            <asp:ListItem Text="Organic Carbon Density (ocd) de 100 a 200 cm" Value="organicacarbondensity_ocd100_200" />
                        </asp:CheckBoxList>
                        <asp:CheckBoxList ID="CheckBoxListPh" runat="server" Visible="false">
                            <asp:ListItem Text="ph Water (ph) de 0 a 5 cm" Value="phwater_ph0_5" />
                            <asp:ListItem Text="ph Water (ph) de 5 a 15 cm" Value="phwater_ph5_15" />
                            <asp:ListItem Text="ph Water (ph) de 15 a 30 cm" Value="phwater_ph15_30" />
                            <asp:ListItem Text="ph Water (ph) de 30 a 60 cm" Value="phwater_ph30_60" />
                            <asp:ListItem Text="ph Water (ph) de 60 a 100 cm" Value="phwater_ph60_100" />
                            <asp:ListItem Text="ph Water (ph) de 100 a 200 cm" Value="phwater_ph100_200" />
                        </asp:CheckBoxList>
                        <asp:CheckBoxList ID="CheckBoxListSnd" runat="server" Visible="false">
                            <asp:ListItem Text="Sand (snd) de 0 a 5 cm" Value="sand_snd0_5" />
                            <asp:ListItem Text="Sand (snd) de 5 a 15 cm" Value="sand_snd5_15" />
                            <asp:ListItem Text="Sand (snd) de 15 a 30 cm" Value="sand_snd15_30" />
                            <asp:ListItem Text="Sand (snd) de 30 a 60 cm" Value="sand_snd30_60" />
                            <asp:ListItem Text="Sand (snd) de 60 a 100 cm" Value="sand_snd60_100" />
                            <asp:ListItem Text="Sand (snd) de 100 a 200 cm" Value="sand_snd100_200" />
                        </asp:CheckBoxList>
                        <asp:CheckBoxList ID="CheckBoxListSlt" runat="server" Visible="false">
                            <asp:ListItem Text="Silt (slt) de 0 a 5 cm" Value="silt_slt0_5" />
                            <asp:ListItem Text="Silt (slt) de 5 a 15 cm" Value="silt_slt5_15" />
                            <asp:ListItem Text="Silt (slt) de 15 a 30 cm" Value="silt_slt15_30" />
                            <asp:ListItem Text="Silt (slt) de 30 a 60 cm" Value="silt_slt30_60" />
                            <asp:ListItem Text="Silt (slt) de 60 a 100 cm" Value="silt_slt60_100" />
                            <asp:ListItem Text="Silt (slt) de 100 a 200 cm" Value="silt_slt100_200" />
                        </asp:CheckBoxList>
                        <asp:CheckBoxList ID="CheckBoxListSoc" runat="server" Visible="false">
                            <asp:ListItem Text="Soil Organic Carbon (soc) de 0 a 5 cm" Value="soilorssganiccarbon_soc0_5" />
                            <asp:ListItem Text="Soil Organic Carbon (soc) de 5 a 15 cm" Value="soilorganiccarbon_soc5_15" />
                            <asp:ListItem Text="Soil Organic Carbon (soc) de 15 a 30 cm" Value="soilorganiccarbon_soc15_30" />
                            <asp:ListItem Text="Soil Organic Carbon (soc) de 30 a 60 cm" Value="soilorganiccarbon_soc30_60" />
                            <asp:ListItem Text="Soil Organic Carbon (soc) de 60 a 100 cm" Value="soilorganiccarbon_soc60_100" />
                            <asp:ListItem Text="Soil Organic Carbon (soc) de 100 a 200 cm" Value="soilorganiccarbon_soc100_200" />
                        </asp:CheckBoxList>
                        <asp:Button ID="ButtonLimpiar" runat="server" Text="Limpiar Lista" OnClick="ButtonLimpiar_Click" CssClass="btn bg-danger" />
                        <asp:ObjectDataSource ID="ObjectDataSourceMunicipio" runat="server" SelectMethod="Municipios" TypeName="SistemaAlertas.Business.Poligono">
                            <SelectParameters>
                                <asp:ControlParameter ControlID="DropDownListEstado" DefaultValue="01" Name="cve" PropertyName="SelectedValue" Type="String" />
                            </SelectParameters>
                        </asp:ObjectDataSource>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </div>
        </div>
        <div class="row">
            <div class="col-sm-12" style="align-content:center;">
                <asp:Panel ID="PanelDownload" runat="server">
                     <table style="margin: 0 auto;">
                    <tr style="padding: 5px;">
                        <td>
                            <asp:ImageButton ID="ImageButtonCSV" runat="server" Height="90px" ImageUrl="~/Images/icon/csv1.png" Width="80px" OnClick="ImageButtonCSV_Click" />
                        </td>
                        <td>
                            <asp:ImageButton ID="ImageButtonTiff" runat="server" Height="90px" Width="80px" ImageUrl="~/Images/icon/tiff3.png" OnClick="ImageButtonTiff_Click"/>
                        </td>
                    </tr>
                </table>
                </asp:Panel>
            </div>
        </div>
        <div class="row">
            <div class="col-sm-12" style="text-align: center;">
                <%-- MAPA --%>
                <asp:Button ID="ButtonMapa" runat="server" Text="Ver Polígono en Mapa" OnClick="ButtonMapa_Click" CssClass="btn btn-success form-control" />

                <asp:Panel ID="PanelMapa" runat="server">
                    <div id="map"></div>
                </asp:Panel>
            </div>
        </div>

    </div>
    <%-- Modal --%>
    <div class="modal fade" id="exampleModalCenter" tabindex="-1" role="dialog" aria-labelledby="exampleModalCenterTitle" aria-hidden="true">
        <div class="modal-dialog modal-dialog-centered" role="document">
            <div class="modal-content">
                <div class="modal-header" style="background-color:darkgreen;">
                        <h3>Información General</h3>
                </div>
                <br />
                <div  style="padding: 5px;">
                    <div class="col-sm-12" style="text-align: justify;">
                        <p>El "SERVICIO WEB PARA EL MANEJO DEL PRODUCTO COMPILACION DE LA BASE DE DATOS DE SUELOS SOILGRIDS PARA LA PLATAFORMA CONTINENTAL DE MÉXICO" (MSMx) se encuentra en etapa de desarrollo beta. Malla con cobertura nacional a 250 metros.</p>
                    </div>
                    <br />
                    <table style="height: 300px; width: 550px; border: medium; font-size: small;" align="center" border="1px">
                        <tbody>
                            <tr>
                                <th>VARIABLES</th>
                                <th>ACRÓNIMO</th>
                                <th>DESCRIPCIÓN</th>
                                <th>UNIDADES DE MAPA</th>
                                <th>FACTOR DE CONVERSIÓN</th>
                                <th>UNIDADES CONVENCIONALES</th>
                            </tr>
                            <tr>
                                <th rowspan="5" style="transform: rotate(90deg)">FISICAS</th>
                                <th>bdod</th>
                                <th style="text-align: justify;">Densidad aparente de la fracción de tierra fina</th>
                                <th>cg/cm³</th>
                                <th>100</th>
                                <th>kg/dm³</th>
                            </tr>
                            <tr>
                                <th>clay</th>
                                <th style="text-align: justify;">Proporción de partículas de arcilla (< 0.002 mm) en la fracción de tierra fina</th>
                                <th>g/kg</th>
                                <th>10</th>
                                <th>g/100g (%)</th>
                            </tr>
                            <tr>
                                <td>sand</td>
                                <td style="text-align: justify;">Proporción de partículas de arena (> 0.05 mm) en la fracción de tierra fina</td>
                                <td>g/kg</td>
                                <td>10</td>
                                <td>g/100g (%)</td>
                            </tr>
                            <tr>
                                <td>silt</td>
                                <td style="text-align: justify;">Proporción de partículas de limo (≥ 0.002 mm y ≤ 0.05 mm) en la fracción de tierra fina</td>
                                <td>g/kg</td>
                                <td>10</td>
                                <td>g/100g (%)</td>
                            </tr>
                            <tr>
                                <td>cfvo</td>
                                <td style="text-align: justify;">Fracción volumétrica de fragmentos gruesos (> 2 mm)</td>
                                <td>cm3/dm3 (vol‰)</td>
                                <td>10</td>
                                <td>cm3/100cm3 (vol%)</td>
                            </tr>
                            <tr>
                                <td rowspan="4" style="transform: rotate(90deg)">QUIMICAS</td>
                                <td>cec</td>
                                <td style="text-align: justify;">Capacidad de Intercambio Catiónico del suelo</td>
                                <td>mmol (c)/kg</td>
                                <td>10</td>
                                <td>cmol(c)/kg centimoles de carga</td>

                            </tr>
                            <tr>
                                <td>nitrogen</td>
                                <td style="text-align: justify;">Nitrógeno Total (N)</td>
                                <td>cg/kg</td>
                                <td>100</td>
                                <td>g/kg</td>
                            </tr>
                            <tr>
                                <td>soc</td>
                                <td style="text-align: justify;">Contenido de carbono orgánico del suelo en la fracción de tierra fina</td>
                                <td>dg/kg</td>
                                <td>10</td>
                                <td>g/kg-1</td>
                            </tr>
                            <tr>
                                <td>phh2o</td>
                                <td style="text-align: justify;">pH del suelo</td>
                                <td>pHx10</td>
                                <td>10</td>
                                <td>pH</td>
                            </tr>
                            <tr>
                                <td rowspan="2" style="transform: rotate(90deg)">DERIVADAS</td>
                                <td>ocd</td>
                                <td style="text-align: justify;">Densidad de carbono orgánico</td>
                                <td>hg/m³</td>
                                <td>10</td>
                                <td>kg/m³</td>
                            </tr>
                            <tr>
                                <td>ocs</td>
                                <td style="text-align: justify;">Reservas de carbono orgánico</td>
                                <td>t/ha</td>
                                <td>10</td>
                                <td>kg/m²</td>
                            </tr>
                        </tbody>
                    </table>
                </div>
                <div class="modal-footer">
                    <button type="button" class="btn bg-danger" data-dismiss="modal">Cerrar</button>
                </div>
            </div>
        </div>
    </div>
    <%-- Mapa Script --%>
    <script>
        var map = L.map('map').setView([22.1615498, -102.2969356], 5);
        L.tileLayer('https://tile.openstreetmap.org/{z}/{x}/{y}.png', {
            maxZoom: 13,
            attribution: '&copy; <a href="http://www.openstreetmap.org/copyright">OpenStreetMap</a>'
        }).addTo(map);

        var lista = <% =Lista_polygonos %> 

            lista.forEach(function (palabra) {
                console.log(palabra);
                var invertedPositions = [];
                var polygon = L.polygon(palabra);
                polygon.getLatLngs().forEach(function (positions) {
                    var invertedLatLngs = positions.map(function (latlng) {
                        return L.latLng(latlng.lng, latlng.lat).wrap();
                    });
                    invertedPositions.push(invertedLatLngs);
                });
                var invertedPolygon = L.polygon(invertedPositions, { color: 'green', fillOpacity: 0.5, fillColor: 'green' });
                invertedPolygon.addTo(map);
            });
    </script>
</asp:Content>
