try
{
    int maxValue = int.MaxValue;

    int minValue = maxValue + 1; // OUTPUT: int.MinValue
    Console.WriteLine(minValue);

    var b = checked(maxValue + 1); // OUTPUT: System.OverflowException: Arithmetic operation resulted in an overflow.
}
catch (Exception)
{
    //handle exception
}