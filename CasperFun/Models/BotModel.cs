using System;
namespace CasperFun.Models
{
    public enum InfuraNetwork
    {
        ETHChainMainNet,
        BNBChainMainNet,
        BNBChainTestNet
    }
    public class BotModel
    {
        public string AccountAddress { get; set; }
        public string AccountPrivateKey { get; set; }
        public string TokenContract { get; set; }
        public decimal AmountIn { get; set; }
        public decimal PriceToBuy { get; set; }
        public decimal PriceToSell { get; set; }
    }
}
