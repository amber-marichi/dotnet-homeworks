using System;

namespace Задание2
{
    class Pupil
    {
        public virtual void Study()
        {
            Console.WriteLine("study");
        }
        public virtual void Read()
        {
            Console.WriteLine("read");
        }
        public virtual void Write()
        {
            Console.WriteLine("write");
        }
        public virtual void Relax()
        {
            Console.WriteLine("relax");
        }
    }
    class BadPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Bad study");
        }
        public override void Read()
        {
            Console.WriteLine("Bad read");
        }
        public override void Write()
        {
            Console.WriteLine("Bad write");
        }
        public override void Relax()
        {
            Console.WriteLine("Excellent relax");
        }
    }

    class GoodPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Good study");
        }
        public override void Read()
        {
            Console.WriteLine("Good read");
        }
        public override void Write()
        {
            Console.WriteLine("Good write");
        }
        public override void Relax()
        {
            Console.WriteLine("Good relax");
        }
    }

    class ExcellenPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Excellent study");
        }
        public override void Read()
        {
            Console.WriteLine("Excellent read");
        }
        public override void Write()
        {
            Console.WriteLine("Excellent write");
        }
        public override void Relax()
        {
            Console.WriteLine("Bad relax");
        }
    }
}
