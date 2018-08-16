using System;
using System.Collections.Generic;
using System.Text;

namespace Terminal.Scenes.MainMenu
{
    class MainMenu : Scene
    {
        public MainMenu(GameManager gameManager) : base(gameManager) {}

        public override void Init()
        {
            Containers.Add(new MainMenuLeft(this.GameManager));
        }

        public override void Destroy()
        {
            throw new NotImplementedException();
        }

        public override void RenderScene()
        {

        }

        public override bool HandleInputScene(ConsoleKey key)
        {
            return false;
        }
    }
}
