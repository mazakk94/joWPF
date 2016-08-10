using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Validators
{
    public class IntRangeValidator: ValidationRule
    {
        private int _minValue;
        private int _maxValue;

        public IntRangeValidator()
        {
            _minValue = Int32.MinValue;
            _maxValue = Int32.MaxValue;
        }

        public int MinValue
        {
            get { return _minValue; }
            set { _minValue = value; }
        }

        public int MaxValue
        {
            get { return _maxValue; }
            set { _maxValue = value; }
        }

        public override ValidationResult Validate(object value, 
                                                  System.Globalization.CultureInfo cultureInfo)
        {
            int res = 0;

            try
            {
                if (((string)value).Length > 0)
                {
                    res = Int32.Parse((string)value);
                }
            }
            catch
            {
                return new ValidationResult(false, "Illegal characters.");
            }

            if ((res < MinValue) || (res > MaxValue))
            {
                return new ValidationResult(false, "Not in range" + MinValue + ":" 
                                                    + MaxValue + ".");
            }

            return new ValidationResult(true, null);
        }
    }
}
