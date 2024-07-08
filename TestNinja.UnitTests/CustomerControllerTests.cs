using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class CustomerControllerTests
    {
        [Test]
        public void GetCustomer_IdIsZero_ReturnNotFound()
        {
            var controller = new CustomerController();

            var result = controller.GetCustomer(0);

            //exactly a NotFound object
            Assert.That(result, Is.TypeOf<NotFound>());

            //NotFound object or one of its derivitives
            //Assert.That(result, Is.InstanceOf<NotFound>());

        }

        [Test]
        public void GetCustomer_IdIsNotZero_ReturnOk()
        {
            var controller = new CustomerController();

            var result = controller.GetCustomer(1);

            //exactly a NotFound object
            Assert.That(result, Is.TypeOf<Ok>());

            //NotFound object or one of its derivitives
            //Assert.That(result, Is.InstanceOf<Ok>());
        }
    }
}
