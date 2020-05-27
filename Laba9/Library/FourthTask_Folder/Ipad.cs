using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.FourthTask_Folder
{
    public class Ipad : IComparable<Ipad>, IEnumerable
    {
        public Ipad(Model m)
        {
            ipadModel = m;
            SetInfo();
        }

        public enum Model
        {
            Pro_12,
            Pro_11,
            Pro_10,
            Air,
            mini
        }
        Model ipadModel;
        string Processor = "";
        int MemoryInGB = 0;
        int CameraMP = 0;
        double WidthMM = 0;
        double HeightMM = 0;
        double Display = 0;
        public ArrayList al = new ArrayList();
        private void SetInfo()
        {
            switch (ipadModel)
            {
                case Model.Pro_12:
                    Display = 12.9;
                    Processor = "A12Z Bionic";
                    MemoryInGB = 1000;
                    CameraMP = 12;
                    HeightMM = 260.6;
                    WidthMM = 214.9;

                    break;
                case Model.Pro_11:
                    Display = 11;
                    Processor = "A12Z Bionic";
                    MemoryInGB = 1000;
                    CameraMP = 10;
                    HeightMM = 247.6;
                    WidthMM = 178.5;
                    break;
                case Model.Pro_10:
                    Display = 10.5;
                    Processor = "A12Z Bionic";
                    MemoryInGB = 1000;
                    CameraMP = 12;
                    HeightMM = 280.6;
                    WidthMM = 214.9;
                    break;
                case Model.Air:
                    Display = 10.5;
                    Processor = "A12 Bionic";
                    MemoryInGB = 256;
                    CameraMP = 8;
                    HeightMM = 250.6;
                    WidthMM = 174.1;
                    break;
                case Model.mini:
                    Display = 7.9;
                    Processor = "A12 Bionic";
                    MemoryInGB = 256;
                    CameraMP = 8;
                    HeightMM = 203.2;
                    WidthMM = 134.8;
                    break;
            }
            al.Add(this.Processor);
            al.Add(this.MemoryInGB);
            al.Add(this.CameraMP);
            al.Add(this.WidthMM);
            al.Add(this.HeightMM);
            al.Add(this.Display);
        }
        public ArrayList GetInfo()
        {

            if (al==null)
            {
                return null;
            }
            else
                return al;
        }

        public int CompareTo(Ipad obj)
        {
            Ipad ipad = obj as Ipad;
            if (ipad.Equals(null))
            {
                throw new NotImplementedException();
            }
            else
            {
                if (this.Display > obj.Display)
                {
                    return 1;
                }
                else if (this.Display < obj.Display)
                {
                    return -1;
                }
                else
                    return 0;
            }
        }

        public IEnumerator GetEnumerator()
        {

            return al.GetEnumerator();//throw new NotImplementedException();
        }

        public override string ToString()
        {
            return ipadModel.ToString();
        }
    }
}
