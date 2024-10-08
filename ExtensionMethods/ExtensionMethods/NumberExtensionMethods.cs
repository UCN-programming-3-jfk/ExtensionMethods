namespace ExtensionMethods.ExtensionMethods;
public static class NumberExtensionMethods
{
    public static int Add(this int baseNumber, int numberToAdd)
    {
        return baseNumber + numberToAdd;
    }

    public static int Increment(this int baseNumber)
    {
        return baseNumber + 1;
    }
}
