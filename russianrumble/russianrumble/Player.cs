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
        static Image texture = Properties.Resources.player;

        public override void Draw(Graphics graphics)
        {
            Point location = new Point(x * Tile.tileSize, y * Tile.tileSize);
            graphics.DrawImage(texture, location);
        }

        public override void Interact()
        {
            
        }

        public override void Move(int direction, World world)
        {
            int oldx = x;
            int oldy = y;
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

            // If another entity is already in that position, revert.
            foreach(Entity e in world.entities)
            {
                if (e.GetX() == x && e.GetY() == y)
                {
                    x = oldx;
                    y = oldy;
                }
            }
        }

        public override void Update(World world)
        {
            
        }
    }
}
