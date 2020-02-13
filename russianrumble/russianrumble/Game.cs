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
        private int mousePosX;
        private int mousePosY;

        public World world;
        public Player player = new Player();

        public Game()
        {
            world = new World(this);
        }

        public void Update(int mousePosX, int mousePosY, Graphics g)
        {
            world.Update(mousePosX, mousePosY, g);
            this.mousePosX = mousePosX;
            this.mousePosY = mousePosY;
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
            //player.Move(x, y);
        }

        public int GetMousePosX()
        {
            return mousePosX;
        }

        public int GetMousePosY()
        {
            return mousePosY;
        }
    }
}
