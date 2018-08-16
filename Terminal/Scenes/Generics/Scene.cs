using System;
using System.Collections.Generic;
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

        }

        public abstract void RenderScene();

        public void HandleInput(ConsoleKey key)
        {
            if (!HandleInputScene(key) && SelectedContainer != null)
            {
                SelectedContainer.HandleInput(key);
            }
        }

        public abstract bool HandleInputScene(ConsoleKey key);

        private void SelectContainer(Container container)
        {
            if(SelectedContainer != null)
            {
                SelectedContainer.Deselect();
            }
            SelectedContainer = container;
            SelectedContainer.Select();
        }
    }
}
