﻿using System.Security.Cryptography.X509Certificates;
using Digipost.Signature.Api.Client.Core;
using Digipost.Signature.Api.Client.Core.Internal.Asice;
using Digipost.Signature.Api.Client.Core.Internal.Asice.AsiceSignature;

namespace Digipost.Signature.Api.Client.Direct.Internal.AsicE
{
    internal class DirectAsiceGenerator : AsiceGenerator
    {
        public static DocumentBundle CreateAsice(Job job, X509Certificate2 certificate, IAsiceConfiguration asiceConfiguration)
        {
            var manifest = new Manifest(job.Sender, (Document) job.Document, job.Signers)
            {
                AuthenticationLevel = job.AuthenticationLevel,
                IdentifierInSignedDocuments = job.IdentifierInSignedDocuments
            };
            var signature = new SignatureGenerator(certificate, job.Document, manifest);

            var asiceArchive = GetAsiceArchive(job, asiceConfiguration, job.Document, signature, manifest);

            return new DocumentBundle(asiceArchive.GetBytes());
        }
    }
}
