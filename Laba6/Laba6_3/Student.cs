using System;
using System.Collections.Generic;
using System.Text;

namespace Laba6_3
{
    class Student
    {
        string Name;
        Score score = new Score();

        public Student() { }
        /// <summary>
        /// Конструктор ввода фамилии, оценки по математике, информатике и физике студента
        /// </summary>
        /// <param name="stname"></param>
        /// <param name="math"></param>
        /// <param name="inform"></param>
        /// <param name="physics"></param>
        public Student(string stname, byte math, byte inform, byte physics)
        {
            this.Name = stname;
            this.score.SetMath(math);
            this.score.SetPhy(physics);
            this.score.SetInform(inform);

        }

        public void SetName(string stname)
        {
            this.Name += stname;
        }
        
        public string GetName()
        {
            return this.Name;
        }
        public void SetMathScore(byte sc)
        {
            this.score.SetMath(sc);
        }
        public byte GetMathScore()
        {
            return this.score.GetMathScore();
        }

        public void SetInformScore(byte sc)
        {
            this.score.SetInform(sc);
        }
        public byte GetInformScore()
        {
            return this.score.GetInformScore();
        }

        public void SetPhyScore(byte sc)
        {
            this.score.SetPhy(sc);
        }
        public byte GetPhyScore()
        {
            return this.score.GetPhyScore();
        }

        public double GetAverageScore()
        {
            return ((double)score.GetMathScore() + score.GetPhyScore() + score.GetInformScore()) / 3.0;
        }
    }
}
