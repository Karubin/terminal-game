using System;
using System.Collections.Generic;
using System.Text;

namespace Terminal
{
    class WindowManager
    {

        public static readonly int WIDTH = Int32.Parse(Program.configuration["window:width"]);
        public static readonly int HEIGHT = Int32.Parse(Program.configuration["window:height"]);

        public static void Init()
        {
            Console.SetWindowSize(WIDTH, HEIGHT);
            Console.SetBufferSize(WIDTH, HEIGHT);
            Console.Title = "Project Terminal";
            Console.CursorVisible = false;
            Console.SetCursorPosition(0, 0);

            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;

            Console.Clear();
        }

        public static void Update()
        {
            Console.CursorVisible = false;
            Console.SetCursorPosition(0, 0);

            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;

            Console.Clear();
            if (Console.WindowWidth != WIDTH || Console.WindowHeight != HEIGHT)
            {
                Console.SetWindowSize(WIDTH, HEIGHT);
                Console.SetBufferSize(WIDTH, HEIGHT);
            }
        }

        public static void ResetColors()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
        }

        public static void RenderLogo()
        {
            Console.SetCursorPosition(0, 6);
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine(@"    ██████╗ ██████╗  ██████╗      ██╗███████╗ ██████╗████████╗                               ");
            Console.WriteLine(@"    ██╔══██╗██╔══██╗██╔═══██╗     ██║██╔════╝██╔════╝╚══██╔══╝                               ");
            Console.WriteLine(@"    ██████╔╝██████╔╝██║   ██║     ██║█████╗  ██║        ██║                                  ");
            Console.WriteLine(@"    ██╔═══╝ ██╔══██╗██║   ██║██   ██║██╔══╝  ██║        ██║                                  ");
            Console.WriteLine(@"    ██║     ██║  ██║╚██████╔╝╚█████╔╝███████╗╚██████╗   ██║                                  ");
            Console.WriteLine(@"    ╚═╝     ╚═╝  ╚═╝ ╚═════╝  ╚════╝ ╚══════╝ ╚═════╝   ╚═╝                                  ");
            Console.WriteLine(@"                                                                                             ");
            Console.WriteLine(@"                  ████████╗███████╗██████╗ ███╗   ███╗██╗███╗   ██╗ █████╗ ██╗               ");
            Console.WriteLine(@"                  ╚══██╔══╝██╔════╝██╔══██╗████╗ ████║██║████╗  ██║██╔══██╗██║               ");
            Console.WriteLine(@"        █████╗       ██║   █████╗  ██████╔╝██╔████╔██║██║██╔██╗ ██║███████║██║         █████╗");
            Console.WriteLine(@"        ╚════╝       ██║   ██╔══╝  ██╔══██╗██║╚██╔╝██║██║██║╚██╗██║██╔══██║██║         ╚════╝");
            Console.WriteLine(@"                     ██║   ███████╗██║  ██║██║ ╚═╝ ██║██║██║ ╚████║██║  ██║███████╗          ");
            Console.WriteLine(@"                     ╚═╝   ╚══════╝╚═╝  ╚═╝╚═╝     ╚═╝╚═╝╚═╝  ╚═══╝╚═╝  ╚═╝╚══════╝          ");




            string label = " - PRESS ANY KEY - ";
            Console.SetCursorPosition((Console.WindowWidth - label.Length) / 2, Console.WindowHeight - 8);
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Write(label);

            Console.ReadKey();

            Console.SetCursorPosition(0, 0);
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
        }

        public static void DrawImage(int column, int row, string[] data, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            for (int i = 0; i < data.Length; i++)
            {
                Console.SetCursorPosition(column, row + i);
                Console.Write(data[i]);
            }
        }

        public static string[] TrainImage = {@"           O         O    O             O         O   OO (OOO)", @"O O OO  O    OO O O OO OOO O O   OO OO OOOO  OOO OOOO O (O(OOO))", @"O OO O              OO O OO O   O O (    OOOO    OOOO )OO O OO)))", @" O OO  OO O OO OO OO   O OOO OOO OOOO OOO OOOO OOO  OOOO((OOOOO))", @"       O          O          OO            OO        O O (OOO))", @"                                                          (OO)", @"   _______----------.   ___    _____    ___    _____      ___", @"--'       `| .----. |---------|     |---------|     |----'   `[5101]", @"          || |____| |                                           |__", @"          |---------     TERMINAL GAME  ____  _________________ |-'", @"          | | 5101    /----------------(____)/,---------------_||__", @"          | |========/ /  \ / _\_/_<|==(____)  \ / _\_/__<|==[__]_\\_", @"---._---_./=|,-._,-\   o---{o}=======\>=[__]o---{o}=======\>=[__]----\=", @"___(O)_(O)___(O)_(O)___\__/_\__/_\__/_______\__/_\__/_\__/____(O)_(O)_\_", };
    }
}
