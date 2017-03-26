namespace Week10.Demo
{
    using System;

    using Common.Lab;
    class Program
    {
        static void Main(string[] args)
        {
            BaseClass b1 = new BaseClass();
            BaseClass b2 = new ChildClass();
            b1.MethodeReguliere();
            b2.MethodeReguliere();
            b1.MethodeVirtual();
            b2.MethodeVirtual();
            Console.WriteLine(b1.ToString());
            Console.WriteLine(b2.ToString());
            Console.In.ReadLine();
        }
    }
}
