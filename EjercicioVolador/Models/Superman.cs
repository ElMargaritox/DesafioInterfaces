using EjercicioVolador.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioVolador.Models
{
    class Superman : SuperHeroe, IVolador
    {
        private int experiencia;

        public void Volador()
        {
            Console.WriteLine("Estoy volando como un campeon");
        }
    }
}
