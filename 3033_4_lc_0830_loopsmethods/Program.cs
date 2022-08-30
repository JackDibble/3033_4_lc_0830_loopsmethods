//Jack Dibble 113458693
//august 30th 2022 mis 3033 004 lecture codes
//loops and methods 


//Loops
//for loop
//0 is the intitalization(where do we start), 1 is the condition(the for loop will go as long as this is met), 2 is the formating(post processing), 3 loop body
//for(0;1 ;2 ) 0 goes once then to 1 then eecutes body then formating last, next rotation skip 0 bc no more initalization then 1->3->2 looped 
//{
//    3
//}
//i++ takes out the stored value and adds 1 
//executres the order that it comes in 
{
    Console.WriteLine("This is a for loop");
    int i = 9;
    for (; ; )
    {
        i++;
        if (i > 20)
        {
            break;
        }
        if (i == 13 || i == 17)//&&
        {
            continue;
        }
        Console.WriteLine(i);
    }
    {
        Console.WriteLine("This is a while loop");
        //while (2) { 3}
        //2->3 until the loop is false 
        i = 10;
        while (i <= 20)
        {
            i++;
            if (i == 13 || i == 17)
            {
                continue;
            }
            Console.WriteLine(i);
            
        }


    }

    Console.WriteLine("Do While loop");
    //do{3}while(2);
    i = 9;

    do 
    {
        i++;
        if (i==11 ||i==13)
        {
            continue;
        }
        Console.WriteLine(i);
        
    } while (i<=20);


    //methods functions A tool == to excel functions 
    //1)datatype 2)function name 3) (datatype var1 , datatype var2,....) 4) {} 5) return product;

    Console.WriteLine( "Methods/functions results");
    double testN = 10.2;
    double product = getlargerdblval(testN,100);
    Console.WriteLine(product);
    Console.ReadLine();

    double getlargerdblval(double dbl1, double dbl2)
        
    {
        double product;
        if(dbl1>dbl2)
        {
            product = dbl1;
        }
        else
        {
            product = dbl2;
        }
        return product;
    }


    
}