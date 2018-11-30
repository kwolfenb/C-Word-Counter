using System;
using System.Collections.Generic;

namespace WordCounter.Models
{
  public class WordSentence
  {
    private string _wordInput;
    private string _sentenceInput;
    private static List<WordSentence> _instances = new List<WordSentence>{};
    private int _id;
    private int _result;
    
    public WordSentence(string userWord, string userSentence)
    {
      _wordInput = userWord;
      _sentenceInput = userSentence;
      _instances.Add(this);
      _id = _instances.Count;
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

    public static List<WordSentence> GetAll()
    {
      return _instances;
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }

    public void AddResult(int result)
    {
      _result = result;
    }

    public int GetResults()
    {
      return _result;
    }
  }
 
}
