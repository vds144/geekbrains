using Microsoft.VisualStudio.TestTools.UnitTesting;
using GeekBrainsAlgos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeekBrainsAlgos
{

    [TestClass()]
    public class ProgramTests
    {
        public string Expected { get; private set; }
        public string Expectedfalse { get; private set; }

        [TestMethod()]
        public void Correct_prostoe()
        {
            string Expected = "Простое";
            string Expectedfalse = "Не простое";

            int n = 5;

            int d = 0;
            int i = 2;
            string prosto = "test";

            while (i < n)
            {
                if (n % i == 0)
                {
                    d++;
                    i++;
                }
                else
                {
                    i++;
                }
            }

            if (d == 0)
            {
                Console.WriteLine("Простое");
                prosto = "Простое";
            }
            else
            {
                Console.WriteLine("Не простое");
                prosto = "Не простое";
            }


            Assert.AreEqual(prosto, Expected);
            Assert.AreNotEqual(prosto, Expectedfalse);


        }


        [TestMethod()]
        public void INCorrect_prostoe()
        {
                int n = 4;
                string Expected = "Простое";
                string Expectedfalse = "Не простое";

                int d = 0;
                int i = 2;
                string prosto = "test";

                while (i < n)
                {
                    if (n % i == 0)
                    {
                        d++;
                        i++;
                    }
                    else
                    {
                        i++;
                    }
                }

                if (d == 0)
                {
                    Console.WriteLine("Простое");
                    prosto = "Простое";
                }
                else
                {
                    Console.WriteLine("Не простое");
                    prosto = "Не простое";
                }

                    Assert.AreNotEqual(prosto, Expected);
                    Assert.AreEqual(prosto, Expectedfalse);
        }

    }
}