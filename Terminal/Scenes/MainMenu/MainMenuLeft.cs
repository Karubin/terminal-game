using System;
using System.Collections.Generic;
using System.Text;

namespace Terminal.Scenes.MainMenu
{
    class MainMenuLeft : Container
    {
        public MainMenuLeft(GameManager gameManager) : base(gameManager)
        {
            Column = 1;
            Row = 1;
            Width = 38;
            Height = 38;
            DisplayName = "MAIN MENU";
        }

        public override void Init()
        {
            ControlElements.Add(new Button(this, 0, 0, "PLAY"));
            ControlElements.Add(new Button(this, 0, 1, "OPTIONS"));
            ControlElements.Add(new Button(this, 0, 2, "CREDITS"));
            ControlElements.Add(new Button(this, 0, 3, "EXIT"));
        }

        public override bool HandleInputContainer(ConsoleKey key)
        {
            return false;
        }

        public override void IsSelectedChanged()
        {

        }

        public override void RenderContainer()
        {

        }
    }
}
