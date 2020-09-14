using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;
using System;
using System.Collections.Generic;
/*
 * Author: Moheeb Aljaroudi
 * Class name: Menu.cs
 * Purpose: static Class used to list all menu items in the Buffet.
 */

using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Reflection;

namespace BleakwindBuffet.Data
{
    /// <summary>
    /// Provides a list of requested namespace
    /// </summary>
    public static class Menu
    {
        
        /// <summary>
        /// Function to show all items in the buffet. It calls all functions and puts them in the list
        /// </summary>
        /// <returns>List of all items on every namespace</returns>
        public static IEnumerable<IOrderItem> FullMenu()
        {
            List<IOrderItem> items = new List<IOrderItem>();
            items.AddRange(Entrees());
            items.AddRange(Drinks());
            items.AddRange(Sides());
            return items;
        }
        /// <summary>
        /// Show all Entrees in the buffet. Adds an instance of each item on the entree name space in a list
        /// </summary>
        /// <returns>List of all entrees</returns>
        public static IEnumerable<IOrderItem> Entrees()
        {
            List<IOrderItem> items = new List<IOrderItem>();
            items.Add(new BriarheartBurger());
            items.Add(new DoubleDraugr());
            items.Add(new GardenOrcOmelette());
            items.Add(new PhillyPoacher());
            items.Add(new SmokehouseSkeleton());
            items.Add(new ThalmorTriple());
            items.Add(new ThugsTBone());
            return items;
        }


        /// <summary>
        /// Displays all drinks in the buffet. 
        /// The function iterate through all sizes and creates an instance of every class in the drink namespace with every size
        /// For soda, it also iterate through every soda flavor.
        /// </summary>
        /// <returns>list of all drinks with all sizes</returns>
        public static IEnumerable<IOrderItem> Drinks()
        {
            List<IOrderItem> baseItems = new List<IOrderItem>();

            
            foreach (Size s in Enum.GetValues(typeof(Size)))
            {
                AretinoAppleJuice drink = new AretinoAppleJuice();
                drink.Size = s;
                baseItems.Add(drink);

            }

            foreach (Size s in Enum.GetValues(typeof(Size)))
            {
                CandlehearthCoffee drink = new CandlehearthCoffee();
                drink.Size = s;
                baseItems.Add(drink);

            }

            foreach (Size s in Enum.GetValues(typeof(Size)))
            {
                MarkarthMilk drink = new MarkarthMilk();
                drink.Size = s;
                baseItems.Add(drink);

            }

            foreach (SodaFlavor f in Enum.GetValues(typeof(SodaFlavor)))
            {
                foreach (Size s in Enum.GetValues(typeof(Size)))
                {
                    SailorSoda drink = new SailorSoda();
                    drink.Size = s;
                    drink.Flavor = f;
                    baseItems.Add(drink);

                }

            }
            foreach (Size s in Enum.GetValues(typeof(Size)))
            {
                WarriorWater drink = new WarriorWater();
                drink.Size = s;
                baseItems.Add(drink);

            }
            
                

            
            
            
            return baseItems;
        }

        /// <summary>
        /// Displays a list of all sides
        /// it iterates through enums and create an instance of every class in side namespace with each size.
        /// </summary>
        /// <returns>List of all sides and their sizes</returns>
        public static IEnumerable<IOrderItem> Sides()
        {

            List<IOrderItem> items = new List<IOrderItem>();

            foreach (Size s in Enum.GetValues(typeof(Size)))
            {
                DragonbornWaffleFries side = new DragonbornWaffleFries();
                side.Size = s;
                items.Add(side);

            }

            foreach (Size s in Enum.GetValues(typeof(Size)))
            {
                FriedMiraak side = new FriedMiraak();
                side.Size = s;
                items.Add(side);

            }

            foreach (Size s in Enum.GetValues(typeof(Size)))
            {
                MadOtarGrits side = new MadOtarGrits();
                side.Size = s;
                items.Add(side);

            }

            foreach (Size s in Enum.GetValues(typeof(Size)))
            {
                VokunSalad side = new VokunSalad();
                side.Size = s;
                items.Add(side);

            }

            return items;
        }


    }
}
