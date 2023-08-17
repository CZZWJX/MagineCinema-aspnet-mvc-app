using MagineCinema.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.PortableExecutable;

namespace MagineCinema.Models
{
    public class Movie
    {
        [Key]
        public int movieId { get; set; }
        public string name { get; set; }
        public string synopsis { get; set; }
        public double price { get; set; }
        public string imageURL { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public Language language { get; set; }
        public Rate rate { get; set; }
        public int movieLength { get; set; }

        public string MovieCategories { get; set; }

        public MovieStatus movieStatus { get; set; }

        //Relationships
        public List<Actor_Movie> actors_Movies { get; set; }
        public List<Director_Movie> directors_Movies { get; set; }

    }
}
