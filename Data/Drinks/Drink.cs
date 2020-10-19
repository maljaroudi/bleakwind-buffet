/*
 * Author: Moheeb Aljaroudi
 * Class name: Drink.cs
 * Purpose: abstract Class used as base of drink classes in drink namespace
 */

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Runtime.CompilerServices;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Provides base properties for every drink class. Implements IOrderItem. If a class iherit this abstract class, it should therefore implement the interface
    /// </summary>
    public abstract class Drink : IOrderItem, INotifyPropertyChanged
    {
        private Size _size = Size.Small;
        /// <summary>
        /// Size of the drink. Can be small, medium or large
        /// </summary>
        public virtual Size Size 
        { 
            get 
            { 
                return _size;
            }
            set 
            { 
                _size = value;
                OnPropertyChanged("Size");
                OnPropertyChanged("Price");
                OnPropertyChanged("Calories");
                OnPropertyChanged("SpecialInstructions");
                
            } 
        }
        /// <summary>
        /// Price of the drink in USD
        /// </summary>
        public abstract double Price { get; }
        /// <summary>
        /// Calories of the drink
        /// </summary>
        public abstract uint Calories { get; }
        /// <summary>
        /// List of special instructions such as ice and cream
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
