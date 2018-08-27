using System;
using System.Collections.Generic;
using System.Text;
using Terminal.GameLogic.World;

namespace Terminal.GameLogic
{
    class Game
    {
        GameManager GameManager;
        public Calendar Calendar;

        public AbstractStation CurrentStation { get; set; }

        public Game(GameManager gameManager)
        {
            GameManager = gameManager;
            Init();
        }

        public void Init()
        {

            CurrentStation = new HomeStation(this);

            Calendar = new Calendar(this);
        }

        public void Update()
        {
            Calendar.Update();
        }

    }
}
