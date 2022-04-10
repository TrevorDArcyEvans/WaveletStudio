# *Block: Operation*
![](images/blocks/SampleBasedOperationBlock.png]

Sum, subtract, multiply or divide two or more signals, sample-by-sample.

## *Parameters:*

*Operation:* Math operation to be used
* Multiply - Multiply
* Sum - Sum
* Subtract - Subtract
* Divide - Divide

## *Example:*

The following example shows an usage in C#.

```csharp
var signal1 = new ImportFromTextBlock { Text = "1, 3, -2, 9, 4, -2, 4, 0" };
var signal2 = new ImportFromTextBlock { Text = "0, 2, -1, 2, 3, 2, 4, 0" };
var block = new SampleBasedOperationBlock
{
    Operation = WaveMath.OperationEnum.Multiply
};

signal1.ConnectTo(block);
signal2.ConnectTo(block);
signal1.Execute();
signal2.Execute();

Console.WriteLine(block.Output[0].ToString(0));
//Console Output:
//0 6 3 18 12 -4 16 0
```

The above example generates the following set of inputs and outputs:
![](images/inoutgraphs/SampleBasedOperationBlock.png]

