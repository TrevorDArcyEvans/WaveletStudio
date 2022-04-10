# *Block: Scale*
![](images/blocks/ScaleBlock.png]

Dilate or contract a signal in time and/or amplitude.

## *Parameters:*

*TimeScalingFactor:* Factor to be used in time scaling. If the value is setted to 1, no scaling will be applied to the time variable.

*AmplitudeScalingFactor:* Factor to be used in amplitude scaling. If the value is setted to 1, no scaling will be applied to the amplitude variable.

## *Example:*

The following example shows an usage in C#.

```csharp
var signal = new ImportFromTextBlock { Text = "1, 3, -2, 9, 4.5, -2, 4, 0" };
var block = new ScaleBlock
{
    TimeScalingFactor = 2,
    AmplitudeScalingFactor = 1.5
};

signal.ConnectTo(block);
signal.Execute();

Console.WriteLine(block.Output[0].ToString(0, ", "));
```

The above example generates the following set of inputs and outputs:
![](images/inoutgraphs/ScaleBlock.png]

