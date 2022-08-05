using System;

namespace VariableExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int dogAge = 8; 
            string dogName = "Titanic"; 
            bool isPureBread = true;
            char nickName = 'T';
            double bones = 5;
            decimal weight = 40.7m;
            

            Console.WriteLine($"My dog's name is {dogName}, {nickName} for short. He is {dogAge} years old and weighs {weight} pounds. If you heard me state he's a pure bread Huskie, it's {isPureBread}! He's burried {bones} bones in our neighbor's backyard.");

            
        }
    }
}
