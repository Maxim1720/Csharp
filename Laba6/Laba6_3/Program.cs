using System;
using System.IO;

namespace Laba6_3
{
  
   
    class Program
    {
        static string intxt = "C:\\Users\\musie\\Desktop\\University\\C#\\Laba6\\Laba6_3\\in.txt";
        static Student[] StudentKit(byte size)
        {
            Student[] kit = new Student[size];
            for(int i = 0; i < size; i++)
            {
                kit[i] = new Student();
            }
            return kit;
        } //Процедура инициализации массива объектов класс Student

        static double MaxAv(Student[] students)
        {
            double max = 0;
            for(int i = 0; i < students.Length; i++)
            {
                if (max < students[i].GetAverageScore())
                {
                    max = students[i].GetAverageScore();
                }
            }
            return max;
        } //Процедура вычисляет максимальное значение по ср.значению
        static void Main(string[] args)
        {
            StreamReader InFile = null;
            try
            {
                InFile = new StreamReader(intxt);


                byte StAmount = Convert.ToByte(InFile.ReadLine());

                Student[] student = StudentKit(StAmount);
                string[] Splits = new string[5];

                for (int i = 0; i < student.Length; i++)
                {
                    string str = InFile.ReadLine();
                    Splits = str.Split(' '); //Делим строку на массив строк(разделителем является пробел) 
                    student[i].SetName(Splits[0] + " " + Splits[1]); //первые две строки - Имя и Фамилия
                    student[i].SetMathScore(Convert.ToByte(Splits[2]));
                    student[i].SetPhyScore(Convert.ToByte(Splits[3]));
                    student[i].SetInformScore(Convert.ToByte(Splits[4]));

                }
                InFile.Close();
                for (int i = 0; i < student.Length; i++)
                {
                    Console.WriteLine("{0} студент: {1,-20} Оценки: матан = {2},физика = {3}, информатика = {4}", i + 1, student[i].GetName(), student[i].GetMathScore(), student[i].GetPhyScore(), student[i].GetInformScore());
                }

                double math, phys, inform;
                math = phys = inform = 0;

                for (int i = 0; i < student.Length; i++)
                {
                    math += student[i].GetMathScore();
                    phys += student[i].GetPhyScore();
                    inform += student[i].GetInformScore();
                }

                math /= student.Length;
                phys /= student.Length;
                inform /= student.Length;

                Console.WriteLine("\n\nСредняя оценка:\n по математике = {0:f2}\n по физике = {1:f2}\n по информатике = {2:f2}", math, phys, inform);


                double max = MaxAv(student);
                Console.WriteLine("\n\tЛучшие ученики:");

                StreamWriter OutFile = new StreamWriter("out.txt", false, System.Text.Encoding.Default);


                for (int i = 0; i < student.Length; i++)
                {
                    if (student[i].GetAverageScore() == max)
                    {
                        Console.WriteLine("{0,-15}, средний балл = {1:f2}", student[i].GetName(), student[i].GetAverageScore());
                        OutFile.WriteLine("{0} {1} {2} {3}", student[i].GetName(), student[i].GetMathScore(), student[i].GetPhyScore(), student[i].GetInformScore());
                    }
                }
                OutFile.Close();
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("--------------\nФайла не существует\n-------------");
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("--------------\nКоличество студентов меньше, чем объявленное число студентов\n--------------");
            }
            catch (FormatException)
            {
                Console.WriteLine("--------------\nНекорректный формат данных внутри файла\n--------------");
            }
            finally
            {
                Console.ReadKey();
            }

        }
    }
}
