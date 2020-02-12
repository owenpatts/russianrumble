using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace russianrumble
{
    class Tile
    {
        int tileSize = 64;
        int textureVariation;
        public int x;
        public int y;
        static Image brickVar1 = Image.FromFile("C:\\Users\\Owen\\source\\repos\\russianrumble\\russianrumble\\russianrumble\\resources\\textures\\tiles\\brick1.png");
        static Image brickVar2 = Image.FromFile("C:\\Users\\Owen\\source\\repos\\russianrumble\\russianrumble\\russianrumble\\resources\\textures\\tiles\\brick2.png");
        static Image brickVar3 = Image.FromFile("C:\\Users\\Owen\\source\\repos\\russianrumble\\russianrumble\\russianrumble\\resources\\textures\\tiles\\brick3.png");


        public Tile(int textureVariation)
        {
            this.textureVariation = textureVariation;
            Console.WriteLine(textureVariation);
        }

        public void Draw(Graphics graphics)
        {
            Point location = new Point(x*tileSize, y*tileSize);
            switch(textureVariation) {
                case 1:
                    graphics.DrawImage(brickVar1, location);
                    break;
                case 2:
                    graphics.DrawImage(brickVar2, location);
                    break;
                case 3:
                    graphics.DrawImage(brickVar3, location);
                    break;
            }
            
        }
    }
}
