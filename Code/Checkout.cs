namespace Code
{
    public class Checkout
    {
        private readonly Scanner _scanner = new Scanner();
        private readonly Discounter _discounter = new Discounter();

        public int Process(Basket basket)
        {
            var cost = 0;
            basket.ForEachItem(item =>
                {
                    cost += _scanner.Scan(item);
                    cost -= _discounter.Discount(item);
                });
            return cost;
        }
    }
}
