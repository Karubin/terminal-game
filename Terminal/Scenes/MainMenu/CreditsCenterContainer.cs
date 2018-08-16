using System;
using System.Collections.Generic;
using System.Text;

namespace Terminal.Scenes.MainMenu
{
    class CreditsCenterContainer : Container
    {
        public CreditsCenterContainer(GameManager gameManager) : base(gameManager)
        {
            Column = 40;
            Row = 1;
            Width = 138;
            Height = 38;
            DisplayName = "CREDITS";
        }

        public override bool HandleInputContainer(ConsoleKey key)
        {
            switch (key)
            {
                default:
                    return false;
            }
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
