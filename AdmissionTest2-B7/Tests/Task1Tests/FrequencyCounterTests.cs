using NUnit.Framework;
using Task1;

namespace Task1Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase("AaaBbC", "a-3,b-2,c-1")]
        [TestCase("jeoHdnHyFDksVGSkecneiQNDkdKdnwazkfHdjw", "a-1,c-1,d-6,e-3,f-2,g-1,h-3,i-1,j-2,k-5,n-4,o-1,q-1,s-2,v-1,w-2,y-1,z-1")]
        [TestCase("", "")]
        [TestCase("ABCDEFGHIJKLMNOPQRSTUVWXYZ", "a-1,b-1,c-1,d-1,e-1,f-1,g-1,h-1,i-1,j-1,k-1,l-1,m-1,n-1,o-1,p-1,q-1,r-1,s-1,t-1,u-1,v-1,w-1,x-1,y-1,z-1")]
        [TestCase("ZYXWVUTSRQPONMLKJIHGFEDCBA", "a-1,b-1,c-1,d-1,e-1,f-1,g-1,h-1,i-1,j-1,k-1,l-1,m-1,n-1,o-1,p-1,q-1,r-1,s-1,t-1,u-1,v-1,w-1,x-1,y-1,z-1")]
        public void Count_ValidText_CorrectCount(string text, string expectedResult)
        {
            var frequencyCounter = new FrequencyCounter();
            var result = frequencyCounter.Count(text);
            Assert.AreEqual(expectedResult, result);
        }
    }
}