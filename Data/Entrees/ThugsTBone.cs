/*
 * Author: Moheeb Aljaroudi
 * Class name: ThugsTBone.cs
 * Purpose: Class used to represent Thugs T-Bone product details
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;


namespace BleakwindBuffet.Data.Entrees 
{
    /// <summary>
    /// Provides the product detail
    /// </summary>
    public class ThugsTBone : Entree, INotifyPropertyChanged
    {
        /// <summary>
        /// Price initalizer, sets the price for the entree
        /// </summary>
        public override double Price { get; } = 6.44;
        /// <summary>
        /// calorie to show how many colories, initalized.
        /// </summary>
        public override uint Calories { get; } = 982;

        /// <summary>
        /// List of special instructions, non there is. so it's empty.
        /// </summary>
        public override List<String> SpecialInstructions { get; } = new List<string>();

        /// <summary>
        /// overrides the ToString method
        /// </summary>
        /// <returns>string showing the Product name</returns>
        public override string ToString()
        {
            return "Thugs T-Bone";
        }


    }
}
