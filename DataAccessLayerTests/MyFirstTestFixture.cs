using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DataAccessLayerTests
{
    public class MyFirstTestFixture : IDisposable
    {
        private int _counter;
        private string _phrase;
        public MyFirstTestFixture()
        {
            _counter = 0;
            _phrase = "Hello";
        }
        public void Dispose()
        {
            //dispose of any objects here after the test has run
           // throw new NotImplementedException();
        }

        [Fact]
        public void CounterShouldEqualZero()
        {
            Assert.Equal(0, _counter);
            Assert.Equal("Hello", _phrase);
            Assert.True(_phrase.Equals("Hello", StringComparison.OrdinalIgnoreCase));
        }
    }
}
