using NUnit.Framework.Constraints;

namespace ArrowAsserts
{
    public static class CustomConstraintExtensions
    {
        public static ReferencingConstraint Referencing(this ConstraintExpression expression, object expected)
        {
            var constraint = new ReferencingConstraint(expected);
            expression.Append(constraint);
            return constraint;
        }
    }

    public class Is : NUnit.Framework.Is
    {
        public static ReferencingConstraint Referencing(object expected)
        {
            return new ReferencingConstraint(expected);
        }
    }
}
