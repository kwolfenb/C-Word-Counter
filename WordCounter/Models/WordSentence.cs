using System;
using System.Collections.Generic;

namespace WordCounter.Models
{
  public class WordSentence
  {
    private string _wordInput;
    private string _sentenceInput;
    
    public WordSentence(string userWord, string userSentence)
    {
      _wordInput = userWord;
      _sentenceInput = userSentence;
    }

    public string GetWord()
    {
      return _wordInput;
    }

    public string GetSentence()
    {
      return _sentenceInput;
    }

    public void SetWord(string setWordInput)
    {
      _wordInput = setWordInput;
    }

    public void SetSentence(string setSentenceInput)
    {
      _sentenceInput = setSentenceInput;
    }
  }
 
}
