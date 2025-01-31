# *Block: Demux*
![](images/blocks/DemuxBlock.png]

Extracts the components of an input signal and outputs the components as separate signals.

## *Parameters:*

*OutputCount:* Number of output ports

*SignalIndexes:* Indexes of the signals to be copied in the output. One line per output, separated with commas (,).

## *Example:*

The following example shows an usage in C#.

```csharp
var signal = new ImportFromTextBlock {Text = "0, 3, -1, 2, 0, \r\n 0, -1, 2, 3, 0;
var block = new DemuxBlock { OutputCount = 2 };
signal.ConnectTo(block);
signal.Execute();

Console.WriteLine("Signal 1 = " + block.OutputNodes[0].Object.ToString(0));
Console.WriteLine("Signal 2 = " + block.OutputNodes[1].Object.ToString(0));

//Console Output:
//Signal 1 = 0 3 -1 2 0
//Signal 2 = 0 -1 2 3 0
```

The above example generates the following set of inputs and outputs:
![](images/inoutgraphs/DemuxBlock.png]

