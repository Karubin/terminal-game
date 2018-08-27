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

            ControlElements.Add(new Button(this, 0, 0, "TRAVEL") { Activate = TravelPressed });
            ControlElements.Add(new Button(this, 0, 1, "CREW") { Activate = CrewPressed });
            ControlElements.Add(new Button(this, 0, 2, "INVENTORY") { Activate = InventoryPressed });
            ControlElements.Add(new Button(this, 0, 3, "STATION") { Activate = StationPressed });
            ControlElements.Add(new Button(this, 0, 4, "TRAIN") { Activate = TrainPressed });
            ControlElements.Add(new Button(this, 0, 5, "LOG") { Activate = LogPressed });

            ControlElements.Add(new Button(this, 0, 7, "TURN") { Activate = PressedTurn });

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

        public void TravelPressed()
        {

        }

        public void CrewPressed()
        {

        }

        public void InventoryPressed()
        {

        }

        public void StationPressed()
        {
            GameManager.SetScene(new StationScene(GameManager));
        }

        public void TrainPressed()
        {

        }

        public void LogPressed()
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
