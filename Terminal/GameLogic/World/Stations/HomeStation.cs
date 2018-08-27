using System;
using System.Collections.Generic;
using System.Text;

namespace Terminal.GameLogic.World
{
    class HomeStation : AbstractStation
    {
        public HomeStation(Game game) : base(game)
        {
            Game = game;
            Name = "Home station Alpha";
        }

        public override void Init()
        {

        }

        public override void Update()
        {

        }
    }
}
