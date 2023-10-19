using System;
class InputConsolDemo
{
    static void Main()
    {
        string name;
        Console.Title = "Lets get acquainted";
        Console.Write("What is your name?");
        name = Console.ReadLine();
        string txt = "Nice to meet," + name + "!";
        Console.Title = "The acquainted is made";
        Console.Write(txt);

    }

}