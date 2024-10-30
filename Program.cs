namespace paralo;

class Program
{
    static void Main(string[] args)
    {
        int firstrequest = int.Parse(Console.ReadLine()!);
        int numbers = firstrequest.ToString().Length;
        if (numbers == 5) {
            string secondresult = firstrequest.ToString().Substring(3);
            string firstresult = firstrequest.ToString().Substring(0, numbers - 3);
            char[] Reverse = firstresult.ToCharArray();
            Array.Reverse(Reverse);
            string result = new string(Reverse);
            if (result == secondresult) {
                Console.WriteLine("Да");
            }
            else {
                Console.WriteLine("Нет");
            }
        }
        else
        {
            Console.WriteLine("Вы не ввели пятизначное число");
        }
    }
}
