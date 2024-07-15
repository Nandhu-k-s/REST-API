public class Blog
{
    public int Id { get; set; }
    public int UUID { get; set; }
    public string? Slug { get; set; } // Nullable string
    public string? Name { get; set; } // Nullable string
    public string? Description { get; set; } // Nullable string
    public string? Image_url { get; set; } // Nullable string
    public bool Is_Active { get; set; }
    public DateTime Created { get; set; }
    public DateTime? Updated { get; set; } // Nullable DateTime
}