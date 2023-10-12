// See https://aka.ms/new-console-template for more information


Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine("   __            _ _     _ _     ___                          ");
Console.WriteLine("   \\ \\  __ _  __| (_) __| (_)   / _ \\__ _ _ __ ___   ___  ___ ");
Console.WriteLine("    \\ \\/ _` |/ _` | |/ _` | |  / /_\\/ _` | '_ ` _ \\ / _ \\/ __|");
Console.WriteLine(" /\\_/ / (_| | (_| | | (_| | | / /_\\\\ (_| | | | | | |  __/\\__ \\");
Console.WriteLine(" \\___/ \\__,_|\\__,_|_|\\__,_|_| \\____/\\__,_|_| |_| |_|\\___||___/");

Console.ForegroundColor = ConsoleColor.DarkRed;


Console.WriteLine("Please enter your name.");

string name = Console.ReadLine();

Console.WriteLine($"Hello, {name}! Welcome to your very own Word Adventure Game!");
Console.WriteLine("Imagine, you are a young child at the age of 12 years old. ");
Console.WriteLine("You live in a town where your parents rule and protect. You have one sister, ");
Console.WriteLine( "3 brothers and a half brother who you have a special siblingly bond with.  ");
Console.WriteLine("You Live a great life, truly! But you've always had a desire for some real adventure.");
Console.WriteLine("You usually stay inside, reading, or helping your Mother and the servents cook,");
Console.WriteLine("but today you wanted to create some chaos...");

Console.WriteLine("Do you want to go out and pick up the bow and shoot some arrows?");
Console.WriteLine("OR");
Console.WriteLine("Climb the Lighthouse?");
Console.WriteLine("Please enter 'climb' or 'shoot'.");

string chaosDecision = Console.ReadLine();

string chaosInput = "climb";
string chaosAnswer = "shoot";

