namespace ForumProject.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public Authors Author { get; set; }
    }
    public enum Authors
    {
        Bob =1,
        Hohn =2,
        Frank =3,
        Jims =4,
    }
}
