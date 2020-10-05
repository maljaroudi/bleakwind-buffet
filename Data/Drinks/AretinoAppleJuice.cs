/*
 * Author: Moheeb Aljaroudi
 * Class name: AretinoAppleJuice.cs
 * Purpose: Class used to represent Aretino Apple Juice product details
 */

using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;
using System.Text;
using BleakwindBuffet.Data.Enums;
namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Provides the Aretino Apple Juice product detail
    /// </summary>
    public class AretinoAppleJuice : Drink
    {




        /// <summary>
        /// Sets price in relation to the Size of the item
        /// </summary>
        public override double Price
        { 
        get
            {
                if (Size == Size.Small)
                {
                    return 0.62;
                   
                }

                else if (Size == Size.Medium)
                {
                    return 0.87;
                }
                else 
                {
                    return 1.01;
                }
            }
        
         }
        
        /// <summary>
        /// overrides calories in relation to the Size of the item
        /// </summary>
        public override uint Calories 
        {
            get
            {
                if (Size == Size.Small)
                {
                    return 44;

                }

                else if (Size == Size.Medium)
                {
                    return 88;
                }
                else
                {
                    return 132;
                }
            }
        }
        /// <summary>
        /// List of special instructions
        /// Adds ice to the list when ice is checked
        /// </summary>
        public override List<String> SpecialInstructions
        {
            get
            {
                List<String> SpecialInstructions = new List<string>();
                if (!Ice) return SpecialInstructions;
                else
                {
                    SpecialInstructions.Add("Add ice");
                    OnPropertyChanged();
                    return SpecialInstructions;
                }
            }
            
        }



        private bool _ice = false;
        /// <summary>
        /// Whether ice is needed, default is false
        /// </summary>
        public bool Ice
        {
            get { return _ice; }
            set
            {
                _ice = value;
                OnPropertyChanged();
                OnPropertyChanged("SpecialInstructions");
            }
        }

        /// <summary>
        /// overrised the ToString method
        /// </summary>
        /// <returns>string showing the size from enum and the product name</returns>
        public override string ToString()
        {
            return $"{Size} Aretino Apple Juice";
        }


    }
}
