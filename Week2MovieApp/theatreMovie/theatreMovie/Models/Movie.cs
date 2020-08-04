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

        public string Language { get; set; }


        [ForeignKey("Id")]
        public int CategoryId { get; set; }



    }
}
