/*
 * Author: Moheeb Aljaroudi
 * Class name: DragonbornWaffleFries.cs
 * Purpose: Class used to represent Dragonborn Waffle Fries product details
 */

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;
using System.ComponentModel;
namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// Provides the product detail
    /// </summary>
    public class DragonbornWaffleFries : Side, INotifyPropertyChanged
    {


        /// <summary>
        /// override for the abstract and IOrderItem property implementation. Shows the description of the item
        /// </summary>
        public override string Description { get; } = "Crispy fried potato waffle fries.";





        /// <summary>
        /// Sets the price in relation to the size of the side. 
        /// </summary>
        public override double Price
        {
            get
            {
                if (Size == Size.Small)
                {
                    OnPropertyChanged();
                    return 0.42;

                }

                else if (Size == Size.Medium)
                {
                    OnPropertyChanged();
                    return 0.76;
                }
                else
                {
                    OnPropertyChanged();
                    return 0.96;
                }
            }

        }
        /// <summary>
        /// sets the calories in terms of the size 
        /// </summary>
        public override uint Calories
        {
            get
            {
                if (Size == Size.Small)
                {
                    OnPropertyChanged();
                    return 77;

                }

                else if (Size == Size.Medium)
                {
                    OnPropertyChanged();
                    return 89;
                }
                else
                {
                    OnPropertyChanged();
                    return 100;
                }
            }
        }
        /// <summary>
        /// special instruction list, there is non for this item, so it's empty.
        /// </summary>
        public override List<String> SpecialInstructions { get; } = new List<string>();


        /// <summary>
        /// overrised the ToString method
        /// </summary>
        /// <returns>string showing the size from enum and the product name</returns>
        public override string ToString()
        {
            return $"{Size} Dragonborn Waffle Fries";
        }


    }
}
