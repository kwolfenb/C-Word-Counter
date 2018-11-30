# _Word Counter Project_

#### _Independent Project for C# week 1, 11.16.2018_

#### By _**Kenny Wolfenberger**_

## Description

_A C# application that takes both a word and a sentence from a user. It then checks how frequently the word appears in the sentence and returns this information to the user._

## Setup/Installation Requirements

* _Clone this repository: $ git clone https://github.com/kwolfenb/WordCounter.Solution.git_
* _To edit the project, open the project in your preferred text editor._
* _To run the program, first navigate to the location of the WordCounter.cs file then compile and execute: $ cd WordCounter/Models $ mcs WordCounter.cs; mono WordCounter.exe;_
* _To run the tests, use these commands: $ cd WordCounter.Tests $ dotnet test_

## Support and contact details

_Kenny Wolfenberger - kennywolfenberger@gmail.com_

### Specs
| Spec | Input | Output |
| :-------------     | :------------- | :------------- |
| Create instance of WordSentence class |new WordSentence instance | Type of new instance == type of WordSentence  |
| WordSentence class can hold and return a word string | "coffee" |  "coffee" |
| WordSentence class can hold and return sentence string | "I like coffee" |  "I like coffee" |
| User can set a word | "car" | "car" |
| User can set a sentence | "My car is a fast car." | "My car is a fast car." |
| Program can identify when the word is not in the sentence | "tea", "I like coffee." | 0  |
| Program can identify when the word is in the sentence | "coffee", "I like coffee" | 1  |
| Program counts the number of times the word is in the sentence | "car", "My car is faster than your car" | 2  | 
| Program counts words that are next to punctuation marks | "hungry", "Are you hungry?" | 1  |
| Program does not count words contained in other words | "read", "is everyone ready?" | 0  |

## Technologies Used

* _C#_
* _.NET_
* _MSTests_

### License

*This software is licensed under the MIT license.*

Copyright (c) 2018 **_Kenny Wolfenberger_**


