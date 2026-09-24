using System.ComponentModel.Design;

namespace Methodassignment2
{
    internal class Program
    {

        static void Main(string[] args)
        {
            for (int i = 0; i < 4; i++)
            {
                // part 1
                Console.WriteLine();
                Console.WriteLine("Hello, welcome to the art maker, pick a number from 1 to 4:");
                int input;
                while (!Int32.TryParse(Console.ReadLine(), out input))
                    Console.WriteLine("Invalied number, please enter again.");


                drawAtst(input);
                drawTerm(input);
                drawDarkhelmet(input);
                drawCross(input);
                drawInvalid(input);
                Console.WriteLine();

            }

            // part 2 (do not read any storys untill you play thought everyone of them);
            Console.Clear();
            Console.WriteLine("Please enter your name:");
            string name = Console.ReadLine();
            for (int g = 0; g < 10; g++)
            {
                Random random = new Random();
                Console.WriteLine();
                Console.WriteLine("Knock, Knock");
                Thread.Sleep(1000);
                Console.WriteLine("Are you going to anwser the door? (Y or N)");
                string anwser = Console.ReadLine().ToLower();

                if (anwser.StartsWith("y"))
                {
                    int ramdomStory = random.Next(1, 5);

                    if (ramdomStory == 1)
                    {
                        storyOne(name);
                    }
                    if (ramdomStory == 2)
                    {
                        StoryTwo(name);
                    }
                    if (ramdomStory == 3)
                    {
                        storyThree(name);
                    }

                }
                else if (anwser.StartsWith("n"))
                {
                    Console.WriteLine();
                    Console.WriteLine("You just desided to not anwser the door. (How rude)");
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Invalid response, Please try again.");
                }

            }


        }

        static void drawAtst(int input)
        {
            if (input == 1)
            {
                Console.WriteLine(@"
                      ________________
                     |'-.--._ _________:
                     |  /    |  __    __\
                     | |  _  | [\_\= [\_\
                     | |.' '. \.........|
                     | ( <)  ||:       :|_
                      \ '._.' | :.....: |_(o
                       '-\_   \ .------./
                        _   \   ||.---.||  _
                       / \  '-._|/\n~~\n' | \
                      (| []=.--[===[()]===[) |
                      <\_/  \_______/ _.' /_/
                       ///            (_/_/
                       |\\            [\\
                       ||:|           | I|
                       |::|           | I|
                       ||:|           | I|
                       ||:|           : \:
                       |\:|            \I|
                      :/\:            ([])
                      ([])             [|
                       ||              |\_
                      _/_\_            [ -'-.__
                     <]   \>            \_____.>
                       \__/");
            }




        }
        static void drawTerm(int input)
        {

            if (input == 2)
            {

                Console.WriteLine(@"
                     ______
                   <((((((\\\
                   /      . }\
                   ;--..--._|}
(\                 '--/\--'  )
 \\                | '-'  :'|
  \\               . -==- .-|
   \\               \.__.'   \--._
   [\\          __.--|       //  _/'--.
   \ \\       .'-._ ('-----'/ __/      \
    \ \\     /   __>|      | '--.       |
     \ \\   |   \   |     /    /       /
      \ '\ /     \  |     |  _/       /
       \  \       \ |     | /        /
         \  \      \        / ");



            }


        }



        static void drawDarkhelmet(int input)
        {
            if (input == 3)
            {
                Console.WriteLine(@"
        _________
     ,''         ``.
    /               \
   |   ,---------.   |
   |  /--.\ | /,--\  |
   | /`-._\\|//_,-'\ |
   |/._ _ _____ _ _.\|
   /   \ |=/#\=| /   \
  (_`-._\|=\#/=|/_,-'_)
   /  ._'-.___,-'_,  \
  / /   `-.\_/.-'   \ \
 : (  ,    | |    .  ) \
 |  \ |    |||    | /  |
 |   \|    |||    |/   |
 | ,-'|    |||    |`-. |
 |/|  |____\|/____|  |\|
  \'--|___((_))___|--|/
   |\_|-_ \\|//__-|_/ |
   |  |_  -\|/- ._|   /
   |\ |____/ \____|  |\
   ; \ |   | |   |   |;
  /   .|   | |   |   ||
  |   ||   | |   |    \
  ;   || -.| | -.|    /
  |   ;| - | |-- |   /\
  ;  ; |   | |   |   ||
  /  | |   | |   |   / \
 |  /  |___| |___|   \ |
/__,--.(=--)_(-- )_,--\_\
       /   ) (   \
 jrei /  ,'   '.  \
     (_,'       '._)");



            }


        }
        static void drawCross(int input)
        {

            if (input == 4)
            {
                Console.WriteLine(@"               
               |
           \       /
             .---. 
        '-.  |   |  .-'
          ___|   |___
     -=  [           ]  =-
         `---.   .---' 
      __||__ |   | __||__
      '-..-' |   | '-..-'
        ||   |   |   ||
        ||_.-|   |-,_||
      .-""`   `""`'`   `""-.
    .'                   '.");



            }





        }
        static void drawInvalid(int input)
        {

            if (input > 4)
            {

                Console.WriteLine("Your number is invalid, please re-run the program");




            }
        }

        static void storyOne(string name)
        {
            Console.WriteLine();
            Console.WriteLine("You go to the door and ask, who's there?");
            Console.WriteLine();
            Thread.Sleep(5000);
            Console.WriteLine("Then someone behind the door said...");
            Thread.Sleep(2000);
            Console.WriteLine("Pizza delivery for " + name);
            Console.WriteLine();
            Console.WriteLine("You open the door get your pizza and relax.");
            Console.WriteLine("THE END");



        }

        static void StoryTwo(string name)
        {

            Console.WriteLine();
            Console.WriteLine("You go to the door and ask, who's there?");
            Console.WriteLine();
            Thread.Sleep(5000);
            Console.WriteLine("But no one anwsers...");
            Console.WriteLine();
            Thread.Sleep(5000);
            Console.WriteLine("What do you do? (1: open the door, 2: leave it, 3: call 911");
            int input;
            while (!Int32.TryParse(Console.ReadLine(), out input))
                Console.WriteLine("Invalied number, please enter again.");
            if (input == 3)
            {

                Thread.Sleep(3000);
                Console.WriteLine("You called and the poice came, but found nothing.");
                Console.WriteLine();
                Thread.Sleep(3000);
                Console.WriteLine("But now they fine you $5000, for calling without reason!");
                Console.WriteLine();
                Thread.Sleep(3000);
                Console.WriteLine("The END");
                Console.WriteLine();
                Console.WriteLine("press enter to contune:");
                Console.ReadLine();
                Console.Clear();
            }
            else if (input == 2)
            {
                Thread.Sleep(3000);
                Console.WriteLine("You did nothing.");
                Console.WriteLine();
                Thread.Sleep(3000);
                Console.WriteLine("And went back to relax. (Lazy Ending)");
            }
            else if (input == 1) 
            {
                Thread.Sleep(3000);
                Console.WriteLine("You opened the door, as the door opened...");
                Console.WriteLine();
                Thread.Sleep(3000);
                Console.WriteLine("You saw...");
                Console.WriteLine();
                Thread.Sleep(3000);
                Console.WriteLine("A...");
                Console.WriteLine();
                Thread.Sleep(3000);
                Console.WriteLine("Ailen?");
                Console.WriteLine();
                Thread.Sleep(3000);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("(Wait, Why is there a random ailen at their door?) ");
                Console.WriteLine();
                Thread.Sleep(1000);
                Console.ForegroundColor= ConsoleColor.Cyan;
                Console.WriteLine("(I thought it would be funny to have a ailen come in and be a buddy to them.)");
                Thread.Sleep(1000);
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("(But how would that be funny at all!)");
                Console.WriteLine();
                Thread.Sleep(1000);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("( I just thought it would be...)");
                Console.WriteLine();
                Thread.Sleep(5000);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("(Wait are they seeing this?)");
                Console.WriteLine();
                Thread.Sleep(2000);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine();
                Console.WriteLine("(...)");
                Console.WriteLine();
                Thread.Sleep(2000);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine();
                Console.WriteLine("(...)");
                Console.WriteLine();
                Thread.Sleep(4000);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("(YOU SAW NOTHING!)");
                Thread.Sleep(4000);
                Console.Clear();

                Console.ForegroundColor = ConsoleColor.White;
            }
         


            
        }
        static void storyThree(string name)
        {
            Console.WriteLine();
            Console.WriteLine("You go to the door and ask, who's there?");
            Console.WriteLine();
            Thread.Sleep(5000);
            Console.WriteLine("But you hear a someone there...");
            Console.WriteLine();
            Thread.Sleep(5000);
            Console.WriteLine("What do you do? (1: open the door, 2: leave it, 3: call 911");
            int input;
            while (!Int32.TryParse(Console.ReadLine(), out input))
                Console.WriteLine("Invalied number, please enter again.");
            if (input == 3)
            {

                Thread.Sleep(3000);
                Console.WriteLine("You called and the poice came, but found your neighbor in his pjs.");
                Console.WriteLine();
                Thread.Sleep(3000);
                Console.WriteLine("You see your neighbor saying to the cops that he was just asking for milk.");
                Console.WriteLine();
                Thread.Sleep(3000);
                Console.WriteLine("But you see him, get put into the cop car.");
                Thread.Sleep(3000);
                Console.WriteLine();
                Console.WriteLine("But a cop came up and thanked you in ading in getting a big time bank robber.");
                Thread.Sleep(3000);
                Console.WriteLine();
                Console.WriteLine("You sit down and relax. (Good Ending)");
                Console.WriteLine();
                Console.WriteLine("press enter to contune:");
                Console.ReadLine();
                Console.Clear();
            }
            else if (input == 2)

            {
                Thread.Sleep(3000);
                Console.WriteLine("You did nothing.");
                Console.WriteLine();
                Thread.Sleep(3000);
                Console.WriteLine("And went back to relax. (Lazy Ending)");
                Console.WriteLine();
                Console.WriteLine("press enter to contune:");
                Console.ReadLine();
                Console.Clear();
            }
            else if (input == 1)
            {
                Thread.Sleep(3000);
                Console.WriteLine("You opened the door, as the door opened...");
                Console.WriteLine();
                Thread.Sleep(3000);
                Console.WriteLine("You saw...");
                Console.WriteLine();
                Thread.Sleep(3000);
                Console.WriteLine("Your neighbor?");
                Console.WriteLine();
                Thread.Sleep(3000);
                
                Console.WriteLine("He then said:");
                Console.WriteLine();
                Thread.Sleep(500);
                
                Console.WriteLine("Howdy, neighbor, do you have any milk? (Y/N)");
                Thread.Sleep(1000);
                Console.WriteLine();
                
                string input2 = Console.ReadLine().ToLower();
                if (input2.StartsWith("y"))
                {
                    Console.WriteLine("You go to get some milk out...");
                    Console.WriteLine();
                    Thread.Sleep(1000);

                    Console.WriteLine("You give him the milk, and...");
                    Console.WriteLine();
                    Thread.Sleep(5000);

                    Console.WriteLine("He says, thanks " + name);
                    Console.WriteLine();
                    Thread.Sleep(2000);

                    Console.WriteLine("And he runs off...");
                    Console.WriteLine();
                    Thread.Sleep(2000);

                    Console.WriteLine("In the morning, you find a something in your mail, with $10,000 dollers!");
                    Console.WriteLine();
                    Thread.Sleep(2000);

                    Console.WriteLine("With a note that says (Thanks for the milk!)");
                    Console.WriteLine();
                    Thread.Sleep(2000);

                    Console.WriteLine("Milk Money Ending");
                    Console.WriteLine();
                    Thread.Sleep(2000);
                    Console.WriteLine();
                    Console.WriteLine("press enter to contune:");
                    Console.ReadLine();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("You don't have milk!");
                    Console.WriteLine();
                    Thread.Sleep(2000);
                    Console.WriteLine("Thats fine, I'll ask another neighbor.");
                    Console.WriteLine();
                    Thread.Sleep(2000);
                    Console.WriteLine("Good night " + name + ".");
                    Console.WriteLine();
                    Thread.Sleep(2000);
                    Console.WriteLine();
                    Console.WriteLine("press enter to contune:");
                    Console.ReadLine();
                    Console.Clear();
                }
                
                
                
            }
        }
    }
}
