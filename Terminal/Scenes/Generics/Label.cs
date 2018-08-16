using System;
using System.Collections.Generic;
using System.Text;

namespace Terminal.Scenes
{
    class Label : Element
    {
        public Label(Container container, int column, int row, string displayName) : base(container, column, row, displayName)
        {
        }

        public override void RenderElement()
        {
        }
    }
}
