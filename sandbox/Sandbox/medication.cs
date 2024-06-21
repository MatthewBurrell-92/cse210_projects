using System;

public class Medication
{
    protected string _medicationName;
    protected string _contraindications;
    protected string _indications;
    protected string _dosage;
    protected string _routes;

    public Medication(string name, string contra, string indica, string dose, string routes)
    {
        _medicationName = name;
        _contraindications = contra;
        _indications = indica;
        _dosage = dose;
        _routes = routes;
    }
}


