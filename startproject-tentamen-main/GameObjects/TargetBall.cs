using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;

namespace SimPhy_Jun2022.GameObjects
{
    class TargetBall : SpriteGameObject
    {
        public string assetname;
        public TargetBall(Vector2 position, string assetname) : base(assetname)
        {
            this.position = position;
            this.assetname = assetname;
        }
    }
}
