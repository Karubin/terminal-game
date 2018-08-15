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
            Console.CursorVisible = false;
            Console.SetCursorPosition(0, 0);
            if(Console.WindowWidth != WIDTH || Console.WindowHeight != HEIGHT)
            {
                Console.SetWindowSize(WIDTH, HEIGHT);
                Console.SetBufferSize(WIDTH, HEIGHT);
            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;

            Console.Clear();
        }

        public static void RenderLogo()
        {
            Console.SetCursorPosition(0, 1);
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine(@"$$$$$$$$\                                $$\                     $$\ ");
            Console.WriteLine(@"\__$$  __|                               \__|                    $$ |");
            Console.WriteLine(@"   $$ | $$$$$$\   $$$$$$\  $$$$$$\$$$$\  $$\ $$$$$$$\   $$$$$$\  $$ |");
            Console.WriteLine(@"   $$ |$$  __$$\ $$  __$$\ $$  _$$  _$$\ $$ |$$  __$$\  \____$$\ $$ |");
            Console.WriteLine(@"   $$ |$$$$$$$$ |$$ |  \__|$$ / $$ / $$ |$$ |$$ |  $$ | $$$$$$$ |$$ |");
            Console.WriteLine(@"   $$ |$$   ____|$$ |      $$ | $$ | $$ |$$ |$$ |  $$ |$$  __$$ |$$ |");
            Console.WriteLine(@"   $$ |\$$$$$$$\ $$ |      $$ | $$ | $$ |$$ |$$ |  $$ |\$$$$$$$ |$$ |");
            Console.WriteLine(@"   \__| \_______|\__|      \__| \__| \__|\__|\__|  \__| \_______|\__|");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("Pres any key to continue");

            Console.ReadKey();
            Console.SetCursorPosition(0, 0);
            Console.Clear();
        }

    }
}
