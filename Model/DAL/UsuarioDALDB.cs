using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DAL
{
    public class UsuarioDALDB : IUsuarioDAL
    {
        private EvacuatroEntities eva4DB = new EvacuatroEntities();
        public void AgregarUsuario(Usuario usuario)
        {
            this.eva4DB.Usuarios.Add(usuario);
            this.eva4DB.SaveChanges();
        }

        public void EliminarUsuario(int IdUsuario)
        {
            Usuario usuario = this.eva4DB.Usuarios.Find(IdUsuario);
            this.eva4DB.Usuarios.Remove(usuario);
            this.eva4DB.SaveChanges();
        }

        public Usuario Obtener(int IdUsuario)
        {
            return this.eva4DB.Usuarios.Find(IdUsuario);
        }

        public List<Usuario> ObtenerUsuarios()
        {
            return this.eva4DB.Usuarios.ToList();
        }

        public void Actualizar(Usuario u)
        {
            Usuario uOriginal = this.eva4DB.Usuarios.Find(u.IdUsuario);
            uOriginal.Nombre = u.Nombre;
            uOriginal.Rut = u.Rut;
            uOriginal.Contraseña = u.Contraseña;
            uOriginal.Correo = u.Correo;
            this.eva4DB.SaveChanges();
        }

        public List<Usuario> ObtenerUsuarios(string rut)
        {
            var query = from u in this.eva4DB.Usuarios
                        where u.Rut == rut
                        select u;
            return query.ToList();
        }
    }
}
