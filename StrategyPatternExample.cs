using System.Collections.Generic;
using System.Linq;

namespace StrategyPattern_DiscountSaleExample
{
     /*
     for best practices don't write all tasks or classes in one file
     must to split all of them in its owner file.
     so this just for toturial
     and easy to moving from class to other.
    */
    public interface IStrategyDiscound
    {
        decimal ApplayDiscount(decimal sale);
    }
    public abstract class StrategyDiscountBase : IStrategyDiscound
    {
        private int space = 10;
        public string GetObjFormattingTesting()
        {
            string objName = this.ToString();
            objName = objName.Substring(objName.LastIndexOf(".") + 1);
            string formate = $"{objName}-->{this.GetFormattingPercentage().PadLeft(space)}\n";

            space++;
            return formate;
        }
        public string GetFormattingPercentage()
        {
            double percentage = discountPercentage / 100;
            return percentage.ToString("P2");

        }
        public double GetdiscountPercentage()
        {
            return this.discountPercentage;
        }
        protected double discountPercentage { get; set; }
        public abstract decimal ApplayDiscount(decimal sale);

    }
    public class NonDiscount : StrategyDiscountBase
    {
        public NonDiscount()
        {
            discountPercentage = 0d;
        }
        public override decimal ApplayDiscount(decimal sale)
        {
            return (decimal)(100 - discountPercentage) * sale / 100;
        }
    }
    public class LayaltyDiscount : StrategyDiscountBase
    {
        public LayaltyDiscount()
        {
            discountPercentage = 15d;
        }
        public override decimal ApplayDiscount(decimal sale)
        {
            return (decimal)(100 - discountPercentage) * sale / 100;
        }
    }
    public class LayaltyStudentDiscount : StrategyDiscountBase
    {
        public LayaltyStudentDiscount()
        {
            discountPercentage = 25d;
        }
        public override decimal ApplayDiscount(decimal sale)
        {
            return (decimal)(100 - discountPercentage) * sale / 100;
        }
    }
    public class StudentDiscount : StrategyDiscountBase
    {
        public StudentDiscount()
        {
            discountPercentage = 10d;
        }
        public override decimal ApplayDiscount(decimal sale)
        {
            return (decimal)(100 - discountPercentage) * sale / 100;
        }
    }
    public class CustomerDiscount : StrategyDiscountBase
    {
        public CustomerDiscount()
        {
            discountPercentage = 5d;
        }
        public override decimal ApplayDiscount(decimal sale)
        {
            return (decimal)(100 - discountPercentage) * sale / 100;
        }
    }
    public class FirstTimeCustomerVisiterDiscount : StrategyDiscountBase
    {
        public FirstTimeCustomerVisiterDiscount()
        {
            discountPercentage = 5d;
        }
        public override decimal ApplayDiscount(decimal sale)
        {
            return (decimal)(100 - discountPercentage) * sale / 100;
        }
    }
    public class MixDiscount : StrategyDiscountBase
    {
        public MixDiscount(IEnumerable<StrategyDiscountBase> strategyDiscounts)
        {
            discountPercentage = strategyDiscounts.ToList().Sum(discount => discount.GetdiscountPercentage());
        }
        public override decimal ApplayDiscount(decimal sale)
        {
            return (decimal)(100 - discountPercentage) * sale / 100;
        }
    }


}
