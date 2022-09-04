Console.WriteLine("Enter the integer number: ");
try{
    int x = Convert.ToInt32(Console.ReadLine());
    int i = 1;
    while (i <= x) {
        if(i % 2 == 0) {
            Console.Write(i + ", ");
        }
        i++;
    }
} catch {
    Console.WriteLine("The number is not integer!!!1!");
}