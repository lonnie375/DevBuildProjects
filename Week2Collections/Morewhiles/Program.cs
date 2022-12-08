int x = 0;

//while (10 > 9)
//{
//    //This will run for ever 
//    Console.WriteLine($"While lopp. x is {x}");
//    x++;
//}

//while ( 9 > 10)
//{
//    //9 > 10 is false statement. So this code will never run. 
//    Console.WriteLine($"While loop. x is {x}");
//    x++;
//}


bool done = false; 
while (!done)
{
    Console.WriteLine($"While loop. x is {x}");
    x++;

    if (x == 1000)
    {
        done = true;
    }
}