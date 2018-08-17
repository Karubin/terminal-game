using System;
using System.Collections.Generic;
using System.Text;

namespace Terminal.Scenes.MainMenu
{
    class MainMenuHelpContainer : Container
    {
        public MainMenuHelpContainer(GameManager gameManager) : base(gameManager)
        {
            Column = 1;
            Row = WindowManager.HEIGHT - 3;
            Width = WindowManager.WIDTH - 1;
            Height = 3;
            DisplayName = "CONTROLS";
        }

        public override bool HandleInputContainer(ConsoleKey key)
        {
            return false;
        }

        public override void Init()
        {

        }

        public override void IsSelectedChanged()
        {

        }

        public override void RenderContainer()
        {
            Console.SetCursorPosition(Column + 1, Row + 1);
            Console.Write("[Up/Down] Select button | [Tab] Select panel | [Enter] Press selected button");
        }
    }
}
