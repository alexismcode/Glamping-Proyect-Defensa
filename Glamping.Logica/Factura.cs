using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glamping.Logica
{
    public class Factura : Reserva
    {
        public override string ToString()
        {
            decimal valorTotal = GetValueToPay();
            decimal impuestoConsumo = valorTotal * 0.12m;
            decimal impuestoServicio = valorTotal * 0.10m;
            decimal valorConImpuestos = valorTotal + impuestoConsumo + impuestoServicio;

            return $"{base.ToString()}\n" +
                $"\t  Impuesto por dervicio...........: {impuestoServicio,30:C2}\n\n" +
                $"\t  Valor Total a pagar (con IVA)...: {valorConImpuestos,30:C2}\n\n" +
                $"\t\t   >> RESERVACIÓN REALIZADA CON ÉXITO <<\n\n" +
                $"\t---------------------------------------------------------------------------\n\n";
        }
    }
}