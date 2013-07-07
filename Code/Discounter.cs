using System.Collections.Generic;
using System.Linq;

namespace Code
{
    public class Discounter
    {
        private readonly IList<DiscountRule> _discountRules = new List<DiscountRule>
            {
                new DiscountRule("A", 3, 20),
                new DiscountRule("B", 2, 15)
            };

        public int Discount(string item)
        {
            return _discountRules.Sum(rule => rule.GetApplicableDiscount(item));
        }
    }
}
