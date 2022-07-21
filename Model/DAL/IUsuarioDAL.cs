using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DAL
{
    public interface IUsuarioDAL
    {

        List<Usuario> ObtenerUsuarios();
        List<Usuario> ObtenerUsuarios(string rut);
        Usuario Obtener(int IdUsuario);
        void AgregarUsuario(Usuario usuario);
        void EliminarUsuario(int IdUsuario);

    }
}
