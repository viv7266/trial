using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using LargestFunction;

[TestFixture]
    public class LargestTest
    {
    [Test]
    public void LargestOf3(){
        Assert.That(LargestNumber.Largest(new int[] {8,9,7}), Is.EqualTo(9));
    }
}


