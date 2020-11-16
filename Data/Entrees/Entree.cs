/*
 * Author: Moheeb Aljaroudi
 * Class name: Entree.cs
 * Purpose: abstract Class used as base of entree classes in entree namespace
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Provides base properties for every Entree class. Implements IOrderItem. If a class inherit this abstract class, it should therefore implement the interface
    /// </summary>
    public abstract class Entree : IOrderItem
    {
        /// <summary>
        /// Abstract for the Description of each entree derived from IOrderItem
        /// </summary>
        public abstract string Description { get; }

        /// <summary>
        /// Price of the drink in USD
        /// </summary>
        public abstract double Price { get; }
        /// <summary>
        /// Calorie of the entree
        /// </summary>
        public abstract uint Calories { get; }
        /// <summary>
        /// Special instructions for the entree, depends on each of the classes specs.
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }

        /// <summary>
        /// Event Handler for INotifyPropertyChanged interface
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;




        /// <summary>
        /// Property Change event caller for INotifyPropertyChanged interface .
        /// </summary>
        /// <param name="name">Name of the changing property.</param>
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
