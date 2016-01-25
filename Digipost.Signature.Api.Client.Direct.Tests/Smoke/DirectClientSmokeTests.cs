﻿using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Digipost.Signature.Api.Client.Core;
using Digipost.Signature.Api.Client.Core.Tests.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Digipost.Signature.Api.Client.Direct.Tests.Smoke
{
    [TestClass]
    public class DirectClientSmokeTests
    {
        private static DirectClient DirectClient(Sender sender)
        {
            var directClient = new DirectClient(
                new ClientConfiguration(
                    new Uri("https://172.16.91.1:8443"),
                    sender,
                    DomainUtility.GetTestIntegrasjonSertifikat()
                    )
                );
            return directClient;
        }

        [TestClass]
        public class CreateMethod : DirectClientSmokeTests
        {
            [TestMethod]
            public async Task SendsCreateSuccessfully()
            {
                //Arrange
                var sender = new Sender("983163327");
                var directClient = DirectClient(sender);
                var directJob = new DirectJob(sender, DomainUtility.GetDocument(), DomainUtility.GetSigner(), "SmokeTestReference", DomainUtility.GetExitUrls());

                //Act
                var result = await directClient.Create(directJob);

                //Assert
                Assert.IsNotNull(result.JobId);
            }
        }

        [TestClass]
        public class GetStatusMethod : DirectClientSmokeTests
        {
            [TestMethod]
            public async Task GetsStatusSuccessfully()
            {
                //Arrange
                var sender = new Sender("983163327");
                var directClient = DirectClient(sender);
                var directJob = new DirectJob(sender, DomainUtility.GetDocument(), DomainUtility.GetSigner(), "SmokeTestReference", DomainUtility.GetExitUrls());
                var jobResponse = await directClient.Create(directJob);

                Trace.WriteLine(jobResponse.ResponseUrls.Redirect);

                //Act
                var jobStatus = await directClient.GetStatus(jobResponse.DirectJobReference);

                //Assert
                Assert.IsNotNull(jobStatus.JobId);
            }
        }
    }
}