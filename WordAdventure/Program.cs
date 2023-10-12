// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;
using System.Security.Claims;

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
Console.WriteLine( "three brothers and a half brother who you have a special siblingly bond with.  ");
Console.WriteLine("You live a great life, truly! But you've always had a desire for some real adventure.");
Console.WriteLine("You usually stay inside, reading, or helping your Mother and the servents cook,");
Console.WriteLine("but today you wanted to create some chaos...");

Console.WriteLine("Do you want to go out and pick up the bow and shoot some arrows?");
Console.WriteLine("OR");
Console.WriteLine("Climb the Lighthouse?");
Console.WriteLine("Please enter 'climb' or 'shoot'.");

string chaosDecision = Console.ReadLine();

switch (chaosDecision.ToLower())
{
    case "climb":
        Console.WriteLine("You see the Lighthouse from the cobblestone floor of the castle center,");
        Console.WriteLine("The urge to go climb it like you did when you were smaller took over.");
        Console.WriteLine("Before you knew it you had your hands and feet on the wall and you could");
        Console.WriteLine("see the locals below going about their buisness. Off in the distance,  ");
        Console.WriteLine("you see a carriage riding towards your little town.  ");
        break;
    case "shoot":
        Console.WriteLine("You race out of the castle and outside to the range where your brothers are sparring.");
        Console.WriteLine("Hidden, you grab a bow from the chest behind the brick wall that stands between you and ");
        Console.WriteLine("your brothers, you set up your bow with the arrow. Still hidden, you peer over the wall ");
        Console.WriteLine("and let it fly. The arrow cuts through the air and lands on that little dot in the center ");
        Console.WriteLine("of the bullseye. In awe of yourself, you stand there, speechless, while all of your brothers, " +
            "\nas well as your father turn around to see you standing their with your bow. All in utter shock.");
        
        break;
    default:
        Console.WriteLine("Invalid choice, Please try again");
        break;
}




