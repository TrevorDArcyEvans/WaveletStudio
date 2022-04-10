# *Block: Absolute Value*
![](images/blocks/AbsoluteValueBlock.png)

Outputs the absolute value of a signal.

## *Example:*

The following example shows an usage in C#.

```csharp
var block = new AbsoluteValueBlock();
var signal = new ImportFromTextBlock {Text = "2.1, 3.2, -1, -1.3, -100, -2;
signal.ConnectTo(block);
signal.Execute();
Console.WriteLine(block.OutputNodes[0].Object.ToString(1));

//Console Output:
//2.1 3.2 1.0 1.3 100.0 2.0
```

The above example generates the following set of inputs and outputs:
![](images/inoutgraphs/AbsoluteValueBlock.png)

