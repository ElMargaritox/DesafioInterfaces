using DesafioInterfaces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesafioInterfaces
{
    static class Program
    {
        static void Main()
        {
            Impresora impresora = new Impresora();

            Contrato contrato = new Contrato();
            Foto foto = new Foto();
            Documento documento = new Documento();


            impresora.AgregarImprimible(contrato);
            impresora.AgregarImprimible(foto);
            impresora.AgregarImprimible(documento);

            impresora.ImprimirTodo();

        }
    }
}
