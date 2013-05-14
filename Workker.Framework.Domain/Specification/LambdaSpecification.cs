using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Workker.Framework.Domain
{
    public class LambdaSpecification : CompositeSpecification
    {
        private Func<bool> lambda;

        public LambdaSpecification(Func<bool> lambda)
        {
            this.lambda = lambda;
        }

        public override bool IsSatisfied()
        {
            return lambda();
        }


    }
}
