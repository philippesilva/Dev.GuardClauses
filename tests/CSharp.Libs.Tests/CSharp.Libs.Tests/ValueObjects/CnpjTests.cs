using CSharp.Libs.ValueObjects;
using Xunit;

namespace CSharp.Libs.Tests.ValueObjects
{
    public class CnpjTests
    {
        [Theory]
        [InlineData("59.450.556/1001-22")]
        [InlineData("59450556002122")]
        public void ValidateCnpj_IsInvalid_ReturnSuccess(string cnpj)
        {
            Assert.False(Cnpj.Validate(cnpj));
        }

        [Theory]
        [InlineData("59.450.556/0001-22")]
        [InlineData("59450556000122")]
        public void ValidateCnpj_IsValid_ReturnSuccess(string cnpj)
        {
            Assert.True(Cnpj.Validate(cnpj));
        }
    }
}