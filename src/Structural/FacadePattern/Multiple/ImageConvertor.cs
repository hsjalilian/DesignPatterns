namespace FacadePattern.Multiple;
internal class ImageConvertor
{
    public string ConvertByteToText(byte[] input)
    {
        CheckInputLength(input);

        Console.WriteLine($"convert image byte to text!");
        return "";
    }

    private void CheckInputLength(byte[] input)
    {
        Console.WriteLine($"Check input byte length");

        if (input.Length < 0)
            throw new Exception("The length of the input can't be less than zero!");
        if (input.Length > 5000)
            throw new Exception("The input length is greater than 5000");
    }
}
