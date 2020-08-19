using System.Globalization;
using System.Windows.Controls;
using System.Text.RegularExpressions;

namespace SSTC_ViewResources.Rules
{
    // Data validation rule for numeric input fields in views.
    // Rule: Only positive real numbers allowed, zero is not positive real number :). 
    public class NumericFieldValidationRule_PRN : ValidationRule
    {
        // Rule alowws to enter any greater than zero real number in clasic or scientific format.
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            Regex regex = new Regex(@"^[+]?([1-9][0-9]*(?:[\.][0-9]*)?|0*\.0*[1-9][0-9]*)?([eE][+-]?\d+)?$"); // my very own Frankenstein, I belive it can be optimized :)
            Match match = regex.Match(value.ToString());

            if (match == null || match == Match.Empty || value == null || value.ToString() == "") return new ValidationResult(false, "Invalid input format. Please enter a valid real number greater than 0.");
            else return ValidationResult.ValidResult;
        }
    }
}
