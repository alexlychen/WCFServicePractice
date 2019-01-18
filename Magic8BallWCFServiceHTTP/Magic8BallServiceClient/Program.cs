using System;
using Magic8BallServiceClient.ServiceReference1;

namespace Magic8BallServiceClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-- Ask the Magic 8 Ball --\n");
            using (Magic8BallClient ball = new Magic8BallClient())
            {
                Console.Write("Your question: ");
                string question = Console.ReadLine();

                string answer = ball.ObtainAnswerToQuestion(question);
                Console.WriteLine("8-Ball says: {0}", answer);
            }
            Console.ReadLine();
        }
    }
}
