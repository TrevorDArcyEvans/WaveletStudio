# *Block: Import CSV*
![](images/blocks/ImportFromCSVBlock.png]

Generates a signal based on a CSV file.
A CSV (comma-separated values) is a text file with the data (samples) separated with commas or another char. Each line in the file represents a signal. For example:
```csharp
signal_name,sample1,sample2,sample3,sample4
Signal1, 1.1, 9.12, 0.123, 0
Signal2, 1.1, 4.56, 0.123, -45
```

This example shows a file with 2 signals, with 4 samples in each one. The first column in the file is optional and represents the name of the signal. The header is optional too.
This block has no inputs.

## *Parameters:*

*FilePath:* Absolute or relative path to the file

*ColumnSeparator:* Column separator

*SignalStart:* Signal start

*SamplingInterval:* Sampling interval

*IgnoreFirstRow:* Ignore first row when reading the file

*SignalNameInFirstColumn:* If true, the first column contains the name of the signal

## *Example:*

The following example shows an usage in C#.

```csharp
File.WriteAllText(@"C:\Temp\File.csv", "0, 2, -1, 4.1, 3, -1, 4, 0");

var block = new ImportFromCSVBlock
{
    ColumnSeparator = ",",
    SignalStart = 0,
    SamplingInterval = 0.1,
    IgnoreFirstRow = false,
    SignalNameInFirstColumn = false,
    FilePath = @"C:\Temp\File.csv"
};
block.Execute();

Console.WriteLine(block.Output[0].ToString(1, ","));

//Console Output: 0.0, 2.0, -1.0, 4.1, 3.0, -1.0, 4.0, 0.0
```

The above example generates the following set of inputs and outputs:
![](images/inoutgraphs/ImportFromCSVBlock.png]

