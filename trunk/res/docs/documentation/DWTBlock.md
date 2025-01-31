# *Block: DWT*
![](images/blocks/DWTBlock.png]

The DWT block decomposes a signal using the specified wavelet function.

## *Parameters:*

*WaveletName:* One of following wavelet functions name:
- Coiflet wavelets: coif1, coif2, coif3, coif4, coif5
- Daubechies wavelets: db2, db3, db4, db5, db6, db7, db8, db9, db10
- Haar wavelet (db1): haar
- Discreete Meyer wavelet: dmeyer
- Symlet wavelet: sym2, sym3, sym4, sym5, sym6, sym7, sym8

*Level:* Number of levels of decomposition.

*Rescale:* Rescale outputs in the "ALL" output to the original signal size, reverting the downsample and extension effects. Warning: the "ALL" output will be modified, and the signal in this output cannot be reconstructed. Default value is false.

*ExtensionMode:* Extension mode
* SymmetricHalfPoint - Symmetric-padding (half-point): boundary value symmetric replication
* SymmetricWholePoint - Symmetric-padding (whole-point): boundary value symmetric replication
* AntisymmetricHalfPoint - Antisymmetric-padding (half-point): boundary value antisymmetric replication
* AntisymmetricWholePoint - Antisymmetric-padding (whole-point): boundary value antisymmetric replication
* PeriodicPadding - Periodized extension
* ZeroPadding - Zero extension
* SmoothPadding0 - Smooth extension of order 0 (Continuous)
* SmoothPadding1 - Smooth extension of order 1

## *Inputs:*

This block has only one input: the signal to perform the wavelet decomposition.

## *Outputs:*

This block has four outputs:
0 – Approximation (Apx): Decomposition approximation levels
1 – Details (Det): Decomposition details levels
2 – Reconstruction (Rc): Reconstruction of the signal
3 – All: List with all the previous outputs.

## *Example:*

The following example shows an usage in C#.

```csharp
var signal = new ImportFromTextBlock { Text = "0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 1, 1.1, 0.9, 1, 0, 0, 0, 0, 1, 1, 1, 1" };
var block = new DWTBlock
{
    WaveletName = "haar",
    Level = 1,
    Rescale = true
};

signal.ConnectTo(block);
signal.Execute();

Console.WriteLine("APX: " + block.OutputNodes[0].Object.ToString(1));
Console.WriteLine("DET: " + block.OutputNodes[1].Object.ToString(1));
Console.WriteLine("RC:  " + block.OutputNodes[2].Object.ToString(1));
```

The above example generates the following set of inputs and outputs:
![](images/inoutgraphs/DWTBlock.png]

