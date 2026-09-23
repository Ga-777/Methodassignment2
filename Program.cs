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

            // part 2
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
                        storyOne();
                    }
                    if (ramdomStory == 2)
                    {

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

        static void storyOne()
        {
            Console.WriteLine();
            Console.WriteLine("You go to the door and ask, who's there?");
            Console.WriteLine();
            Thread.Sleep(5000);
            Console.WriteLine("Then someone behind the door said...");
            Thread.Sleep(2000);
            Console.WriteLine("Pizza ");
            Console.WriteLine();
            Console.WriteLine("You open the door get your pizza and relax.");
            Console.WriteLine("THE END");



        }


    }
}
