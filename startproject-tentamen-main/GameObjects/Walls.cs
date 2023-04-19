using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimPhy_Jun2022.GameObjects
{
    class Walls : GameObjectList
    {
        SpriteGameObject wallLeft;
        SpriteGameObject wallRight;
        SpriteGameObject ceiling;

        public SpriteGameObject WallLeft
        {
            get { return wallLeft; }
        }
        public SpriteGameObject WallRight
        {
            get { return wallRight; }
        }

        public SpriteGameObject Ceiling
        {
            get { return ceiling; }
        }

        public Walls()
        {
            //creating walls
            wallLeft = new SpriteGameObject("SideWall");
            wallRight = new SpriteGameObject("SideWall");
            ceiling = new SpriteGameObject("TopWall");

            //positioning walls
            wallLeft.Position = new Vector2(0, 0);
            wallRight.Position = new Vector2(GameEnvironment.Screen.X - wallRight.Width, 0);
            ceiling.Position = new Vector2(0, 0);

            //Adding walls
            Add(wallLeft);           
            Add(wallRight);
            Add(ceiling);
        }
    }
}
