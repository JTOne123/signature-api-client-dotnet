﻿using System.Net.Http;
using Digipost.Signature.Api.Client.Core.Tests.Fakes;
using Digipost.Signature.Api.Client.Core.Tests.Utilities;

namespace Digipost.Signature.Api.Client.Direct.Tests.Fakes
{
    internal class FakeHttpClientHandlerForStatusResponse : FakeHttpClientHandlerResponse
    {
        public override HttpContent GetContent()
        {
            return new StringContent(ContentUtility.GetStatusResponse());
        }
    }
}