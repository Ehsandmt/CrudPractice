namespace CrudPractice.Entities;

public class Author
{
    [Required]
    public Guid Id { get; set; }

    [Required]
    [MaxLength(256)]
    public string? Name { get; set; }

    [MaxLength(40)]
    public string? OrcId { get; set; }

    [MaxLength(256)]
    public string? About { get; set; }
}