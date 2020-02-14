using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace russianrumble
{
    class BattleState : iGameState
    {
        Game game;

        public BattleState(Game game)
        {
            this.game = game;
        }

        public void Draw(Graphics g)
        {

        }

        public void HandleKeyPress(char key)
        {

        }

        public void HandleMouseClick()
        {
            game.gameState = new OverworldState(game);
        }

        public void Update()
        {

        }
    }
}
