
using NumberReading;

Okuma okuma = new Okuma();
string result = string.Empty;
while (true)
{
    try
    {
        ulong number = Convert.ToUInt64(Console.ReadLine());
        if (number == 0)
        {
            Console.WriteLine("sıfır");
        }
        else
        {
            string sNumber = number.ToString();
            //sNumber = "1123076"

            okuma.Bol(ref sNumber);
            // sNumber = "1,123,076

            result = okuma.Oku(sNumber);

            Console.WriteLine(result);
            Console.WriteLine(sNumber);
            break;
        }
    }
    catch (Exception)
    {
        Console.WriteLine("0-18446744073709551615 aralığında bir değer girin.");
    }

}

