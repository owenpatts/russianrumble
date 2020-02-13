using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace russianrumble
{
    class Player : Squatter
    {
        static Image texture = Image.FromFile("C:\\Users\\Owen\\source\\repos\\russianrumble\\russianrumble\\russianrumble\\resources\\textures\\entities\\player.png");

        public override void Draw(Graphics graphics)
        {
            Point location = new Point(x * Tile.tileSize, y * Tile.tileSize);
            graphics.DrawImage(texture, location);
        }

        public override void Move(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
