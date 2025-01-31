# *Block: IFFT*
![](images/blocks/IFFTBlock.png]

Executes the Backward Fast Fourier Transform (FFT) using the Managed FFT function.

## *Parameters:*

*Mode:* Computation mode
* UseLookupTable - Store the trigonometric values in a table (faster)
* DynamicTrigonometricValues - Dynamicaly compute the trigonometric values (use less memory)

## *Example:*

The following example shows an usage in C#.

```csharp
var freqInput = new ImportFromTextBlock { Text = "12.3, 0.0, 4.5, 7.2, -5.8, 4.5, -7.5, -2.3, -2.8, 0.0, -7.5, 2.3, -5.8, -4.5, 4.5, -7.2" };
var block = new IFFTBlock
{
    Mode = ManagedFFTModeEnum.UseLookupTable
};

freqInput.ConnectTo(block);
freqInput.Execute();

Console.WriteLine(block.OutputNodes[0].Object.ToString(1));

//Console output:
//-1.0, 6.0, 5.0, -0.5, 0.5, 0.0, 0.3, 2.0
```

The above example generates the following set of inputs and outputs:
![](images/inoutgraphs/IFFTBlock.png]

