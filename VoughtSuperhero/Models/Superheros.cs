using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VoughtSuperhero.Models
{
    public class Superheros
    {
        public int ID { get; set; }
        [Required]

        public string HeroName { get; set; }
        [Required]
        public string AlterEgo { get; set; }
        [Required]
        public string SuperPowerOne { get; set; }
        [Required]
        public string SuperPowerTwo { get; set; }
        [Required]
        public string Publisher { get; set; }
        [Required]
        public string Catchphrase { get; set; }
    }
}
