using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace russianrumble
{
    class Game
    {
        World world = new World();
        Player player = new Player();

        public void Update(int MousePosX, int MousePosY)
        {
            world.Update(MousePosY, MousePosX);
        }

        public void Draw(Graphics graphics)
        {
            world.Draw(graphics);
            player.Draw(graphics);
        }

        public void Click(int x, int y)
        {
            x /= Tile.tileSize;
            y /= Tile.tileSize;
            player.Move(x, y);
        }
    }
}
