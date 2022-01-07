using System.Globalization;
using Helpers;
using Xunit;

namespace MyWebApp.Tests.Helpers;

public class DateHelpersTests
{
    [Fact]
    public void GivenUnformattedDate_ShouldReturnFormattedDate()
    {
        // arrange
        var unformattedDate = "01/01/20";

        // act
        var result = DateHelpers.ConvertDateToGovukDate(unformattedDate);

        // assert
        Assert.Equal("01 January 2020", result);
    }
}