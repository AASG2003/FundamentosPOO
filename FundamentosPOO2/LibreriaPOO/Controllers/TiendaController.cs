using LibreriaPOO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaPOO.Controllers
{
    public class TiendaController
    {
        public List<Motocicleta> motocicletas;

        public TiendaController()
        {
            motocicletas = new List<Motocicleta>();
            Motocicleta moto1 = new Motocicleta() { Recorrido = 8 };
            moto1.Kilometraje();
            moto1.Desgaste();
        }

        public void AgregarMotocicleta(int codMotor, int recorrido)
        {
            Motocicleta moto = new Motocicleta() { Recorrido = recorrido, CodigoMotor=123 };
            motocicletas.Add(moto);
        }
    }
}
