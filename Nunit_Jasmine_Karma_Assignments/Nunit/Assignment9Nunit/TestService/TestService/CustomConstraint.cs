using NUnit.Framework.Constraints;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestService
{
    public class StringCheck : Constraint
    {
        readonly string _expected;
        public StringCheck(string expected)
        {
            _expected = char.ToLower(expected[0]) + expected.Substring(1);
            Description = $"Expected is {expected}";
        }
        public override ConstraintResult ApplyTo<TActual>(TActual actual)
        {
            if (typeof(TActual) != typeof(string))
                return new ConstraintResult(this, actual, ConstraintStatus.Error);
            if (_expected == actual.ToString())
                return new ConstraintResult(this, actual, ConstraintStatus.Success);
            else
                return new ConstraintResult(this, actual, ConstraintStatus.Failure);
        }
    }
    public class Is : NUnit.Framework.Is
    {
        public static StringCheck IsLower(string expected)
        {
            return new StringCheck(expected);
        }
    }
}
