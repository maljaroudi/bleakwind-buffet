using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.DataTests
{
    public class MenuTest
    {
        [Fact]
        public void AllShouldBeIncludedInMenu()
        {
            

            Assert.Collection(Menu.FullMenu(),
                item => Assert.IsType<BriarheartBurger>(item),
                item => Assert.IsType<DoubleDraugr>(item),
                item => Assert.IsType<GardenOrcOmelette>(item),
                item => Assert.IsType<PhillyPoacher>(item),
                item => Assert.IsType<SmokehouseSkeleton>(item),
                item => Assert.IsType<ThalmorTriple>(item),
                item => Assert.IsType<ThugsTBone>(item),

                item => Assert.IsType<AretinoAppleJuice>(item),
                item => Assert.IsType<AretinoAppleJuice>(item),
                item => Assert.IsType<AretinoAppleJuice>(item),
                item => Assert.IsType<CandlehearthCoffee>(item),
                item => Assert.IsType<CandlehearthCoffee>(item),
                item => Assert.IsType<CandlehearthCoffee>(item),
                item => Assert.IsType<MarkarthMilk>(item),
                item => Assert.IsType<MarkarthMilk>(item),
                item => Assert.IsType<MarkarthMilk>(item),
                item => Assert.IsType<SailorSoda>(item),
                item => Assert.IsType<SailorSoda>(item),
                item => Assert.IsType<SailorSoda>(item),
                item => Assert.IsType<SailorSoda>(item),
                item => Assert.IsType<SailorSoda>(item),
                item => Assert.IsType<SailorSoda>(item),
                item => Assert.IsType<SailorSoda>(item),
                item => Assert.IsType<SailorSoda>(item),
                item => Assert.IsType<SailorSoda>(item),
                item => Assert.IsType<SailorSoda>(item),
                item => Assert.IsType<SailorSoda>(item),
                item => Assert.IsType<SailorSoda>(item),
                item => Assert.IsType<SailorSoda>(item),
                item => Assert.IsType<SailorSoda>(item),
                item => Assert.IsType<SailorSoda>(item),
                item => Assert.IsType<SailorSoda>(item),
                item => Assert.IsType<SailorSoda>(item),
                item => Assert.IsType<SailorSoda>(item),
                item => Assert.IsType<WarriorWater>(item),
                item => Assert.IsType<WarriorWater>(item),
                item => Assert.IsType<WarriorWater>(item),

                item => Assert.IsType<DragonbornWaffleFries>(item),
                item => Assert.IsType<DragonbornWaffleFries>(item),
                item => Assert.IsType<DragonbornWaffleFries>(item),
                item => Assert.IsType<FriedMiraak>(item),
                item => Assert.IsType<FriedMiraak>(item),
                item => Assert.IsType<FriedMiraak>(item),
                item => Assert.IsType<MadOtarGrits>(item),
                item => Assert.IsType<MadOtarGrits>(item),
                item => Assert.IsType<MadOtarGrits>(item),
                item => Assert.IsType<VokunSalad>(item),
                item => Assert.IsType<VokunSalad>(item),
                item => Assert.IsType<VokunSalad>(item)


                );
        }

        [Fact]
        public void ShouldHaveAllDrinks()
        {

            Assert.Collection<IOrderItem>(Menu.Drinks(),
                item => Assert.IsType<AretinoAppleJuice>(item),
                item => Assert.IsType<AretinoAppleJuice>(item),
                item => Assert.IsType<AretinoAppleJuice>(item),
                item => Assert.IsType<CandlehearthCoffee>(item),
                item => Assert.IsType<CandlehearthCoffee>(item),
                item => Assert.IsType<CandlehearthCoffee>(item),
                item => Assert.IsType<MarkarthMilk>(item),
                item => Assert.IsType<MarkarthMilk>(item),
                item => Assert.IsType<MarkarthMilk>(item),
                item => Assert.IsType<SailorSoda>(item),
                item => Assert.IsType<SailorSoda>(item),
                item => Assert.IsType<SailorSoda>(item),
                item => Assert.IsType<SailorSoda>(item),
                item => Assert.IsType<SailorSoda>(item),
                item => Assert.IsType<SailorSoda>(item),
                item => Assert.IsType<SailorSoda>(item),
                item => Assert.IsType<SailorSoda>(item),
                item => Assert.IsType<SailorSoda>(item),
                item => Assert.IsType<SailorSoda>(item),
                item => Assert.IsType<SailorSoda>(item),
                item => Assert.IsType<SailorSoda>(item),
                item => Assert.IsType<SailorSoda>(item),
                item => Assert.IsType<SailorSoda>(item),
                item => Assert.IsType<SailorSoda>(item),
                item => Assert.IsType<SailorSoda>(item),
                item => Assert.IsType<SailorSoda>(item),
                item => Assert.IsType<SailorSoda>(item),
                item => Assert.IsType<WarriorWater>(item),
                item => Assert.IsType<WarriorWater>(item),
                item => Assert.IsType<WarriorWater>(item)
                );

            Assert.Collection<IOrderItem>(Menu.Drinks(),
                item => Assert.Contains($"{Size.Small}",item.ToString()),
                item => Assert.Contains($"{Size.Medium}", item.ToString()),
                item => Assert.Contains($"{Size.Large}", item.ToString()),
                item => Assert.Contains($"{Size.Small}", item.ToString()),
                item => Assert.Contains($"{Size.Medium}", item.ToString()),
                item => Assert.Contains($"{Size.Large}", item.ToString()),
                item => Assert.Contains($"{Size.Small}", item.ToString()),
                item => Assert.Contains($"{Size.Medium}", item.ToString()),
                item => Assert.Contains($"{Size.Large}", item.ToString()),
                item => Assert.Contains($"{Size.Small} {SodaFlavor.Blackberry}", item.ToString()),
                item => Assert.Contains($"{Size.Medium} {SodaFlavor.Blackberry}", item.ToString()),
                item => Assert.Contains($"{Size.Large} {SodaFlavor.Blackberry}", item.ToString()),
                item => Assert.Contains($"{Size.Small} {SodaFlavor.Cherry}", item.ToString()),
                item => Assert.Contains($"{Size.Medium} {SodaFlavor.Cherry}", item.ToString()),
                item => Assert.Contains($"{Size.Large} {SodaFlavor.Cherry}", item.ToString()),
                item => Assert.Contains($"{Size.Small} {SodaFlavor.Grapefruit}", item.ToString()),
                item => Assert.Contains($"{Size.Medium} {SodaFlavor.Grapefruit}", item.ToString()),
                item => Assert.Contains($"{Size.Large} {SodaFlavor.Grapefruit}", item.ToString()),
                item => Assert.Contains($"{Size.Small} {SodaFlavor.Lemon}", item.ToString()),
                item => Assert.Contains($"{Size.Medium} {SodaFlavor.Lemon}", item.ToString()),
                item => Assert.Contains($"{Size.Large} {SodaFlavor.Lemon}", item.ToString()),
                item => Assert.Contains($"{Size.Small} {SodaFlavor.Peach}", item.ToString()),
                item => Assert.Contains($"{Size.Medium} {SodaFlavor.Peach}", item.ToString()),
                item => Assert.Contains($"{Size.Large} {SodaFlavor.Peach}", item.ToString()),
                item => Assert.Contains($"{Size.Small} {SodaFlavor.Watermelon}", item.ToString()),
                item => Assert.Contains($"{Size.Medium} {SodaFlavor.Watermelon}", item.ToString()),
                item => Assert.Contains($"{Size.Large} {SodaFlavor.Watermelon}", item.ToString()),
                item => Assert.Contains($"{Size.Small}", item.ToString()),
                item => Assert.Contains($"{Size.Medium}", item.ToString()),
                item => Assert.Contains($"{Size.Large}", item.ToString())


                );

           

        }


        [Fact]
        public void ShouldHaveAllEntrees()
        {
            Assert.Collection<IOrderItem>(Menu.Entrees(),
                item => Assert.IsType<BriarheartBurger>(item),
                item => Assert.IsType<DoubleDraugr>(item),
                item => Assert.IsType<GardenOrcOmelette>(item),
                item => Assert.IsType<PhillyPoacher>(item),
                item => Assert.IsType<SmokehouseSkeleton>(item),
                item => Assert.IsType<ThalmorTriple>(item),
                item => Assert.IsType<ThugsTBone>(item)
                );
        }

        [Fact]
        public void ShouldHaveAllSides()
        {
            Assert.Collection<IOrderItem>(Menu.Sides(),
                item => Assert.IsType<DragonbornWaffleFries>(item),
                item => Assert.IsType<DragonbornWaffleFries>(item),
                item => Assert.IsType<DragonbornWaffleFries>(item),
                item => Assert.IsType<FriedMiraak>(item),
                item => Assert.IsType<FriedMiraak>(item),
                item => Assert.IsType<FriedMiraak>(item),
                item => Assert.IsType<MadOtarGrits>(item),
                item => Assert.IsType<MadOtarGrits>(item),
                item => Assert.IsType<MadOtarGrits>(item),
                item => Assert.IsType<VokunSalad>(item),
                item => Assert.IsType<VokunSalad>(item),
                item => Assert.IsType<VokunSalad>(item)
                );
            Assert.Collection<IOrderItem>(Menu.Sides(),
                item => Assert.Contains($"{Size.Small}", item.ToString()),
                item => Assert.Contains($"{Size.Medium}", item.ToString()),
                item => Assert.Contains($"{Size.Large}", item.ToString()),
                item => Assert.Contains($"{Size.Small}", item.ToString()),
                item => Assert.Contains($"{Size.Medium}", item.ToString()),
                item => Assert.Contains($"{Size.Large}", item.ToString()),
                item => Assert.Contains($"{Size.Small}", item.ToString()),
                item => Assert.Contains($"{Size.Medium}", item.ToString()),
                item => Assert.Contains($"{Size.Large}", item.ToString()),
                item => Assert.Contains($"{Size.Small}", item.ToString()),
                item => Assert.Contains($"{Size.Medium}", item.ToString()),
                item => Assert.Contains($"{Size.Large}", item.ToString())

                );
        }

    }
}
