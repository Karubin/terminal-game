using System;
using System.Collections.Generic;
using System.Text;

namespace Terminal.Scenes
{
    class MainMenu : Scene
    {
        public MainMenu(GameManager gameManager) : base(gameManager) {}

        public override void Init()
        {

        }

        public override void Destroy()
        {
            throw new NotImplementedException();
        }

        public override void RenderScene()
        {
            Console.SetCursorPosition(4, 4);
            Console.Write("Main menu");
        }

        public override bool HandleInputScene(ConsoleKey key)
        {
            return false;
        }
    }
}
