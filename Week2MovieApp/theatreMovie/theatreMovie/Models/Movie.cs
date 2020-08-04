using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace theatreMovie.Models
{
    public class Movie
    {
        public int Id {get; set; }
        public string Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        public string Director { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        public enum MovieLanguage
        {
            English,
            Japanese,
            Chinese
        }

        public List<Catagory> MovieCatagories { get; set; }



    }
}
