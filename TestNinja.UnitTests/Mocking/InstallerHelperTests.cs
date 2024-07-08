using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using TestNinja.Mocking;

namespace TestNinja.UnitTests.Mocking
{
    public class InstallerHelperTests
    {
        Mock<IFileDownloader> _mockFileDownloader;
        InstallerHelper _installerHelper;

        [SetUp]
        public void SetUp()
        {
            _mockFileDownloader = new Mock<IFileDownloader>();
            _installerHelper = new InstallerHelper( _mockFileDownloader.Object );
        }


        [Test]
        public void DownloadInstaller_DownloadCompletes_ReturnTrue()
        {
            var result = _installerHelper.DownloadInstaller("customer", "installer");

            Assert.That(result, Is.True);
        }

        [Test]
        public void DownloadInstaller_DownloadFails_ReturnFalse()
        {
            _mockFileDownloader.Setup(fd => 
                fd.DownloadFile(It.IsAny<string>(), It.IsAny<string>()))
                .Throws<WebException>();

            var result = _installerHelper.DownloadInstaller("customer", "installer");

            Assert.That(result, Is.False);
        }
    }
}
