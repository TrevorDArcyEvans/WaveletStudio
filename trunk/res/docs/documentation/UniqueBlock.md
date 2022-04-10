# *Block: Unique*
![](images/blocks/UniqueBlock.png]

Removes duplicated samples in a signal.

For example, if we have a signal with 8 samples like this one:
```csharp
1, 3, -4, 8, 3, 4, 1, -3
```

the block will output a new signal with the folowing samples:
```csharp
1, 3, -4, 8, 4, -3
```csharp


## *Parameters:*

*SortSamples:* If true, the block sorts the samples after remove the duplicated samples. Default value is true.

## *Example:*

The following example shows an usage in C#.

```csharp
var signal = new ImportFromTextBlock { Text = "1, 3, -4, 8, 3, 4, 1, -3" };
var block = new UniqueBlock
{
    SortSamples = false
};

signal.ConnectTo(block);
signal.Execute();

Console.WriteLine(block.Output[0].ToString(0));
//Output: 1, 3, -4, 8, 4, -3
```

The above example generates the following set of inputs and outputs:
![](images/inoutgraphs/UniqueBlock.png]

