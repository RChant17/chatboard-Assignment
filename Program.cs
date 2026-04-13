using System;

class Program
{
    static void Main(string[] args)

    {


        Console.Title = "Chant-Bot - Cybersecurity Awareness";

        ConsoleUI.DisplayLogo();

        UserProfile user = new UserProfile();
        user.GetUserName();

        ConsoleUI.BotSay(
            $"Hello {user.Name}! Welcome to the Cybersecurity Awareness Bot\n" +
            "I am Chant-Bot, here to help you stay safe online.\n" +
            "Type 'exit' or 'bye' to quit."
        );

        AudioPlayer.Speak("Welcome to the Cybersecurity Awareness Bot");

        ResponsesService bot = new ResponsesService();
        bot.RunChat(user.Name);
    }
}