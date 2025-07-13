using Microsoft.AspNetCore.Routing.Constraints;
using System.ComponentModel.DataAnnotations;

namespace DailyBlog.Models
{
    public class Category
    {

        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="The Category  Nmae is required")]
        [MaxLength(100, ErrorMessage =" The category name can not exceed 100 word")]
        public string Nmae { get; set; }


        public string? des { get; set; }// with "?" i dwclare it as nullable member, meaning it can be null
                                        // for this nullable should be enabbled in the project file


    }
}
