/*
 * Author: Moheeb Aljaroudi
 * Class name: Side.cs
 * Purpose: abstract Class used as base of side classes in side namespace
 */

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;
namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// Provides base properties for every Side class. Implements IOrderItem. If a class iherit this abstract class, it should therefore implement the interface
    /// </summary>
    public abstract class Side : IOrderItem
    {
        /// <summary>
        /// Size of the side. Can be small, medium or large
        /// </summary>
        public virtual Size Size { get; set; }

        /// <summary>
        /// Price of the Side in USD
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// Calories of the Side
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// List of special instructions depends on each class.
        /// </summary>
        public abstract List<String> SpecialInstructions { get; }




    }
}
