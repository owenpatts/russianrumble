﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace russianrumble
{
    class InventoryState : iGameState
    {
        Game game;
        private float inventoryHeightModifier = 0.8f;
        private float inventoryWidthModifier = 0.7f;
        private float border;
        private float previewDescRelHeight = 0.3f;
        private int marginSize;
        private ArrayList buttons = new ArrayList();

        public InventoryState(Game game)
        {
            this.game = game;
        }

        public void Draw(Graphics g)
        {
            marginSize = GameProperties.screenWidth / 30;
            border = GameProperties.screenWidth / 480;
            int inventoryHeight = (int) (GameProperties.screenHeight * inventoryHeightModifier);
            int inventoryWidth  = (int) (GameProperties.screenWidth * inventoryWidthModifier);
            int originY = ((GameProperties.screenHeight - inventoryHeight) / 2);
            int originX = ((GameProperties.screenWidth - inventoryWidth) / 2);
            
            int previewSize = (int)(inventoryHeight * previewDescRelHeight);
            int previewOriginX = originX + marginSize;
            int previewOriginY = originY + marginSize;

            int descriptionOriginX = previewSize + previewOriginX + marginSize;
            int descriptionOriginY = originY + marginSize;
            int descriptionWidth = inventoryWidth - previewSize - marginSize * 3;
            int descriptionHeight = previewSize;

            int contentsOriginX = originX + marginSize;
            int contentsOriginY = originY + previewSize + marginSize * 2;
            int contentsHeight = inventoryHeight - previewSize - marginSize * 3;
            int contentsWidth = inventoryWidth - marginSize * 2;

            int scrollButtonSize = contentsHeight / 5;
            int scrollButtonTopOriginX = contentsOriginX + contentsWidth - scrollButtonSize;
            int scrollButtonTopOriginY = contentsOriginY;
            int scrollButtonBotOriginX = contentsOriginX + contentsWidth - scrollButtonSize;
            int scrollButtonBotOriginY = contentsOriginY + contentsHeight - scrollButtonSize;

            Rectangle inventory = new Rectangle(originX, originY, inventoryWidth, inventoryHeight);
            Rectangle preview = new Rectangle(previewOriginX, previewOriginY, previewSize, previewSize);
            Rectangle description = new Rectangle(descriptionOriginX, descriptionOriginY, descriptionWidth, descriptionHeight);
            Rectangle contents = new Rectangle(contentsOriginX, contentsOriginY, contentsWidth, contentsHeight);
            Rectangle scrollButtonTop = new Rectangle(scrollButtonTopOriginX, scrollButtonTopOriginY, scrollButtonSize, scrollButtonSize);
            Rectangle scrollButtonBot = new Rectangle(scrollButtonBotOriginX, scrollButtonBotOriginY, scrollButtonSize, scrollButtonSize);

            g.DrawRectangle(new Pen(Brushes.LightGray, border), inventory);
            g.DrawRectangle(new Pen(Brushes.Red, border), preview);
            g.DrawRectangle(new Pen(Brushes.Red, border), description);
            g.DrawRectangle(new Pen(Brushes.Red, border), contents);
            g.DrawRectangle(new Pen(Brushes.Red, border), scrollButtonBot);
            buttons.Add(new ScrollButtonUp(scrollButtonTopOriginX, scrollButtonTopOriginY, scrollButtonSize));

            foreach (Button b in buttons)
            {
                b.Draw(g);
            }
        }

        public void HandleKeyPress(char key)
        {
            if(key == 'e')
            {
                game.ReturnToLastState();
            }
        }

        public void HandleMouseClick()
        {
            
        }

        public void Update()
        {

        }
    }
}
