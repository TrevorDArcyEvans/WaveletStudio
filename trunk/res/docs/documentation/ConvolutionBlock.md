# *Block: Convolution*

![](images/blocks/ConvolutionBlock.png] 

The Convolution block convolves the signal of the first input with the signal of second input (filter).
Both the signal and filter can be lists. Each signal in the first list will be convolved with the correspondent filter in the second. If the number of filters in the filter list is lesser than the number of filters, the first filter will be used.

## *Parameters:*

*FFTMode:* The FFT mode to be used on convolution.
* UseLookupTable - Store the trigonometric values in a table (faster)
* DynamicTrigonometricValues - Dynamicaly compute the trigonometric values (use less memory)

*ReturnOnlyValid:* If true, the block will return only the central part of the convolution resulting in a new signal with (S – F + 1) samples (S = size of signal, F = size of filter). If false, all the convolution will returned and resulting in a new signal with (S + F – 1) samples. Default value is false.

## *Inputs:*

This block has two inputs: the signal list and the filter list.

## *Outputs:*

This block has only one output: the result of convolution between the inputs.

## *Example:*

The following example shows an usage in C#.

```csharp
var signal = new ImportFromTextBlock { Text = "0, 0, 1, 1, 1, 1, 0, 0" };
var filter = new ImportFromTextBlock { Text = "0, 0, 1, 0.75, 0.5, 0.25, 0, 0" };
var block = new ConvolutionBlock
{
    FFTMode = ManagedFFTModeEnum.UseLookupTable,
    ReturnOnlyValid = false
};

signal.OutputNodes[0].ConnectTo(block.InputNodes[0]);
filter.OutputNodes[0].ConnectTo(block.InputNodes[1]);

var blockList = new BlockList { signal, filter, block };
blockList.ExecuteAll();
Console.WriteLine(block.Output[0].ToString(1));

//Console Output:
//0.0 0.0 0.0 0.0 1.0 1.8 2.3 2.5 1.5 0.8 0.3 0.0 0.0 0.0 0.0
```

The above example generates the following set of inputs and outputs:
![](images/inoutgraphs/ConvolutionBlock.png]

