using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGridMergedCells.ViewModel
{

    /// <summary>
    ///     Item is entity with name and price of item
    /// </summary>
    class Item
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Item" /> class.
        /// </summary>
        /// <param name="name">The name of item.</param>
        /// <param name="price">The price of item.</param>
        public Item(string name , double price)
        {
            this.Name = name;
            this.Price = price;
        }

        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>The name of item</value>
        public string Name { get; }

        /// <summary>
        /// Gets the price.
        /// </summary>
        /// <value>The price of item</value>
        public double Price { get; }
    }
}
