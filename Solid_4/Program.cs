﻿using System;

/*Даний інтерфейс поганий тим, що він включає занадто багато методів.
 А що, якщо наш клас товарів не може мати знижок або промокодом, або для нього немає сенсу встановлювати матеріал з 
 якого зроблений (наприклад, для книг). Таким чином, щоб не реалізовувати в кожному класі невикористовувані в ньому методи, краще 
розбити інтерфейс на кілька дрібних і кожним конкретним класом реалізовувати потрібні інтерфейси.
Перепишіть, розбивши інтерфейс на декілька інтерфейсів, керуючись принципом розділення інтерфейсу. 
Опишіть класи книжки (розмір та колір не потрібні, але потрібна ціна та знижки) та верхній одяг (колір, розмір, ціна знижка),
які реалізують притаманні їм інтерфейси.*/

interface IHasPrice
{
    void SetPrice(double price);
}
interface IHasPromocodeDiscount
{
    void ApplyPromocode(String promocode);
}

interface IHasDiscount
{
    void ApplyDiscount(String discount);
}

interface IHasColor
{
    void SetColor(byte color);
}

interface IHasSize
{
    void SetSize(byte size);
}

class Book : IHasDiscount, IHasPrice, IHasPromocodeDiscount
{
    public void SetPrice(double price) { }
    public void ApplyPromocode(String promocode) { }
    public void ApplyDiscount(String discount) { }
}

class Clothes : IHasPrice, IHasDiscount, IHasColor, IHasSize, IHasPromocodeDiscount
{
    public void SetPrice(double price) { }
    public void SetColor(byte color) { }
    public void SetSize(byte size) { }
    public void ApplyPromocode(String promocode) { }
    public void ApplyDiscount(String discount) { }
}

class Program
{
    static void Main(string[] args)
    {
       
        Console.ReadKey();
    }
}