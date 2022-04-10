# *Block: Shift*
![](images/blocks/ShiftBlock.png]

Shifts a signal in time modifying the Start property.

## *Parameters:*

*Delay:* Delay in time

## *Example:*

The following example shows an usage in C#.

```csharp
var block = new ShiftBlock { Delay = 1.7 };
var signal = new ImportFromTextBlock { Text = "0, 1, -1, 3, 0", SignalStart = 1 };
signal.ConnectTo(block);
signal.Execute();

Console.WriteLine(block.Output[0].Start);
//Output: 2.7
```

The above example generates the following set of inputs and outputs:
![](images/inoutgraphs/ShiftBlock.png]

