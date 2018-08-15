using System;
using System.Collections.Generic;
using System.Text;

namespace Terminal
{
    class GameManager
    {

        private bool isRunning;

        #region LIFECYCLE

        public void Init()
        {
            // set up window size etc
            WindowManager.Init();

            // load resources

            // splash screen / credits
            WindowManager.RenderLogo();

            //Start
            Start();
        }

        public void Start()
        {
            isRunning = true;
            Run();
        }

        public void Run()
        {
            while (isRunning)
            {
                Render();
                ConsoleKey key = Console.ReadKey().Key;
                HandleInput(key);
            }
        }

        public void Stop()
        {
            isRunning = false;

            Destroy();
        }

        public void Destroy()
        {
            WindowManager.RenderLogo();
        }

        #endregion

        private void HandleInput(ConsoleKey key)
        {
            switch (key)
            {
                case ConsoleKey.F12:
                    Stop();
                    break;
                default:
                    break;
            }
        }

        private void Render()
        {
            WindowManager.Init();
        }

    }
}
