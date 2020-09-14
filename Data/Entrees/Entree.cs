/*
 * Author: Moheeb Aljaroudi
 * Class name: Entree.cs
 * Purpose: abstract Class used as base of entree classes in entree namespace
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Provides base properties for every Entree class. Implements IOrderItem. If a class inherit this abstract class, it should therefore implement the interface
    /// </summary>
    public abstract class Entree : IOrderItem
    {
        /// <summary>
        /// Price of the drink in USD
        /// </summary>
        public abstract double Price { get; }
        /// <summary>
        /// Calorie of the entree
        /// </summary>
        public abstract uint Calories { get; }
        /// <summary>
        /// Special instructions for the entree, depends on each of the classes specs.
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }

    }
}
