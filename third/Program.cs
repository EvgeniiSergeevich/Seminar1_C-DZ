Console.WriteLine("Enter the integer number: ");
try {
    int i = Convert.ToInt32(Console.ReadLine());
    if(i%2 == 0) {
        Console.Write("The number " + i + " is even");
    } else {
        Console.Write("The number " + i + " is not even");
    }
} catch {
    Console.WriteLine("The number is not integer!");
}