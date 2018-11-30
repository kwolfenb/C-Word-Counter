using Microsoft.AspNetCore.Mvc;

namespace WordCounter.Controllers
{
  public class WordCounterController : Controller
  {
    
    [HttpGet("/wordcounter")]
    public ActionResult Index()
    {
      
      return View();
    }

    [HttpGet("/wordcounter/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/wordcounter")]
    public ActionResult Create(string word, string sentence)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      RepeatCounter newRepeatCounter = new RepeatCounter(word, sentence);
      WordSentence newWordSentence = new Wordsentence(word, sentence);
      
      model.Add("repeatCounter", newRepeatCounter);
      model.Add("wordSentence", newWordSentence);

      return View("Index", model);
    }


  }
}