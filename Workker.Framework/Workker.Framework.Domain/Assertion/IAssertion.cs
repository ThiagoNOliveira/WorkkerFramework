using System;
using System.Collections.Generic;
using System.Text;

namespace Workker.Framework.Domain
{
    public interface IAssertion
    {

        string Message { get; }

        //object Candidate { get; }

        ISpecification Specification { get; }

        void Validate();

        void DoValidation(List<string> messages);

        bool IsValid();

        IAssertion AND(IAssertion other);

        IAssertion and(IAssertion other);

        IAssertion OR(IAssertion other);

        IAssertion or(IAssertion other);

        IAssertion Not();

    }
 
}
