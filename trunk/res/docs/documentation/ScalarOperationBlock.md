# *Block: Scalar Operation*
![](images/blocks/ScalarOperationBlock.png]

Executes a scalar operation in a signal (sum, subtraction, multiplication and division).
The operation is made sample-by-sample.

## *Parameters:*

*Operation:* Math operation to be used
* Multiply - Multiply
* Sum - Sum
* Subtract - Subtract
* Divide - Divide

*Value:* Scalar value

## *Example:*

The following example shows an usage in C#.

```csharp
var signal = new ImportFromTextBlock { Text = "1, 3, -2, 9, 4.5, -2, 4, 0" };
var block = new ScalarOperationBlock
{
    Operation = WaveMath.OperationEnum.Sum,
    Value = 1.5
};

signal.ConnectTo(block);
signal.Execute();

Console.WriteLine(block.Output[0].ToString(0, ", "));
//Console Output:
//2.5, 4.5, -0.5, 10.5, 6.0, -0.5, 5.5, 1.5
```

The above example generates the following set of inputs and outputs:
![](images/inoutgraphs/ScalarOperationBlock.png]

