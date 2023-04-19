using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;

namespace SimPhy_Jun2022.GameObjects
{
    class Obstacles : SpriteGameObject
    {
        public Obstacles(Vector2 position, Vector2 velocity) : base("Obstacle")
        {
            this.position = position;
            this.velocity = velocity;
            origin = Center;
        }
    }
}
