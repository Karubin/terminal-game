using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Terminal.Scenes;

namespace Terminal
{
    abstract class Scene
    {
        public GameManager GameManager;
        public Container SelectedContainer;
        public readonly List<Container> Containers;

        public Scene(GameManager gameManager)
        {
            GameManager = gameManager;
            Containers = new List<Container>();
            Init();
        }

        public abstract void Init();
        public abstract void Destroy();

        public void Render()
        {
            RenderScene();

            foreach(Container container in Containers)
            {
                container.Render();
            }

            WindowManager.ResetColors();

        }

        public abstract void RenderScene();

        public void HandleInput(ConsoleKey key)
        {

            /*
             * Generic scene always handles:
             *      - Tab to cycle through containers
             *      
             * Rest is sent to selected container
             */

            switch (key)
            {
                case ConsoleKey.Tab:
                    NextContainer();
                    break;
                default:
                    if (!HandleInputScene(key) && SelectedContainer != null)
                    {
                        SelectedContainer.HandleInput(key);
                    }
                    break;
            }
        }

        public abstract bool HandleInputScene(ConsoleKey key);

        protected void SelectContainer(Container container)
        {
            if(SelectedContainer != null)
            {
                SelectedContainer.Deselect();
            }
            SelectedContainer = container;
            SelectedContainer.Select();
        }

        protected void NextContainer()
        {
            if(Containers.Count == 0)
            {
                return;
            }
            if(SelectedContainer == null)
            {
                SelectContainer(Containers[0]);
                return;
            }
            var index = Containers.IndexOf(SelectedContainer);
            index++;
            index = (index < 0) ? Containers.Count - 1 : (index >= Containers.Count) ? 0 : index;
            SelectContainer(Containers[index]);
        }
    }
}
