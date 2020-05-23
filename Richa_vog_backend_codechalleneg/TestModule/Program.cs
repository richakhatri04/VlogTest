using System;

namespace TestModule
{
    public static class TESTModule
    {
        public static object Module(object testObject) // Answer: We could have used integer instead of object as object can have values other than integer in that case it will not function, also add a break statement after each case.
        {
            switch (testObject)
            {
                case 1:
                case 2:
                    return doubler((int)testObject);
                case int value when value >= 3:
                    return tripler(value);
                case float floatValue when floatValue == 1.0f:
                    return leveler(floatValue);
                default:
                    return testObject;
            }


            int doubler(int amount) => amount * 2;
            int tripler(int amount) => amount * 3;
            double leveler(double amount) => amount - 0.1f * 10f;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            TestModule.TESTModule.Module(3); 
        }
    }

  

}
