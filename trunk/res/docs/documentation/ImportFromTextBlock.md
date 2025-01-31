# *Block: Import from Text*
![](images/blocks/ImportFromTextBlock.png]

Generates a signal based on a text.
This block has no inputs.

## *Parameters:*

*Text:* The text to be processed.

*ColumnSeparator:* The string to be used to split the data. Default value is “,”.

*SignalStart:* The start of the signal in time. Used to plot the data properly. Default value is 0.

*SamplingInterval:* The number of samples per unit of time. Used to plot the data properly. Default value is 0.

*SignalNameInFirstColumn:* If true, the first column in the file will be used as the name of the signal. Default value is false.

## *Example:*

The following example shows an usage in C#.

```csharp
var block = new ImportFromTextBlock
{
    Text = "0, 2, -1, 4.1, 3, -1, 4, 0",
    ColumnSeparator = ",",
    SignalStart = 0,
    SamplingInterval = 0.1,
    SignalNameInFirstColumn = false
};
block.Execute();

Console.WriteLine(block.Output[0].ToString(1, ","));

//Console Output: 0.0, 2.0, -1.0, 4.1, 3.0, -1.0, 4.0, 0.0
```

The above example generates the following set of inputs and outputs:
![](images/inoutgraphs/ImportFromTextBlock.png]

