# *Block: Switch*
![](images/blocks/SwitchBlock.png]

Switch output between first input (A) and third input (B) based on value of second input or the threshold value, using the specified switch criteria.
For example, let’s consider the following scenario:
```csharp
Signal A: 1, 3, 4, -4, 8, 3, 2, -10
Signal B: 3, -2, 4, -6, 7, 1, 4, 3
Threshold: 2
Switch Criteria: Select B when B is greater than threshold
```

The Switch Criteria is a parameter defining when the value of the signal B will be selected, instead of selecting the value of the signal A. The block will output a new signal with the folowing samples:
```csharp
3 3 4 -4 7 3 4 3
```

The #1 sample (3) was selected from signal B (the value from B is greater than the threshold);
The #2 sample (3) was selected from signal A (the value from B is not greater than the threshold);
The #3 sample (4) was selected from signal B (the value from B is greater than the threshold);
and so on.

## *Parameters:*

*SwitchCriteria:* Defines when the value of the signal B will be selected, instead of selecting the value of the signal A
* BIsGreaterThanThreshold - Select B when B > threshold, otherwise select A
* BIsLessThanThreshold - Select B when B < threshold, otherwise select A
* BIsGreaterOrEqualsThanThreshold - Select B when B >= threshold, otherwise select A
* BIsLessOrEqualsThanThreshold - Select B when B <= threshold, otherwise select A

*StaticThreshold:* Assign the switch threshold that determines which input the block passes to the output. You can use this parameter to set a static value, or use the second input of the block to define a signal as a threshold.

## *Inputs:*

0 - Signal A
1 - Threshold signal(optional)
2 - Signal B

## *Outputs:*

This block outputs a single signal or a signal list of switched samples.

## *Example:*

The following example shows an usage in C#.

```csharp
var signal1 = new ImportFromTextBlock { Text = "1, 3, 4, -4, 8, 3, 2, -10" };
var signal2 = new ImportFromTextBlock { Text = "3, -2, 4, -6, 7, 1, 4, 3" };
var block = new SwitchBlock
{
    StaticThreshold = 2,
    SwitchCriteria = WaveMath.SwitchCriteriaEnum.BIsGreaterThanThreshold
};
signal1.OutputNodes[0].ConnectTo(block.InputNodes[0]);
signal2.OutputNodes[0].ConnectTo(block.InputNodes[2]);
signal1.Execute();
signal2.Execute();

Console.WriteLine(block.OutputNodes[0].Object.ToString(0));
//Output: 3 3 4 -4 7 3 4 3
```

The above example generates the following set of inputs and outputs:
![](images/inoutgraphs/SwitchBlock.png]

