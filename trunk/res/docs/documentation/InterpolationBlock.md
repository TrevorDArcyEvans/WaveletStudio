# *Block: Interpolation*
![](images/blocks/InterpolationBlock.png]

Increases the sampling rate of a signal using linear, nearest, cubic, Newton’s or polynomial interpolation methods.

## *Parameters:*

*Mode:* Defines the interpolation method used by the block:
* Linear - Linear interpolation
* Nearest - Nearest neighbour interpolation
* Cubic - Cubic interpolation (spline)
* Polynomial - Polynomial interpolation using the Neville's Algorithm
* NewtonForm - Newton form of polynomial interpolation

*Factor:* Defines the interpolation factor used in the interpolation function or how many
samples will be inserted between samples of the signal. Default value is 5 (insert 4 samples).

## *Example:*

The following example shows an usage in C#.

```csharp
//Creates a signal with 4 samples
var signal = new ImportFromTextBlock { Text = "14, 20, 11, 41" };
var block = new InterpolationBlock
{
    Factor = 10, //(will insert 9 samples)
    Mode=InterpolationModeEnum.Polynomial
};

//Connect and execute blocks
signal.ConnectTo(block);
signal.Execute();

Console.WriteLine(block.Output[0].ToString(1));
```

The above example generates the following set of inputs and outputs:
![](images/inoutgraphs/InterpolationBlock.png]

