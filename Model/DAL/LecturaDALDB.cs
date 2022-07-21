using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DAL
{
    public class LecturaDALDB : ILecturaDAL
    {
        private EvacuatroEntities eva4DB = new EvacuatroEntities();
        public void AgregarLectura(Lectura Lectura)
        {
            this.eva4DB.Lecturas.Add(Lectura);
            this.eva4DB.SaveChanges();
        }

        public void EliminarLectura(int IdLectura)
        {
            Lectura lectura = this.eva4DB.Lecturas.Find(IdLectura);
            this.eva4DB.Lecturas.Remove(lectura);
            this.eva4DB.SaveChanges();
        }

        public Lectura Obtener(int IdLectura)
        {
            return this.eva4DB.Lecturas.Find(IdLectura);
        }

        public List<Lectura> ObtenerLecturas()
        {
            return this.eva4DB.Lecturas.ToList();
        }

        public void Actualizar(Lectura l)
        {
            Lectura lOriginal = this.eva4DB.Lecturas.Find(l.IdLectura);
            lOriginal.Medidor = l.Medidor;
            lOriginal.Usuario = l.Usuario;
            lOriginal.Consumo = l.Consumo;
            lOriginal.FechaLectura = l.FechaLectura;
            this.eva4DB.SaveChanges();
        }

        public List<Lectura> ObtenerLecturas(Medidor m)
        {
            var query = from a in this.eva4DB.Lecturas
                        where a.Medidor == m
                        select a;
            return query.ToList();
        }
    }
}
