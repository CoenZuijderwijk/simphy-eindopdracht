using Microsoft.Xna.Framework;
using SimPhy_Jun2021.GameObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace BaseProject.GameStates
{
    class PlayingState : GameObjectList
    {
        private PlayerCircle player;

        /// <summary>
        /// PlayState constructor which adds the different gameobjects and lists in the correct order of drawing.
        /// </summary>
        public PlayingState()
        {
            player = new PlayerCircle(new Vector2(400, 300), "circle");
            Add(player);

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
    }

}
