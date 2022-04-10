# *Block: Logic Port*
![](images/blocks/LogicOperationBlock.png]

Point-by-point logic operators (AND, OR, NAND, NOR, XOR, NXOR, NOT).

## *Parameters:*

*Operation:* Math operation to be used
* Or - Or (||)
* Xor - Xor (^)
* NotOr - Not Or (!||)
* NotXor - Not Xor (!^)
* Not - Not (!)

## *Example:*

The following example shows an usage in C#.

```csharp
var signal1 = new ImportFromTextBlock{ Text =  "0, 15, -1, 1, 0, -15, 1,;
var signal2 = new ImportFromTextBlock { Text = "0, -1, 11, 0, 1, 0, 1" };

var block = new LogicOperationBlock
{
    Operation = WaveMath.LogicalOperationEnum.And
};

signal1.ConnectTo(block);
signal2.ConnectTo(block);
signal1.Execute();
signal2.Execute();

Console.WriteLine(block.Output[0].ToString(0));
//Console Output: 0 1 1 0 0 0 1
```

The above example generates the following set of inputs and outputs:
![](images/inoutgraphs/LogicOperationBlock.png]

