using System.Security.Cryptography.X509Certificates;

namespace dom_ot_tetradkata
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Dai duma: ");
            string input = Console.ReadLine();
            int mid = input.Length / 2;
            bool isPalindrome = true;
            for (int i = 0; i < mid; i++)
            {
                if (input[i] != input[input.Length - 1 - i])
                {
                    isPalindrome = false;
                    break;
                }
            }
            if (isPalindrome)
            {
                Console.WriteLine("Palindrom");
            }
            else
            {
                Console.WriteLine("Ne e palindrom");
            }
        }
    }
}