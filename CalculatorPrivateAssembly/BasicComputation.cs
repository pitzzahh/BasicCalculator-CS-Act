namespace CalculatorPrivateAssembly;

public static class BasicComputation
{
    public static T Compute<T>(T x, T y, char op)
    {
        return op switch
        {
            '+' => (dynamic)x! + (dynamic)y!,
            '-' => (dynamic)x! - (dynamic)y!,
            '*' => (dynamic)x! * (dynamic)y!,
            '/' => (dynamic)x! / (dynamic)y!,
            _ => throw new ArgumentException("Operation is not valid.")
        };
    }
}