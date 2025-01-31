# *Block: FFT*
![](images/blocks/FFTBlock.png]

Executes the Forward Fast Fourier Transform (FFT) using the Managed FFT function.

## *Parameters:*

*Mode:* Computation mode
* UseLookupTable - Store the trigonometric values in a table (faster)
* DynamicTrigonometricValues - Dynamicaly compute the trigonometric values (use less memory)

## *Inputs:*

This block has only one input: the signal or signal list to be computed.

## *Outputs:*

This block has two outputs:
0 – Absolute Value (abs): Absolute values of transform. Usefull to plot the transform.
1 – Complex FFT (fft): Complex values of transform (real and imaginary part). You must use this output if you plan to reconstruct the original signal.

## *Example:*

The following example shows an usage in C#.

```csharp
var signal = new ImportFromTextBlock { Text = "-1, 6, 5, -0.5, 0.5, 0, 0.25, 2, 0, -4, 4, 0, 1, -3, -1, 2, -3, 0, 0, 3, 0, -0.1, 1, 1.1, -3, 0, 0, 1, 5, -1, -0.5, -4.5, -4, 4, 0, -0.25, 3, 2" };
var block = new FFTBlock
{
    Mode = ManagedFFTModeEnum.UseLookupTable
};

signal.ConnectTo(block);
signal.Execute();

Console.WriteLine("Abs: " + block.OutputNodes[0].Object.ToString(1));
Console.WriteLine("FFT: " + block.OutputNodes[1].Object.ToString(1));
```

The above example generates the following set of inputs and outputs:
![](images/inoutgraphs/FFTBlock.png]

