using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace russianrumble
{
    class Crate : Tile
    {
        public Crate(int x, int y)
        {
            this.x = x;
            this.y = y;
            walkable = false;

        }

        static Image textureClosed = Image.FromFile("C:\\Users\\Owen\\source\\repos\\russianrumble\\russianrumble\\russianrumble\\resources\\textures\\tiles\\box.png");
        static Image textureOpen = Image.FromFile("C:\\Users\\Owen\\source\\repos\\russianrumble\\russianrumble\\russianrumble\\resources\\textures\\tiles\\box_open.png");
        public override void Draw(Graphics graphics)
        {
            Point location = new Point(x * tileSize, y * tileSize);
            if (hovered)
            {
                graphics.DrawImage(textureOpen, location);
            } else
            {
                graphics.DrawImage(textureClosed, location);
            }
        }

        public override void Interact()
        {
            throw new NotImplementedException();
        }

        public override void Update(bool hover)
        {
            this.hovered = hover;
        }
    }
}
