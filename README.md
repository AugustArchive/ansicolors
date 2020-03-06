# AnsiColors
> :bouquet: **| Simple ANSI colors for .NET**

## Example
```cs
using AnsiColors;
using System;

namespace MyNamespace
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var colors = new AnsiColors();
            Console.WriteLine($"Red: {colors.GetColor(AnsiColor.Red, "test")}");
        }
    }
}
```

## License
**AnsiColors** is released under the **MIT** License. Read [here](/LICENSE) for more information.