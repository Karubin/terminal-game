using System;
using System.Collections.Generic;
using System.Text;

namespace Terminal.Scenes.Game
{
    class TravelScene : Scene
    {
        public TravelScene(GameManager gameManager) : base(gameManager)
        {
        }

        public override void Init()
        {
            Containers.Add(new PlayNavigationContainer(GameManager));
            Containers.Add(new CalendarContainer(GameManager));

            SelectContainer(Containers[0]);
        }

        public override void Destroy()
        {

        }

        public override void RenderScene()
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
    }
}
