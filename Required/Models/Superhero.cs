using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Required.Models
{
    public class Superhero
    {
        [Key]
        public int Id { get; set; }

        public string SuperheroName { get; set; }
        public string AlterEgo { get; set; }
        public string SuperpowerOne { get; set; }
        public string SuperpowerTwo { get; set; }
        public string CatchPhrase { get; set; }
    }
}
