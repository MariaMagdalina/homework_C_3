// данная программа проверяет - является ли число палиндромом 
Console.Write("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());

// определим количество цифр в числе
int quantity = 1; // переменная для подсчета цифр в числе
int digit_capacity = 1; // переменная для подсчета десятков
bool t = false;
int number1 = number; // вводим переменную для того, чтобы не потерять первичное значение нашего числа
while(t == false)
{
   if(number1 / 10 > 0)
      {
         quantity++;
         digit_capacity = digit_capacity * 10;
         number1 = number1/10;
      }
   else 
      t = true;
}

// проверяем является ли число палиндромом
int k = 1;
int i = 1; 
while(i < quantity/2)
{
  if((number/digit_capacity)%10 == (number/k)%10) // сравниваем поочередно крайние цифры
  {
   digit_capacity = digit_capacity/10; // уменьшаем делитель для определерния крайней справа цифры в 10 раз
   k = k*10; // увеличиваем делитель для определения крайней слева цифры в 10 раз
  }
  else
  t = false; // если сравниваемые цифры не равны меняем значение переменной t
  i++;
}

// Если сравниваемые цифры были равны, то переменная t не менялась и выводится сообщение "да", иначе выводится сообщение "нет"
if(t == true)
   Console.WriteLine("да");
else 
   Console.WriteLine("нет");