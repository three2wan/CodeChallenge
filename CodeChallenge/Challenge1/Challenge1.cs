// [Easy] Challenge 1
// ===================
//
// create a program that will ask the users name, age, and reddit username. have it tell them the information back, in the format:
//
//              your name is (blank), you are(blank) years old, and your username is (blank)
//
// for extra credit, have the program log this information in a file to be accessed later.

using System;
using System.IO;

class Challenge1
{
    public void AnswerChallenge1()
    {
        string name, username;
        int age;
        
        Console.Write("Enter your name: ");
        name = Console.ReadLine();
        Console.Write("Enter your age: ");
        age = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter your Reddit username: ");
        username = Console.ReadLine();

        Console.WriteLine($"Your name is {name}, you are {age} years old and your Reddit username is {username}");
        
        string[] userData = { name, age.ToString(), username };
        SaveInfoToFile(userData);
    }

    void SaveInfoToFile(string[] savedInfo)
    {
        string path = @"D:\Projects\CodeChallenge\CSharp\CodeChallenge\CodeChallenge\SaveData\data.txt";
        File.AppendAllLines(path, savedInfo);
    }
}

