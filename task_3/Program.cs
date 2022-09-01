// программа формирует массив из кубов чисел от 1 до числа, полученного пользователем на входе

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

// обьявляем новый массив и заполняем его в цикле кубами чисел
int [] array_cubed = new int [number];
for (int i=0; i<number; i++)
{
   array_cubed[i] = (i+1)*(i+1)*(i+1);
   Console.WriteLine(array_cubed[i]);
} 
