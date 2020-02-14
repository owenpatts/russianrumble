using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace russianrumble
{
    class InventoryState : iGameState
    {
        Game game;

        public InventoryState(Game game)
        {
            this.game = game;
        }

        public void Draw(Graphics g)
        {

        }

        public void HandleKeyPress(char key)
        {
            if(key == 'e')
            {
                game.ReturnToLastState();
            }
        }

        public void HandleMouseClick()
        {
            
        }

        public void Update()
        {

        }
    }
}
