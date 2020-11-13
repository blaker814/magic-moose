using System;

namespace MagicMoose
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Welcome to the Magic Moose Simulator!");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine();

            MooseSays("Ask me a yes or no question");
            Continue();
        }
        static void MooseSays(string message)
        {
            Console.WriteLine($@"
                                       _.--^^^--,
                                    .'          `\
  .-^^^^^^-.                      .'              |
 /          '.                   /            .-._/
|             `.                |             |
 \              \          .-._ |          _   \
  `^^'-.         \_.-.     \   `          ( \__/
        |             )     '=.       .,   \
       /             (         \     /  \  /
     /`               `\        |   /    `'
     '..-`\        _.-. `\ _.__/   .=.
          |  _    / \  '.-`    `-.'  /
          \_/ |  |   './ _     _  \.'
               '-'    | /       \ |
                      |  .-. .-.  |
                      \ / o| |o \ /
                       |   / \   |    {message}
                      / `^`   `^` \
                     /             \
                    | '._.'         \
                    |  /             |
                     \ |             |
                      ||    _    _   /
                      /|\  (_\  /_) /
                      \ \'._  ` '_.'
                       `^^` `^^^`
            ");
        }
        static string Question()
        {
            return Console.ReadLine().ToLower();
        }
        static void Answer()
        {
            Random r = new Random();
            int randNum = r.Next(1, 21);

            switch (randNum)
            {
                case 1:
                    MooseSays("As I see it, yes");
                    break;
                case 2:
                    MooseSays("Ask again later.");
                    break;
                case 3:
                    MooseSays("Better not tell you now.");
                    break;
                case 4:
                    MooseSays("Cannot predict now.");
                    break;
                case 5:
                    MooseSays("Concentrate and ask again.");
                    break;
                case 6:
                    MooseSays("Don’t count on it.");
                    break;
                case 7:
                    MooseSays("It is certain.");
                    break;
                case 8:
                    MooseSays("It is decidedly so.");
                    break;
                case 9:
                    MooseSays("Most likely.");
                    break;
                case 10:
                    MooseSays("My reply is no.");
                    break;
                case 11:
                    MooseSays("My sources say no.");
                    break;
                case 12:
                    MooseSays("Outlook not so good.");
                    break;
                case 13:
                    MooseSays("Outlook good.");
                    break;
                case 14:
                    MooseSays("Reply hazy, try again.");
                    break;
                case 15:
                    MooseSays("Signs point to yes.");
                    break;
                case 16:
                    MooseSays("Very doubtful.");
                    break;
                case 17:
                    MooseSays("Without a doubt.");
                    break;
                case 18:
                    MooseSays("Yes.");
                    break;
                case 19:
                    MooseSays("Yes – definitely.");
                    break;
                case 20:
                    MooseSays("You may rely on it.");
                    break;
            }
        }
        static void Continue()
        {
            string question = Question();
            while (question != "")
            {
                Answer();
                MooseSays("Ask me a yes or no question");
                question = Question();
            }
        }
    }
}
