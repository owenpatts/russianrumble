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
                    map[i, j] = new Brick();
                    map[i, j].x = i;
                    map[i, j].y = j;
                }
            }
        }

        public void Update(int mousePosX, int mousePosY)
        {
            Console.WriteLine("Update");
            for (int i = 0; i < worldWidth; i++)
            {
                for (int j = 0; j < worldHeight; j++)
                {
                    Tile t = map[i, j];
                    t.Update(MouseInTile(i, j, mousePosX, mousePosY));
                }

            }
        }

        public void Draw(Graphics graphics)
        {
            Console.WriteLine("Draw");
            for (int i = 0; i < worldWidth; i++)
            {
                for (int j = 0; j < worldHeight; j++) {
                    Tile t = map[i, j];
                    t.Draw(graphics);
                }

            }
        }

        private bool MouseInTile(int tileIdxX, int tileIdxY, int mousePxX, int mousePxY)
        {
            int currentTileCoordinateX = Tile.tileSize * tileIdxX;
            int currentTileCoordinateY = Tile.tileSize * tileIdxY;
            Rectangle r = new Rectangle(currentTileCoordinateX, currentTileCoordinateY, Tile.tileSize, Tile.tileSize);
            return r.Contains(mousePxX, mousePxY);
        }
    }
}
