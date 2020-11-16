/*
 * Author: Moheeb Aljaroudi
 * Class name: MarkarthMilk.cs
 * Purpose: Class used to represent Markarth Milk product details
 */
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Provides the Markarth Milk product detail
    /// </summary>
    public class MarkarthMilk : Drink
    {


        /// <summary>
        /// override for the abstract and IOrderItem property implementation. Shows the description of the item
        /// </summary>
        public override string Description { get; } = "Hormone-free organic 2% milk.";



        /// <summary>
        /// Price in relation to size of the drink
        /// </summary>
        public override double Price
        {
            get
            {
                if (Size == Size.Small)
                {
                    return 1.05;

                }

                else if (Size == Size.Medium)
                {
                    return 1.11;
                }
                else
                {
                    return 1.22;
                }
            }

        }
        /// <summary>
        /// Calories in relation to size of the drink
        /// </summary>
        public override uint Calories
        {
            get
            {
                if (Size == Size.Small)
                {
                    return 56;

                }

                else if (Size == Size.Medium)
                {
                    return 72;
                }
                else
                {
                    return 93;
                }
            }
        }
        /// <summary>
        /// Special instructions. 
        /// It adds "Add ice" when ice is needed, otherwise it shows empty list.
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
                }
                return SpecialInstructions;
            }

        }


        private bool _ice = false;
        /// <summary>
        /// Whether the costumer needs ice default to no.
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
        /// Overrisde ToString() to show the product name
        /// </summary>
        /// <returns>string value for the product and its size</returns>
        public override string ToString()
        {
            
            return $"{Size} Markarth Milk";
        }


    }
}
