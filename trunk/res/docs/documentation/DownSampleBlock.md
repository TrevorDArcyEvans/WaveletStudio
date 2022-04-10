# *Block: Downsample*
![](images/blocks/DownSampleBlock.png]

Decreases the sampling rate of the input by deleting samples.

## *Parameters:*

*Factor:* Downsample factor. Default is 2.

## *Example:*

The following example shows an usage in C#.

```csharp
var signal = new ImportFromTextBlock { Text = "0, 1, -1, 5, 4, -1, 0" };
var block = new DownSampleBlock();

signal.ConnectTo(block);
signal.Execute();

Console.WriteLine(block.OutputNodes[0].Object.ToString(0));
//Console Output:
//0 -1 4 0
```

The above example generates the following set of inputs and outputs:
![](images/inoutgraphs/DownSampleBlock.png]

