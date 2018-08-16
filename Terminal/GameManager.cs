using System;
using System.Collections.Generic;
using System.Text;
using Terminal.Scenes;
using Terminal.Scenes.MainMenu;

namespace Terminal
{
    class GameManager
    {

        private bool isRunning;
        private Scene ActiveScene;

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
            SetScene(new MainMenuScene(this));

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
            WindowManager.Init();
            Destroy();
        }

        public void Destroy()
        {
            WindowManager.Init();
            WindowManager.RenderLogo();
        }

        #endregion

        public void SetScene(Scene scene)
        {
            if(ActiveScene != null)
            {
                ActiveScene.Destroy();
            }
            ActiveScene = scene;
        }

        private void HandleInput(ConsoleKey key)
        {
            switch (key)
            {
                case ConsoleKey.F12:
                    Stop();
                    break;
                default:
                    ActiveScene.HandleInput(key);
                    break;
            }
        }

        private void Render()
        {
            WindowManager.Init();
            ActiveScene.Render();
        }

    }
}
