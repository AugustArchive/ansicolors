using Xunit.Abstractions;
using Xunit;

namespace AnsiColors.Test
{
    public class AnsiTests
    {
        private readonly ITestOutputHelper output;
        public AnsiTests(ITestOutputHelper output)
        {
            this.output = output;
        }

        [Fact]
        public void Test_GetColor()
        {
            var lib = new AnsiColors();
            output.WriteLine($"Color with Red: {lib.GetColor(AnsiColor.Red, "test")}");
        }

        [Fact]
        public void Test_GetStyle()
        {
            var lib = new AnsiColors();
            output.WriteLine($"Style with Bold: {lib.GetStyle(AnsiStyle.Bold, "test")}");
        }
    }
}