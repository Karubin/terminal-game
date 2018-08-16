using System;
using System.Collections.Generic;
using System.Text;

namespace Terminal.Scenes.Game
{
    class CalendarContainer : Container
    {
        public CalendarContainer(GameManager gameManager) : base(gameManager)
        {
            Column = 1;
            Row = 1;
            Width = 178;
            Height = 3;
            DisplayName = "CALENDAR";
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
            string text = "TIME: 13:00 | DAY: 07 | MONTH: 10 | YEAR: 1916";
            Console.SetCursorPosition((Width-text.Length)/2, Row + 1);
            Console.Write(text);
        }
    }
}
