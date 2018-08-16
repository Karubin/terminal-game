using System;
using System.Collections.Generic;
using System.Text;

namespace Terminal.Scenes.MainMenu
{
    class OptionsCenterContainer : Container
    {
        public OptionsCenterContainer(GameManager gameManager) : base(gameManager)
        {
            Column = 40;
            Row = 1;
            Width = 98;
            Height = 38;
            DisplayName = "OPTIONS";
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
        }
    }
}
