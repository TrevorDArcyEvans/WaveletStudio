# *Block: Signal Extension*
![](images/blocks/SignalExtensionBlock.png]

Extends a signal using the specified mode.

## *Parameters:*

*ExtensionMode:* One of the following extension modes:
* SymmetricHalfPoint - Symmetric-padding (half-point): boundary value symmetric replication
* SymmetricWholePoint - Symmetric-padding (whole-point): boundary value symmetric replication
* AntisymmetricHalfPoint - Antisymmetric-padding (half-point): boundary value antisymmetric replication
* AntisymmetricWholePoint - Antisymmetric-padding (whole-point): boundary value antisymmetric replication
* PeriodicPadding - Periodized extension
* ZeroPadding - Zero extension
* SmoothPadding0 - Smooth extension of order 0 (Continuous)
* SmoothPadding1 - Smooth extension of order 1

*ExtensionSize:* Extension size. If zero (default), extents no next power of 2.

## *Example:*

The following example shows an usage in C#.

```csharp
var signal = new ImportFromTextBlock{Text = "1, 2, 3, 4, 5, 6, 7, 8;
var block = new SignalExtensionBlock
{
    ExtensionMode = SignalExtension.ExtensionMode.SymmetricHalfPoint,
    ExtensionSize = 2
};
signal.ConnectTo(block);
signal.Execute();

Console.WriteLine(block.Output[0].ToString(0));
//Output: 2 1 1 2 3 4 5 6 7 8 8 7
```

The above example generates the following set of inputs and outputs:
![](images/inoutgraphs/SignalExtensionBlock.png]

