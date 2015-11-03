package org.realmanual.rest.example.resources;

import javax.ws.rs.GET;
import javax.ws.rs.Path;
import javax.ws.rs.Produces;
import javax.ws.rs.core.MediaType;

//se indica con que ruta será accesado a este recurso
@Path("/messages")
public class MessagesResource 
{

	//se indica el método http con el que se accede a este recurso
	@GET
	//se indica el formato en que será mostrada la respuesta
	@Produces(MediaType.TEXT_PLAIN)
	public String getMessages()
	{
		return "Hello World!";
	}
	
}
