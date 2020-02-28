using System;

public static class ResistorColor
{
    private static string[] _colors = new string[] { "black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white" };

    public static int ColorCode(string color)
    {
        return Array.IndexOf(_colors, color.ToLower());

    }

    public static string[] Colors()
    {
        return _colors;
    }
}