// программа рассчитывает расстояние между двумя точками в пространстве
// координаты точки А
Console.Write("Введите координаты точки А. xa = ");
int xa = Convert. ToInt32(Console.ReadLine());
Console.Write("ya = ");
int ya = Convert. ToInt32(Console.ReadLine());
Console.Write("za = ");
int za = Convert. ToInt32(Console.ReadLine());

// координаты точки В
Console.Write("Введите координаты точки B. xb = ");
int xb = Convert. ToInt32(Console.ReadLine());
Console.Write("yb = ");
int yb = Convert. ToInt32(Console.ReadLine());
Console.Write("zb = ");
int zb = Convert. ToInt32(Console.ReadLine());

// находим расстояние между точками по формуле
double s; // расстояние между точками
s = Math.Sqrt((xa-xb)*(xa-xb) + (ya-yb)*(ya-yb) + (za-zb)*(za-zb));
Console.WriteLine("расстояние между точкой А и точкой В равно " + s);