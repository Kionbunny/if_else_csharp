﻿// See https://aka.ms/new-console-template for more information
// Top level statement allow developers to write a program without the need for a main method or a class 
Console.WriteLine("Hello");
string message = "hello world!";
Console.WriteLine(message);
if (message.Contains("h"))
{
    Console.WriteLine("status ok ");
}
else
{
    Console.WriteLine("status not ok ");
}
string[] arr = { "Tony", "John", "james" }; // array of string with size 3 
/// the first set of square brackets [] merely tells the compiler that the variable named arr is an array
foreach(string name in arr)
{
    ///Console.WriteLine(name + " ");
    Console.Write(name + " ");/// print without a new line or print all of them in a single line 
}
