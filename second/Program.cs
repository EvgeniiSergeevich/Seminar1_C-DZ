Console.WriteLine("Enter three integer numbers: ");
try {
    int i = Convert.ToInt32(Console.ReadLine());
    int j = Convert.ToInt32(Console.ReadLine());
    int k = Convert.ToInt32(Console.ReadLine());
    int max = i;

    if(max < j) {
        max = j;
    }
    if (max < k) {
        max = k;
    }
    Console.WriteLine("Max number = " + max);
} catch {
    Console.WriteLine("Enter numbers again!");
}