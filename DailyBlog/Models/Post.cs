namespace DailyBlog.Models
{
    public class Post
    {
        // declaring the features  of post method
         public int Id { get; set; }
         
         public String Title { get; set; }

         public string Content { get; set; }

         public string Author { get; set; }

        public string FeatureImagePath { get; set; }

        public  DateTime PublishedDate { get; set; }





    }
}
