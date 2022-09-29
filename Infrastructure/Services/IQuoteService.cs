public interface IQuoteService
{
  public List<Quote> GetQuotes();
  public Quote AddQuote(Quote quote);
}