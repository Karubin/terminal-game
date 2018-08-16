using System;
using System.Collections.Generic;
using System.Text;

namespace Terminal.Scenes.MainMenu
{
    class OptionsScene : Scene
    {
        public OptionsScene(GameManager gameManager) : base(gameManager)
        {
        }

        public override void Destroy()
        {
        }

        public override bool HandleInputScene(ConsoleKey key)
        {
            return false;
        }

        public override void Init()
        {
            Containers.Add(new NavigationContainer(this.GameManager));
            Containers.Add(new OptionsCenterContainer(this.GameManager));
            SelectContainer(Containers[1]);
        }

        public override void RenderScene()
        {
        }
    }
}
