using CashierTestConsole.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierTestConsole
{
    public class BlockAddress : AddressBase, IAddress
    {
        public BlockAddress(string block, string district, string entrance = "") 
        {
            this.Block = block;
            this.District = district;
            this.Entrance = entrance;
        }

        public override string AddressString => $"Block {Block}\n Entrance {this.Entrance}\n{base.AddressString}";

        /// <summary>
        /// 
        /// </summary>
        string Block { get; set; } = string.Empty;

        /// <summary>
        /// 
        /// </summary>
        string Entrance {  get; set; } = string.Empty;

        /// <summary>
        /// e.g. Manhattan
        /// </summary>
        string District {  get; set; } = string.Empty;
    }
}
