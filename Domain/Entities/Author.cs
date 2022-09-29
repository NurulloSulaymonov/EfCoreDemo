using System.ComponentModel.DataAnnotations;

public class Author
{
    public int Id { get; set; }
    [Required,MaxLength(100)]
    public string Fullname { get; set; }
}