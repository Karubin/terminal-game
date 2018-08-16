using System;
using System.Collections.Generic;
using System.Text;

namespace Terminal.Scenes
{
    abstract class Container
    {

        public GameManager GameManager;

        public int Column { get; set; }
        public int Row { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public string DisplayName { get; set; }

        public bool IsSelected { get; set; }

        public ControlElement SelectedElement;
        public List<ControlElement> ControlElements;

        public Container(GameManager gameManager)
        {
            GameManager = gameManager;
            ControlElements = new List<ControlElement>();
            Init();
        }

        public abstract void Init();

        public void Render()
        {
            Console.SetCursorPosition(Column, Row);
            for(int i = 0; i < Width/2; i++)
            {
                Console.Write("-");
            }
            Console.Write(DisplayName);
            for (int i = 0; i < Width / 2; i++)
            {
                Console.Write("-");
            }

            foreach (ControlElement el in ControlElements)
            {
                el.Render();
            }
            RenderContainer();
        }

        public abstract void RenderContainer();

        public void HandleInput(ConsoleKey key)
        {
            if (!HandleInputContainer(key) && SelectedElement != null)
            {
                SelectedElement.HandleInput(key);
            }
        }

        public abstract bool HandleInputContainer(ConsoleKey key);


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


    }
}
