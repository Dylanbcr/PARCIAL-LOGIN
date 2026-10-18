using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Dylan_AccesoPlatanitos.Models
{
    public class Usuario
    {
        public int IDUsuario { get; set; }
        public string Telefono { get; set; }
        public string Pais { get; set; }
        public string TipoDocumento { get; set; }
        public string Documento { get; set; }
        public string Email { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string FechaCreacion { get; set; }
        public string Contrasena { get; set; }

        public Usuario(DataRow dr)
        {
            IDUsuario = int.Parse(dr["IDUsuario"].ToString());
            Telefono = dr["Telefono"].ToString();
            Pais = dr["Pais"].ToString();
            TipoDocumento = dr["TipoDocumento"].ToString();
            Documento = dr["Documento"].ToString();
            Email = dr["Email"].ToString();
            Nombres = dr["Nombres"].ToString();
            Apellidos = dr["Apellidos"].ToString();
            Contrasena = dr["Contrasena"].ToString();
            FechaCreacion = dr["FechaCreacion"].ToString();
        }
    }
}