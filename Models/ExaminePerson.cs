using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_DOTNET6.Models
{
    public class ExaminePerson
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //public DateTime ReleaseDate { get; set; }
        public string Oraganization { get; set; }
        public string ContactDetails { get; set; }
        //public int Rating { get; set; }
        public string Feedback { get; set; }
    }
}
