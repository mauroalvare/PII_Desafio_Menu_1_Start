//------------------------------------------------------------------------------
// <copyright file="Dish.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//------------------------------------------------------------------------------

namespace Ucu.Poo.Restaurant
{
    /// <summary>
    /// Representa un platillo individual en el menú del restaurante.
    /// </summary>
    public class Dish
    {
        public string Name { get; }
        public double Price { get; }
        public bool IsVegetarian { get; }

        public Dish(string name, double price, bool isVegetarian)
        {
            Name = name;
            Price = price;
            IsVegetarian = isVegetarian;
        }
    }
}