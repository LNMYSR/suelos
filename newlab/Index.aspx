<%@ Page Title="" Language="C#" MasterPageFile="~/Lab.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="newlab.lnmysr" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <style>
            .alert {
  padding: 20px;
  background-color: #f44336;
  color: white;
}

.closebtn {
  margin-left: 15px;
  color: white;
  font-weight: bold;
  float: right;
  font-size: 22px;
  line-height: 20px;
  cursor: pointer;
  transition: 0.3s;
}

.closebtn:hover {
  color: black;
}
        .carousel-inner > .item > img,
        .carousel-inner > .item > a > img {
            width:  60%;
            margin: auto;
        }
    </style>
    <div class="container">
        <!--BREADCRUMB / MODIFICAR SOLAMENTO EL NOMBRE DEL SITIO-->
      
    </div>
    <div class="container">
        <%-- AVISO --%>
        <div class="row">
            <div class="col-sm-12">
                <div class="alert">
                    <span class="closebtn" onclick="this.parentElement.style.display='none';">&times;</span>
                    <b>Descargo de responsabilidad:</b> <p style='text-align:justify;'>Los datos meteorológicos publicados en este portal, corresponden con la posición geográfica de equipos electromecánicos de monitoreo instalados y operados bajo diferentes condiciones de registro y envío de origen. El INIFAP, a través de este portal es coadyuvante en la generación de información meteorológica en el marco regulatorio de LEY DEL SISTEMA NACIONAL DE INFORMACIÓN ESTADÍSTICA Y GEOGRÁFICA, del <b>Sistema Nacional de Información Estadística y Geográfica.</b></p>
                    <button type="button" class="btn btn-success" data-toggle="modal" data-target="#myModal">PROTECCIÓN DE SU PRIVACIDAD</button>
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col-sm-12">
                  <ol class="breadcrumb top-buffer">
            <li><a href="http://www.gob.mx"><i class="icon icon-home"></i></a></li>
            <li><a href="https://www.gob.mx/inifap">Instituto Nacional de Investigaciones Forestales, Agrícolas y Pecuarias</a></li>
            <li class="active">LNMYSR</li>
        </ol>
                <h2>Laboratorio Nacional de Modelaje y Sensores Remotos</h2>
                <h3>Productos y Servicios</h3>
                <hr class="red"/>

                <div class="row">
                    <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12">
                        <div class="container">
                            <div id="myCarousel" class="carousel slide" data-ride="carousel" data-inteval="6000">
                                <!-- Indicators -->
                                <ol class="carousel-indicators">
                                    <li data-target="#myCarousel" data-slide-to="0" class="active"></li>
                                    <li data-target="#myCarousel" data-slide-to="1"></li>
                                    <li data-target="#myCarousel" data-slide-to="2"></li>
                                    <li data-target="#myCarousel" data-slide-to="3"></li>
                                    <li data-target="#myCarousel" data-slide-to="4"></li>
                                    <li data-target="#myCarousel" data-slide-to="5"></li>
                                    <li data-target="#myCarousel" data-slide-to="6"></li>
                                    <li data-target="#myCarousel" data-slide-to="7"></li>
                                    <li data-target="#myCarousel" data-slide-to="8"></li>
                                    <li data-target="#myCarousel" data-slide-to="9"></li>
                                    <li data-target="#myCarousel" data-slide-to="10"></li>
                                    <li data-target="#myCarousel" data-slide-to="11"></li>
                                    <li data-target="#myCarousel" data-slide-to="12"></li>
                                    <li data-target="#myCarousel" data-slide-to="13"></li>
                                    <li data-target="#myCarousel" data-slide-to="14"></li>
                                </ol>
                                <div class="carousel-inner" role="listbox">
                                    <%-- GUAYABA --%>
                               <%--     <div class="item active">
                                        <img src="Images/Eventos/G1.png" width="800" height="600"/>
                                         <div class="carousel-caption">
                                            <div>
                                                <h2 style="background-color:#187114"><a href="Eventos/Guayabo.aspx" style="color:white;">Ver Aquí</a></h2>
                                            </div>
                                        </div>
                                    </div>--%>
                                    <%--  --%>
                                    <div class="item active">
                                        <img src="Documentos/Eventos/CIASA_2023_V1.jpg" alt="Flower" width="800" height="600"/>
                                        <div class="carousel-caption">
                                            <div>
                                                <p style="background-color:#ffffff">
                                                    <a href="Eventos/CongresoIASA.aspx" style="font-size:xx-large">Ver Aquí</a>
                                                </p>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="item">
                                         <img src="Documentos/Eventos/CIASA_2023_V2.jpg" alt="Flower" width="800" height="600"/>
                                        <div class="carousel-caption">
                                            <div>
                                                <p style="background-color:#ffffff"">
                                                    <a href="Eventos/CongresoIASA.aspx" style="font-size:xx-large">Ver Aquí</a>
                                                </p>
                                            </div>
                                        </div>
                                    </div>
                                    <%--<div class="item">
                                        <img src="Images/SENTINEL.png" alt="Flower" width="800" height="600"/>
                                        <div class="carousel-caption">
                                            <div>
                                                <h2 style="background-color:#ef932f">Sentinel HUB</h2>
                                                <p style="background-color:#ffffff">
                                                    <a href="DatosIndirectos/Sentinel.aspx">Ver Aquí</a>
                                                </p>
                                            </div>
                                        </div>
                                    </div>--%>
                                    <div class="item">
                                        <img src="Images/DatosIndirectos/infograf_essenger.png" alt="Flower" width="800" height="600"/>
                                        <div class="carousel-caption">
                                            <div>
                                                <p style="background-color:#ffffff">
                                                    <a href="DatosIndirectos/NEssenger.aspx">Ver Aquí</a>
                                                </p>
                                            </div>
                                        </div>
                                    </div>
                                  <%--  <div class="item">
                                        <img src="Images/dialogo_sequia.jpg" alt="Flower" width="800" height="600"/>
                                        <div class="carousel-caption">
                                            <div>
                                                <p style="background-color:#ffffff">
                                                <a href="https://www.youtube.com/watch?v=PlyPS_gnosE" >Ver Aquí Transmisión en Vivo</a>
                                                <img src="Images/youtube.png" width="50" height="30" />
                                                </p>
                                            </div>
                                        </div>
                                    </div>--%>
                                    <%--<div class="item">
                                        <img src="Images/swat.png" alt="Flower" width="800" height="600"/>
                                        <div class="carousel-caption">
                                        </div>
                                    </div>--%>
                                    <div class="item">
                                        <img src="Images/Pronostico/pronomet.png" alt="Flower" width="800" height="600"/>
                                        <div class="carousel-caption">
                                            <h2 style="background-color:#ef932f">Perspectiva Meteorológica: Diario a 8km</h2>
                                            <p><a href="Perspectiva/Pronomet.aspx">Ver</a></p>
                                        </div>
                                    </div>
                                    <div class="item">
                                        <img src="Images/Pronostico/mexicohr.png" alt="Flower" width="800" height="600"/>
                                        <div class="carousel-caption">
                                            <h2 style="background-color:#eace47" >Perspectiva Meteorológica: Horario a 8km</h2>
                                            <p><a href="Perspectiva/PronometHorario.aspx">Ver</a></p>
                                        </div>
                                    </div>
                                    <div class="item">
                                        <img src="Images/Pronostico/pronometNA.png" alt="Flower" width="800" height="600"/>
                                        <div class="carousel-caption">
                                            <h2 style="background-color:#64b6c2">Pronóstico Norte América 15km</h2>
                                            <p><a href="~/Pronostico/PronosticoDiarioNA">Ver</a></p>
                                        </div>
                                    </div>
                                    <div class="item">
                                        <img src="Images/Pronostico/nahr.png" alt="Flower" width="800" height="600"/>
                                        <div class="carousel-caption">
                                            <h3 style="background-color:#388dcc">Pronóstico Horario Norte América 15km</h3>
                                            <p><a href="~/Pronostico/PronosticoHorarioNA">Ver</a></p>
                                        </div>
                                    </div>
                                    <div class="item">
                                        <img src="Images/promo/chihuahua/chihuahuaA.png" alt="Flower" width="800" height="600"/>
                                        <div class="carousel-caption">
                                            <h3 style="background-color:#92c17c">Sistema Meteorológico de Alerta Fitosanitaria Temprana. Chihuahua</h3>
                                            <p><a href="~/Portales/Chihuahua">Ver nota</a></p>
                                        </div>
                                    </div>
                                    <div class="item">
                                        <img src="Images/promo/caborca/caborcaA.png" alt="Flower" width="800" height="600"/>
                                        <div class="carousel-caption">
                                            <h3 style="background-color:#808080">Sistema de Monitoreo Ambiental. Caborca</h3>
                                            <p><a href="~/Portales/Caborca">Ver nota</a></p>
                                        </div>
                                    </div>
                                    <div class="item">
                                        <img src="Images/Pronostico/Calvillo_AGS.png" alt="Flower" width="800" height="600"/>
                                        <div class="carousel-caption">
                                            <h3 style="background-color:#dda2a2">Meteogramas</h3>
                                            <p><a href="~/Pronostico/Meteogramas">Ver nota</a></p>
                                        </div>
                                    </div>
                                    <div class="item">
                                        <img src="http://clima.inifap.gob.mx/img/img/img/satellite/satellite.png" alt="Flower" width="800" height="600"/>
                                        <div class="carousel-caption">
                                            <h2 style="background-color:blue">Apoyo Técnico a Satélite 2019 CECyTEA: San José de Gracia</h2>
                                            <p><a href="https://github.com/MASTERF500/cecytea">Github</a></p>
                                        </div>
                                    </div>
                                    <div class="item">
                                        <img src="Images/temperaturaMinima.jpg" alt="Flower" width="800" height="600"/>
                                        <div class="carousel-caption">
                                            <h3>Pronóstico Temperatura mínima</h3>
                                            <p><a href="~/Principal/Tmin" target="_blank">Ver</a></p>
                                        </div>
                                    </div>
                                    <div class="item">
                                        <img src="Images/unidadesCalor.jpg" alt="Flower" width="800" height="600"/>
                                        <div class="carousel-caption">
                                            <h3>Pronóstico Unidades Calor base 10</h3>
                                            <p><a href="~/Principal/unidadesCalor" target="_blank">Ver</a></p>
                                        </div>
                                    </div>
                                    <div class="item">
                                        <img src="Images/precipitacion.jpg" alt="Flower" width="800" height="600"/>
                                        <div class="carousel-caption">
                                            <h3>Pronóstico Precipitación</h3>
                                            <p><a href="~/Principal/Precipitacion" target="_blank">Ver</a></p>
                                        </div>
                                    </div>
                                </div>
                                <a class="left carousel-control" href="#myCarousel" role="button" data-slide="prev">
                                    <span class="glyphicon glyphicon-chevron-left" aria-hidden="true"></span>
                                    <span class="sr-only">Previous</span>
                                </a>
                                <a class="right carousel-control" href="#myCarousel" role="button" data-slide="next">
                                    <span class="glyphicon glyphicon-chevron-right" aria-hidden="true"></span>
                                    <span class="sr-only">Next</span>
                                </a>
                            </div>
                        </div>

                    </div>
                </div>

                <div class="row">
                    <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12">
                        <div class="col-md-4">
                            <article>
                                <div class="row" style="width: 100%; font-size: small;">
                                    <br/>
                                    <h4>Pronóstico del clima</h4>

                                </div>
                                <div class="row" style="width: 100%; text-align:justify; font-size: medium;">
                                    <br/>
                                    El Laboratorio Nacional de Modelaje y Sensores Remotos (LNMySR), es el responsable por INIFAP de emitir los pronósticos de las condiciones de humedad y temperatura. Se emiten dos prónosticos: uno Estacional y otro de corto Plazo.

                                    Pronóstico Estacional.

                                    Este pronóstico se emite a finales de cada mes año calendario y cubre un periodo de 3 meses; esto es, el pronóstico para los meses de Julio, Agosto y Septiembre, se emite a finales de Junio.

                                    Pronóstico a Corto Plazo

                                    Este es un pronóstico numérico con proyección a 5 días y resolución a 8 km. Se inicializa diariamente a las 6:00 AM hora del centro. Describe la dirección de hacia dónde se desplazan las masas de humedad en el territorio nacional.
                                </div>
                                <div class="row" style="width: 100%; font-size: medium;">
                                </div>
                            </article>
                        </div>

                        <div class="col-md-4">
                            <article>

                                <div class="row" style="width: 100%;  font-size: small;">
                                    <br/>
                                    <h4>Red Nacional de Estaciones Agrometeorológicas Automatizadas</h4>
                                </div>
                                <div class="row" style="width: 100%; text-align: justify; font-size: medium;">
                                    <br/>
                                    La Red Nacional de Estaciones Agrometeorológicas Automatizadas (RNEAA), fue diseñada para proveer el servicio de monitoreo de las variables del clima. Con una distribución geográfica nacional, las estaciones están equipadas con sensores electrónicos que registran datos de: temperatura, humedad relativa, precipitación, radiación solar e intensidad y dirección del viento. Una vez sometidos a pruebas de análisis de calidad, los paquetes de datos son manejados y almacenados en el Laboratorio Nacional de Modelaje y Sensores Remotos.
                                </div>
                                <div class="row" style="width: 100%; font-size: medium;">
                                </div>
                            </article>
                        </div>

                        <div class="col-md-4">
                            <article>

                                <div class="row" style="width: 100%; font-size: small;">
                                    <br/>
                                    <h4>Aplicaciones móviles</h4>
                                </div>
                                <div class="row" style="width: 100%; text-align: justify; font-size: medium;">
                                    <br/>
                                    El desarrollo de aplicaciones para gestionar la información climática a través de dispositivos móviles abre una ventana de oportunidad para apoyar a los productores y a los tomadores de decisiones con respecto al clima. Por su interfaz sencilla y amigable, el usuario puede navegar sobre las diferentes pantallas de infomración y con base en la información meteorológica, decidir si regar o no, si realizar o no alguna práctica del cultivo, etc.
                                </div>
                                <div class="row" style="width: 100%; font-size: medium;">
                                </div>
                            </article>
                        </div>
                    </div>
                </div>

                <div class="row">
                    <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12">
                        <div class="col-md-4">
                            <article>
                                <div class="row" style="width: 100%; font-size: small;">
                                    <br/>
                                    <h4>Corroboración de desastres naturales</h4>
                                </div>
                                <div class="row" style="width: 100%; text-align: justify; font-size: medium;">
                                    <br/>
                                    Corroboración de desastres naturales
                                    El INIFAP ha sido declarado por SAGARPA autoridad técnica competente para el dictamen de ocurrencia de desastre natural. A través de los datos registrados por la RNEAA y la interpretación agronómica de la afectación ocurrida por algún evento meteorológico extremo, el INIFAP emite los dictámenes de corroboración de desastres naturales como: ciclón, granizada, inundación significativa, lluvia torrencial, helada, granizada, huracán, deslave y sequía atípica.
                                </div>
                                <div class="row" style="width: 100%; font-size: medium;">
                                    <br/>
                                 <a class="nav-link" href="../Publicaciones/CasosEstudio.aspx">continuar leyendo...</a>
                                    <br/>
                                </div>
                            </article>
                        </div>

                    </div>
                </div>
            </div>
        </div>
</div>
      <script>
          $(document).ready(function () {
              if (!window.sessionStorage.getItem("mostrarModalX")) {
                  window.sessionStorage.setItem("mostrarModalX", "no");
                  $('#myModal').modal();
              }
          })
    </script>
    <div id="myModal" class="modal fade">
        <div class="modal-dialog modal-login">
            <div class="modal-content">
                <div class="modal-header">
                    <h5 class="modal-title">PROTECCIÓN DE SU PRIVACIDAD</h5>
                    <button type="button" class="close" data-dismiss="modal" aria-hidden="true">&times;</button>
                </div>
                <div class="modal-body">
                    <p style="text-align:justify;">
                        <b>¿Qué puede esperar al visitar nuestro sitio web?</b><br />

                        En el Laboratorio Nacional de Modelaje y Sensores Remotos:<br />

                        Estamos comprometidos con la privacidad de nuestros visitantes. No recopilamos información personal sobre usted cuando visita nuestro sitio web a menos que decida proporcionarnos esa información. Así es como tratamos la información sobre su visita a http://clima.inifap.gob.mx/lnmysr: <br />  Si durante su visita no hace nada más que navegar por el sitio web, leer páginas o descargar información, recopilaremos y almacenaremos automáticamente cierta información sobre su visita. Esta información no le identifica personalmente. Recogemos y almacenamos automáticamente información como la siguiente relativa a su visita:<br />

                        El dominio de Internet (por ejemplo, "xcompany.com" si utiliza una cuenta privada de acceso a Internet, o "tuescuela.edu.mx" si se conecta desde el dominio de una universidad, o tu dependencia.gob.mx si se conecta desde un dominio del Gobierno de México);
                        Su dirección IP (una dirección IP es un número que se asigna automáticamente a su ordenador cada vez que navega por la red) desde la que accede a nuestro sitio web.
                        El tipo de navegador y el sistema operativo utilizados para acceder a nuestro sitio;
                        La fecha y hora de acceso a nuestro sitio;
                        Las páginas que visita; y
                        Si ha accedido a nuestro sitio web desde otro, la dirección de ese sitio.<br />

                        Utilizamos esta información para ayudarnos a hacer que nuestro sitio sea más útil para los visitantes: para conocer el número de visitantes de nuestro sitio y los tipos de tecnología que utilizan nuestros visitantes.<br />

                        <b>Protección de La Información</b><br />

                        Por motivos de seguridad del sitio y para garantizar que este servicio siga estando disponible para todos los usuarios, este sistema informático gubernamental emplea programas de software para supervisar el tráfico de la red con el fin de identificar intentos no autorizados de cargar o cambiar información, o de causar daños de cualquier otra forma. Si dicha monitorización revela pruebas de posibles abusos o actividades delictivas, dichas pruebas podrán ser facilitadas a los funcionarios encargados de hacer cumplir la ley. Los intentos no autorizados de cargar o modificar información en este servidor están estrictamente prohibidos y pueden ser sancionados.<br />

                        Información que usted proporciona voluntariamente<br />

                        No recopilamos información de identificación personal a menos que usted decida proporcionárnosla. Si nos proporciona información de identificación personal (por ejemplo, enviando un correo electrónico o rellenando un formulario y enviándolo a través de nuestro sitio web), utilizamos esa información únicamente para responder a su mensaje y para ayudarnos a proporcionarle la información y los servicios que solicita. El envío voluntario de información constituye su consentimiento para el uso de la información para el propósito indicado. Cuando los usuarios hacen clic en el botón "Enviar" en cualquiera de los formularios web que se encuentran en nuestro sitio, están indicando su consentimiento voluntario para el uso de la información que envían para el propósito indicado. No recopilamos ni utilizamos la información para fines comerciales.<br />

                        Cómo se utiliza la información<br />

                        La información que recopilamos se utiliza para diversos fines (por ejemplo, comentarios sobre propuestas de normas; solicitudes de datos; para responder a las solicitudes de información sobre nuestras normas y políticas). Hacemos todo lo posible para revelar claramente cómo se utiliza la información en el punto en que se recoge, de modo que nuestros usuarios puedan determinar por sí mismos si desean proporcionar la información.<br />

                        Uso compartido de su información<br />

                        Podemos compartir la información que nos proporcione con otra dependencia o entidad de la Administración Pública si su consulta está relacionada con dicha dependencia. En otras circunstancias limitadas, como las respuestas a solicitudes de información de instituto Nacional de Acceso a la Información (INAI), es posible que la ley nos obligue a revelar la información que usted envía.<br />

                        También podemos compartir la información recopilada durante su visita con entidades no federales, pero sólo si su consulta requiere acceder a datos de esa entidad externa. Todos nuestros sitios que requieran dicho acceso externo estarán claramente identificados para ayudarle a tomar una decisión informada.<br />

                        Enlaces a otros sitios<br />


                        Este sitio puede tener enlaces a los sitios web de otras dependencias federales. Puede haber enlaces a organizaciones privadas con su permiso. Una vez que vaya a un sitio distinto del nuestro, estará sujeto a las políticas de privacidad y seguridad del nuevo sitio. Siempre es una buena idea leer la política de privacidad de cualquier sitio web que visite. https://clima.inifap.gob.mx/lnmysr no controla ni garantiza la exactitud, pertinencia, actualidad o integridad de la información contenida en un sitio enlazado. Tampoco respaldamos a las organizaciones o individuos que mantienen los sitios a los que enlazamos, las opiniones que expresan o los productos/servicios que ofrecen.<br />

                        Cookies<br />

                        Las "cookies" son pequeños fragmentos de texto que se utilizan durante una sesión (cookies de sesión) o se guardan en el disco duro de un usuario para identificarlo o para obtener información sobre él la próxima vez que se conecte a un sitio web (cookies persistentes). Este sitio web no utiliza cookies persistentes ni ninguna otra tecnología de seguimiento persistente. Uno o más de nuestros sitios web componentes pueden utilizar cookies de sesión para facilitar la navegación. Estas cookies de sesión se eliminan del servidor del componente una vez finalizada su sesión, y la información que contienen no se recoge ni se guarda.<br />
                        Para mayor información contacte al Administrador: <a href="~/Principal/Directorio">Contacto.</a>
                    </p>
                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-default" data-dismiss="modal">Cerrar</button>
                </div>
            </div>
        </div>
    </div>
    </asp:Content>
