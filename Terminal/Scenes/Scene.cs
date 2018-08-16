using System;
using System.Collections.Generic;
using System.Text;

namespace Terminal
{
    abstract class Scene
    {
        GameManager GameManager;
        Container SelectedContainer;
        List<Container> Containers;

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
            HandleInput(key);
        }

        public abstract void HandleInputScene(ConsoleKey key);

        private void SelectContainer(Container container)
        {

        }
    }
}
