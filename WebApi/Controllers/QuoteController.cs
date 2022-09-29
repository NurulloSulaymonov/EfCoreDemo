using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class QuoteController : ControllerBase
{
    private readonly IQuoteService _quoteService;

    public QuoteController(IQuoteService quoteService)
    {
        _quoteService = quoteService;
    }

    [HttpGet]
    public List<Quote> GetQuotes()
    {
        return _quoteService.GetQuotes();
    }


     [HttpPost]
    public Quote AddQuotes(Quote quote)
    {
        return _quoteService.AddQuote(quote);
    }
}