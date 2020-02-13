﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace russianrumble
{
    class Game
    {
        public World world = new World();
        public Player player = new Player();

        public void Update(int MousePosX, int MousePosY, Graphics g)
        {
            world.Update(MousePosY, MousePosX, g);
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
    }
}
