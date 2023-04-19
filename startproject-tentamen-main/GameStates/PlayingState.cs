using Microsoft.Xna.Framework;
using SimPhy_Jun2021.GameObjects;
using SimPhy_Jun2022.GameObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace BaseProject.GameStates
{
    class PlayingState : GameObjectList
    {
        string[] color = new string[3]; 
        GameObjectList balls;
        private Ball player;
        private Cannon cannon;
        private int ballColor = 0;
        bool cooldown = false;
        int counter = 100;
        static int speed = 5;

        /// <summary>
        /// PlayState constructor which adds the different gameobjects and lists in the correct order of drawing.
        /// </summary>
        public PlayingState()
        {
            color[0] = "RedBall";
            color[1] = "GreenBall";
            color[2] = "BlueBall";
            Add(new SpriteGameObject("background"));
            cannon = new Cannon(new Vector2(GameEnvironment.Screen.X / 2, GameEnvironment.Screen.Y - 20), "Cannon");
            Add(cannon);
            //player = new Ball(new Vector2(GameEnvironment.Screen.X / 2, GameEnvironment.Screen.Y - 50), Vector2.Zero, Vector2.Zero, "circle");
            //Add(player);
            balls = new GameObjectList();
            Add(balls);

            // Add initialization logic here
        }

        /// <summary>
        /// Updates the PlayState.
        /// </summary>
        /// <param name="gameTime"></param>
        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
            // Add update logic here
        }

        public override void HandleInput(InputHelper inputHelper)
        {
            base.HandleInput(inputHelper);

            
            if (inputHelper.KeyPressed(Microsoft.Xna.Framework.Input.Keys.Q)) ballColor++;
            Vector2 ballSpeed = Vector2.Subtract(inputHelper.MousePosition, cannon.Position);
            if (ballColor > 2) ballColor = 0;

            if (inputHelper.MouseLeftButtonPressed() && !cooldown)
            {
                balls.Add(new Ball(cannon.Position, speed * ballSpeed, new Vector2(0, 50), color[ballColor]));
                counter = 0;
            }
        }
    }

}
