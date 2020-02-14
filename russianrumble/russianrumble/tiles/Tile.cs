using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace russianrumble
{
    abstract class Tile
    {
        public static int tileSize = 64;
        public static int maxHighlightOpacity = 50;
        public int x;
        public int y;
        public bool walkable;
        public bool hovered;

        public abstract void Draw(Graphics graphics);

        public abstract void Update(bool hover);

        public abstract void Interact();
    }
}
