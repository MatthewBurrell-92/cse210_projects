using System;

public class Dopamine : WeightBased
{
    public Dopamine() : base()
    {
        _concentration = "1600mcg/1ml";
        _doseLow = "2mcg/kg/min";
        _doseHigh = "10mcg/kg/min";
        _contraindications = "Pregnancy, HTN, kidney disease";
        _indications = "Hypotension";
    }
}



