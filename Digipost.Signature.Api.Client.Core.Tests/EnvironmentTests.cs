﻿using System;
using Difi.Felles.Utility.Utilities;
using Xunit;

namespace Digipost.Signature.Api.Client.Core.Tests
{
    public class EnvironmentTests
    {
        public class GetEnvironmentMethod : EnvironmentTests
        {
            [Fact]
            public void Gets_initialize_localhost_environment()
            {
                //Arrange
                var url = new Uri("https://172.16.91.1:8443");
                var certificates = CertificateChainUtility.FunksjoneltTestmiljøSertifikater();

                //Act
                var environment = Environment.Localhost;

                //Assert
                Assert.NotNull(environment.CertificateChainValidator);
                Assert.Equal(url, environment.Url);
                Assert.Equal(certificates, environment.CertificateChainValidator.CertificateStore);
            }

            [Fact]
            public void Gets_initialized_difi_qa_environment()
            {
                //Arrange
                var url = new Uri("https://api.difiqa.signering.posten.no");
                var certificates = CertificateChainUtility.FunksjoneltTestmiljøSertifikater();

                //Act
                var environment = Environment.DifiQa;

                //Assert
                Assert.NotNull(environment.CertificateChainValidator);
                Assert.Equal(url, environment.Url);
                Assert.Equal(certificates, environment.CertificateChainValidator.CertificateStore);
            }

            [Fact]
            public void Gets_initialized_difi_test_environment()
            {
                //Arrange
                var url = new Uri("https://api.difitest.signering.posten.no");
                var certificates = CertificateChainUtility.FunksjoneltTestmiljøSertifikater();

                //Act
                var environment = Environment.DifiTest;

                //Assert
                Assert.NotNull(environment.CertificateChainValidator);
                Assert.Equal(url, environment.Url);
                Assert.Equal(certificates, environment.CertificateChainValidator.CertificateStore);
            }

            [Fact]
            public void Gets_initialized_production_environment()
            {
                //Arrange
                var url = new Uri("https://api.signering.posten.no");
                var certificates = CertificateChainUtility.ProduksjonsSertifikater();

                //Act
                var environment = Environment.Production;

                //Assert
                Assert.NotNull(environment.CertificateChainValidator);
                Assert.Equal(url, environment.Url);
                Assert.Equal(certificates, environment.CertificateChainValidator.CertificateStore);
            }
        }
    }
}