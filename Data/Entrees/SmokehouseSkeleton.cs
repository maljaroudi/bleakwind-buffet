/*
 * Author: Moheeb Aljaroudi
 * Class name: SmokehouseSkeleton.cs
 * Purpose: Class used to represent Smokehouse Skeleton product details
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
    public class SmokehouseSkeleton : Entree, INotifyPropertyChanged
    {
        /// <summary>
        /// override for the abstract and IOrderItem property implementation. Shows the description of the item
        /// </summary>
        public override string Description { get; } = "Put some meat on those bones with a small stack of pancakes. Includes sausage links, eggs, and hash browns on the side. Topped with the syrup of your choice.";

        /// <summary>
        /// Price initalizer sets it across all options
        /// </summary>
        public override double Price { get;  } = 5.62;

        /// <summary>
        /// Calories to show how many calories in the dish
        /// </summary>
        public override uint Calories { get; } = 602;

        /// <summary>
        /// Special instructions in case the customer doesn't want an option. it adds "hold [item]" for each item he doesn't want
        /// </summary>
        public override List<String> SpecialInstructions
        {
            get
            {
                List<String> SpecialInstructions = new List<string>();
                if (SausageLink == false) SpecialInstructions.Add("Hold sausage");
                if (HashBrowns == false) SpecialInstructions.Add("Hold hash browns");
                if (Pancake == false) SpecialInstructions.Add("Hold pancakes");
                if (Egg == false) SpecialInstructions.Add("Hold eggs");
                OnPropertyChanged();
                return SpecialInstructions;
            }

        }

        /// <summary>
        /// overrides the ToString method
        /// </summary>
        /// <returns>string showing the Product name</returns>
        public override string ToString()
        {
            return "Smokehouse Skeleton";
        }



        private bool _susageLink = true;


        /// <summary>
        /// Sausage option, defaults to true
        /// </summary>
        public bool SausageLink
        {
            get { return _susageLink; }
            set
            {
                _susageLink = value;
                OnPropertyChanged();
                OnPropertyChanged("SpecialInstructions");
            }
        }


        private bool _hashBrowns = true;

        /// <summary>
        /// Hash browns option, set to true
        /// </summary>
        public bool HashBrowns
        {
            get { return _hashBrowns; }
            set
            {
                _hashBrowns = value;
                OnPropertyChanged();
                OnPropertyChanged("SpecialInstructions");
            }
        }


        private bool _pancake = true;

        /// <summary>
        /// Pancake option, defaults to true
        /// </summary>
        public bool Pancake
        {
            get { return _pancake; }
            set
            {
                _pancake = value;
                OnPropertyChanged();
                OnPropertyChanged("SpecialInstructions");
            }
        }

        private bool _egg = true;
        /// <summary>
        /// egg option, set to true
        /// </summary>
        public bool Egg
        {
            get { return _egg; }
            set
            {
                _egg = value;
                OnPropertyChanged();
                OnPropertyChanged("SpecialInstructions");
            }
        }



    }
}
