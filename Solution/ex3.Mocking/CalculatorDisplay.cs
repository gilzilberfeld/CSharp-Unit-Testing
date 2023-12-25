
namespace UnitTestingCourse.Solution.ex3.Mocking
{
    // 1. Modify CalculatorDisplay to accept external display
    public class CalculatorDisplay
    {
        IExternalDisplay externalDisplay;
        public bool IsDisplayConnected;
        string display = "";
        int lastArgument = 0;
        bool newArgument = false;
        bool shouldReset = true;
        OperationType lastOperation;

        public CalculatorDisplay(IExternalDisplay external)
        {
            externalDisplay = external;
            IsDisplayConnected = false;
        }
        public void Press(string key)
        {
            if (key.Equals("+"))
            {
                lastOperation = OperationType.Plus;
                lastArgument = int.Parse(display);
                newArgument = true;
            }
            else
            {
                if (key.Equals("/"))
                {
                    lastOperation = OperationType.Div;
                    lastArgument = int.Parse(display);
                    newArgument = true;
                }
                else if (key.Equals("="))
                {
                    int currentArgument = int.Parse(display);
                    if (lastOperation == OperationType.Plus)
                    {
                        display = (lastArgument + currentArgument).ToString();
                    }
                    if (lastOperation == OperationType.Div && currentArgument == 0)
                    {
                        display = "Division By Zero Error";
                    }
                    shouldReset = true;
                }
                else
                {
                    if (shouldReset)
                    {
                        display = "";
                        shouldReset = false;
                    }
                    if (newArgument)
                    {
                        display = "";
                        newArgument = false;
                    }
                    display += key;
                }
            }
            if (externalDisplay.IsOn())
                externalDisplay.Show(GetDisplay());
            else
                IsDisplayConnected = false;
        }

        public string GetDisplay()
        {
            if (display.Equals(""))
                return "0";
            if (display.Length > 5)
                return "E";
            return display;
        }

        public enum OperationType
        {
            Plus,
            Div
        }
    }
}