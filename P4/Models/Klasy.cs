using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using P4.Atrybuty;

namespace P4.Models
{
    public class waluty
    {
        public int ID { set; get; }
        [Required]
        [Symbol(ErrorMessage =" Niewłaściwy symbol waluty")]
        public string Base { set; get; }
        [Required]
        [Symbol(ErrorMessage = " Niewłaściwy symbol waluty")]
        public string Symbol { set; get; }
        public decimal wartosc { set; get; }
        public DateTime dataPobrania { set; get; }
    }
    public class walutesy_operacje
    {
        public string Base { set; get; }
        public Dictionary<string, decimal> rates { set; get; }
    }
}
