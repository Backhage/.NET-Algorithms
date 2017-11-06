using DynamicProgramming;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Numerics;

namespace DynamicProgrammingTests
{
    [TestClass]
    public class FibonacciTests 
    {
          [TestMethod]
          public void Fibonacci_TestLessThan1()
          {
              Assert.AreEqual(new BigInteger(-1), Fibonacci.Calculate(0));
              Assert.AreEqual(new BigInteger(-1), Fibonacci.Calculate(-1));
          }
  
          [TestMethod]
          public void Fibonacci_TestMoreThan2000()
          {
              Assert.AreEqual(new BigInteger(-1), Fibonacci.Calculate(2001));
          }
  
          [TestMethod]
          public void Fibonacci_TestBaseCases()
          {
              Assert.AreEqual(new BigInteger(1), Fibonacci.Calculate(1));
              Assert.AreEqual(new BigInteger(1), Fibonacci.Calculate(2));
              Assert.AreEqual(new BigInteger(2), Fibonacci.Calculate(3));
              Assert.AreEqual(new BigInteger(3), Fibonacci.Calculate(4));
              Assert.AreEqual(new BigInteger(5), Fibonacci.Calculate(5));
          }
  
          [TestMethod]
          public void Fibonacci_TestExceedIntMax()
          {
              Assert.AreEqual(new BigInteger(2971215073L), Fibonacci.Calculate(47));
          }
  
          [TestMethod]
          public void Fibonacci_TestExceedLongMax()
          {
              Assert.AreEqual(new BigInteger(12200160415121876738UL), Fibonacci.Calculate(93));
          }
    }
}
