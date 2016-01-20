
<!DOCTYPE html>
<!--[if lt IE 7]>      <html class="no-js lt-ie9 lt-ie8 lt-ie7"> <![endif]-->
<!--[if IE 7]>         <html class="no-js lt-ie9 lt-ie8"> <![endif]-->
<!--[if IE 8]>         <html class="no-js lt-ie9"> <![endif]-->
<!--[if gt IE 8]><!--> <html class="no-js"> <!--<![endif]-->

    <head>
        <meta charset="utf-8">
        <title>Virtual Solutions</title>
          <meta name="description" content="">
        <meta name="viewport" content="width=device-width">
<!-- 
Flex Template 
http://www.templatemo.com/tm-406-flex
-->
        
        <link href='http://fonts.googleapis.com/css?family=Open+Sans:400,300,600,700,800' rel='stylesheet' type='text/css'>
        
        <link rel="stylesheet" href="css/bootstrap.min.css">
        <link rel="stylesheet" href="css/font-awesome.css">
        <link rel="stylesheet" href="css/animate.css">
        <link rel="stylesheet" href="css/templatemo_misc.css">
        <link rel="stylesheet" href="css/templatemo_style.css">

        <script src="js/vendor/modernizr-2.6.1-respond-1.1.0.min.js"></script>
        
        
</head>
    <body>
        <!--[if lt IE 7]>
            <p class="chromeframe">You are using an outdated browser. <a href="http://browsehappy.com/">Upgrade your browser today</a> or <a href="http://www.google.com/chromeframe/?redirect=true">install Google Chrome Frame</a> to better experience this site.</p>
        <![endif]-->
 <!-- Modal -->
  <%
   
   if(session.getAttribute("username") == null || session.getAttribute("username") == "")
   {
       %>
       <center>
      <p>Para operar el sistema debe iniciar sesion</p>
      <br>
      <a href="../Login.jsp">Iniciar sesion</a>
      </center>
        <%
   }
   else
   {
       String usuario = session.getAttribute("username").toString();
       %>
       <div align=right>
           <p>Usuario:   <%= usuario %></p>
        </div>
                                    
        <div class="site-main" id="sTop">
            <div class="site-header">
                <div class="container">
                    <div class="row">
                        <div class="col-md-12 text-center">
                            <ul class="social-icons">
                                <li><a href="#" class="fa fa-facebook"></a></li>
                                <li><a href="#" class="fa fa-twitter"></a></li>
                                <li><a href="#" class="fa fa-dribbble"></a></li>
                                <li><a href="#" class="fa fa-linkedin"></a></li>
                            </ul>
                        </div> <!-- /.col-md-12 -->
                    </div> <!-- /.row -->
                </div> <!-- /.container -->
                <div class="main-header">
                    <div class="container">
                        <div id="menu-wrapper">
                            <div class="row">
                                <div class="logo-wrapper col-md-2 col-sm-2">
                                   <img src="images/virtualsol.png">
                                </div> <!-- /.logo-wrapper -->
                                <div class="col-md-10 col-sm-10 main-menu text-right">
                                    <div class="toggle-menu visible-sm visible-xs"><i class="fa fa-bars"></i></div>
                                    <ul class="menu-first">
                                        <li class="active"><a href="indexP.php">Inicio</a></li>
                                        <li><a href="#services">Conocenos</a></li>
                                        <li><a href="#portfolio">Cursos</a></li>
                                        <!--  <li><a href="http://www.facebook.com/templatemo" class="external" target="_parent">External</a></li>--> 
                                        <li><a href="#contact">Contactanos</a></li>
                                        <li class="last"><a href="cerrarSesion.jsp">Cerrar Sesion</a></li>
                                       <!--  <li><a  href="" data-toggle="modal" data-target="#myModal">Cerrar Sesion</a></li> -->
                                    </ul>                                    
                                </div> <!-- /.main-menu -->
                            </div> <!-- /.row -->
                        </div> <!-- /#menu-wrapper -->                        
                    </div> <!-- /.container -->
                </div> <!-- /.main-header -->
            </div> <!-- /.site-header -->

            <div class="site-slider">
                <div class="slider">
                    <div class="flexslider">
                        <ul class="slides">
                            <li>
                                <div class="overlay"></div>
                                <img src="images/maquina1.jpg" alt="">
                                <div class="slider-caption visible-md visible-lg">
                                    <h2>4D Virtual Suite is here</h2>
                                </div>
                            </li>

                            <li>
                                <div class="overlay"></div>
                                <img src="images/maquina2.jpg" alt="">
                                <div class="slider-caption visible-md visible-lg">
                                    <h2>4D Virtual Suite is here</h2>
                                </div>
                            </li>

                            <li>
                                <div class="overlay"></div>
                                <img src="images/maquina3.jpg" alt="">
                                <div class="slider-caption visible-md visible-lg">
                                    <h2>4D Virtual Suite is here</h2>
                                </div>
                            </li>
                        </ul>
                    </div> <!-- /.flexslider -->
                </div> <!-- /.slider -->
            </div> <!-- /.site-slider -->
        </div> <!-- /.site-main -->

<!---//////////////////////////////////////////////////////////////////////////////////////////////////////////// -->               
    
  <style type="text/css">
  .fotos img 
  {
    margin: 0px 300px;
    border: 1px solid #ccc;
    border-radius: 10px 10px 10px 10px;
  }
  .datos 
  {
    top: -190px;
    width: 400px;
    margin: 0 540px;
    position: relative;
    font-size: 20px;
  }
  .misCursos
  {
    font-size: 18px;
    margin: 0 205px;
    border: 1px solid #ccc;
    border-radius: 10px 10px 10px 10px;
    width: 400px;
    height: 300px;
  }
  .misCursosBotones a
  {
    border: 2px solid #ccc;
    border-radius: 10px 10px 10px 10px;
    top: -230px;
    position: relative;
    width: 180px;
    font-size: 10px;
    padding: 8px;
    font-weight: bold;
    background: #e67e22;
    color: #FFFFFF;
    top: -200px;
    margin: 0 400px;
    height: 300px; 
  }
 
  .masCursos
  {
    position: relative;
    top: -850px;
    font-size: 18px;
    margin: 0 300px 
  }
  .estrellas
  {
    top: 5px;
    position: relative;
    margin: 0 10px;
     
  }
  .estrellas1
  {
    top: -115px;
    position: relative;
    margin: 0 10px;
     
  }
  .estrellas2
  {
    top: -238px;
    position: relative;
    margin: 0 10px;
     
  }
  .estrellas3
  {
    top: -355px;
    position: relative;
    margin: 0 10px;
     
  }

  .estrella1
  {
    margin: 0 850px;
    position: relative;
    top: -480px;
  }
  .estrella2
  {
    margin: 0 900px;
    position: relative;
    top: -512px;
  }
  .estrella3
  {
    margin: 0 950px;
    position: relative;
    top: -544px;
  }
  .estrella4
  {
    margin: 0 1000px;
    position: relative;
    top: -576px;
  }
  .estrella5
  {
    margin: 0 1050px;
    position: relative;
    top: -608px;
  }
  .logros
  {
    margin: 0 750px;
    position: relative;
    top: -350px;
  }
  .super
  {
    position: relative;
    top: 90px;
  }
  article
  {

    margin: 0 230px;

  }
  article section
  {
    font-size: 18px;
    line-height: 40px;
  
  }
  header h1
  {
    font-size: 18px;
    font-weight: 700;
  }
  aside section a
  {
    position: relative;
    top: -160px;
    margin: 0 600px;
    border: 2px solid #ccc;
    border-radius: 10px 10px 10px 10px;
    font-size: 10px;
    padding: 8px;
    font-weight: bold;
    background: #e67e22;
    color: #FFFFFF;
    line-height: 40px;
  
     
  } 
  .calCurso
  {
    font-size: 18px;
    margin: 0 900px;
    position: relative;
    top: -350px;
    width: 200px;
  }
  
  </style> 
<!--//////////////////////////////////////////////////////////////////////////////////////////////////////// -->
        <div class="fotos">
           <img src="images/imagen.jpg" height="200" width="180">
        </div>

        <?php
           $usuario = $_SESSION['usuarios'];

        
           $sql = "select IdUsuario from usuario where nombre = '$usuario'";
           $resultado = mysql_query($sql,$conexion);
           $myrow=mysql_fetch_array($resultado);

           $idUsuario = $myrow[0];
           
           $resultados=mysql_query("SELECT IdUsuario, nombre, contrasena, edad, correo, foto, tipo FROM usuario WHERE IdUsuario = $idUsuario",$conexion);

            while ($myrow=mysql_fetch_array($resultados)) 
            { 
              echo "<div class='datos'>";
              echo "<tr>";
              echo "<td><p>Nombre: $myrow[1]</p></td><td><p>Edad: $myrow[3]</p></td><td><p>Correo: $myrow[4]</p></td>";
              echo "<a href=''><u>Modificar Perfil</u></a>";
              echo "</tr>";
              echo "</div>";
            } 
             mysql_close($conexion);
       ?>
        <br><br>
        <div class="content-section" id="services">
            <div class="container">
                <div class="row">
                    <div class="heading-section col-md-12 text-center">
                        <h2>Conocenos</h2>
                        <p>Permitenos Entrenarte</p>
                    </div> <!-- /.heading-section -->
                </div> <!-- /.row -->
                
                <div class="centrado">
                    <div class="col-md-3 col-sm-6">
                        <div class="service-item" id="service-1">
                            <div class="service-icon">
                                <img src="images/prueba.png"> 
                           </div> <!-- /.service-icon -->
                            <div class="service-content">
                                <div class="inner-service">
                                   <h3>Aprende las bases de cualquier maquinaria</h3>
                                </div>
                            </div> <!-- /.service-content -->
                        </div> <!-- /#service-1 -->
                    </div> <!-- /.col-md-3 -->
                    <div class="col-md-3 col-sm-6">
                        <div class="service-item" id="service-2">
                            <div class="service-icon">
                                <img src="images/progreso.png">
                            </div> <!-- /.service-icon -->
                            <div class="service-content">
                                <div class="inner-service">
                                   <h3>Conoce Tus Progresos</h3>
                                </div>
                            </div> <!-- /.service-content -->
                        </div> <!-- /#service-1 -->
                    </div> <!-- /.col-md-3 -->
                    <div class="col-md-3 col-sm-6">
                        <div class="service-item" id="service-3">
                            <div class="service-icon">
                                <img src="images/linkedin.png">
                            </div> <!-- /.service-icon -->
                            <div class="service-content">
                                <div class="inner-service">
                                   <h3>Compartelo En Linkeding</h3>
                                 </div>
                            </div> <!-- /.service-content -->
                        </div> <!-- /#service-1 -->
                    </div> <!-- /.col-md-3 -->
                </div> <!-- /.row -->
            </div> <!-- /.container -->
        </div> <!-- /#services -->

        <div class="content-section" id="portfolio">
          <div class="container">
            <div class="row">
              <div class="heading-section col-md-12 text-center">
                <h2>Cursos</h2>
              </div> <!-- /.heading-section -->
            </div> <!-- /.row -->
          </div> <!-- /container -->     
        </div> <!-- / -->

        <section>
          <article>
            <header>
              <h1><u>Mis Cursos</u></h1>
            </header>
                
            <section>Curso Virtual De Minicargadores</section>
            <section>Curso Virtual De Retroexcavadoras</section>
            <section>Curso Virtual De Cargador De Rueda</section>
            <section>Curso Virtual De Motoniveladoras</section>
          </article>
        </section>
        
        <aside>
          <section><a href=""><u>Certificado</u></a></section>
          <section><a href="#"><u>Ver Progreso</u></a></section>
          <section><a href="#"><u>Ver Progreso</u></a></section>
          <section><a href="#"><u>Ver Progreso</u></a></section>
        </aside>
        
        <div class="calCurso">
            <p><u><B>Califica Tu Curso</B></u></p>
        </div>

        <div class="logros">
            <img src="images/certificado3.png">
        </div>

        <div class="super">
            <div class="estrellas">
                <div class="estrella1">
                    <img src="images/estrella3.png">
                </div>
                <div class="estrella2">
                    <img src="images/estrella3.png">
                </div>
                <div class="estrella3">
                    <img src="images/estrella3.png">
                </div>
                <div class="estrella4">
                    <img src="images/estrella3.png">
                </div>
                <div class="estrella5">
                    <img src="images/estrella3.png">
                </div>
           </div>

           <div class="estrellas1">
                <div class="estrella1">
                    <img src="images/estrella3.png">
                </div>
                <div class="estrella2">
                    <img src="images/estrella3.png">
                </div>
                <div class="estrella3">
                    <img src="images/estrella3.png">
                </div>
                <div class="estrella4">
                    <img src="images/estrella3.png">
                </div>
                <div class="estrella5">
                    <img src="images/estrella3.png">
                </div>
           </div>

           <div class="estrellas2">
                <div class="estrella1">
                    <img src="images/estrella3.png">
                </div>
                <div class="estrella2">
                    <img src="images/estrella3.png">
                </div>
                <div class="estrella3">
                    <img src="images/estrella3.png">
                </div>
                <div class="estrella4">
                    <img src="images/estrella3.png">
                </div>
                <div class="estrella5">
                    <img src="images/estrella3.png">
                </div>
           </div>

            <div class="estrellas3">
                <div class="estrella1">
                    <img src="images/estrella3.png">
                </div>
                <div class="estrella2">
                    <img src="images/estrella3.png">
                </div>
                <div class="estrella3">
                    <img src="images/estrella3.png">
                </div>
                <div class="estrella4">
                    <img src="images/estrella3.png">
                </div>
                <div class="estrella5">
                    <img src="images/estrella3.png">
                </div>
           </div>
        </div>

        <div class="masCursos">
            <a href=""><u>Ver MÃ¡s Cursos</u></a>
        </div>
    

        <div class="content-section" id="contact">
            <div class="container">
                <div class="row">
                    <div class="heading-section col-md-12 text-center">
                      <h2>Contactanos</h2>
                    </div> <!-- /.heading-section -->
                </div> <!-- /.row -->
                <div class="row">
                    <div class="col-md-12">
                       <div class="googlemap-wrapper">
                            <div id="map_canvas" class="map-canvas"></div>
                        </div> <!-- /.googlemap-wrapper -->
                    </div> <!-- /.col-md-12 -->
                </div> <!-- /.row -->

                <div class="row">
                    <div class="col-md-7 col-sm-6">
                        <ul class="contact-info">
                            <li>TelÃ©fono: 010-080-0180</li>
                            <li>Correo ElectrÃ³nico: <a href="mailto:info@company.com">info@company.com</a></li>
                            <li>DirecciÃ³n: Zapopan.Jalisco</li>
                        </ul>
                        <!-- spacing for mobile viewing --><br><br>
                    </div> <!-- /.col-md-7 -->
                    <div class="col-md-5 col-sm-6">
                        <div class="contact-form">
                            <form method="post" name="contactform" id="contactform">
                                <p>
                                    <input name="name" type="text" id="name" placeholder="Nombre">
                                </p>
                                <p>
                                    <input name="email" type="text" id="email" placeholder="Correo ElectrÃ³nico"> 
                                </p>
                                <p>
                                    <input name="subject" type="text" id="subject" placeholder="Asunto"> 
                                </p>
                                <p>
                                    <textarea name="comments" id="comments" placeholder="Mensaje"></textarea>    
                                </p>
                                <input type="submit" class="mainBtn" id="submit" value="Enviar Mensaje">
                            </form>
                        </div> <!-- /.contact-form -->
                    </div> <!-- /.col-md-5 -->
                </div> <!-- /.row -->
            </div> <!-- /.container -->
        </div> <!-- /#contact -->
               
       <div id="footer">
            <div class="container">
                <div class="row">
                    <div class="col-md-8 col-xs-12 text-left">
                        <span>Copyright &copy; 2015 Virtual Solutions 
                        - DiseÃ±ado por <a rel="nofollow" href="http://www.templatemo.com/tm-406-flex" target="_parent">Virtual Solutions</a></span>
                  </div> <!-- /.text-center -->
                    <div class="col-md-4 hidden-xs text-right">
                        <a href="#top" id="go-top">Volver a Inicio</a>
                    </div> <!-- /.text-center -->
                </div> <!-- /.row -->
            </div> <!-- /.container -->
        </div> <!-- /#footer -->
        
        <script src="js/vendor/jquery-1.11.0.min.js"></script>
        <script>window.jQuery || document.write('<script src="js/vendor/jquery-1.11.0.min.js"><\/script>')</script>
        <script src="js/bootstrap.js"></script>
        <script src="js/plugins.js"></script>
        <script src="js/main.js"></script>

        <!-- Google Map -->
        <script src="http://maps.google.com/maps/api/js?sensor=true"></script>
        <script src="js/vendor/jquery.gmap3.min.js"></script>
        
        <!-- Google Map Init-->
        <script type="text/javascript">
            jQuery(function($){
                $('#map_canvas').gmap3({
                    marker:{
                        address: '20.6634835,-103.3867743,19' 
                    },
                        map:{
                        options:{
                        zoom: 15,
                        scrollwheel: false,
                        streetViewControl : true
                        }
                    }
                });
            });
        </script>
        <!-- templatemo 406 flex -->
    </body>
</html>
<%
}
%>
