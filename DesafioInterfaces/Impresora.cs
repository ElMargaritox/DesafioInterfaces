using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioInterfaces
{
    class Impresora
    {
        private List<Imprimible> ColaDeImpresion = new List<Imprimible>();


        public void ImprimirTodo()
        {
            foreach (Imprimible item in ColaDeImpresion) item.Imprimir();
        }

        public void AgregarImprimible(Imprimible unImprimible)
        {
            ColaDeImpresion.Add(unImprimible);
        }
    }
}
