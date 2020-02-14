using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace russianrumble
{
    interface iGameState
    {
        void Update();

        void Draw(Graphics g);

        void HandleKeyPress(char key);

        void HandleMouseClick();
    }
}
