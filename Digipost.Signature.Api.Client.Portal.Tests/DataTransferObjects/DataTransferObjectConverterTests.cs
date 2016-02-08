﻿using System.Collections.Generic;
using System.Linq;
using Digipost.Signature.Api.Client.Core;
using Digipost.Signature.Api.Client.Core.Tests.Utilities;
using Digipost.Signature.Api.Client.Core.Tests.Utilities.CompareObjects;
using Digipost.Signature.Api.Client.Portal.DataTransferObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Digipost.Signature.Api.Client.Portal.Tests.DataTransferObjects
{
    [TestClass]
    public class DataTransferObjectConverterTests
    {
        [TestClass]
        public class ToDataTransferObjectMethod : DataTransferObjectConverterTests
        {
            [TestMethod]
            public void ConvertsPortalJobSuccessfully()
            {
                //Arrange
                var sender = DomainUtility.GetSender();
                var document = DomainUtility.GetDocument();
                var signers = DomainUtility.GetSigners(2);
                var reference = "reference";
                var source = new PortalJob(document, signers, reference);

                var expected = new DTOPortalsignaturejobrequest
                {
                    Reference = reference,
                    Sender = new DTOSender
                    {
                        Organization = sender.OrganizationNumber
                    },
                    Signers = new List<DTOSigner>
                    {
                        new DTOSigner { Personalidentificationnumber = signers.ElementAt(0).PersonalIdentificationNumber },
                        new DTOSigner { Personalidentificationnumber = signers.ElementAt(1).PersonalIdentificationNumber }
                    }
                };
                
                //Act
                var result = DataTransferObjectConverter.ToDataTransferObject(source, sender);

                //Assert
                var comparator = new Comparator();
                IEnumerable<IDifference> differences;
                comparator.AreEqual(expected, result, out differences);
                Assert.AreEqual(0, differences.Count());
            }
        }
        
    }
}