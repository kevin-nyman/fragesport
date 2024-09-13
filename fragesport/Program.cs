class Program
{
    public static int state = 0;
    static void Main()
    {
        Menu.PrintMenu();

    }

    static class Menu
    {

        static int index = 0;
        static int ww = Console.WindowWidth;
        static int wh = Console.WindowHeight;
        static bool yes = false;
        static string title = "eggbert's episka kviss";
        public static IReadOnlyList<string> Options { get; } = new List<string>
        {
            "play",
            "editor",
            "quit"
        };

        public static void PrintMenu()
        {
            Console.CursorVisible = false;
            while (state == 0)
            {
                if (ww != Console.WindowWidth || wh != Console.WindowHeight)
                {
                    Console.Clear();
                    ww = Console.WindowWidth;
                    wh = Console.WindowHeight;
                    yes = false;
                }

                if (!yes)
                {
                    int center_y = (wh - Options.Count - 1) / 2;
                    Console.SetCursorPosition((ww - title.Length) / 2, center_y);
                    Console.WriteLine(title);

                    int option_y = center_y + 2;
                    for (int i = 0; i < Options.Count; i++)
                    {
                        Console.SetCursorPosition((ww - Options[i].Length) / 2, option_y + i);
                        if (index == i) {
                            Console.Write("\x1b[47m\x1b[30m");
                            Console.Write(Options[i]);
                            Console.Write("\x1b[0m");
                        }
                        else {
                            Console.WriteLine(Options[i]);
                        }
                    }
                    yes = true;
                }

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = InputHandler.GetKey();

                    if (InputHandler.IsKey(key, ConsoleKey.UpArrow) || InputHandler.IsKey(key, ConsoleKey.W))
                    {
                        index = (index - 1 + Options.Count) % Options.Count;
                        yes = false;
                    }
                    else if (InputHandler.IsKey(key, ConsoleKey.DownArrow) || InputHandler.IsKey(key, ConsoleKey.S))
                    {
                        index = (index + 1) % Options.Count;
                        yes = false;
                    }
                    else if (InputHandler.IsKey(key, ConsoleKey.Enter))
                    {
                        switch (index)
                        {
                            case 0:
                                state = 1;
                                break;
                            case 1:
                                state = 2;
                                break;
                            case 2:
                                Environment.Exit(0);
                                break;
                        }
                    }
                }

            }
        }
    }

    class InputHandler
    {
        public static ConsoleKeyInfo GetKey()
        {
            return Console.ReadKey(true);
        }

        public static bool IsKey(ConsoleKeyInfo key, ConsoleKey expectedKey)
        {
            return key.Key == expectedKey;
        }
    }
    class Quiz {
        
        public static List<string> Questions { get; set; } = new List<string> {};
        
        public static void InitializeQuestions() {
            
        }

        public static void Play() {

        }


    }

    class Editor {

    }

    class Parser {

    }

}

