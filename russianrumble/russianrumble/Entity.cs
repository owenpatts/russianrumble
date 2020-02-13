using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace russianrumble
{
    internal abstract class Entity
    {
        protected int x;
        protected int y;

        public int GetX()
        {
            return x;
        }

        public int GetY()
        {
            return y;
        }

        public abstract void Update(World world);

        public abstract void Draw(Graphics g);

        public abstract void Interact();

        public bool checkHover(World world)
        {
            int mousePxX = world.game.GetMousePosX();
            int mousePxY = world.game.GetMousePosY();
            int currentTileCoordinateX = Tile.tileSize * x;
            int currentTileCoordinateY = Tile.tileSize * y;
            Rectangle r = new Rectangle(currentTileCoordinateX, currentTileCoordinateY, Tile.tileSize, Tile.tileSize);
            return r.Contains(mousePxX, mousePxY);
        }

        public bool checkAdjacent(int otherPosX, int otherPosY)
        {
            return ((otherPosX == x + 1 || otherPosX == x - 1 && otherPosY == y) || (otherPosY == y + 1 || otherPosY == y - 1 && otherPosX == x));
        }
    }
}