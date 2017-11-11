using NUnit.Framework.Constraints;

namespace ArrowAsserts
{
    public class ReferencingConstraint : Constraint
    {
        private readonly object _expected;

        public ReferencingConstraint(object expected)
        {
            _expected = expected;
        }

        public override ConstraintResult ApplyTo<TActual>(TActual actual)
        {
            return new ConstraintResult(this, actual, true);
        }
    }
}
