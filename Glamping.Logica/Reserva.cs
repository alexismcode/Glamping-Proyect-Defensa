using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glamping.Logica
{
    public class Reserva : Cliente
    {
        public string? _diaReserva;
        public int Adultos { get; set; }
        public int Niños { get; set; }
        public decimal _precioAdulto;
        public decimal _precioNiño;
        public int _dias;
        public int Habitaciones { get; set; }

        public Reserva()
        {
            _precioAdulto = 50;
            _precioNiño = 25;
        }

        public string? Dia
        {
            get => _diaReserva;
            set => _diaReserva = ValidateDia(value?.ToUpper());
        }

        public int Dias
        {
            get => _dias;
            set => _dias = ValidateDias(value);
        }

        public override decimal GetValueToPay()
        {
            ValidateDias(Dias);
            ValidateFormaPago(FormaPago);
            return ((decimal)Dias * _precioAdulto * Adultos) + ((decimal)Dias * _precioNiño * Niños);
        }


        public override string ToString()
        {
            var CHues = Niños + Adultos;
            return $"{base.ToString()}\n" +
                $"\t  Dia de reserva..................:{Dia,30:C2}\n\n" +
                $"\t  Forma de Pago...................:{FormaPago,30}\n\n" +
                $"\t  Niños...........................:{Adultos,30}\n\n" +
                $"\t  Adultos.........................:{Niños,30}\n\n" +
                $"\t  Total Huespedes.................:{CHues,30}\n\n" +
                $"\t  Número de habitaciones..........:{Habitaciones,30}\n\n" +
                $"\t  Valor de la Reserva.............:{GetValueToPay(),30:C2}\n\n";
        }

        private int ValidateDias(int value)
        {
            if (value < 2)
            {
                throw new ArgumentException("Lo sentimos, minimo son 2 días");
            }
            else if (value > 4)
            {
                throw new ArgumentException("Lo sentimos, solo un máximo de 4 días");
            }
            return value;
        }

        private string? ValidateDia(string? value)
        {
            if (value == "JUEVES" || value == "VIERNES" || value == "SABADO" || value == "DOMINGO")

            {
                return value;

            }
            throw new ArgumentException("Día no inválido. Los días permitidos son Jueves, viernes, sabado y domingo.");
        }

        private void ValidateFormaPago(string? formaPago)
        {
            formaPago = formaPago?.ToUpper();
            if (formaPago != "EFECTIVO" && formaPago != "TRANSFERENCIA" && formaPago != "TARJETA DE CREDITO")
                throw new ArgumentException("Forma de pago no válida.");
        }
    }
}