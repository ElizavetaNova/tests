using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;


namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
        }

        [TestMethod]
        public void TestEquation()
        {
            double a = 1;
            double b = 5;
            double c = -6;
            Equation equation = new Equation();
            equation.EquationRezult(a, b, c);

            Assert.AreEqual(equation.EquationRezult(a, b, c), -5);

            


        }
    }
}
