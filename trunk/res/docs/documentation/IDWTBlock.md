# *Block: IDWT*
![](images/blocks/IDWTBlock.png]

The IDWT block reconstructs a signal using the specified wavelet coefficients.

## *Parameters:*

*WaveletName:* Wavelet function to be used

*Level:* Number of levels

## *Inputs:*

This block has only one output: the reconstructed signal.

## *Outputs:*

This block has two inputs:
0 – Aproximation Coefficients of decomposition
1 – Details coefficients of decomposition

## *Example:*

The following example shows an usage in C#.

```csharp
var approximation = new ImportFromTextBlock { Text = "0.0, 0.0, 1.4, 1.4, 0.0, 0.0, 1.4, 1.4, 0.0, 0.0, 1.5, 1.3, 0.0, 0.0, 1.4, 1.4" };
var details = new ImportFromTextBlock { Text = "0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, -0.1, -0.1, 0.0, 0.0, 0.0, 0.0" };
var block = new IDWTBlock
{
    WaveletName = "haar",
    Level = 1
};

var signalList = new BlockList { approximation, details, block };
approximation.ConnectTo(block);
details.ConnectTo(block);
signalList.ExecuteAll();

Console.WriteLine(block.OutputNodes[0].Object.ToString(1));

//Console Output:
//0.0 0.0 0.0 0.0 1.0 1.0 1.0 1.0 0.0 0.0 0.0 0.0 1.0 1.0 1.0 1.0 0.0 0.0 0.0 0.0 1.0 1.1 0.8 1.0 0.0 0.0 0.0 0.0 1.0 1.0 1.0 0.0
```

The above example generates the following set of inputs and outputs:
![](images/inoutgraphs/IDWTBlock.png]

