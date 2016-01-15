﻿using Digipost.Signature.Api.Client.Core.Asice.AsiceManifest;
using Digipost.Signature.Api.Client.Core.Tests.Utilities;
using Digipost.Signature.Api.Client.Core.Xsd;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Digipost.Signature.Api.Client.Core.Tests.Asice.AsiceSignature
{
    [TestClass]
    public class SignatureGeneratorTests
    {
        [TestClass]
        public class ConstructorMethod : SignatureGeneratorTests
        {
            [TestMethod]
            public void InitializesWithDocumentManifestAndCertificate()
            {
                //Arrange
                var document = DomainUtility.GetDocument();
                var sender = DomainUtility.GetSender();
                var manifest = new Manifest(sender, document, DomainUtility.GetSigners(3));
                var x509Certificate2 = DomainUtility.GetCertificate();

                //Act
                var signatur = new Core.Asice.AsiceSignature.SignatureGenerator(document, manifest, x509Certificate2);

                //Assert
                Assert.AreEqual(document, signatur.Document);
                Assert.AreEqual(manifest, signatur.Manifest);
                Assert.AreEqual(x509Certificate2, signatur.Certificate);
            }
        }

        [TestClass]
        public class FileNameMethod : SignatureGeneratorTests
        {
            [TestMethod]
            public void ReturnsCorrectStaticFileName()
            {
                //Arrange
                var signaturGenerator = GetSignaturGenerator();
                const string expectedFileName = "META-INF/signatures.xml";

                //Act

                //Assert
                Assert.AreEqual(expectedFileName, signaturGenerator.FileName);
            }
        }

        [TestClass]
        public class IdMethod : SignatureGeneratorTests
        {
            [TestMethod]
            public void ReturnsCorrectStaticId()
            {
                //Arrange
                var signaturGenerator = GetSignaturGenerator();
                const string expectedId = "Id_0";

                //Act

                //Assert
                Assert.AreEqual(expectedId, signaturGenerator.Id);
            }
        }

        [TestClass]
        public class XmlMethod : SignatureGeneratorTests
        {
            [TestMethod]
            public void GeneratesValidSignatureXml()
            {
                //Arrange
                var signatureGenerator = DomainUtility.GetSignature();
                var signatureValidator = new SignatureValidator();

                //Act
                var isValidSignatureXml = signatureValidator.ValiderDokumentMotXsd(signatureGenerator.Xml().InnerXml);
                int signatureLength = signatureGenerator.Xml().InnerXml.Length;

                //Assert
                Assert.IsTrue(isValidSignatureXml);
                Assert.IsTrue(signatureLength > 3200);
            }

        }

        internal Core.Asice.AsiceSignature.SignatureGenerator GetSignaturGenerator()
        {
            var document = DomainUtility.GetDocument();
            var sender = DomainUtility.GetSender();
            var manifest = new Manifest(sender, document, DomainUtility.GetSigners(3));
            var x509Certificate2 = DomainUtility.GetCertificate();
            var signaturGenerator = new Core.Asice.AsiceSignature.SignatureGenerator(document, manifest, x509Certificate2);
            return signaturGenerator;
        }
    }
}