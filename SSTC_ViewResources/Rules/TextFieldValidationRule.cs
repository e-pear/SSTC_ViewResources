using System.Globalization;
using System.Windows.Controls;

namespace SSTC_ViewResources.Rules
{
    public class TextFieldValidationRule : ValidationRule
    {
        // Data validation rule for text input fields in views.
        // Rule: No semicolons allowed.
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            string s = value.ToString();

            if (s.Contains(";")) return new ValidationResult(false, "Semicolons (;) are forbidden to use. Please alter your input.");
            else return new ValidationResult(true, null);
        }
    }
}
