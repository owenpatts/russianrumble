using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Collections;

namespace russianrumble
{
    class World
    {
        static int worldHeight = 18;
        static int worldWidth = 30;

        public Tile[,] map;
        public ArrayList entities = new ArrayList();
        
        public Game game;

        public World(Game game)
        {
            // placing tiles
            this.game = game;
            Random rand = new Random();
            map = new Tile[worldWidth, worldHeight];
            for(int i = 0; i < worldWidth; i++)
            {
                for(int j = 0; j < worldHeight; j++)
                {
                    map[i, j] = new Floor(i, j);
                }
            }

            // Populating chests
            int numberOfChests = rand.Next(1, 20);
            for (int i = 0; i < numberOfChests; i++)
            {
                int chestPosX = rand.Next(0, worldWidth);
                int chestPoxY = rand.Next(0, worldHeight);

                bool locationTaken = false;
                foreach (Entity e in entities) {
                    if (e.GetX() == chestPosX && e.GetY() == chestPoxY)
                    {
                        locationTaken = true;
                    }
                }
                if (!locationTaken)
                    entities.Add(new Crate(chestPosX, chestPoxY));
            }

        }

        public void Update(int mousePosX, int mousePosY)
        {
            for (int i = 0; i < worldWidth; i++)
            {
                for (int j = 0; j < worldHeight; j++)
                {
                    Tile t = map[i, j];
                    t.Update(MouseInTile(i, j, mousePosX, mousePosY));
                }

            }
            foreach(Entity e in entities)
            {
                e.Update(this);
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
            foreach (Entity e in entities)
            {
                e.Draw(graphics);
            }
        }
        /// <summary>
        /// Checks if the mouse is inside the given tile
        /// </summary>
        /// <param name="tileIdxX"></param>
        /// <param name="tileIdxY"></param>
        /// <param name="mousePxX"></param>
        /// <param name="mousePxY"></param>
        /// <param name="g"></param>
        /// <returns></returns>
        private bool MouseInTile(int tileIdxX, int tileIdxY, int mousePxX, int mousePxY)
        {
            int currentTileCoordinateX = Tile.tileSize * tileIdxX;
            int currentTileCoordinateY = Tile.tileSize * tileIdxY;
            Rectangle r = new Rectangle(currentTileCoordinateX, currentTileCoordinateY, Tile.tileSize, Tile.tileSize);
            return r.Contains(mousePxX, mousePxY);
        }
    }
}
