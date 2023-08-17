using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MagineCinema.Models
{
    public class Director
    {
        [Key]
        public int directorId { get; set; }
        public string profilePictureURL { get; set; }
        public string fullName { get; set; }
        public string bio { get; set; }

        //Relationship
        public List<Director_Movie> directors_Movies { get; set; }

    }
}
