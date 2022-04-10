# *Block: Invert*
![](images/blocks/InvertBlock.png]

Inverts a signal in time.
For example, if we have a signal with 8 samples like this one:

```csharp
2, 3, -4, 8, 7, 1, 2, -3
```csharp


the block will output a new signal with the folowing samples:

```csharp
-3, 2, 1, 7, 8, -4, 3, 2
```


This block has no inputs.

## *Example:*

The following example shows an usage in C#.

```csharp
var signal = new ImportFromTextBlock { Text = "2, 3, -4, 8, 7, 1, 2, -3" };
var block = new InvertBlock();
signal.ConnectTo(block);
signal.Execute();

Console.WriteLine(block.Output[0].ToString(0));
//Output: -3 2 1 7 8 -4 3 2
```

The above example generates the following set of inputs and outputs:
![](images/inoutgraphs/InvertBlock.png]

