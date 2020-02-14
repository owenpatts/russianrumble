using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace russianrumble
{
    class Crate : Entity
    {
        protected bool interactable;

        public Crate(int x, int y)
        {
            this.x = x;
            this.y = y;

        }

        static Image textureClosed = Properties.Resources.box;
        static Image textureOpen = Properties.Resources.box_open;
        public override void Draw(Graphics graphics)
        {
            Point location = new Point(x * Tile.tileSize, y * Tile.tileSize);
            if (interactable)
            {
                graphics.DrawImage(textureOpen, location);
            } else
            {
                graphics.DrawImage(textureClosed, location);
            }
        }

        public override void Interact()
        {
            world.game.SetState(new InventoryState(world.game));
        }

        public override void Update(World world)
        {
            this.world = world;
            interactable = (checkHover() && checkAdjacent(world.game.Player.GetX(), world.game.Player.GetY()));
        }
    }
}
