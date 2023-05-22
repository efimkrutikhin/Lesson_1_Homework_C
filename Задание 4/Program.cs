Console.WriteLine("Введите ваше число");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Чётные числа:");

for( int i= 1; i <=num; i++){
    if(i % 2 ==0){
        Console.WriteLine(i);
    }
}
    Console.ReadKey();