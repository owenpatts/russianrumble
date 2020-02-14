using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace russianrumble
{
    class Game
    {
        private int mousePosX;
        private int mousePosY;

        private iGameState currentState;
        private iGameState lastState;

        public World World;
        public Player Player = new Player();

        public Game()
        {
            World = new World(this);
            currentState = new OverworldState(this);
        }

        public void Update(int mousePosX, int mousePosY)
        {
            currentState.Update();
            this.mousePosX = mousePosX;
            this.mousePosY = mousePosY;
        }

        public void Draw(Graphics graphics)
        {
            currentState.Draw(graphics);
        }

        public void Click(int x, int y)
        {
            x /= Tile.tileSize;
            y /= Tile.tileSize;
            //player.Move(x, y);
        }

        public int GetMousePosX()
        {
            return mousePosX;
        }

        public int GetMousePosY()
        {
            return mousePosY;
        }

        public void HandleMouseClick()
        {
            currentState.HandleMouseClick();
        }

        public void HandleKeyPress(char key)
        {
            currentState.HandleKeyPress(key);
        }

        public void SetState(iGameState state)
        {
            this.lastState = currentState;
            this.currentState = state;
        }

        public void ReturnToLastState()
        {
            iGameState tempState = currentState;
            this.currentState = lastState;
            this.lastState = tempState;
        }
    }
}
