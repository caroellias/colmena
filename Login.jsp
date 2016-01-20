<%-- 
    Document   : Login
    Created on : 6/01/2016, 07:11:57 PM
    Author     : misa9312
--%>

<%@page import="entities.Usuarios"%>
<%@page import="clientes.Auxiliar"%>
<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE html>

<html lang="es">
<head>
<meta charset="utf-8">
<!-- <link rel="stylesheet" href="css/login.css" />	
<script src="http://html5shiv.googlecode.com/svn/trunk/html5.js"></script}
 -->
<link href="css/bootstrap.css" rel="stylesheet">
<script src="//code.jquery.com/jquery-1.11.0.min.js"></script>
	<script src="main.js"></script>

	<!-- Latest compiled and minified CSS -->
	<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.2.0/css/bootstrap.min.css">

	<!-- Optional theme -->
	<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.2.0/css/bootstrap-theme.min.css">

	<link rel="stylesheet" href="main.css">


  
</head>
<title>Acceso</title>

<body background="images/maquina2.jpg">
	<script>
	// Load the SDK asynchronously
	  (function(d, s, id) {
	    var js, fjs = d.getElementsByTagName(s)[0];
	    if (d.getElementById(id)) return;
	    js = d.createElement(s) js.id = id;
	    js.src = "//connect.facebook.net/en_US/sdk.js";
	    fjs.parentNode.insertBefore(js, fjs);
	  }(document, "script", "facebook-jssdk"));
	 </script>

</body>

<style type="text/css"> 
		*{ 
    		font-size: 14px; 
		} 
		form.login 
		{ 
			background: none repeat scroll 0 0 #F1F1F1; 
			border: 1px solid #DDDDDD; 
			font-family: sans-serif; 
			margin: 0 auto; 
			padding: 20px; 
			width: 278px; 
			box-shadow:0px 0px 20px black; 
			border-radius:10px; 
		} 
		form.login div 
		{ 
			margin-bottom: 15px; 
			overflow: hidden; 
		} 
		form.login div label 
		{ 
			display: block; 
			float: left; 
			line-height: 25px; 
		} 
		form.login div input[type="text"], form.login div input[type="password"] 
		{ 
			border: 1px solid #DCDCDC; 
			float: right; 
			padding: 4px; 
		} 
		form.login div input[type="submit"] 
		{ 
			background: none repeat scroll 0 0 #DEDEDE; 
			border: 1px solid #C6C6C6; 
			float: right; 
			font-weight: bold; 
			padding: 4px 20px; 
		} 
		.error
		{ 
			color: blue; 
			font-weight: bold; 
			margin: 10px; 
			text-align: center; 
		} 
		
	</style> 
<%
    //se obtiene el valor del parametro idUsuario (formulario)
    String username = request.getParameter("idUsuario");
    String contra = request.getParameter("contra");
    
    //si el parametro regresa null o un espacio en blanco se seguirá
    //mostrando el formulario hasta que se ingrese algo en dicho parámetro.
    if(username == null || username.equals(""))
    {    
%>        
        <form action="Login.jsp" method="post" class="login" >
            <P align = "center" >Iniciar Sesi&oacuten </P>
            <Br>
            <div class="input-group">
                <span class="input-group-addon">
                    <span class="glyphicon glyphicon-user">

                    </span>               
                </span>

                <input type="text" class="form-control" name="idUsuario" placeholder="Usuario" />

            </div>

            <div class="input-group">
                <span class="input-group-addon">
                    <span class="glyphicon glyphicon-lock">

                    </span>

                </span>

                <input type="password" name="contra" class="form-control" placeholder="Contraseña" />

            </div>
                <input type="submit" name="login" value="Iniciar Sesion"  class="btn btn-sm btn-primary btn-block">
                <br>
                <a href="#" id="login" class="btn btn-primary">Login Con Facebook</a>
                <Br><Br>
                <p style="text-align:center"><a href="Registro.jsp">¿Nuevo Usuario? Registrate!</a></p>
        </form>
<%
    }
    else
    {
        Auxiliar aux = new Auxiliar();
        
        try
        {    
            //se lleva a cabo una búsqueda del username ingresado en el formulario.
            //En caso de existir el username continúa el flujo del código, de lo contrario,
            //muestra un mensaje de que el username no existe
            Usuarios usuario = aux.getUser(username);
            String password = usuario.getPassword();
            
            //se obtiene el password del usuario con el fin de saber si este coincide con el
            //contenido en la base de datos para ese username
            if(contra.equals(password))
            {
                //variables de sesion:
                session.setAttribute("username", username);
                
                //se obtiene el tipo de usuario para después redireccionar a las diferentes páginas
                //disponibles
                String tipo = usuario.getTipo();
                
                if (tipo.equals("U")) 
                {
                    response.sendRedirect("Persona/indexP.jsp");
                }
            
                if (tipo.equals("E")) 
                {
                    response.sendRedirect("Empresa/indexE.jsp");
                }
            
                if (tipo.equals("A")) 
                {
                    response.sendRedirect("Admin/indexA.jsp");             
                }
                
            }
            else
            {    
                %>
                <h2>La contrasena no es valida</h2>
                <a href="Login.jsp">Intentar de nuevo</a>
                <%
            }    
                 
        }
        catch(Exception e)
        {
%>            
            <h2>El usuario no existe</h2>
            <a href="Login.jsp">Intentar de nuevo</a>
<%                        
        }
        
        
        
%>        
<%
    }
%>
    
<html>


