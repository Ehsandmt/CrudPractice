namespace CrudPractice.Entities;

public class Article
{
    [Required]
    public Guid Id{get; set;}   
    
    [Required]
    [MaxLength(256)]
    public string? Subject { get; set; }

    [MaxLength(2048)]
    public string? Abstract { get; set; }

    public DateOnly ReleaseDate { get; set; }

    public File[]? Contents { get; set; }

    public string[]? Authors { get; set; }

    public string[]? References { get; set; }
}
