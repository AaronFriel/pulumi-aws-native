// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.Events.Inputs
{

    public sealed class ConnectionApiKeyAuthParametersArgs : Pulumi.ResourceArgs
    {
        [Input("apiKeyName", required: true)]
        public Input<string> ApiKeyName { get; set; } = null!;

        [Input("apiKeyValue", required: true)]
        public Input<string> ApiKeyValue { get; set; } = null!;

        public ConnectionApiKeyAuthParametersArgs()
        {
        }
    }
}
