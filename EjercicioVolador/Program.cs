using EjercicioVolador.Abstracts;
using EjercicioVolador.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioVolador
{
    class Program
    {
        static void Main(string[] args)
        {

            Animal pato = new Pato();
            Aviones boing747 = new Boing747();
            SuperHeroe superman = new Superman();
            TorreDeControl torreDeControl = new TorreDeControl();

            torreDeControl.agregarVolador((IVolador)pato);
            torreDeControl.agregarVolador((IVolador)boing747);
            torreDeControl.agregarVolador((IVolador)superman);
            torreDeControl.vuelenTodos();
            
        }
    }
}
