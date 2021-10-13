using EjercicioVolador.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioVolador.Models
{
    class Boing747 : Aviones, IVolador
    {
        private int horas;

        public void Volador()
        {
            Console.WriteLine("Estoy volando como un avion...");
        }
    }
}
