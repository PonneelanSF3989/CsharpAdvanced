namespace Exercise3
{
    public delegate void CalculatorDelegate();
    public static class Operation
    {
       
        
        public static Calculator newCalculator = new Calculator();

        
        
       public static void MultiDelegate()
       {
            CalculatorDelegate myCalculator = new CalculatorDelegate(newCalculator.GetNumbers);
            myCalculator += new CalculatorDelegate(newCalculator.Addition);
            myCalculator += new CalculatorDelegate(newCalculator.Subraction);
            myCalculator += new CalculatorDelegate(newCalculator.Division);
            myCalculator += new CalculatorDelegate(newCalculator.Multiplication);

            myCalculator();
       }

       public static void singleDelegate()
       {
        CalculatorDelegate myCalculatorGetNumber = new CalculatorDelegate(newCalculator.GetNumbers);
        CalculatorDelegate myCalculatorAddition = new CalculatorDelegate(newCalculator.Addition);
        CalculatorDelegate myCalculatorSubraction = new CalculatorDelegate(newCalculator.Subraction);
        CalculatorDelegate myCalculatorMultipliaction = new CalculatorDelegate(newCalculator.Multiplication);
        CalculatorDelegate myCalculatorDivision = new CalculatorDelegate(newCalculator.Division);

        myCalculatorGetNumber();
        myCalculatorAddition();
        myCalculatorSubraction();
        myCalculatorMultipliaction();
        myCalculatorDivision();

       }
       
        
    }
}