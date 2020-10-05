using System;

namespace ClassLibrary1
{
    public class Class1
    {

        private string a;
        private string b;

        public Class1(string a, string b)
        {
            this.a = a;
            this.b = b;
        }
        public string getClass1()
        {
            return "" + (System.Math.Pow(Int32.Parse(a), Int32.Parse(b)));
        }
    }
    public class Class2
    {
        private string a;
        private string b;

        public Class2(string a, string b)
        {
            this.a = a;
            this.b = b;
        }
        public string getClass2()
        {
            return "" + (Int32.Parse(a) + Int32.Parse(b));
        }
    }
    public class Class3
    {
        private string a;
        private string b;

        public Class3(string a, string b)
        {
            this.a = a;
            this.b = b;
        }
        public string getClass3()
        {
            return "" + (Int32.Parse(a) * Int32.Parse(b));
        }
    }
}
