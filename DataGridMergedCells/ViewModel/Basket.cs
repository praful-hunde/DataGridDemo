using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGridMergedCells.ViewModel
{

    /// <summary>
    ///     Basket is collection of 0 or more <see cref="Item"/>
    /// </summary>
    /// <seealso cref="System.Collections.Generic.List{DataGridMergedCells.ViewModel.Item}" />
    class Basket : List<Item>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Basket"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        public Basket(string name)
        {
            this.Name = name;
        }

        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value> The name.</value>
        public string Name { get; }
    }
}
