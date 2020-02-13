﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace russianrumble
{
    class Brick : Tile
    {
        static Image texture = Image.FromFile("C:\\Users\\Owen\\source\\repos\\russianrumble\\russianrumble\\russianrumble\\resources\\textures\\tiles\\brick1.png");
        private int highlightAmt;

        public Brick(int x, int y)
        {
            walkable = true;
            this.x = x;
            this.y = y;
            
        }

        public override void Draw(Graphics graphics)
        {
            Point location = new Point(x * tileSize, y * tileSize);
            graphics.DrawImage(texture, location);

            if (highlightAmt > 0)
            {
                SolidBrush highlight = new SolidBrush(Color.FromArgb(highlightAmt, 255, 255, 255));
                graphics.FillRectangle(highlight, x * tileSize, x * tileSize, Tile.tileSize, Tile.tileSize);
            }
        }
        
        public override void Update(bool hover)
        {
            // Highlighting code:
            if (hover)
            {
                this.hovered = true;
                if (this.highlightAmt < maxHighlightOpacity)
                {
                    this.highlightAmt += this.highlightAmt + 1;
                }
            } else
            {
                if (this.highlightAmt > 0)
                {
                    this.highlightAmt -= 5;
                }
            }

            if (highlightAmt > maxHighlightOpacity)
                highlightAmt = maxHighlightOpacity;
            if (highlightAmt < 0)
                highlightAmt = 0;
        }

        public override void Interact()
        {
            throw new NotImplementedException();
        }
    }
}
