using System.ComponentModel.DataAnnotations;

public class Quote
{
    public int Id { get; set; }
    [MaxLength(500), Required] 
    public string QuoteText { get; set; }
    
}