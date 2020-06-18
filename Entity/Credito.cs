using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Credito
    {
        public int NumeroCredito { get; set; }
        public decimal ValorCredito { get; set; }
        public decimal TasaInteres { get; set; }
        public DateTime FechaInicial { get; set; }
        public DateTime FechaFinal { get; set; }
        public int NumeroCuotas { get; set; }
        public decimal ValorCuota { get; set; }
        public int CuotasPagadas { get; set; }
        public Cliente Cliente { get; set; }
        

        public void AgregarCliente(Cliente cliente)
        {
            Cliente = cliente;
        }

        private decimal CalcularTasaInteres()
        {
            //0.05 porque es la tasa inicial
            TasaInteres = 0.05m;
            for (int i = 1; i < NumeroCuotas; i++)
            {
                //aumento dependiendo el numero de cuotas
                TasaInteres += 0.02m;  
            }
            return TasaInteres;
        }

        private decimal CalcularValorCuota()
        {
           return ValorCuota = ((ValorCredito * TasaInteres)+ValorCredito) / NumeroCuotas;
        }

        public void CalcularCredito()
        {
            CalcularTasaInteres();
            CalcularValorCuota();
        }

    }
}
