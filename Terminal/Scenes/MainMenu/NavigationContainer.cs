using System;
using System.Collections.Generic;
using System.Text;
using Terminal.Scenes.Game;

namespace Terminal.Scenes.MainMenu
{
    class NavigationContainer : Container
    {
        public NavigationContainer(GameManager gameManager) : base(gameManager)
        {
            Column = 1;
            Row = 1;
            Width = 38;
            Height = 38;
            DisplayName = "MAIN MENU";
        }

        public override void Init()
        {
            ControlElements.Add(new Button(this, 0, 0, "PLAY") {Activate= PressedPlay });
            ControlElements.Add(new Button(this, 0, 1, "HELP") { Activate = PressedOptions});
            ControlElements.Add(new Button(this, 0, 2, "CREDITS") { Activate = PressedCredits});
            ControlElements.Add(new Button(this, 0, 3, "EXIT") { Activate = PressedExit} );

            SelectElement(ControlElements[0]);
        }

        public override bool HandleInputContainer(ConsoleKey key)
        {
            return false;
        }

        public override void IsSelectedChanged()
        {

        }

        public override void RenderContainer()
        {

        }

        /*
         * Methods for control elements
         */

        public void PressedPlay()
        {
            GameManager.SetScene(new TravelScene(GameManager));
        }

        public void PressedOptions()
        {
            GameManager.SetScene(new OptionsScene(GameManager));
        }

        public void PressedCredits()
        {
            GameManager.SetScene(new CreditsScene(GameManager));
        }

        public void PressedExit()
        {
            GameManager.Stop();
        }
    }
}
