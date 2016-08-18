﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Digipost.Signature.Api.Client.Core;
using Digipost.Signature.Api.Client.Core.Tests.Smoke;
using Digipost.Signature.Api.Client.Direct.Enums;
using Digipost.Signature.Api.Client.Direct.Tests.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Digipost.Signature.Api.Client.Core.Tests.Smoke.SmokeTests;

namespace Digipost.Signature.Api.Client.Direct.Tests.Smoke
{
    internal class TestHelper
    {
        private readonly DirectClient _directClient;

        // Gradually built state
        private JobResponse _jobResponse;
        private JobStatusResponse _status;
        private StatusReference _statusReference;

        public TestHelper(DirectClient directClient)
        {
            _directClient = directClient;
        }

        public TestHelper Create_direct_job(params PersonalIdentificationNumber[] signers)
        {
            var job = DomainUtility.GetDirectJob(signers);
            _jobResponse = _directClient.Create(job).Result;
            return this;
        }

        public TestHelper Create_pollable_direct_job(params PersonalIdentificationNumber[] signers)
        {
            var job = DomainUtility.GetPollableDirectJob(signers);
            _jobResponse = _directClient.Create(job).Result;
            return this;
        }

        public TestHelper Sign_job(PersonalIdentificationNumber signer)
        {
            Assert_state(_jobResponse);

            var statusUrl = _directClient.AutoSign(_jobResponse.JobId, signer.Value).Result;
            var queryParams = new Uri(statusUrl).Query;
            var queryDictionary = HttpUtility.ParseQueryString(queryParams);
            var statusQueryToken = queryDictionary.Get(0);

            if (_jobResponse.ResponseUrls.HasStatusUrl())
            {
                _statusReference = MorphStatusReferenceIfMayBe(_jobResponse.ResponseUrls.Status(statusQueryToken));
            }

            return this;
        }

        public TestHelper Get_status()
        {
            Assert_state(_statusReference);

            _status = MorphJobStatusResponseIfMayBe(_directClient.GetStatus(_statusReference).Result);
            return this;
        }

        public TestHelper Get_status_by_polling()
        {
            _status = MorphJobStatusResponseIfMayBe(_directClient.GetStatusChange().Result);
            return this;
        }

        public TestHelper Expect_job_to_have_status(JobStatus expectedJobStatus, params KeyValuePair<PersonalIdentificationNumber, SignatureStatus>[] expectedSignatureStatuses)
        {
            Assert_state(_status);

            Assert.AreEqual(expectedJobStatus, _status.Status);
            foreach (var expectedSignatureStatus in expectedSignatureStatuses)
            {
                Assert.AreEqual(expectedSignatureStatus.Value, _status.GetSignatureFrom(expectedSignatureStatus.Key).SignatureStatus);
            }
            return this;
        }

        public TestHelper Get_XAdES(PersonalIdentificationNumber signer)
        {
            Assert_state(_status);

            var xades = _directClient.GetXades(_status.GetSignatureFrom(signer).XadesReference).Result;
            Assert.IsTrue(xades.CanRead);
            return this;
        }

        public TestHelper Get_PAdES()
        {
            Assert_state(_status);

            var pades = _directClient.GetPades(_status.References.Pades).Result;
            Assert.IsTrue(pades.CanRead);
            return this;
        }

        public TestHelper Confirm_status()
        {
            Assert_state(_status);

            _directClient.Confirm(_status.References.Confirmation).Wait();

            return this;
        }

        private static StatusReference MorphStatusReferenceIfMayBe(StatusReference statusReference)
        {
            var statusReferenceUri = GetUriFromRelativePath(statusReference.Url().AbsolutePath);
            return new StatusReference(statusReferenceUri, statusReference.StatusQueryToken);
        }

        private static JobStatusResponse MorphJobStatusResponseIfMayBe(JobStatusResponse jobStatusResponse)
        {
            if (ClientType == SmokeTests.Client.Localhost)
            {
                //Server returns 'localhost' as server address, while the server is running on vmWare hos address. We swap it here to avoid configuring server
                jobStatusResponse.Signatures = jobStatusResponse.Signatures.Select(signature =>
                {
                    var xadesReference = signature.XadesReference == null ? null : new XadesReference(GetUriFromRelativePath(signature.XadesReference.Url.AbsolutePath));
                    return new Signature(signature.Signer, xadesReference, signature.SignatureStatus);
                }).ToList();
                jobStatusResponse.References.Pades = new PadesReference(GetUriFromRelativePath(jobStatusResponse.References.Pades.Url.AbsolutePath));
                jobStatusResponse.References.Confirmation = new ConfirmationReference(GetUriFromRelativePath(jobStatusResponse.References.Confirmation.Url.AbsolutePath));
            }

            return jobStatusResponse;
        }

        internal static KeyValuePair<PersonalIdentificationNumber, SignatureStatus> ExpectedSignerStatus(PersonalIdentificationNumber signer, SignatureStatus status)
        {
            return new KeyValuePair<PersonalIdentificationNumber, SignatureStatus>(signer, status);
        }

        private static void Assert_state(object obj)
        {
            if (obj == null)
            {
                throw new InvalidOperationException("Requires gradually built state. Make sure you use functions in the correct order");
            }
        }
    }
}