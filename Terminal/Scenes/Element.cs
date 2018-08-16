using System;
using System.Collections.Generic;
using System.Text;

namespace Terminal.Scenes
{
    abstract class Element
    {
        public int Column { get; set; }
        public int Height { get; set; }

        public Element(Container container)
        {

        }

        public abstract void HandleInput(ConsoleKey key);

    }
}
