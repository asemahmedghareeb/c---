
    //object instansiation 
    object z = new object();
    //selection statments
    var mark = 55;
    if (mark >= 60)
    {
        Console.WriteLine("pass");
    }
    else if (mark >= 55)
    {
        Console.WriteLine("you have a chance in a make up exam");
    }
    else
    {
        Console.WriteLine("Fail");
    }

    var amount = 100;
    var currType = "usd";
    var output = 0d;
    //1 normal switch
    switch (currType)
    {
        case "usd":
            output = amount * 1.41d;
            break;
        case "eur":
            output = amount * 1.19d;
            break ;
        case "cad":
            output = amount * 1.78d;
            break;
        default:
            break;

    }

    //2 one action for many cases
    var num = 7;
    switch (num)
    {
        case 1:
        case 3:
        case 5:
        case 7:
        case 9:
            Console.WriteLine("odd");
            break;
        case 2:
        case 4:
        case 6:
        case 8:
        case 10:
            Console.WriteLine("even");
            break ;

    }

    //3 switch on types
    object o = "asem";
    switch (o)
    {
        case int i:
            Console.WriteLine($"square of {i} is {i * i}");
            break;
        case string i:
            Console.WriteLine($"it  is stirng capitalizition {i} is {i.ToUpper()}");
            break;
    }

//preduct value
bool Isvip = true;
switch (Isvip)
{
    case bool i when i == true:
        Console.WriteLine("Yes");
        break; 
    case bool i :
        Console.WriteLine("NO");
        break;
}
//switch on expression
var carNo=177;
string cardName = carNo switch
{
    //if carNo =1 assign "ACE" to cardName (=>) is called lambda operator
    1=>"ACE",
    13=>"king",
    12=>"queen",
    10=>"jack",
    //else 
    _=>carNo.ToString()
};
Console.WriteLine(cardName);