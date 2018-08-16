using System;
using System.Collections.Generic;
using System.Text;
using Terminal.Scenes.MainMenu;

namespace Terminal.Scenes.Game
{
    class PlayNavigationContainer : Container
    {
        public PlayNavigationContainer(GameManager gameManager) : base(gameManager)
        {
        }

        public override void Init()
        {
            Column = 1;
            Row = 4;
            Width = 38;
            Height = 38;
            DisplayName = "";

            ControlElements.Add(new Button(this, 0, 0, "TRAVEL"));
            ControlElements.Add(new Button(this, 0, 1, "CREW"));
            ControlElements.Add(new Button(this, 0, 2, "INVENTORY"));
            ControlElements.Add(new Button(this, 0, 3, "STATION"));
            ControlElements.Add(new Button(this, 0, 4, "TRAIN"));
            ControlElements.Add(new Button(this, 0, 5, "LOG"));

            ControlElements.Add(new Button(this, 0, 7, "TURN") { Activate = PressedTurn});

            ControlElements.Add(new Button(this, 0, Height - 7, "HELP"));
            ControlElements.Add(new Button(this, 0, Height - 6, "SAVE"));
            ControlElements.Add(new Button(this, 0, Height - 5, "MAIN MENU") { Activate = MainMenuPressed });

            SelectElement(ControlElements[0]);
        }

        public override bool HandleInputContainer(ConsoleKey key)
        {
            switch (key)
            {
                default:
                    return false;
            }
        }

        public override void RenderContainer()
        {

        }

        public override void IsSelectedChanged()
        {

        }

        public void PressedTurn()
        {
            GameManager.Game.Update();
        }

        public void MainMenuPressed()
        {
            GameManager.SetScene(new MainMenuScene(GameManager));
        }
    }
}
