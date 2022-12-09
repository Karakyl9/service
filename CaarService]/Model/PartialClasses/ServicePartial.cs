using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaarService_.Model
{
    public partial class Service
    {
        public string DiscountText
        {
            get
            {
                if (Discount == 0 || Discount == null)
                    return "";
                else
                    return $"* скидка {Discount * 100} %";
            }
        }
        public double CostWithDiscount
        {
            get
            {
                if (Discount == 0 || Discount == null)
                {
                    return (double)Cost;
                }
                else
                {
                    var CostWithDiscount = (double)Cost * (1.00 - Discount);
                    return CostWithDiscount.Value;
                }
            }
        }
        public string TotalCost
        {
            get
            {
                if (Discount == 0 || Discount == null)
                {
                    return $"{Cost:N2} рублей за {Convert.ToInt32(DurationInSeconds) / 60} минут";
                }
                else
                {
                    return $"{CostWithDiscount:N2} Рублей за {Convert.ToInt32(DurationInSeconds) / 60}";
                }
            }
        }

    }
}
