namespace Code
{
    public class DiscountRule
    {
        private readonly string _item;
        private readonly int _triggerQuantity;
        private readonly int _discount;
        private int _count;

        public DiscountRule(string item, int triggerQuantity, int discount)
        {
            _discount = discount;
            _triggerQuantity = triggerQuantity;
            _item = item;
        }

        public int GetApplicableDiscount(string item)
        {
            if (item == _item)
            {
                RecordItem();
                return RuleIsTriggered() ? _discount : 0;
            }

            return 0;
        }

        private void RecordItem()
        {
            _count++;
        }

        private bool RuleIsTriggered()
        {
            return (_count % _triggerQuantity == 0);
        }
    }
}
