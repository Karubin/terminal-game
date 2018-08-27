using System;
using System.Collections.Generic;
using System.Text;

namespace Terminal.Scenes
{
    class Button : ControlElement
    {
        public Button(Container container, int column, int row, string displayName) : base(container, column, row, displayName)
        {
        }

        public override void HandleInput(ConsoleKey key)
        {

        }

        public override void IsSelectedChanged()
        {
            if (IsSelected)
            {
                ForegroundColor = ConsoleColor.Black;
                BackgroundColor = ConsoleColor.Gray;
            }
            else
            {
                ForegroundColor = ConsoleColor.White;
                BackgroundColor = ConsoleColor.Black;
            }
        }

        public override void RenderElement()
        {
            Console.ForegroundColor = ForegroundColor;
            Console.BackgroundColor = BackgroundColor;
            Console.SetCursorPosition(Column, Row);
            string text = IsSelected ? ">" + DisplayName : "" + DisplayName;
            Console.Write(text);
        }
    }
}
