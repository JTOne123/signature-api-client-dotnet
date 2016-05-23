﻿using Digipost.Signature.Api.Client.Core;

namespace Digipost.Signature.Api.Client.Portal
{
    public class Document : AbstractDocument
    {
        public Document(string title, string message, string fileName, FileType fileType, byte[] documentBytes)
            : base(title, message, fileName, fileType, documentBytes)
        {
        }

        public Document(string title, string message, string fileName, FileType fileType, string documentPath)
            : base(title, message, fileName, fileType, documentPath)
        {
        }

        public string NonsensitiveTitle { get; set; }

        public override string ToString()
        {
            return $"{base.ToString()}, NonsensitiveTitle: {NonsensitiveTitle}";
        }
    }
}