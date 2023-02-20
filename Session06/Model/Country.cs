using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session06.Model
{
    //POCO
    //Entity
    public class Country
    {
        //EF Convention
        //Id, <Entity>Id = CountryId -> primray key
        public int Id { get; set; }

        //Attribute C#? // Reflection
        [MaxLength(50)]
        public string Name { get; set; } // type: nvarchar(MAX)
    }
}
