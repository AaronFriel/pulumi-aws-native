// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.Glue.Inputs
{

    public sealed class JobConnectionsListArgs : Pulumi.ResourceArgs
    {
        [Input("connections")]
        private InputList<string>? _connections;
        public InputList<string> Connections
        {
            get => _connections ?? (_connections = new InputList<string>());
            set => _connections = value;
        }

        public JobConnectionsListArgs()
        {
        }
    }
}
