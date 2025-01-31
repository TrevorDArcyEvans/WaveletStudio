# *Block: Mux*
![](images/blocks/MuxBlock.png]

Combine several input signals into vector.
For example, if we connect 3 blocks to the MuxBlock, it will output a single signal list, with 3 items.

## *Parameters:*

*InputCount:* Number of inputs

*SignalNames:* Signal names used in the output (optional, one per line)

## *Example:*

The following example shows an usage in C#.

```csharp
var signal1 = new ImportFromTextBlock { Text = "1, 7, 3, 1" };
var signal2 = new ImportFromTextBlock { Text = "5, 7, 2, 8" };
var signal3 = new ImportFromTextBlock { Text = "9, 8, 4, 3" };
var block = new MuxBlock { InputCount = 3 };
signal1.ConnectTo(block);
signal2.ConnectTo(block);
signal3.ConnectTo(block);
signal1.Execute();
signal2.Execute();
signal3.Execute();

Console.WriteLine(block.OutputNodes[0].Object.Count);
Console.WriteLine(block.Output[0, 0].ToString(0));
Console.WriteLine(block.Output[0, 1].ToString(0));
Console.WriteLine(block.Output[0, 2].ToString(0));

//Output:
//3
//1 7 3 1
//5 7 2 8
//9 8 4 3
```

The above example generates the following set of inputs and outputs:
![](images/inoutgraphs/MuxBlock.png]

