using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCModelBinding.Models
{
    public class Movie
    {
        [Display(Name = "Movie Title")]
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Movie title is required.")]
        public string Title { get; set; }

        [Display(Name = "Year Released")]
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Movie year is required.")]
        public string ReleaseYear { get; set; }

        [Display(Name = "Genre")]
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Genre is required")]
        public string Genre { get; set; }

        [Display(Name = "Rating")]
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Movie rating is required")]
        public string Rating { get; set; }

        /// <summary>
        /// Movie length in minutes.
        /// </summary>
        [Display(Name = "Movie Length")]
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Length is required.")]
        public string Length { get; set; }

    }
}
