namespace CalculatorPrivateAssembly;

public static class Converter
{
    public static object Parse(string input)
    {
        if (decimal.TryParse(input, out var decimalValue))
        {
            return decimalValue;
        }
        if (double.TryParse(input, out var doubleValue))
        {
            return doubleValue;
        }
        if (float.TryParse(input, out var floatValue))
        {
            return floatValue;
        }
        if (int.TryParse(input, out var intValue))
        {
            return intValue;
        }

        throw new ArgumentException("Failed to parse the input string.");
    }
}