﻿using System.Text;
using Digipost.Signature.Api.Client.Core.Asice;
using Digipost.Signature.Api.Client.Core.Asice.AsiceManifest;
using Digipost.Signature.Api.Client.Core.Asice.DataTransferObjects;
using Digipost.Signature.Api.Client.Core.Tests.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Digipost.Signature.Api.Client.Core.Tests.Asice.AsiceManifest
{
    public class ManifestTests
    {
        [TestClass]
        public class ConstructorMethod : ManifestTests
        {
            [TestMethod]
            public void SimpleConstructor()
            {
                //Arrange
                var sender = DomainUtility.GetSender();
                var document = DomainUtility.GetDocument();
                var signers = DomainUtility.GetSigners(3);

                //Act
                var manifest = new Manifest(sender, document, signers);

                //Assert
                Assert.AreEqual(sender, manifest.Sender);
                Assert.AreEqual(document, manifest.Document);
                Assert.AreEqual(signers, manifest.Signers);
            }
        }

        [TestClass]
        public class FileNameMethod : ManifestTests
        {
            [TestMethod]
            public void ReturnsCorrectStaticString()
            {
                //Arrange
                const string fileName = "manifest.xml";
                var manifest = DomainUtility.GetManifest();

                //Act

                //Assert
                Assert.AreEqual(fileName, manifest.FileName);
            } 
        }

        [TestClass]
        public class MimeTypeMethod : ManifestTests
        {
            [TestMethod]
            public void ReturnsCorrectStaticString()
            {
                //Arrange
                const string mimeType = "application/xml";
                var manifest = DomainUtility.GetManifest();

                //Act

                //Assert
                Assert.AreEqual(mimeType, manifest.MimeType);
            }
        }

        [TestClass]
        public class IdMethod : ManifestTests
        {
            [TestMethod]
            public void ReturnsCorrectStaticString()
            {
                //Arrange
                const string id = "Id_1";
                var manifest = DomainUtility.GetManifest();

                //Act

                //Assert
                Assert.AreEqual(id, manifest.Id);
            }
        }

        [TestClass]
        public class BytesMethod : ManifestTests
        {
            [TestMethod]
            public void SuccessfulManifestToBytes()
            {
                //Arrange
                var manifest = DomainUtility.GetManifest();
                var manifestDataTranferObject = DataTransferObjectConverter.ToDataTransferObject(manifest);
                var expectedResult = SerializeUtility.Serialize(manifestDataTranferObject);

                //Act
                var bytes = manifest.Bytes;
                var actualResult = Encoding.UTF8.GetString(bytes);

                //Assert
                Assert.AreEqual(expectedResult, actualResult);
            }
        }
    }
}