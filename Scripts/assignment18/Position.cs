using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment18
{
    public struct Position
    {
        public float X;
        public float Y;
        public float Z;

        public Position(float x, float y, float z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public void printPosition()
        {
            Debug.Log(X);
            Debug.Log(Y);
            Debug.Log(Z);
        }
    }
}
