using System;
using System.Collections.Generic;
using System.Text;

namespace Terminal
{
    abstract class Container
    {

        public void Render()
        {
            RenderContainer();
        }

        public abstract void RenderContainer();

    }
}
