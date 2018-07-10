﻿using System.Linq;
using Digipost.Signature.Api.Client.Core.Internal;
using Digipost.Signature.Api.Client.Core.Internal.Asice.AsiceSignature;
using Digipost.Signature.Api.Client.Core.Tests.Utilities;
using Digipost.Signature.Api.Client.Portal.Internal.AsicE;
using Digipost.Signature.Api.Client.Portal.Tests.Utilities;
using Xunit;

namespace Digipost.Signature.Api.Client.Portal.Tests.Asice.AsiceSignature
{
    public class SignatureGeneratorTests
    {
        internal SignatureGenerator GetSignaturGenerator()
        {
            var document = DomainUtility.GetPortalDocument();
            var sender = CoreDomainUtility.GetSender();
            var signers = DomainUtility.GetSigners(2);
            var manifest = new Manifest(sender, document, signers);
            var x509Certificate2 = CoreDomainUtility.GetTestCertificate();
            var signaturGenerator = new SignatureGenerator(x509Certificate2, document, manifest);
            return signaturGenerator;
        }

        public class ConstructorMethod : SignatureGeneratorTests
        {
            [Fact]
            public void Initializes_with_document_portal_manifest_and_certificate()
            {
                //Arrange
                var document = DomainUtility.GetPortalDocument();
                var sender = CoreDomainUtility.GetSender();
                var manifest = new Manifest(sender, document, DomainUtility.GetSigners(3));
                var x509Certificate2 = CoreDomainUtility.GetTestCertificate();

                //Act
                var signatur = new SignatureGenerator(x509Certificate2, document, manifest);

                //Assert
                Assert.Equal(document, signatur.Attachables.ElementAt(0));
                Assert.Equal(manifest, signatur.Attachables.ElementAt(1));
                Assert.Equal(x509Certificate2, signatur.Certificate);
            }
        }

        public class FileNameMethod : SignatureGeneratorTests
        {
            [Fact]
            public void Returns_correct_static_file_name()
            {
                //Arrange
                var signaturGenerator = GetSignaturGenerator();
                const string expectedFileName = "META-INF/signatures.xml";

                //Act

                //Assert
                Assert.Equal(expectedFileName, signaturGenerator.FileName);
            }
        }

        public class IdMethod : SignatureGeneratorTests
        {
            [Fact]
            public void Returns_correct_static_id()
            {
                //Arrange
                var signaturGenerator = GetSignaturGenerator();
                const string expectedId = "Id_0";

                //Act

                //Assert
                Assert.Equal(expectedId, signaturGenerator.Id);
            }
        }

        public class XmlMethod : SignatureGeneratorTests
        {
            [Fact]
            public void Generates_valid_signature_xml()
            {
                ////Arrange
                var signatureGenerator = DomainUtility.GetSignature();
                var xml = signatureGenerator.Xml().InnerXml;
                var signatureValidator = new SignatureValidator();

                //Act
                var isValidSignatureXml = signatureValidator.Validate(xml);
                var signatureLength = xml.Length;

                //Assert
                Assert.True(isValidSignatureXml);
                Assert.True(signatureLength > 3200);
            }
        }
    }
}