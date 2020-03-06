using System;

namespace AnsiColors
{
    public enum AnsiColor
    {
        Black = 30,
        Red = 31,
        Green = 32,
        Yellow = 33,
        Blue = 34,
        Magenta = 35,
        Cyan = 36,
        White = 37,
        Gray = 90,
        Grey = 90, // Alias for "Gray" for non-American users
        BlackBright = 90, // I have no idea why they are the same \_(^w^)_/
        RedBright = 91,
        GreenBright = 92,
        YellowBright = 93,
        BlueBright = 94,
        MagentaBright = 95,
        CyanBright = 96,
        WhiteBright = 97,
        BgBlack = 40,
        BgRed = 41,
        BgGreen = 42,
        BgYellow = 43,
        BgBlue = 44,
        BgMagenta = 45,
        BgCyan = 46,
        BgWhite = 47,
        BgBlackBright = 100,
        BgRedBright = 101,
        BgGreenBright = 102,
        BgYellowBright = 103,
        BgBlueBright = 104,
        BgMagentaBright = 105,
        BgCyanBright = 106,
        BgWhiteBright = 107,
        BgGray = 100,
        BgGrey = 100 // Used for non-American users
    }

    public enum AnsiStyle
    {
        Reset = 0,
        Bold = 1,
        Dim = 2,
        Italic = 3,
        Underline = 4,
        Blink = 5,
        Inverse = 7,
        Strikethrough = 9
    }

    public class AnsiColors
    {
        public bool Supports()
        {
            var noColor = Environment.GetEnvironmentVariable("NO_COLOR");
            var forceColor = Environment.GetEnvironmentVariable("FORCE_COLOR");
            var term = Environment.GetEnvironmentVariable("TERM");
            var platform = Environment.OSVersion.Platform;

            return noColor == null || forceColor != "0" || platform == PlatformID.Win32NT || (term == null ? false : term != "dumb");
        }

        public string GetColor(AnsiColor color, string text) => $"\\x1b[{color}m{text}\\x1b[0m";
        public string GetStyle(AnsiStyle style, string text) => $"\\x1b[{style}m{text}\\x1b[0m";

    }
}