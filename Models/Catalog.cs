using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassificationSystem.Models
{
    public class Catalog
    {
        public int Id { get; set; }
        public string Goal { get; set; }
        public string Advantages { get; set; }
        public string Disadvantages { get; set; }

        public Catalog()
        {

        }
    }
}
