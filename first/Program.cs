Console.WriteLine("Enter two intrger numbers");
try {
    int x = Convert.ToInt32(Console.ReadLine());
    int y = Convert.ToInt32(Console.ReadLine());
    if(x < y) {
        Console.Write("Number " + x + " is less than number " + y);
    } else if(x > y) {
        Console.Write("Number " + x + " is greater than number " + y);
    }
    else {
        Console.Write("The numbers are equal");
    }

} catch {
    Console.WriteLine("Enter correct numbers");
}    