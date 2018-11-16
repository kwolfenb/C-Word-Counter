using System;
using System.Collections.Generic;

namespace WordCounter.Models
{

  public class RepeatCounter
  {
    private string _wordToCount;
    private string _sentenceToCheck;
    private int _wordCount;

    public RepeatCounter(string wordToCount, string sentenceToCheck)
    {
      _wordToCount = wordToCount.ToLower();
      _sentenceToCheck = sentenceToCheck.ToLower();
    }

    public int WordInSentence()
    {
      _wordCount = 0;
      string[] sentenceArray = _sentenceToCheck.Split(' ','?','!','.','"',',');
      foreach(string x in sentenceArray)
      {
        if(x == _wordToCount) 
        {
          _wordCount ++;
        }
      } 
      return _wordCount;
    }
  }
}