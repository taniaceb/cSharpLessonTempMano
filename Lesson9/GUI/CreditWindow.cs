﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson9.GUI
{
    class CreditWindow : Window
    {
        private Button _backButton;

        private TextBlock _creditTextBlock;

        public CreditWindow() : base (28,10,60,18,'@')
        {
            List<String> creditData = new List<string>();
            creditData.Add("");
            creditData.Add("Game design:");
            creditData.Add("Vardas Vardaitis");
            creditData.Add("");
            creditData.Add("Programuotojas:");
            creditData.Add("Vardas Vardaitis");
            creditData.Add("");
            creditData.Add("\'Art\':");
            creditData.Add("Vardas Vardaitis");
            creditData.Add("");
            creditData.Add("Marketingas:");
            creditData.Add("Vardas Vardaitis");
            creditData.Add("");

            _creditTextBlock = new TextBlock(28 + 1, 10 + 1, 60 - 1, creditData);
            _backButton = new Button(28 + 20, 10 + 14, 18, 3, "Back");
            _backButton.SetActive();
            
        }
        public new void Render()
        {
            base.Render();
            _creditTextBlock.Render();
            _backButton.Render();

            Console.SetCursorPosition(0, 0);
        }
    }
}
