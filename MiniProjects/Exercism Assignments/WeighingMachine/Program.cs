// See https://aka.ms/new-console-template for more information
using System;
using System.Globalization;

class WeighingMachine
{
    // TODO: define the 'Precision' property
    public int Precision
    {
        get;
        private set;
    }



    // TODO: define the 'Weight' property
    private double weight1;
    public double Weight
    {
        get { return weight1; }
        set
        {
            if (value >= 0)
            {
                weight1 = value;
            }
            else

                throw new ArgumentOutOfRangeException("Weight cannot be negative");
        }
    }

    // TODO: define the 'TareAdjustment' property
    public double TareAdjustment
    {
        get; set;
    } = 5;

    // TODO: define the 'DisplayWeight' property
    public string DisplayWeight
    {
        get
        {
            var format = new NumberFormatInfo() { NumberDecimalDigits = this.Precision };

            var realWeight = (this.Weight - this.TareAdjustment).ToString("f", format);
            return $"{realWeight} kg";
        }
    }

    public WeighingMachine(int precision)
    {
        Precision = precision;
    }
}
