/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package clientes;

import entities.Empresa;
import entities.Usuarios;

/**
 *
 * @author misa9312
 */
public class Auxiliar 
{
    UsuariosClient ucliente = new UsuariosClient();
    EmpresasClient ecliente = new EmpresasClient();
    //método que recibe un username y regresa un objeto de tipo usuario que corresponde
    //al solicitado desde alguna otra clase
    public Usuarios getUser(String username)
    {    
        Usuarios usuario = ucliente.findByUsername(Usuarios.class, username);
        return usuario;
    }
    
    public void createUser(Usuarios usuario)
    {
        ucliente.create(usuario);
    }
    
    public Empresa getEmpresa(String id)
    {
        Empresa empresa = ecliente.find_JSON(Empresa.class, id);
        return empresa;
    }
    
    
    
}
