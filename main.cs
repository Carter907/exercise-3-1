using System;
//Write a program named Twitter that accepts a user’s message and determines whether it is short enough for a social networking service that does not accept messages of more than 140 characters.


class Program {
  public static void Main (string[] args) {
    Console.WriteLine("enter message:");
    string userIn = Console.ReadLine();

    if (userIn.ToCharArray().Length > 140) {
      Console.WriteLine("Rejected");
    } else {
      Console.WriteLine("Posted");
    }
  }
}