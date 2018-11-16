using System;
using System.Collections.Generic;

namespace WordCounter.Models
{
  public class Program
  {
    public static void Main()
    {
      // Intro
      Console.WriteLine("Hi. I am WASAP -- Word And Sentence Analyzing Program.");
      Console.WriteLine("I run a Word Counter program. Would you like to try the Word Counter now? (y/n)");
      string userResponse1 = Console.ReadLine();
      if (userResponse1 == "y" || userResponse1 =="Y")
      {
        Body();
      }

      else if (userResponse1 =="n" || userResponse1 == "N")
      {
        Ending();
      }

    }

    public static void Body()
    {
      // User Input
      Console.WriteLine("What is the word you would like me to count?");
      string userResponseWord = Console.ReadLine();
      Console.WriteLine("Please enter a sentence and I will count the instances of your word.");
      string userResponseSentence = Console.ReadLine();

      WordSentence newWordSentence = new WordSentence(userResponseWord, userResponseSentence);
      string wordInput = newWordSentence.GetWord();
      string sentenceInput = newWordSentence.GetSentence();

      Console.WriteLine("Great! Let me calculate how many times your word \"" + wordInput + "\" appears in your sentence: \"" + sentenceInput + "\".");

      RepeatCounter newRepeatCounter = new RepeatCounter(wordInput, sentenceInput);
      int resultCount = newRepeatCounter.WordInSentence();

      Console.WriteLine("The answer is " + resultCount +"." );
      Console.WriteLine("Shall we try again? (y/n)");
      string userResponse2 = Console.ReadLine();

      if (userResponse2 == "n" || userResponse2 =="N")
      {
        Ending();
      }
      else if (userResponse2 == "y" || userResponse2 =="Y")
      {
        Console.WriteLine("Would you like to change your word, your sentence, or simply start over? (word/sentence/startover)");
        string userResponse3 = Console.ReadLine();
        if (userResponse3 == "startover" || userResponse3 == "Startover" || userResponse3 == "start over" )
        {
          Body();
        }
        else if (userResponse3 == "word" || userResponse3 == "Word")
        {
          NewWord();
        } 
        else if ( userResponse3 == "sentence" || userResponse3 == "Sentence")
        {
          NewSentence();
        }
      }

    }
    public static void NewWord()
    {
        Console.WriteLine("Okay. Let's change the word.");
    }

    public static void NewSentence()
    {
        Console.WriteLine("Okay. Let's change the sentence.");
    }

    public static void Ending()
    {
        Console.WriteLine("Thank you for stopping by. WASAP out!");
    }
    
  }
}