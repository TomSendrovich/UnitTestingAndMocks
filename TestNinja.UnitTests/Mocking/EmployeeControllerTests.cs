using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestNinja.Mocking;

namespace TestNinja.UnitTests.Mocking
{
    public class EmployeeControllerTests
    {
        Mock<IEmployeeStorage> employeeStorageMock;
        EmployeeController employeeController;

        [SetUp] 
        public void SetUp() 
        {
            employeeStorageMock = new Mock<IEmployeeStorage>();
            employeeController = new EmployeeController(employeeStorageMock.Object);
        }

        [Test]
        public void DeleteEmployee_WhenCalled_DeleteEmployeeFromDb()
        {
            employeeController.DeleteEmployee(1);

            employeeStorageMock.Verify(es => es.DeleteEmployee(1));
        }

        [Test]
        public void DeleteEmployee_WhenCalled_RetunsRedirectResultObject()
        {
            var result = employeeController.DeleteEmployee(1);

            Assert.That(result, Is.TypeOf<RedirectResult>());
        }
    }
}
