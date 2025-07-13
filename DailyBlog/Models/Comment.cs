using System.ComponentModel.DataAnnotations;

namespace DailyBlog.Models
{
    public class Comment
    {


        [Key] 
        public int Id { get; set; }



        [Required(ErrorMessage = "The   UserNmae is required")]
        [MaxLength(100, ErrorMessage = " The UserName can not exceed 100 word")]

        public string UserName { get; set; }



        [DataType(DataType.Date)]
        public DateTime CommentDate { get; set; }

        [Required]
        public string Content { get; set; }
    }
}
