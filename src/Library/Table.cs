//------------------------------------------------------------------------------
// <copyright file="Table.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//------------------------------------------------------------------------------

using System.Collections;

namespace Ucu.Poo.Restaurant
{
    /// <summary>
    /// Representa una mesa en el restaurante.
    /// </summary>
    public class Table
    {
        private ArrayList order = new ArrayList();

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="Table"/>.
        /// </summary>
        /// <param name="number">El número identificador de la mesa.</param>
        public Table(int number)
        {
            this.Number = number;
        }

        /// <summary>
        /// Obtiene o establece el número identificador de la mesa.
        /// </summary>
        public int Number {get; set;}

        /// <summary>
        /// Obtiene o establece un valor que indica si la mesa está ocupada.
        /// </summary>
        public bool IsOccupied{get; set;}

        /// <summary>
        /// Marca la mesa como ocupada.
        /// </summary>
        public void Occupy()
        {
            this.IsOccupied = true;
        }

        /// <summary>
        /// Libera la mesa y vacía la lista de pedidos.
        /// </summary>
        public void Free()
        {
            this.IsOccupied = false;
            this.order.Clear();
        }

        /// <summary>
        /// Agrega un platillo a los que han sido ordenados en la mesa.
        /// </summary>
        /// <param name="dish">El platillo a agregar.</param>
        public void AddToOrder(Dish dish)
        {
            this.order.Add(dish);
        }

        /// <summary>
        /// Determina si la mesa tiene pedidos o no.
        /// </summary>
        /// <returns>true si la mesa tiene pedidos; false en caso contrario.</returns>
        public bool HasOrders()
        {
            return this.order.Count > 0;
        }
    }
}