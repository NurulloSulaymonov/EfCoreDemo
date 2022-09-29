public class QuoteService : IQuoteService
{
    private readonly DataContext _context;

    public QuoteService(DataContext context)
    {
        _context = context;
    }
    public Quote AddQuote(Quote quote)
    {
        _context.Quotes.Add(quote);
        _context.SaveChanges();
        return quote;
    }

    public List<Quote> GetQuotes()
    {
        return _context.Quotes.ToList();
    }
}
