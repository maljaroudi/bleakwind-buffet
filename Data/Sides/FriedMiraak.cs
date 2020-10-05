/*
 * Author: Moheeb Aljaroudi
 * Class name: FriedMiraak.cs
 * Purpose: Class used to represent Fried Miraak product details
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
    public class FriedMiraak : Side, INotifyPropertyChanged
    {
        /// <summary>
        /// Price in relation to the size
        /// </summary>
        public override double Price
        {
            get
            {
                if (Size == Size.Small)
                {
                    OnPropertyChanged();
                    return 1.78;

                }

                else if (Size == Size.Medium)
                {
                    OnPropertyChanged();
                    return 2.01;
                }
                else
                {
                    OnPropertyChanged();
                    return 2.88;
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
                    return 151;

                }

                else if (Size == Size.Medium)
                {
                    OnPropertyChanged();
                    return 236;
                }
                else
                {
                    OnPropertyChanged();
                    return 306;
                }
            }
        }
        /// <summary>
        /// Special instruction list, there is non. so it's empty.
        /// </summary>
        public override List<String> SpecialInstructions { get; } = new List<string>();
        

        /// <summary>
        /// overrised the ToString method
        /// </summary>
        /// <returns>string showing the size from enum and the product name</returns>
        public override string ToString()
        {
            return $"{Size} Fried Miraak";
        }



    }
}
