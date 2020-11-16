/*
 * Author: Zachery Brunner
 * Class: GardenOrcOmeletteTests.cs
 * Purpose: Test the GardenOrcOmelette.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class GardenOrcOmeletteTests
    {
        [Fact]
        public void ShouldInlcudeBroccoliByDefault()
        {
            GardenOrcOmelette entree = new GardenOrcOmelette();
            Assert.True(entree.Broccoli);

        }

        [Fact]
        public void ShouldInlcudeMushroomsByDefault()
        {
            GardenOrcOmelette entree = new GardenOrcOmelette();
            Assert.True(entree.Mushrooms);
        }

        [Fact]
        public void ShouldInlcudeTomatoByDefault()
        {
            GardenOrcOmelette entree = new GardenOrcOmelette();
            Assert.True(entree.Tomato);
        }

        [Fact]
        public void ShouldInlcudeCheddarByDefault()
        {
            GardenOrcOmelette entree = new GardenOrcOmelette();
            Assert.True(entree.Cheddar);
        }

        [Fact]
        public void ShouldBeAbleToSetBroccoli()
        {
            GardenOrcOmelette entree = new GardenOrcOmelette();
            entree.Broccoli = false;
            Assert.False(entree.Broccoli);

        }

        [Fact]
        public void ShouldBeAbleToSetMushrooms()
        {
            GardenOrcOmelette entree = new GardenOrcOmelette();
            entree.Mushrooms = false;
            Assert.False(entree.Mushrooms);
        }

        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            GardenOrcOmelette entree = new GardenOrcOmelette();
            entree.Tomato = false;
            Assert.False(entree.Tomato);
        }

        [Fact]
        public void ShouldBeAbleToSetCheddar()
        {
            GardenOrcOmelette entree = new GardenOrcOmelette();
            entree.Cheddar = false;
            Assert.False(entree.Cheddar);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            GardenOrcOmelette entree = new GardenOrcOmelette();
            Assert.Equal(4.57, entree.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            GardenOrcOmelette entree = new GardenOrcOmelette();
            Assert.Equal(404.0, entree.Calories);
        }

        [Theory]
        [InlineData(true, true, true, true)]
        [InlineData(false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBroccoli, bool includeMushrooms,
                                                            bool includeTomato, bool includeCheddar)
        {
            GardenOrcOmelette entree = new GardenOrcOmelette();
            entree.Broccoli = includeBroccoli;
            entree.Mushrooms = includeMushrooms;
            entree.Tomato = includeTomato;
            entree.Cheddar = includeCheddar;
            if (!includeBroccoli) Assert.Contains("Hold broccoli", entree.SpecialInstructions);
            if (!includeMushrooms) Assert.Contains("Hold mushrooms", entree.SpecialInstructions);
            if (!includeTomato) Assert.Contains("Hold tomato", entree.SpecialInstructions);
            if (!includeCheddar) Assert.Contains("Hold cheddar", entree.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            GardenOrcOmelette entree = new GardenOrcOmelette();
            Assert.Equal("Garden Orc Omelette", entree.ToString());
        }

        [Fact]
        public void ShouldBeAssignableToInterfaceClass()
        {
            GardenOrcOmelette entree = new GardenOrcOmelette();
            Assert.IsAssignableFrom<IOrderItem>(entree);
        }

        [Fact]
        public void ShouldBeAssignableToAbstractDrinkClass()
        {
            GardenOrcOmelette entree = new GardenOrcOmelette();
            Assert.IsAssignableFrom<Entree>(entree);
        }





        [Theory]
        [InlineData("Broccoli")]
        [InlineData("Mushrooms")]
        [InlineData("Tomato")]
        [InlineData("Cheddar")]
        public void HoldingShouldNotifyPropertiesChange(string s)
        {
            GardenOrcOmelette entree = new GardenOrcOmelette();
            System.Action p = () =>
            {
                entree.Broccoli = false;
                entree.Mushrooms = false;
                entree.Tomato = false;
                entree.Cheddar = false;
            };
            Assert.PropertyChanged(entree, "SpecialInstructions", p);
            Assert.PropertyChanged(entree, s, p);



        }

        [Fact]
        public void ShouldDisplayCorrectDescription()
        {
            GardenOrcOmelette entree = new GardenOrcOmelette();
            Assert.Equal("Vegetarian. Two egg omelette packed with a mix of broccoli, mushrooms, and tomatoes. Topped with cheddar cheese.", entree.Description);
        }

    }
}