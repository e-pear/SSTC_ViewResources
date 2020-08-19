using System.Globalization;
using System.Windows.Controls;
using System.Text.RegularExpressions;

namespace SSTC_ViewResources.Rules
{
    // Data validation rule for numeric input fields in views.
    // Rule: Only real numbers allowed. 
    public class NumericFieldValidationRule_RN : ValidationRule
    {
        // Rule alowws to enter any real number in clasic or scientific format.
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            Regex regex = new Regex(@"^[-]?\d*([,.]\d+)?([eE][+-]?\d+)?$"); // Sligthly modified regular expression written by jteeuwen from regexlib.com
            Match match = regex.Match(value.ToString());

            if (match == null || match == Match.Empty || value == null || value.ToString()=="") return new ValidationResult(false, "Invalid input format. Please enter a valid real number.");
            else return ValidationResult.ValidResult;
        }
    }
}
