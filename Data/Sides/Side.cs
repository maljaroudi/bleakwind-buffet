/*
 * Author: Moheeb Aljaroudi
 * Class name: Side.cs
 * Purpose: abstract Class used as base of side classes in side namespace
 */

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;
using System.ComponentModel;
using System.Runtime.CompilerServices;
namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// Provides base properties for every Side class. Implements IOrderItem. If a class iherit this abstract class, it should therefore implement the interface
    /// </summary>
    public abstract class Side : IOrderItem, INotifyPropertyChanged
    {

        /// <summary>
        /// Abstract for the Description of each entree derived from IOrderItem
        /// </summary>
        public abstract string Description { get; }

        private Size _size = Size.Small;
        /// <summary>
        /// Size of the side. Can be small, medium or large
        /// </summary>
        public virtual Size Size
        {
            get { return _size; }
            set 
            {
                _size = value;
                OnPropertyChanged();
                OnPropertyChanged("Calories");
                OnPropertyChanged("Price");
            }
        }

        /// <summary>
        /// Price of the Side in USD
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// Calories of the Side
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// List of special instructions depends on each class.
        /// </summary>
        public abstract List<String> SpecialInstructions { get; }


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
