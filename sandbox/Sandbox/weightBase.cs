using System;
public class WeightBased : Medication
{
    protected string _concentration;
    protected string _doseLow;
    protected string _doseHigh;

    public float DosageLow(float patientWeight)
    {
        _doseGiven = _doseLow * patientWeight;
        return _doseageLow;
    }
    public float DosageHigh(float patientWeight)
    {
        _doseGiven = _doseHigh * patientWeight;
        return _dosageHigh;
    }
}



