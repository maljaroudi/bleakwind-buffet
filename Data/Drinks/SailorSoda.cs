/*
 * Author: Moheeb Aljaroudi
 * Class name: CandlehearthCoffee.cs
 * Purpose: Class used to represent Sailor Soda product details
 */
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;




namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Provides the Sailor Soda product detail
    /// </summary>
    public class SailorSoda : Drink
    {
        /// <summary>
        /// Price in relation to size.
        /// </summary>
        public override double Price
        {
            get
            {
                if (Size == Size.Small)
                {
                    return 1.42;

                }

                else if (Size == Size.Medium)
                {
                    return 1.74;
                }
                else
                {
                    return 2.07;
                }
            }

        }
        /// <summary>
        /// Calories in relation to Size
        /// </summary>
        public override uint Calories
        {
            get
            {
                if (Size == Size.Small)
                {
                    return 117;

                }

                else if (Size == Size.Medium)
                {
                    return 153;
                }
                else
                {
                    return 205;
                }
            }
        }
        /// <summary>
        /// Special Instructions, Adds "Hold Ice" when ice isn't needed.
        /// </summary>
        public override List<String> SpecialInstructions
        {
            get
            {
                List<String> SpecialInstructions = new List<string>();
                if (Ice) return SpecialInstructions;
                else
                {
                    SpecialInstructions.Add("Hold ice");
                    
                }
                return SpecialInstructions;
            }

        }


        /// <summary>
        /// Ice, defaults to true
        /// </summary>
        public bool Ice { get; set; } = true;
        /// <summary>
        /// Flavor, defaults to Cherry
        /// </summary>
        public SodaFlavor Flavor { get; set;} = SodaFlavor.Cherry;

        /// <summary>
        /// Overrisde ToString() to show the product name
        /// </summary>
        /// <returns>string value for the product and its size</returns>
        public override string ToString()
        {
            return $"{Size} {Flavor} Sailor Soda";
        }



    }
}
