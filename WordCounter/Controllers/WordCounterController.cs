using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;
using System.Collections.Generic;
using System;

namespace WordCounter.Controllers
{
  public class WordCounterController : Controller
  {
    
    [HttpGet("/wordcounter")]
    public ActionResult Index()
    {
      List<WordSentence> wordSentenceList = WordSentence.GetAll();
      return View(wordSentenceList);
    }

    [HttpGet("/wordcounter/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/wordcounter/result")]
    public ActionResult Show(string word, string sentence)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      RepeatCounter newRepeatCounter = new RepeatCounter(word, sentence);
      WordSentence newWordSentence = new WordSentence(word, sentence);
      newWordSentence.AddResult(newRepeatCounter.WordInSentence());
      model.Add("repeatCounter", newRepeatCounter);
      model.Add("wordSentence", newWordSentence);
      return View(model);
    }

    [HttpPost("/wordcounter/clear")]
    public ActionResult Destroy()
    {
      WordSentence.ClearAll();
      return View();
    }
    
  }
}