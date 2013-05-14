using System;
using System.Collections.Generic;
using System.Text;


namespace Workker.Framework.Domain
{
    public class Not_Specification : CompositeSpecification
    {
        private ISpecification wrapped;

        public Not_Specification(ISpecification specification)
        {
            wrapped = specification;
        }

        public override bool IsSatisfied()
        {
            return !wrapped.IsSatisfied();
        }
    }
}
