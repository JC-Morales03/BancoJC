using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BancoJC.Models
{
    public class CuentaBancaria
    {
        public int Id { get; set; }
        public string NombreTitular { get; set; }
        public string TipoCuenta { get; set; } 
        public decimal SaldoInicial { get; set; }
        public string Email { get; set; }
    }
}