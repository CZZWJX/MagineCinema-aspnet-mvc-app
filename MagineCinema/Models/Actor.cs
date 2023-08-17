using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

namespace MagineCinema.Models
{
    public class Actor
    {
        [Key]
        public int actorId { get; set; }
        public string profilePictureURL { get; set; }
        public string fullName { get; set; }
        public string bio { get; set; }

        //Relationships
        public List<Actor_Movie> actors_Movies { get; set; }
    }
}
