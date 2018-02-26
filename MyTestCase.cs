using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumberRefactor
{
    [TestFixture]
    class MyTestCase
    {
        //[This case will fail beacause of 2,2,2,1 and compared value from function 2,2,2,2]
        [TestCase]
        public void PrimeFactors()
        {            
            Program myobj = new Program();
            ArrayList one = new ArrayList();
            one.Add(2);
            one.Add(2);
            one.Add(2);
            one.Add(1);         
              
            Assert.AreEqual(one, Program.PrimeFactors(16));                        
        }

        //[This case will Success beacause of 2,2,2,2 and compared value from function 2,2,2,2]
        [TestCase]
        public void PrimeFactors2()
        {
            Program myobj = new Program();
            ArrayList one = new ArrayList();
            one.Add(2);
            one.Add(2);
            one.Add(2);
            one.Add(2);

            Assert.AreEqual(one, Program.PrimeFactors(16));
        }

    }

}
