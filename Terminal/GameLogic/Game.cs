using System;
using System.Collections.Generic;
using System.Text;

namespace Terminal.GameLogic
{
    class Game
    {
        GameManager GameManager;
        public Calendar Calendar;

        public Game(GameManager gameManager)
        {
            GameManager = gameManager;
            Init();
        }

        public void Init()
        {
            Calendar = new Calendar(this);
        }

        public void Update()
        {
            Calendar.Update();
        }

    }
}
