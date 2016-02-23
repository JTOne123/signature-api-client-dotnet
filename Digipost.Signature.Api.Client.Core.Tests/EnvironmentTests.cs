﻿using System;
using Difi.Felles.Utility.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Digipost.Signature.Api.Client.Core.Tests
{
    [TestClass]
    internal class EnvironmentTests
    {
        [TestClass]
        public class GetEnvironmentMethod : EnvironmentTests
        {
            [TestMethod]
            public void GetsInitializedDifiTestEnvironment()
            {
                //Arrange
                var url = new Uri("https://api.difitest.signering.posten.no");
                var certificates = SertifikatkjedeUtility.FunksjoneltTestmiljøSertifikater();

                //Act
                var environment = Environment.DifiTest;

                //Assert
                Assert.IsNotNull(environment.Sertifikatkjedevalidator);
                Assert.AreEqual(url, environment.Url);
                CollectionAssert.AreEqual(certificates, environment.Sertifikatkjedevalidator.SertifikatLager);
            }

            [TestMethod]
            public void GetsInitializedDifiQaEnvironment()
            {
                //Arrange
                var url = new Uri("https://api.difiqa.signering.posten.no");
                var certificates = SertifikatkjedeUtility.FunksjoneltTestmiljøSertifikater();

                //Act
                var environment = Environment.DifiQa;

                //Assert
                Assert.IsNotNull(environment.Sertifikatkjedevalidator);
                Assert.AreEqual(url, environment.Url);
                CollectionAssert.AreEqual(certificates, environment.Sertifikatkjedevalidator.SertifikatLager);
            }
        }
    }
}