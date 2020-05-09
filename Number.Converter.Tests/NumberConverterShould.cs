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


        [Fact]
        public void GenerateCorrectSpeelingForHundredsorThrousands()
        {
            Assert.Equal("One Hundred", ((int)100).ConvertToSpelling());
            Assert.Equal("One Thousand", ((int)1000).ConvertToSpelling());
            Assert.Equal("Ten Thousand", ((int)10000).ConvertToSpelling());
            Assert.Equal("One Hundred Thousand", ((int)100000).ConvertToSpelling());
            Assert.Equal("One Million", ((int)1000000).ConvertToSpelling());
            Assert.Equal("Seven Million", ((int)7000000).ConvertToSpelling());
            Assert.Equal("Seven Million Two Hundred Fifty", ((int)7000250).ConvertToSpelling());

        }

    }
}
