public class Fraction
{
    // These are private! Nobody outside of this class can access them from Program.cs.
    private int _top;
    private int _bottom;

    //1. Constructor with no parameters (1/1)
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    //2. Constructor with one parameter (x/1)
    public Fraction(int top)
    {
        _top = top;
        _bottom = 1;
    }

    //3. Constructor with two parameters (x/y)
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    // Getters and Setters
      // Getter for the top number
      public int GetTop()
    {
        return _top;
    }
      // Setter for the top number
      public void SetTop(int top)
    {
        _top = top;
    }
        
        //Getter for the bottom number
    public int GetBottom()
    {
        return _bottom;
    }
    
        // Setter for the bottom number
        public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    //Returns "top/bottom"
    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }

    //Returns a decimal value of the fraction
    // Note: We use (double) so C# will treat the numbers as doubles and not integers. If we don't do this, C# will round down to the nearest whole number.
    public double GetDecimalValue()
    {
        return (double)_top / _bottom;    }
}