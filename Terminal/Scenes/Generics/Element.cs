using System;
using System.Collections.Generic;
using System.Text;

namespace Terminal.Scenes
{
    abstract class Element
    {
        public int Column { get; set; }
        public int Row { get; set; }
        public string DisplayName { get; set; }
        public ConsoleColor ForegroundColor { get; set; }
        public ConsoleColor BackgroundColor { get; set; }

        public Element(Container container, int column, int row, string displayName)
        {
            Column = container.Column + column + 2;
            Row = container.Row + row + 2;
            DisplayName = displayName;

            ForegroundColor = ConsoleColor.White;
            BackgroundColor = ConsoleColor.Black;
        }
        public void Render()
        {
            RenderElement();
        }
        public abstract void RenderElement();

    }
}
