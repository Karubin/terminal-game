using System;
using System.Collections.Generic;
using System.Text;

namespace Terminal.GameLogic.World
{
    abstract class AbstractStation
    {
        public Game Game;
        public string Name { get; set; }

        public AbstractStation(Game game)
        {
            Game = game;

            Init();
        }

        public abstract void Init();
        public abstract void Update();
    }
}
