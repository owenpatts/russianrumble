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

        public override void Move(int direction)
        {
            if(direction == Direction.UP)
            {
                y -= 1;
            } else if (direction == Direction.DOWN)
            {
                y += 1;
            }
            else if (direction == Direction.LEFT)
            {
                x -= 1;
            }
            else if (direction == Direction.RIGHT)
            {
                x += 1;
            }
            Console.WriteLine(x);
        }
    }
}
