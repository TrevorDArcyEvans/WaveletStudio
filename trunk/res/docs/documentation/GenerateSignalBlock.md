# *Block: Generate Signal*
![](images/blocks/GenerateSignalBlock.png]

Generates a signal based on one of the following templates:

Sine     :=  y(x) = A * sin(2 * PI * t) + D
Cosine   :=  y(x) = A * cos(2 * PI * t) + D
Sawtooth :=  y(x) = A * 2*(t - floor(t+0.5)) + D
Square   :=  y(x) = A * sign(sin(2 * PI * t)) + D
Triangle :=  y(x) = A * (1-4*abs(round(t-0.25)-(t-0.25))) + D

Where:
A := Amplitude
D := Offset
t := f*x+φ
f := Frequency
φ := Phase

This block has no inputs.

## *Parameters:*

*Amplitude:* Amplitude of the signal. Default value is 1.

*Frequency:* Frequency of the signal in Hz. Default value is 60.

*Phase:* The initial angle of function at its origin. Default value is 0.

*Offset:* Distance from the origin. Default value is 0.

*Start:* Start of the signal in time. Default value is 0.

*Finish:* Finish of the signal in time. Default value is 1.

*SamplingRate:* Sampling rate used on sampling. Default value is 32768 (32KHz).

*IgnoreLastSample:* If true, the last sample is not included in the created signal. Default value is false.

## *Example:*

The following example shows an usage in C#.

```csharp
var block = new GenerateSignalBlock
{
    TemplateName = "Sine",
    Amplitude = 2.1,
    Frequency = 2,
    Phase = 0.5,
    Offset = 0.2,
    Start = 0,
    Finish = 5,
    SamplingRate = 15,
    IgnoreLastSample = true
};
block.Execute();

Console.WriteLine(block.OutputNodes[0].Object.ToString(1));
```

The above example generates the following set of inputs and outputs:
![](images/inoutgraphs/GenerateSignalBlock.png]

