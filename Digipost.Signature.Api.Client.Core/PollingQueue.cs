﻿namespace Digipost.Signature.Api.Client.Core
{
    public class PollingQueue
    {
        internal static string QueryParameterName = "polling_queue";

        public static PollingQueue Default = new PollingQueue();

        public PollingQueue(string name = null)
        {
            Name = name;
        }

        public string Name { get; }

        public override bool Equals(object obj)
        {
            var that = obj as PollingQueue;

            return that != null && Name.Equals(that.Name);
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }
    }
}
