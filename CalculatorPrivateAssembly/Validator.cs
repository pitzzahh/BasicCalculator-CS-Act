using System.Text.RegularExpressions;

namespace CalculatorPrivateAssembly;

public static class Validator
{
    public static bool IsNumber(string input) => Regex.IsMatch(input, @"^[-+]?[0-9]*\.?[0-9]+$");
}