# *Block: Export CSV*
![](images/blocks/ExportToCSVBlock.png]

Exports a single signal or a signal list to a CSV file.
A CSV (comma-separated values) is a text file with the data (samples) separated with commas or another character.
This block has no outputs.

## *Parameters:*

*FilePath:* The path to the file. You can use a relative (ex.: ../file.csv) or absolute path (ex.: C:\file.csv). Default value is “output.csv”.

*ColumnSeparator:* The string to be used to split the data. Default value is “,”.

*DecimalPlaces:* The number of decimal places to be used in the output file. Default value is 3.

*IncludeSignalNameInFirstColumn:* Include signal name in first column.

## *Example:*

The following example shows an usage in C#.

```csharp
var signal = new ImportFromTextBlock { Text = "1, 2, 3, 4, -1" };
var block = new ExportToCSVBlock
{
    FilePath = "file1.csv",
    ColumnSeparator = ";",
    IncludeSignalNameInFirstColumn = true,
    DecimalPlaces = 1
};
signal.ConnectTo(block);
signal.Execute();

//Ouput in file1.csv
//Line 1;1.0;2.0;3.0;4.0;-1.0
```


