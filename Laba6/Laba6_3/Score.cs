using System;
using System.Collections.Generic;
using System.Text;

namespace Laba6_3
{
    class Score
    {
        byte Math = 0;
        byte Physics = 0;
        byte Inform = 0;

        public Score() { }
        public Score(byte math, byte inform, byte physics)
        {
            this.Inform = inform;
            this.Math = math;
            this.Physics = physics;
        }


        public void SetMath(byte score)
        {
            this.Math = score;
        }
        public byte GetMathScore()
        {
            return this.Math;
        }
        public void SetPhy(byte score)
        {
            this.Physics = score;
        }
        public byte GetPhyScore()
        {
            return this.Physics;
        }
        public void SetInform(byte score)
        {
            this.Inform = score;
        }
        public byte GetInformScore()
        {
            return this.Inform;
        }






    }
}
