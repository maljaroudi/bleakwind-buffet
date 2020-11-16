/*
 * Author: Moheeb Aljaroudi
 * Class name: MadOtarGrits.cs
 * Purpose: Class used to represent Mad Otar Grits product details
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
    public class MadOtarGrits : Side, INotifyPropertyChanged
    {

        /// <summary>
        /// override for the abstract and IOrderItem property implementation. Shows the description of the item
        /// </summary>
        public override string Description { get; } = "Cheesey Grits.";


        /// <summary>
        /// Price in relation to the size.
        /// </summary>
        public override double Price
        {
            get
            {
                if (Size == Size.Small)
                {
                    OnPropertyChanged();
                    return 1.22;

                }

                else if (Size == Size.Medium)
                {
                    OnPropertyChanged();
                    return 1.58;
                }
                else
                {
                    OnPropertyChanged();
                    return 1.93;
                }
            }

        }
        /// <summary>
        /// Calories in relation to the size
        /// </summary>
        public override uint Calories
        {
            get
            {
                if (Size == Size.Small)
                {
                    OnPropertyChanged();
                    return 105;

                }

                else if (Size == Size.Medium)
                {
                    OnPropertyChanged();
                    return 142;
                }
                else
                {
                    OnPropertyChanged();
                    return 179;
                }
            }
        }
        /// <summary>
        /// Special instruction list, empty because there is non.
        /// </summary>
        public override List<String> SpecialInstructions { get; } = new List<string>();


        /// <summary>
        /// overrised the ToString method
        /// </summary>
        /// <returns>string showing the size from enum and the product name</returns>
        public override string ToString()
        {
            return $"{Size} Mad Otar Grits";
        }


    }
}
