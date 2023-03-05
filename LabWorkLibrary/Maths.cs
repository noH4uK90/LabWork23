namespace LabWorkLibrary;

public class Maths
{
    /// <summary>Число Pi</summary>
    public const double PI = 3.1415;
    
    /// <summary>Метод для сложения двух чисел</summary>
    /// <param name="a">Первое число</param>
    /// <param name="b">Второе число</param>
    /// <returns>Возвращает сумму двух чисел</returns>
    public static double Sum(double a, double b) => a + b;

    /// <summary>Метод для вычитания двух чисел</summary>
    /// <param name="a">Первое число</param>
    /// <param name="b">Второе число</param>
    /// <returns>Возвращает разность двух чисел</returns>
    public static double Subtraction(double a, double b) => a - b;

    /// <summary>Метод для умножения a на b</summary>
    /// <param name="a">Первое число</param>
    /// <param name="b">Второе число</param>
    /// <returns>Возвращает произведение двух чисел</returns>
    public static double Multiplication(double a, double b) => a * b;
    
    /// <summary>Метод для деления a на b</summary>
    /// <exception cref="T:System.ArgumentException">Генерирует исключение при попытке деления на 0</exception>
    /// <param name="a">Первое число</param>
    /// <param name="b">Второе число</param>
    /// <returns>Возвращает частное двух чисел</returns>
    public static double Division(double a, double b) => b != 0.0 ? a / b : throw new ArgumentException("Нельзя делить на 0");

    /// <summary>Метод для рассчёта площади прямоугольника</summary>
    /// /// <exception cref="T:System.ArgumentException">Генерирует исключение при значениях длины или ширины меньше 1</exception>
    /// <param name="width">Ширина</param>
    /// <param name="height">Высота</param>
    /// <returns>Возвращает частное двух чисел</returns>
    public static double SquareRectangle(double width, double height) => height < 1 || width < 1
        ? throw new ArgumentException("Длина и ширина должны быть больше 0")
        : width * height;
}