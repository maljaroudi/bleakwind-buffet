/*
 * Author: Moheeb Aljaroudi
 * Class name: Drink.cs
 * Purpose: abstract Class used as base of drink classes in drink namespace
 */

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Provides base properties for every drink class. Implements IOrderItem. If a class iherit this abstract class, it should therefore implement the interface
    /// </summary>
    public abstract class Drink : IOrderItem
    {
        /// <summary>
        /// Size of the drink. Can be small, medium or large
        /// </summary>
        public virtual Size Size { get; set; }
        /// <summary>
        /// Price of the drink in USD
        /// </summary>
        public abstract double Price { get; }
        /// <summary>
        /// Calories of the drink
        /// </summary>
        public abstract uint Calories { get; }
        /// <summary>
        /// List of special instructions such as ice and cream
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }
    }
}
