using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Superheros.Models
{
    public class HeroModel
    {
        [Key]
        public int Id { get; set; }
        public string HeroName { get; set; }
        public string AlterEgo { get; set; }
        public string PrimaryAbility { get; set; }
        public string SecondaryAbility { get; set; }
        public string Catchphrase { get; set; }
    }
}

