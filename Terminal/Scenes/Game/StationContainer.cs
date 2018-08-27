using System;
using System.Collections.Generic;
using System.Text;

namespace Terminal.Scenes.Game
{
    class StationContainer : Container
    {
        public StationContainer(GameManager gameManager) : base(gameManager)
        {
            Column = 40;
            Row = 4;
            Width = 138;
            Height = 38;
            DisplayName = "STATION";
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
            SetCursorPosition(1, 1);
            Console.Write("CURRENT STATION: " + GameManager.Game.CurrentStation.Name);
        }
    }
}
