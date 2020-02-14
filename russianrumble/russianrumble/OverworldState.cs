using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace russianrumble
{
    class OverworldState : iGameState
    {
        private Game game;

        public OverworldState(Game game)
        {
            this.game = game;
        }
        public void Draw(Graphics graphics)
        {
            game.world.Draw(graphics);
        }

        public void HandleKeyPress(char key)
        {
            switch (key)
            {
                case 'w':
                    if (game.player.GetY() >= 0)
                    {
                        game.player.Move(Direction.UP, game.world);
                    }
                    break;
                case 's':
                    if (game.player.GetY() >= 0)
                    {
                        game.player.Move(Direction.DOWN, game.world);
                    }
                    break;
                case 'a':
                    if (game.player.GetY() >= 0)
                    {
                        game.player.Move(Direction.LEFT, game.world);
                    }
                    break;
                case 'd':
                    if (game.player.GetY() >= 0)
                    {
                        game.player.Move(Direction.RIGHT, game.world);
                    }
                    break;
                case 'e':
                    game.gameState = new BattleState(game);
                    break;
            }
        }

        public void HandleMouseClick()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            game.world.Update(game.GetMousePosX(), game.GetMousePosY());
        }
    }
}
