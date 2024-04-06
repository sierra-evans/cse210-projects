public class Video {
    private string title;
    private string author;
    private int length;
    private List<Comment> comments;

    public Video(string title, string author, int length)
    {
        this.title = title;
        this.author = author;
        this.length = length;
        comments = GetComments();
    }

    public int NumberOfComments()
    {
        int numberOfComments = comments.Count();
        return numberOfComments;
    }

    public void DisplayVideo(int numberOfComments)
    {
        Console.WriteLine();
        Console.WriteLine($"Title: {title}, Author: {author}, Length (in seconds): {length}, Number of Comments: {numberOfComments}");
        Console.WriteLine();
        Console.WriteLine("Comments:");
        foreach (var comment in comments)
        {
            comment.DisplayComment();
        }
    }

    public List<Comment> GetComments()
    {
        if (title == "Start")
        {
            List<Comment> comments = new List<Comment>();
            var comment1 = new Comment("Sarah", "Great work!");
            var comment2 = new Comment("Susan", "Can't wait for more!");
            var comment3 = new Comment("Sean", "Loved it!");

            comments.Add(comment1);
            comments.Add(comment2);
            comments.Add(comment3);

            return comments;
        }

        else if (title == "Middle")
        {
            List<Comment> comments = new List<Comment>();
            var comment1 = new Comment("Millie", "Loved this info!");
            var comment2 = new Comment("Megan", "Wished it was longer!");
            var comment3 = new Comment("Miles", "Will be showing this to my family!");

            comments.Add(comment1);
            comments.Add(comment2);
            comments.Add(comment3);

            return comments;
        }

        else
        {
            List<Comment> comments = new List<Comment>();
            var comment1 = new Comment("Francesca", "Needed this today!");
            var comment2 = new Comment("Fiona", "This really moved me!");
            var comment3 = new Comment("Fred", "Is it okay to share this on my story?");

            comments.Add(comment1);
            comments.Add(comment2);
            comments.Add(comment3);

            return comments;
        }
    }
}