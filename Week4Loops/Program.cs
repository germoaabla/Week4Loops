

Random rnd = new Random();

int myRandom;


for (int i = 0; i < 10; i++)
{
    myRandom = rnd.Next(1, 11);
    Console.WriteLine($"{i + 1}. {myRandom}");
}



//for(int i = 0; i < 3; i++) //i++ ==> i + 1
//{
//    Console.WriteLine($"{i + 1}. I will not skip zoom classes.");
//}    