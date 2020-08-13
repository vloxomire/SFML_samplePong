using SFML.Graphics;
using SFML.System;
using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFML_sample
{
    public enum COLLISION_DIRECTION { LEFT, RIGHT, TOP, BOT }
    class CollisionUtils
    {
        public static bool CheckCollision(Sprite spriteA, Sprite spriteB, ref COLLISION_DIRECTION dir)
        {
            FloatRect rectA = spriteA.GetGlobalBounds();
            FloatRect rectB = spriteB.GetGlobalBounds();

            float aRight = rectA.Left + rectA.Width;
            float bRight = rectB.Left + rectB.Width;
            float aDown = rectA.Top - rectA.Height;
            float bDown = rectB.Top - rectB.Height;

            if (IsCollision(rectA, rectB))
            {
                if (CollisionOnLeft(rectA, rectB))
                {
                    dir = COLLISION_DIRECTION.LEFT;
                    return true;
                }
                if (CollisionOnRight(rectA, rectB))
                {
                    dir = COLLISION_DIRECTION.RIGHT;
                    return true;
                }
                if (CollisionOnTop(rectA, rectB))
                {
                    dir = COLLISION_DIRECTION.TOP;
                    return true;
                }
                if (CollisionOnBot(rectA, rectB))
                {
                    dir = COLLISION_DIRECTION.BOT;
                    return true;
                }
            }
            return false;
        }
        private static bool IsCollision(FloatRect rectA,FloatRect rectB)
        {
            float aRight = rectA.Left + rectA.Width;
            float bRight = rectB.Left + rectB.Width;
            float aDown = rectA.Top - rectA.Height;
            float bDown = rectB.Top - rectB.Height;

            if (aRight >= rectB.Left && rectA.Left <= bRight && rectA.Top >= bDown && aDown <= rectB.Top)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }
        private static bool CollisionOnLeft(FloatRect rectA, FloatRect rectB)
        {
            float aRight = rectA.Left + rectA.Width;
            float bRight = rectB.Left + rectB.Width;
            if (rectB.Left < rectA.Left && rectB.Left < (rectA.Left + aRight) && bRight < aRight)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private static bool CollisionOnRight(FloatRect rectA, FloatRect rectB)
        {
            float aRight = rectA.Left + rectA.Width;
            float bRight = rectB.Left + rectB.Width;
            if (rectA.Left < rectB.Left && rectA.Left < (rectB.Left + bRight) && aRight < bRight)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }
        private static bool CollisionOnTop(FloatRect rectA, FloatRect rectB)
        {
            float aDown = rectA.Top + rectA.Height;
            float bDown = rectB.Top + rectB.Height;
            if (rectB.Top < rectA.Top && rectB.Top < (rectA.Top + aDown) && bDown < aDown)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private static bool CollisionOnBot(FloatRect rectA, FloatRect rectB) 
        {
            float aDown = rectA.Top + rectA.Height;
            float bDown = rectB.Top + rectB.Height;
            if (rectA.Top < rectB.Top && rectA.Top < (rectB.Top + bDown) && aDown < bDown)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
