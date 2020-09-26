using System;
using System.Threading.Tasks;
using System.IO;
using Nethereum.Web3;
using System.Text;
using Nethereum.Web3.Accounts;
using Nethereum.Web3.Accounts.Managed;
using Nethereum.Hex.HexTypes;
using NBitcoin;
using Nethereum.HdWallet;
using Nethereum.RPC.Eth.DTOs;
using Nethereum.RPC.Eth.Transactions;
using Nethereum;
using Nethereum.Signer;
using Nethereum.Hex.HexConvertors.Extensions;
using Nethereum.KeyStore;
using Nethereum.Hex.HexConvertors;
using Nethereum.RPC.NonceServices;
using Nethereum.RPC.TransactionReceipts;



namespace CreatAccounts{
    class Program{
        static string bytecode = "608060405260008055348015601357600080fd5b5060e3806100226000396000f3fe6080604052348015600f57600080fd5b506004361060325760003560e01c806306661abd1460375780634f2be91f146053575b600080fd5b603d605b565b6040518082815260200191505060405180910390f35b60596061565b005b60005481565b60008081548092919060010191905055507f1067e8d3f4a637d51a15fce55d66e9c1eb92feaf49a494fc5f1a00b3a593df906000546040518082815260200191505060405180910390a156fea26469706673582212202d10158aeaa2d72fe12e022b054ce8ed7b703df3ced4c42ba7b791ea8748714964736f6c634300060c0033";
        static string ABI = "[ { 'inputs': [], 'name': 'add', 'outputs': [], 'stateMutability': 'nonpayable', 'type': 'function' }, { 'anonymous': false, 'inputs': [ { 'indexed': false, 'internalType': 'uint256', 'name': 'ct', 'type': 'uint256' } ], 'name': 'cot', 'type': 'event' }, { 'inputs': [], 'name': 'count', 'outputs': [ { 'internalType': 'uint256', 'name': '', 'type': 'uint256' } ], 'stateMutability': 'view', 'type': 'function' } ]";
        public static void Main(string[] args){ 
            Console.WriteLine("開始...");
            DepolyContract().Wait();
            
            
        }

        static async Task DepolyContract(){
            var Privatekey = "40fde7b2565aef0725c2fd3d1c3082060aa442f8c872998b63cf108438761179";

            var account = new Account(Privatekey);  

            var web3 = new Web3(account,"https://Rinkeby.infura.io/v3/7238211010344719ad14a89db874158c");

            var gasPrice = new HexBigInteger(8000000);

            var txHash = await web3.Eth.DeployContract.SendRequestAsync(ABI,bytecode,account.Address,gasPrice);

            Console.WriteLine("TxHash: "+txHash);

             using (StreamWriter w = File.AppendText("Hash.txt")){
                    w.Write("合約部屬位置: " + txHash + "\r\n");
                    
                }

            
            var balance = await web3.Eth.GetBalance.SendRequestAsync("0x7C538496D4c6A8B6C1F3ADF9dd8bD3abca882f1C");
            var balanceETH = Web3.Convert.FromWei(balance.Value);
            
            Console.WriteLine("0x7C538496D4c6A8B6C1F3ADF9dd8bD3abca882f1C 剩餘金額: "+balanceETH);

        }


     
    }
}
