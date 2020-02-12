using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace russianrumble
{
    class World
    {
        static int worldHeight = 18;
        static int worldWidth = 30;

        Tile[,] map;

        public World()
        {
            Random rand = new Random();
            map = new Tile[worldWidth, worldHeight];
            for(int i = 0; i < worldWidth; i++)
            {
                for(int j = 0; j < worldHeight; j++)
                {
                    map[i, j] = new Tile(rand.Next(1,4));
                    map[i, j].x = i;
                    map[i, j].y = j;
                }
            }
        }

        public void Draw(Graphics graphics)
        {
            foreach(Tile t in map)
            {
                t.Draw(graphics);
            }
        }
    }
}
