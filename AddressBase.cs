using CashierTestConsole.interfaces;

namespace CashierTestConsole
{
    public class AddressBase : IAddress
    {
        public virtual string AddressString
        {
            get
            {
                return $"{City}\n{PostalCode}\n\n{Country}";
            }
        }

        /// <summary>
        /// Name of the city
        /// </summary>
        public string City { get; set; } = string.Empty;

        /// <summary>
        /// 
        /// </summary>
        public string State { get; set; } = string.Empty;

        /// <summary>
        /// 
        /// </summary>
        public string PostalCode { get; set; } = string.Empty;

        /// <summary>
        /// 
        /// </summary>
        public string Country { get; set; } = string.Empty;

    }
}