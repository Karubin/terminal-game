using System;
using System.Collections.Generic;
using System.Text;

namespace Terminal.Scenes.MainMenu
{
    class MainMenuScene : Scene
    {
        public MainMenuScene(GameManager gameManager) : base(gameManager) {}

        public override void Init()
        {
            Containers.Add(new NavigationContainer(this.GameManager));
            Containers.Add(new MainMenuHelpContainer(GameManager));

            SelectContainer(Containers[0]);
        }

        public override void Destroy()
        {

        }

        public override void RenderScene()
        {
            WindowManager.DrawImage(48, 8, WindowManager.TrainImage, ConsoleColor.Red);
        }

        public override bool HandleInputScene(ConsoleKey key)
        {
            return false;
        }
    }
}
