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
            Console.ForegroundColor = (IsSelected) ? ConsoleColor.Red : ConsoleColor.White;
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
            Console.ForegroundColor = ConsoleColor.White;
            foreach (ControlElement el in ControlElements)
            {
                el.Render();
            }
            RenderContainer();
            WindowManager.ResetColors();
        }

        public abstract void RenderContainer();

        public void HandleInput(ConsoleKey key)
        {
            /*
             * Generic container always handles:
             *      - up/down arrows to cycle through control elements
             *      - enter to activate selected control element
             * 
             * Rest is handled either by child container or selected control element
             */
            switch (key)
            {
                case ConsoleKey.UpArrow:
                    PreviousElement();
                    break;
                case ConsoleKey.DownArrow:
                    NextElement();
                    break;
                case ConsoleKey.Enter:
                    if(SelectedElement.Activate != null)
                    {
                        SelectedElement.Activate();
                    }
                    break;
                default:
                    if (!HandleInputContainer(key) && SelectedElement != null)
                    {
                        SelectedElement.HandleInput(key);
                    }
                    break;

            }
        }

        public abstract bool HandleInputContainer(ConsoleKey key);

        public void SelectElement(ControlElement element)
        {
            if(SelectedElement != null)
            {
                SelectedElement.Deselect();
            }
            SelectedElement = element;
            SelectedElement.Select();
        }

        public void NextElement()
        {
            if(ControlElements.Count == 0)
            {
                return;
            }
            if(SelectedElement == null)
            {
                SelectElement(ControlElements[0]);
            }
            else
            {
                var index = ControlElements.IndexOf(SelectedElement);
                var maxIndex = ControlElements.Count - 1;
                index++;
                index = (index < 0) ? maxIndex : (index > maxIndex) ? 0 : index;
                SelectElement(ControlElements[index]);
            }
        }

        public void PreviousElement()
        {
            if (ControlElements.Count == 0)
            {
                return;
            }
            if (SelectedElement == null)
            {
                SelectElement(ControlElements[0]);
            }
            else
            {
                var index = ControlElements.IndexOf(SelectedElement);
                var maxIndex = ControlElements.Count - 1;
                index--;
                index = (index < 0) ? maxIndex : (index > maxIndex) ? 0 : index;
                SelectElement(ControlElements[index]);
            }
        }

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
