using System;
using System.Collections.Generic;

namespace WordCounter.Models
{
  public class Program
  {
    static WordSentence newWordSentence = new WordSentence("", "");

    public static void Main()
    {
// Intro
        Console.WriteLine("Hi. I am WASAP -- Word And Sentence Analyzing Program.");
        Console.WriteLine("I run a Word Counter program. Would you like to try the Word Counter now? (y/n)");
        string userResponse1 = Console.ReadLine();
        if (userResponse1 == "n" || userResponse1 =="N")
        {
          Ending();
        }
        if (userResponse1 == "y" || userResponse1 =="Y")
        {
        Console.WriteLine("What is the word you would like me to count?");
        string userResponseWord = Console.ReadLine();
        Console.WriteLine("Please enter a sentence and I will count the instances of your word.");
        string userResponseSentence = Console.ReadLine();
        newWordSentence.SetWord(userResponseWord);
        newWordSentence.SetSentence(userResponseSentence);
        Body();
      }
      else
      {
        Console.WriteLine("Sorry, I couldn't understand that.");
        Main();
      }
    }
//Main 
    public static void Body()
    {
      string wordInput = newWordSentence.GetWord();
      string sentenceInput = newWordSentence.GetSentence();
      Console.WriteLine("Great! Let me calculate how many times your word \"" + wordInput + "\" appears in your sentence: \"" + sentenceInput + "\".");
      RepeatCounter newRepeatCounter = new RepeatCounter(wordInput, sentenceInput);
      int resultCount = newRepeatCounter.WordInSentence();
      Console.WriteLine("The answer is " + resultCount +"." );
      Console.WriteLine("Would you like to try again? (y/n)");
      string userResponse2 = Console.ReadLine();

      if (userResponse2 == "y" || userResponse2 =="Y")
      {
        Console.WriteLine("Would you like to change your word, your sentence, or start over? (word/sentence/startover)");
        string userResponse3 = Console.ReadLine();
        if (userResponse3 == "startover" || userResponse3 == "Startover" || userResponse3 == "start over" )
        {
        Console.WriteLine("What is the word you would like me to count?");
        string userResponseWord = Console.ReadLine();
        Console.WriteLine("Please enter a sentence and I will count the instances of your word.");
        string userResponseSentence = Console.ReadLine();
        newWordSentence.SetWord(userResponseWord);
        newWordSentence.SetSentence(userResponseSentence);
        Body();
        }
        else if (userResponse3 == "word" || userResponse3 == "Word")
        {
          Console.WriteLine("Okay, what would you like your new word to be?");
          string newUserResponseWord = Console.ReadLine();
          newWordSentence.SetWord(newUserResponseWord);
          Body();
        } 
        else if ( userResponse3 == "sentence" || userResponse3 == "Sentence")
        {
          Console.WriteLine("Okay, what would you like your new sentence to be?");
          string newUserResonseSentence = Console.ReadLine();  
          newWordSentence.SetSentence(newUserResonseSentence);
          Body();      
        }
        else 
        {
          Console.WriteLine("Sorry, I didn't understand that.");
          Ending();
        }
      }
      else 
      {
        Ending();
      }
    }
//Ending
    public static void Ending()
    {
        Console.WriteLine("Thank you for stopping by. WASAP out!");
    }
  }
}