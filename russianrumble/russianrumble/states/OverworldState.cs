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
            game.World.Draw(graphics);
            game.Player.Draw(graphics);
        }

        public void HandleKeyPress(char key)
        {
            switch (key)
            {
                case 'w':
                    if (game.Player.GetY() >= 0)
                    {
                        game.Player.Move(Direction.UP, game.World);
                    }
                    break;
                case 's':
                    if (game.Player.GetY() >= 0)
                    {
                        game.Player.Move(Direction.DOWN, game.World);
                    }
                    break;
                case 'a':
                    if (game.Player.GetY() >= 0)
                    {
                        game.Player.Move(Direction.LEFT, game.World);
                    }
                    break;
                case 'd':
                    if (game.Player.GetY() >= 0)
                    {
                        game.Player.Move(Direction.RIGHT, game.World);
                    }
                    break;
                case 'e':
                    game.SetState(new InventoryState(game));
                    break;
            }
        }

        public void HandleMouseClick()
        {
            
        }

        public void Update()
        {
            game.World.Update(game.GetMousePosX(), game.GetMousePosY());
        }
    }
}
