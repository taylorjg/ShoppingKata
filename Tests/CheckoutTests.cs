using System;
using Code;
using NUnit.Framework;

namespace Tests
{
    // ReSharper disable InconsistentNaming

    [TestFixture]
    class CheckoutTests
    {
        [TestCase("", 0)]
        [TestCase("A", 50)]
        [TestCase("B", 30)]
        [TestCase("C", 20)]
        [TestCase("D", 15)]
        [TestCase("AB", 50 + 30)]
        [TestCase("AAA", 130)]
        [TestCase("BB", 45)]
        [TestCase("BBBB", 90)]
        [TestCase("AAABBBBC", 130 + 45 + 45 + 20)]
        [TestCase("BABAABBC", 130 + 45 + 45 + 20)]
        [TestCase("BBB", 45 + 30)]
        public void ABasketWithGivenContentsShouldCost(string items, int expectedCost)
        {
            var checkout = new Checkout();
            var basket = new Basket();
            AddItemsToBasket(items, basket);
            var actual = checkout.Process(basket);
            Assert.That(actual, Is.EqualTo(expectedCost));
        }

        private static void AddItemsToBasket(string items, Basket basket)
        {
            foreach (var item in items.ToCharArray())
            {
                basket.Add(Convert.ToString(item));
            }
        }
    }
}
