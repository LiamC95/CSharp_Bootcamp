/*
 * Write the output
 * This is the first line.
 * This is the second line.
 * 
 * by using two methods
 */
string aFriend = "Billy";
/**
Console.WriteLine("This is the first line.");
Console.Write("This is the");
Console.Write(" second line.");
**/
Console.WriteLine("Howdy " + aFriend);
Console.WriteLine($"Hola {aFriend}");

/*
 * STRINGS
 * Some lines on the properties and methods that are available
 * 
 */
string FirstFriend = "Joe";
string SecondFriend = "Mary";

Console.WriteLine($"The name {FirstFriend} has {FirstFriend.Length} letters.");
Console.WriteLine($"The name {SecondFriend} has {SecondFriend.Length} letters.");

string whiteSpace = "    Billy      ";
Console.WriteLine($"[{whiteSpace}]");
Console.WriteLine($"[{whiteSpace.TrimStart().ToUpper()}]");
Console.WriteLine($"[{whiteSpace.TrimEnd()}]");
Console.WriteLine($"[{whiteSpace.Trim().Replace("Billy", "Barbs")}]");

/* Seraching Strings*/

string songLyrics = "You say goodbye, and I say hello";

Console.WriteLine(songLyrics.Contains("and"));
Console.WriteLine(songLyrics.Contains(aFriend));
string searchString = "say hello";

Console.WriteLine(songLyrics.Contains(searchString));// True
Console.WriteLine(songLyrics.StartsWith("y"));
Console.WriteLine(songLyrics.StartsWith("Y"));

/*
 * Numbers Baby!!
 * 
 */
Console.WriteLine("BREAK\n\n\n\n\n\nNumbers Baby");
int a = 18;
int b = 6;
int c = 3;
Console.WriteLine($" {a}+{b}*{c}  =\t {a + b * c}");
Console.WriteLine($"({a}+{b})*{c} =\t {(a + b) * c}");
Console.WriteLine($" {a}+{b}/{c}  =\t {a + b / c}");
Console.WriteLine($"({a}+{b})/{c} =\t {(a + b) / c}");

/*Ints wont provide a floating point or decimal value so they will round*/
Console.WriteLine($"({a}+{b})/{c} =\t {((a + b) / c)}.{(a+b % c)}");

Console.WriteLine($"The integer max is {int.MaxValue}");
Console.WriteLine($"The integer min is {int.MinValue}");
Console.WriteLine($"The double max is {double.MaxValue}");
Console.WriteLine($"The double min is {double.MinValue}");
Console.WriteLine($"The decimal max is {decimal.MaxValue}");
Console.WriteLine($"The decimal min is {decimal.MinValue}");
int min = int.MinValue;
Console.WriteLine($"\n\nThe integer min minus 5 {(min) - 5} we can see it flips back to positive");

Console.WriteLine($"\n\nA third is 1/3 which is = {1.0 / 3.0}");
Console.WriteLine($"Area for a circle = {Math.PI*c * c}");

/* 
 Branches If statments
 */
Console.WriteLine("BREAK\n\n\n\n\n\nLogic Baby");