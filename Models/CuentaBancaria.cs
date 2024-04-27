using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BancoJC.Models
{
    public class CuentaBancaria
    {
        public string Id { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        // Añade aquí las propiedades de tu cuenta bancaria
        [Required]
        public string NombreTitular { get; set; }

        [Required]
        public string TipoCuenta { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        public decimal SaldoInicial { get; set; }
    }
}