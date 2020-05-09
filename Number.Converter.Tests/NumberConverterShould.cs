using System;
using Xunit;

namespace Number.Converter.Tests
{
    public class NumberConverterShould
    {
        [Fact]
        public void GenerateCorrectSpellingForSmallNumbers()
        {
            Assert.Equal("Three Hundred Fourty Five", ((int)345).ConvertToSpelling());
            Assert.Equal("Fourty Five", ((int)45).ConvertToSpelling());
            Assert.Equal("Three Hundred Two", ((int)302).ConvertToSpelling());
            Assert.Equal("Three Thousand Two", ((int)3002).ConvertToSpelling());

            Assert.Equal("Ten Thousand Two Hundred Thirty", ((int)10230).ConvertToSpelling());
            
        }

    }
}
