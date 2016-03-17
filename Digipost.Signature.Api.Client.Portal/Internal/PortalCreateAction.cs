﻿using System;
using Digipost.Signature.Api.Client.Core.Asice;
using Digipost.Signature.Api.Client.Core.Internal;
using Digipost.Signature.Api.Client.Portal.DataTransferObjects;

namespace Digipost.Signature.Api.Client.Portal.Internal
{
    internal class PortalCreateAction : CreateAction
    {
        public static readonly Func<IRequestContent, string> SerializeFunc = content => SerializeUtility.Serialize(DataTransferObjectConverter.ToDataTransferObject((PortalJob) content));

        public static readonly Func<string, PortalJobResponse> DeserializeFunc = content => DataTransferObjectConverter.FromDataTransferObject(SerializeUtility.Deserialize<portalsignaturejobresponse>(content));

        public PortalCreateAction(PortalJob portalJob, DocumentBundle documentBundle)
            : base(portalJob, documentBundle, SerializeFunc)
        {
        }
    }
}