using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DAL
{
    public interface ILecturaDAL
    {

        List<Lectura> ObtenerLecturas();
        List<Lectura> ObtenerLecturas(Medidor m);
        Lectura Obtener(int IdLectura);
        void AgregarLectura(Lectura Lectura);
        void EliminarLectura(int IdLectura);

    }
}
