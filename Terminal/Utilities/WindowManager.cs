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
            if(Console.WindowWidth != WIDTH || Console.WindowHeight != HEIGHT)
            {
                Console.SetWindowSize(WIDTH, HEIGHT);
            }

            Console.Title = "Project Terminal";
            Console.CursorVisible = false;
            Console.SetCursorPosition(0, 0);
            Console.SetBufferSize(WIDTH, HEIGHT);

            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;

            Console.Clear();
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

    }
}
