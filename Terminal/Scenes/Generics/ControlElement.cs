using System;
using System.Collections.Generic;
using System.Text;

namespace Terminal.Scenes
{
    abstract class ControlElement : Element
    {
        public bool IsSelected { get; set; }

        public ControlElement(Container container, int column, int row, string displayName) : base(container, column, row, displayName)
        {
        }

        public abstract void HandleInput(ConsoleKey key);
        public void Select()
        {
            IsSelected = true;
            IsSelectedChanged();
        }
        public void Deselect()
        {
            IsSelected = false;
            IsSelectedChanged();
        }
        public abstract void IsSelectedChanged();

        public Action Activate;
    }
}
