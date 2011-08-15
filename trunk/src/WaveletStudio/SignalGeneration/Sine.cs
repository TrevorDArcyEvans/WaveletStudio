﻿using System;
using System.Collections.Generic;

namespace WaveletStudio.SignalGeneration
{
    ///<summary>
    /// Create a signal based on a sinusoid: y(x) = A * sin(2 * PI * (f * x + phi)) + D, where: 
    /// A   -> Amplitude
    /// f   -> Frequency
    /// phi -> Phase
    /// D   -> Offset
    ///</summary>  
    public class Sine : CommonSignalBase
    {        
        /// <summary>
        /// Name
        /// </summary>
        public override string Name
        {
            get { return "Sine"; }
        }

        /// <summary>
        /// Generates the signal
        /// </summary>
        /// <returns></returns>
        public override Signal ExecuteSampler()
        {
            var samples = new List<double>();
            var finish = Convert.ToDecimal(GetFinish());
            for (var x = Convert.ToDecimal(Start); x <= finish; x += Convert.ToDecimal(SamplingInterval))
            {
                var value = Amplitude * Math.Sin(2 * Math.PI * (Frequency * Convert.ToDouble(x) + Phase)) + Offset;
                samples.Add(value);
            }
            return new Signal(samples.ToArray())
                        {
                            SamplingRate = SamplingRate,
                            Start = Start,
                            Finish = Finish,
                            SamplingInterval = SamplingInterval
                        };            
        }
    }

    
}
