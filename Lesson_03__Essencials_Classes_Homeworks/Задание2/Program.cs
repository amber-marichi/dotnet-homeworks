using System;

namespace Задание2
{

    class Classroom
    {
        Pupil[] pupil = new Pupil[4];

        public void ClassRoom(Pupil a1, Pupil a2, Pupil a3)
        {
            Console.WriteLine("Form A");
            pupil[0] = a1;
            pupil[1] = a2;
            pupil[2] = a3;
            Study();
            Read();
            Write();
            Relax();
        }
        public void ClassRoom(Pupil b1, Pupil b2, Pupil b3, Pupil b4)
        {
            Console.WriteLine("Form B");
            pupil[0] = b1;
            pupil[1] = b2;
            pupil[2] = b3;
            pupil[3] = b4;
            Study();
            Read();
            Write();
            Relax();
        }

        public void Study()
        {
            Console.WriteLine(new String('*', 15));
            Console.WriteLine("Study:");
            for (int i = 0; i < pupil.Length; i++)
            {
                pupil[i].Study(); 
            }
        }
        public void Read()
        {
            Console.WriteLine(new String('*', 15));
            Console.WriteLine("Read:");
            for (int i = 0; i < pupil.Length; i++)
            {
                pupil[i].Read();
            }
        }
        public void Write()
        {
            Console.WriteLine(new String('*', 15));
            Console.WriteLine("Write:");
            for (int i = 0; i < pupil.Length; i++)
            {
                pupil[i].Write();
            }
        }
        public void Relax()
        {
            Console.WriteLine(new String('*', 15));
            Console.WriteLine("Relax:");
            for (int i = 0; i < pupil.Length; i++)
            {
                pupil[i].Relax();
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            GoodPupil pupil1 = new GoodPupil();
            BadPupil pupil2 = new BadPupil();
            ExcellenPupil pupil3 = new ExcellenPupil();
            GoodPupil pupil4 = new GoodPupil();
            Classroom formA = new Classroom();
            formA.ClassRoom(pupil1, pupil2, pupil3, pupil4);
            Console.ReadLine();
        }
    }
}

