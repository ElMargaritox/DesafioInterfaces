using EjercicioVolador.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioVolador.Models
{
    class Pato : Animal, IVolador
    {
        private float energia;
        public void Volador()
        {
            Console.WriteLine("Estoy volando como un pato... ¡Cuak!");
        }
    }
}
