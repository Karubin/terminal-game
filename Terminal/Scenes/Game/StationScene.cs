using System;
using System.Collections.Generic;
using System.Text;

namespace Terminal.Scenes.Game
{
    class StationScene : Scene
    {
        public StationScene(GameManager gameManager) : base(gameManager)
        {
        }

        public override void Init()
        {
            Containers.Add(new PlayNavigationContainer(GameManager));
            Containers.Add(new StationContainer(GameManager));

            Containers.Add(new CalendarContainer(GameManager));

            SelectContainer(Containers[0]);
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

        public override void RenderScene()
        {

        }
    }
}
