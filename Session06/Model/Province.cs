using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session06.Model
{
    public class Province
    {
        public int Id { get; set; } 
        public string Name { get; set; }

        public int CountryId { get; set; }
        public Country Country{ get; set; }
    }
}
