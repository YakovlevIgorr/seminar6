// Задача 43: Напишите программу, которая найдёт точку пересечения 
// двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

double b1 = 0;
double k1 = 0;
double b2 = 0;
double k2 = 0;
double x = 0;
double y = 0;


double inputData(string point)
{
    Console.WriteLine($"Введите значение {point} ");
    double number = Convert.ToDouble(Console.ReadLine());
    return number;
}

double found_X(double bb2, double bb1, double kk1, double kk2)
{
    double x = (b2 - b1) / (k1 - k2);
    return x;
}

double found_Y(double kk1, double x, double bb1)
{
    double y = (k1 * x) + b1;
    return y;
}

void printCoord()
{
    Console.WriteLine($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k1 = {k1} -> ({x};{y})");
}

b1 = inputData("b1");
k1 = inputData("k1");
b2 = inputData("b2");
k2 = inputData("k2");
x = found_X(b2,b1,k1,k2);
y = found_Y(k1,x,b1);
printCoord();







