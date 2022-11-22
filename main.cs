// Created by: Ekaterina
// Created on: Nov 2022
//
// This program generates random number

using System;

class Program
{
    public static void Main(string[] args)
    {
        int userNumber;
        int randomNumber;

        // This function accepts user input
        Console.WriteLine("Do you want a positive or negative");
        Console.WriteLine(" ");

        Console.WriteLine("Enter 1 if positive, 2 if negative ");
        Console.WriteLine(" ");
        userNumber = Convert.ToInt16(Console.ReadLine());

        Random rnd = new Random();

        Console.WriteLine(" ");
        if (userNumber == 1)
        {
          randomNumber = rnd.Next(1, 6);
          Console.WriteLine("Your random number is " + randomNumber);
        }
        else
        {
          randomNumber = rnd.Next(-6, -1);
          Console.WriteLine("Your random number is " + randomNumber);
        }

        Console.WriteLine("\nDone.");
    }
}