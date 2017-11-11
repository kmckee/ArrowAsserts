using NUnit.Framework.Constraints;

namespace ArrowAsserts
{
    public class ReferencingConstraint : Constraint
    {
        private readonly object _expected;
        private ReferenceChecker _referenceChecker;

        public ReferencingConstraint(object expected)
        {
            _expected = expected;
            _referenceChecker = new ReferenceChecker();
        }

        public override ConstraintResult ApplyTo<TActual>(TActual actual)
        {
            var a = actual as string;
            var b = _expected as string;
            return new ConstraintResult(this, actual, _referenceChecker.DoesAReferenceB(a,b));
        }
    }
}
