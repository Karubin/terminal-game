using System;
using System.Collections.Generic;
using System.Text;

namespace Terminal.Scenes.MainMenu
{
    class CreditsScene : Scene
    {
        public CreditsScene(GameManager gameManager) : base(gameManager)
        {
        }

        public override void Destroy()
        {

        }

        public override bool HandleInputScene(ConsoleKey key)
        {
            switch (key)
            {
                default:
                    return false;
            }
        }

        public override void Init()
        {
            Containers.Add(new NavigationContainer(GameManager));
            Containers.Add(new CreditsCenterContainer(GameManager));
            SelectContainer(Containers[1]);
        }

        public override void RenderScene()
        {

        }
    }
}
