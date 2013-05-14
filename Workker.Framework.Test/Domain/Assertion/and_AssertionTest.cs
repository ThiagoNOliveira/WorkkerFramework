using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Workker.Framework.Domain;

namespace Workker.Framework.Test.Domain.Assertion
{
    [TestFixture]
    public class and_AssertionTest
    {
        private andAssertion andAssertion;

        [SetUp]
        public  void inicializar()
        {
            var assertion1 = Workker.Framework.Domain.Assertion.IsFalse(false, "OK");
            var assertion2 = Workker.Framework.Domain.Assertion.IsFalse(false, "OK");

            andAssertion = new andAssertion(assertion1, assertion2);
        }

        [Test]
        public  void isvalid()
        {
            Assert.IsTrue(andAssertion.IsValid());
        }

        [Test]
        public  void dovalidation_cria_uma_colecao_de_strings_vazia()
        {
            List<string> strings = new List<string>();
            
            andAssertion.DoValidation(strings);

            Assert.AreEqual(strings.Count, 0);
        }
    }
}
