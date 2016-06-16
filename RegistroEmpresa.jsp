<%@page import="entities.Bancos"%>
<%@page import="clientes.BancosClient"%>
<%@page import="clientes.Auxiliar"%>
<%@page import="entities.Usuarios"%>
<%@page import="entities.Empresa"%>
<%@page import="clientes.EmpresaClient"%>
<%@page import="java.util.Date"%>
<html lang="es">
<head>
    <meta charset="utf-8">
    <title>Acceso</title>
    <meta name="description" content="">
    <meta name="viewport" content="width=device-width" />
    <!-- <link rel="stylesheet" href="css/login.css" /> 
    <script src="http://html5shiv.googlecode.com/svn/trunk/html5.js"></script}
     -->
    <link rel="stylesheet" href="css/bootstrap.min.css">
    <link rel="stylesheet" href="css/font-awesome.css">
    <link rel="stylesheet" href="css/flaticon.css">
    <link rel="stylesheet" href="css/animate.css">
    <link rel="stylesheet" href="css/templatemo_misc.css">
    <link rel="stylesheet" href="css/templatemo_style.css">
    <link href="css/bootstrap.css" rel="stylesheet">
    <script src="//code.jquery.com/jquery-1.11.0.min.js"></script>
    <script src="main.js"></script>

    <!-- Latest compiled and minified CSS -->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.2.0/css/bootstrap.min.css">

    <!-- Optional theme -->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.2.0/css/bootstrap-theme.min.css">
    <link rel="stylesheet" href="main.css">
</head>

<style type="text/css"> 
        *{ 
            font-size: 14px; 
        } 
        form.login 
        { 
            position: relative;
            top: -20px;
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

<body background="images/maquina2.jpg">
    
    <%
    String username = request.getParameter("idUsuario");
    if(username == null || username.equals(""))
    {
        
    %>

<form action='RegistroEmpresa.jsp' method='post' class='login'>
    <h4 align = 'center' >Registro</h4>
    <Br>
    <div class='input-group'>
        <span class='input-group-addon'><span class='fa fa-user'></span></span>
        <input type='text' class='form-control' name='idUsuario' placeholder='Usuario' />
    </div>

    <div class='input-group'>
        <span class='input-group-addon'><span class='fa fa-user'></span></span> 
        <input type='text' class='form-control' name='empresa' placeholder='Nombre de la Empresa' />
    </div>
    
    <div class='input-group'>
        <span class='input-group-addon'><span class='fa fa-user'></span></span>
        <input type='text' class='form-control' name='nombre' placeholder='Nombre del encargado' />
    </div>

    <div class='input-group'>
        <span class='input-group-addon'><span class='fa fa-chevron-right'></span></span>
        <input type='text' class='form-control' name='apellido' placeholder='Apellidos' />
    </div>
    
    <div class='input-group'>
        <span class='input-group-addon'><span class='glyphicon glyphicon-lock'></span></span>
        <input type='password' name='contra' class='form-control' placeholder='Password' />
    </div>

    <div class="input-group">
        <span class="input-group-addon"><span class="glyphicon glyphicon-envelope"></span></span>
        <input name="email" type="text" id="email" class="form-control" placeholder="Email" />
    </div>

    <div class="input-group">
        <span class="input-group-addon"><span class="fa fa-photo"></span></span>
        <input name="foto" type="text" id="email" class="form-control" placeholder="Foto" />
    </div>


    <input type="submit" name="Submit" value="Registrarse"  class="btn btn-sm btn-primary btn-block">
</form>
<%
    }
    else
    {
        Date date = new Date();
        
        try
        {
            Auxiliar aux = new Auxiliar();
            Usuarios usuario = new Usuarios();
            Empresa empresa = new Empresa();
            
            //Datos de la empresa
            
            empresa.setNombreEmp(request.getParameter("empresa"));
            empresa.setEmail(request.getParameter("email"));
            empresa.setPassword(request.getParameter("contra"));
            empresa.setFoto(request.getParameter("foto"));
            empresa.setFecha(date);
            aux.createEmpresa(empresa);
            
            //Datos del usuario (que tambien es una empresa)
            usuario.setIdEmpresa(aux.getEmpresa("1"));
            usuario.setUsername(request.getParameter("idUsuario"));
            usuario.setNombre(request.getParameter("nombre"));
            usuario.setApellido(request.getParameter("apellido"));
            usuario.setPassword(request.getParameter("contra"));
            usuario.setEmail(request.getParameter("email"));
            usuario.setTipo("E");
            usuario.setFoto(request.getParameter("foto"));
            usuario.setFecha(date);
            aux.createUser(usuario);
                    
            
            %>
            <h2>Usuario registrado con exito</h2>
            <%
        }
        catch(Exception e)
        {
            %>
            <h2><%= e %></h2>
            <%
        } 
    }
%>
</body>
</html>                                   