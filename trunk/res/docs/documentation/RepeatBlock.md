# *Block: Repeat*
![](images/blocks/RepeatBlock.png]

Repeats samples of a signal.

For example, if we have a signal with 8 samples like this one:
```csharp
1, 9, 0, 1, 2, 5, -4, 4
```

and set the FrameSize parameter to 4, the block will output a new signal with the folowing samples:
```csharp
1, 9, 0, 1,   1, 9, 0, 1,   2, 5, -4, 4,   2, 5, -4, 4
```


## *Parameters:*

*FrameSize:* The number of times the block will repeat the frame. Default value is 1.

*RepetitionCount:* The number of samples to be repeated per time. Default value is 1.

*KeepSamplingRate:* If true, keeps the original sampling rate, changing the signal start and finish times

## *Example:*

The following example shows an usage in C#.

```csharp
var signal = new ImportFromTextBlock { Text = "0, 3, -3, 0, 2, 2, 2, 0" };
var block = new RepeatBlock
{
    FrameSize = 4,
    RepetitionCount = 1
};
signal.ConnectTo(block);
signal.Execute();

Console.WriteLine(block.Output[0].ToString(0));
//Output: 0 3 -3 0 0 3 -3 0 2 2 2 0 2 2 2 0
```

The above example generates the following set of inputs and outputs:
![](images/inoutgraphs/RepeatBlock.png]

