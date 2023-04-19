using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;

namespace SimPhy_Jun2022.GameObjects
{
    class Cannon : RotatingSpriteGameObject
    {
        public Cannon(Vector2 position, string assetName) : base(assetName)
        {
            origin = Center;

            this.position = position;

            offsetDegrees = 270;
        }

        public override void HandleInput(InputHelper inputHelper)
        {
            base.HandleInput(inputHelper);
            AngularDirection = inputHelper.MousePosition - position;
        }
    }
}
