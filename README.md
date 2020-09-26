# DeployContract
Using .net to deploy smart contract on Ethereum

## ABI & Bytecode

Using string to store your contract ABI and Bytecode

### Example

static string _ABI = "608060405260008055348015601357600080fd5b5060e3806100226000396000f3fe6080604052348015600f57600080fd5b506004361060325760003560e01c806306661abd1460375780634f2be91f146053575b600080fd5b603d605b565b6040518082815260200191505060405180910390f35b60596061565b005b60005481565b60008081548092919060010191905055507f1067e8d3f4a637d51a15fce55d66e9c1eb92feaf49a494fc5f1a00b3a593df906000546040518082815260200191505060405180910390a156fea26469706673582212202d10158aeaa2d72fe12e022b054ce8ed7b703df3ced4c42ba7b791ea8748714964736f6c634300060c0033";

<br>
static string _Bytecode = "[ { 'inputs': [], 'name': 'add', 'outputs': [], 'stateMutability': 'nonpayable', 'type': 'function' }, { 'anonymous': false, 'inputs': [ { 'indexed': false, 'internalType': 'uint256', 'name': 'ct', 'type': 'uint256' } ], 'name': 'cot', 'type': 'event' }, { 'inputs': [], 'name': 'count', 'outputs': [ { 'internalType': 'uint256', 'name': '', 'type': 'uint256' } ], 'stateMutability': 'view', 'type': 'function' } ]";

<br>

## Import Your private Key

var Privatekey = "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX";

var account = new Account(Privatekey);  

var web3 = new Web3(account,"https://Rinkeby.infura.io/v3/7238211010344719ad14a89db874158c");





