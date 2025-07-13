using System.ComponentModel.DataAnnotations;

namespace DailyBlog.Models
{
    public class Post
    {
        //step1: declaring the properties  of post method
        //step2: Now we will add some attributes to these properties

        [Key]
        public int Id { get; set; }



        [Required(ErrorMessage = "The Title is Required")]
        [MaxLength (400, ErrorMessage = "The title can not exceed 400 character")]
         public String Title { get; set; }




        [Required(ErrorMessage = "The Content is Required")]
        public string Content { get; set; }




        [Required(ErrorMessage = "The Author is Required")]
        [MaxLength(100, ErrorMessage = "Author name cannot exceed 100 character")]
        public string Author { get; set; }



        public string FeatureImagePath { get; set; }



        [DataType(DataType.Date)] //only for showing Date not Time

        public  DateTime PublishedDate { get; set; } = DateTime.
            Now;





    }
}
