# *Block: Relational Operation*
![](images/blocks/RelationalOperatorBlock.png]

Conversion to boolean based on >, <, >=, <=, <>, = an static value, the previous sample or the next sample.
For each sample in the signal S1, the Relational Operation Block will compare the sample using the specified operation and returns 1 if true or 0 if false.

## *Parameters:*

*Operation:* Relational operator to be used
* GreaterThan - >
* LessThan - <
* GreaterOrEqualsThan - >=
* LessOrEqualsThan - <=
* EqualsTo - =
* NotEqualsTo - !=

*Operand:* Operand type
* StaticValue - An static scalar value
* PreviousSample - The previous sample of the same signal
* NextSample - The next sample of the same signal
* Signal - Another signal (S2)

## *Example:*

The following example shows an usage in C#.

```csharp
var signal1 = new ImportFromTextBlock { Text = "1, 3, -2, 9, 4, 2, 4, 0" };
var signal2 = new ImportFromTextBlock { Text = "0, 2, -1, 2, 3, 2, 4, 0" };
var block = new RelationalOperatorBlock
{
    Operation = WaveMath.RelationalOperatorEnum.GreaterThan,
    Operand = RelationalOperatorBlock.OperandEnum.Signal,
};

signal1.ConnectTo(block);
signal2.ConnectTo(block);
signal1.Execute();
signal2.Execute();

Console.WriteLine(block.Output[0].ToString(0));
//Console Output:
//1 1 0 1 1 0 0 0
//This means that samples at index 0, 1, 3 and 4 of signal1 area greater than the respective samples of signal2
```

The above example generates the following set of inputs and outputs:
![](images/inoutgraphs/RelationalOperatorBlock.png]

