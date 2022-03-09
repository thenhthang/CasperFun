using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CasperFun.Common;
using CasperFun.Models;
using Nethereum.Uniswap.Contracts.UniswapV2Router02;
using Nethereum.Web3;
using Nethereum.Web3.Accounts;
using Nethereum.Contracts;
using System.Numerics;
using Nethereum.Uniswap.Contracts.UniswapV2Router02.ContractDefinition;
using Nethereum.Uniswap.Contracts.UniswapV2Factory;

namespace CasperFun.BotClient
{
    public class BotClient
    {
        private InfuraNetwork _infuraNetwork;
        private BotModel _botModel;
        private Web3  _web3;
        private Contract _contact;
        private UniswapV2Router02Service swapService;
        private const string constminABI = @"[{constant:true,inputs:[{name:""_owner"",type:""address""}],name:""balanceOf"",outputs:[{name:""balance"",type:""uint256""}],type:""function"",},]";
        public BotClient(InfuraNetwork infuraNetwork,BotModel botModel)
        {
            _infuraNetwork = infuraNetwork;
            _botModel = botModel;
            _web3 = new Web3(new Account(botModel.AccountPrivateKey, BNBChain.ChainID), BNBChain.NetWorkRPCUrl);
            swapService = new UniswapV2Router02Service(_web3, BNBChain.Contract_PancakeRouter);
        }
        public async void Buy()
        {
            //var deadline = DateTimeOffset.Now.AddMinutes(15).ToUnixTimeSeconds();
            //var path = new List<string> {BNBChain.Contract_BUSD, _botModel.TokenContract};
            //var amountBUSD = Web3.Convert.ToWei(1);
            //var amounts = await swapService.GetAmountsOutQueryAsync(amountBUSD, path);
            //var swapEthForExactTokens = new SwapExactTokensForTokensFunction()
            //{
            //    AmountIn = amountBUSD,
            //    AmountOutMin = amounts[1],
            //    Path = path,
            //    Deadline = deadline,
            //    To = _web3.TransactionManager.Account.Address,
            //    GasPrice = 5000000000,
            //    Gas = 290000,
            //};

            //var swapReceipt = await swapService.SwapExactTokensForTokensRequestAndWaitForReceiptAsync(swapEthForExactTokens);
        }
        public async void Swap(decimal AmountIn, string FromContract,string ToContract)
        {
            var deadline = DateTimeOffset.Now.AddMinutes(15).ToUnixTimeSeconds();
            var path = new List<string> { FromContract,ToContract };
            var amountInWei = Web3.Convert.ToWei(AmountIn);
            var amounts = await swapService.GetAmountsOutQueryAsync(amountInWei, path);
            var swapEthForExactTokens = new SwapExactTokensForTokensFunction()
            {
                AmountIn = amountInWei,
                AmountOutMin = amounts[1],
                Path = path,
                Deadline = deadline,
                To = _web3.TransactionManager.Account.Address,
                GasPrice = 5000000000,
                Gas = 290000,
            };

            var swapReceipt = await swapService.SwapExactTokensForTokensRequestAndWaitForReceiptAsync(swapEthForExactTokens);
        }
        public async Task<string> GetPair(string contract1,string contract2)
        {
            var factoryAddress = BNBChain.Contract_Factory;
            var factoryService = new UniswapV2FactoryService(_web3, factoryAddress);
            var pair = await factoryService.GetPairQueryAsync(contract1, contract2);
            return pair;
        }
        public void Sell()
        {

        }
        //work
        public async Task<decimal> GetTokenPrice()
        {
            var path = new List<string> { BNBChain.Contract_BUSD, _botModel.TokenContract };
            var amountBUSD = Web3.Convert.ToWei(1);
            var amounts = await swapService.GetAmountsOutQueryAsync(amountBUSD, path);
            var value = amounts[1];
            var price = Math.Round( 1/Web3.Convert.FromWei(value),4);
            return price;
        }
        //work
        public async Task<Decimal> GetBalance()
        {
            var balance =  await _web3.Eth.GetBalance.SendRequestAsync(_web3.TransactionManager.Account.Address);
            return Web3.Convert.FromWei(balance);
        }
        //work
        public async Task<Decimal> GetTokenBalance(string tokenContract)
        {
            var contract = _web3.Eth.GetContract(constminABI, tokenContract);
            var balanceFunction = contract.GetFunction("balanceOf");
           // var tokenName = await contract.GetFunction("name").CallAsync<string>();
            var tokenBalance = await balanceFunction.CallAsync<BigInteger>(_web3.TransactionManager.Account.Address);
            return Web3.Convert.FromWei(tokenBalance);
        }
    }
}
