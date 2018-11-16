using System;
using System.Collections.Generic;

namespace WordCounter.Models
{
  public class WordSentence
  {
    private string _wordInput;
    // private string _sentenceInput;
    
    public WordSentence(string userWord)
    {
      _wordInput = userWord;
    }

    public string GetWord()
    {
      return _wordInput;
    }

  }
}