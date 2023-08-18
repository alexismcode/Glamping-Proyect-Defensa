using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glamping.Logica
{
    public abstract class Cliente
    {
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public int Celular { get; set; }



        private string? _correo;
        //private int _huespedes;
        //private string? _diaReserva;

        public string? Correo
        {
            get => _correo;
            set
            {
                ValidateCorreo(value);
                _correo = value;
            }
        }

        //public int Huespedes
        //{
        //    get => _huespedes;
        //    set
        //    {
        //        ValidateHuespedes(value);
        //        _huespedes = value;
        //    }
        //}
        //public string? DiaReserva
        //{
        //    get => _diaReserva;
        //    set => _diaReserva = ValidateDiaReserva(value?.ToUpper());
        //}

        public string? FormaPago { get; set; }

        public override string ToString()
        {
            return $"\t------------------------- INVOICE ---------------------------------\n\n" +
                   $"\t  Nombre del reservante...........: {Nombre,25} {Apellido}\n\n" +
                   $"\t  Correo..........................: {Correo,30}\n\n" +
                   $"\t  Celular.........................: {Celular,30}\n\n";
        }

        private void ValidateCorreo(string? correo)
        {
            if (correo == null || !correo.Contains("@"))
            {
                throw new ArgumentException("Correo inválido. Debe contener el símbolo '@'.");
            }
        }

        public abstract decimal GetValueToPay();
    }
}