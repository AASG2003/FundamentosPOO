using LibreriaPOO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaPOO.Controllers
{
    class TiendaController
    {
        public List<Motocicleta> motocicletas;

        public TiendaController()
        {
            Motocicleta moto1 = new Motocicleta() { Recorrido = 8 };
            moto1.Kilometraje();
            moto1.Desgaste();
        }
    }
}
