// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

public class Calculator
{
    public int Add(params int[] nums)
    {
        return nums.Sum();
    }
}