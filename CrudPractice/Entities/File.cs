namespace CrudPractice.Entities;

public class File
{
    [Required]
    public Guid Id { get; set; }

    [Required]
    public string? Name { get; set; } 
    public string? Format { get; set; } //pdf, etc ...  

    [Required]
    public byte[]? Content { get; set; }
}