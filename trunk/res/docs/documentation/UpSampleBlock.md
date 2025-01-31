# *Block: Upsample*
![](images/blocks/UpSampleBlock.png]

Resample input at higher rate by inserting zeros.

For example, if we have a signal with 8 samples like this one:
```csharp
1.1, 9.12, 0.123, 1, 1.1, 4.56, 0.123, -45
```

the block will output a new signal with the folowing samples:
```csharp
1.1, 0, 9.12, 0, 0.123, 0, 1, 0, 1.1, 0, 4.56, 0, 0.123, 0, -45
```


## *Parameters:*

*Factor:* Upsample factor. Default value is 2.

## *Example:*

The following example shows an usage in C#.

```csharp
var signal = new ImportFromTextBlock { Text = "2, 3, -1, 1" };
var block = new UpSampleBlock
{
    Factor = 3
};

signal.ConnectTo(block);
signal.Execute();

Console.WriteLine(block.Output[0].ToString(0));
//Output: 2 0 0 3 0 0 -1 0 0 1
```

The above example generates the following set of inputs and outputs:
![](images/inoutgraphs/UpSampleBlock.png]

