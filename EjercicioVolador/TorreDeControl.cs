using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioVolador
{
    class TorreDeControl
    {

        private List<IVolador> voladores = new List<IVolador>();

        
        public void vuelenTodos()
        {
            foreach (IVolador item in voladores) item.Volador();
        }


        public void agregarVolador(IVolador unVolable)
        {
            voladores.Add(unVolable);
        }
    }
}
