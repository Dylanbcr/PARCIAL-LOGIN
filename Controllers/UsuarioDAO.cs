using Dylan_AccesoPlatanitos.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Dylan_AccesoPlatanitos.Controllers
{
    public class UsuarioDAO 
    {
        Db db = new Db("Platanitos");
        
        public Usuario Login(string email, string contrasena)
        {
            db.Sentencia("SELECT TOP 1 * FROM Usuarios WHERE Email = @Email AND Contrasena = @Contrasena");
            db.Parametro("@Email", email.Trim());
            db.Parametro("@Contrasena", contrasena);

            DataTable resultado = db.getDataTable();
            if (resultado == null || resultado.Rows.Count == 0)
                return null;

            return new Usuario(resultado.Rows[0]);

        }
        
    }
}