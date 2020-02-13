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
                    map[i, j] = new Brick(i, j);
                }
            }

            map[7, 7] = new Crate(7, 7);
            map[8, 13] = new Crate(8, 13);
        }

        public void Update(int mousePosX, int mousePosY, Graphics g)
        {
            for (int i = 0; i < worldWidth; i++)
            {
                for (int j = 0; j < worldHeight; j++)
                {
                    Tile t = map[i, j];
                    t.Update(MouseInTile(i, j, mousePosX, mousePosY, g));
                }

            }
        }

        public void Draw(Graphics graphics)
        {
            for (int i = 0; i < worldWidth; i++)
            {
                for (int j = 0; j < worldHeight; j++) {
                    Tile t = map[i, j];
                    t.Draw(graphics);
                }

            }
        }

        private bool MouseInTile(int tileIdxX, int tileIdxY, int mousePxX, int mousePxY, Graphics g)
        {
            int currentTileCoordinateX = Tile.tileSize * tileIdxX;
            int currentTileCoordinateY = Tile.tileSize * tileIdxY;
            Rectangle r = new Rectangle(currentTileCoordinateX, currentTileCoordinateY, Tile.tileSize, Tile.tileSize);
            Pen p = new Pen(Brushes.White);
            p.Width = 1F;
            //g.DrawRectangle(p, r);
            return r.Contains(mousePxY, mousePxX);
        }
    }
}
