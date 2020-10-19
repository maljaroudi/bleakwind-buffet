/*
 * Author: Moheeb Aljaroudi
 * Class name: IOrderItem.cs
 * Purpose: interface used to as implementaiton on every class
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Runtime.CompilerServices;

namespace BleakwindBuffet.Data
{
    /// <summary>
    /// Provides an interface for all menu items
    /// </summary>
    public interface IOrderItem: INotifyPropertyChanged


    {
        /// <summary>
        /// Price in USD
        /// </summary>
        double Price { get; }

        /// <summary>
        /// Calories of the item
        /// </summary>
        uint Calories { get; }


        /// <summary>
        /// Special Instructions for the item
        /// </summary>
        List<String> SpecialInstructions { get; }









    }
}
