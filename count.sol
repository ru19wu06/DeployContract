pragma solidity ^0.6.0;

contract Trading{
    
    uint public count  = 0;
    event cot(uint ct);
    
    function  add() public {
        count++;
        
        emit cot(count);
    }
    
}