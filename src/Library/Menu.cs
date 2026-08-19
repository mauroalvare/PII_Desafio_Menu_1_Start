//------------------------------------------------------------------------------
// <copyright file="Menu.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//------------------------------------------------------------------------------

/*
Menu

Tareas

- Conocer la lista de platillos disponibles en el restaurante
- Agregar un platillo a la lista de platillos del menú
- Eliminar un platillo de la lista del menú
- Buscar y devolver un platillo específico del menú basado en su nombre

Colaborar: Dish

Responsabilidades de conocer:

dishes: Conocer la lista de platillos disponibles en el restaurante; esta responsabilidad está ya implementada 
con la variable de instancia dishes en el código provisto.

Responsabilidades de hacer:

- AddDish(Dish): Agregar un platillo a la lista de platillos del menú.
- RemoveDish(Dish): Eliminar un platillo de la lista del menú.
- Dish GetDishByName(string): Buscar y devolver un platillo específico del menú basado en su nombre; retorna null si no encuentra en platillo.

*/


using System.Collections;

namespace Ucu.Poo.Restaurant
{
    // <summary>
    // Representa el conjunto de platillos <see cref="Dish"/> disponibles en el
    // restaurante.
    // </summary>
     
    
    public class Menu
    {
        private ArrayList dishes = new ArrayList();

        public void AddDish(Dish dish)
    {
        if (dish != null)
        {
            this.dishes.Add(dish);
        }
    }

        public void RemoveDish(Dish dish)
    {
        if (dish != null)
        {
            this.dishes.Remove(dish);
        }
    }

        public Dish GetDishByName(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            return null;
        }
        foreach (Dish dish in this.dishes)
        {
            if (dish.Name.ToLower() == name.ToLower())
            {
                return dish;
            }
        }

        return null;
    }
    }
}