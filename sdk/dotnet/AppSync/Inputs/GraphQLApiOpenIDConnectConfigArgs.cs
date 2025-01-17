// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.AppSync.Inputs
{

    public sealed class GraphQLApiOpenIDConnectConfigArgs : Pulumi.ResourceArgs
    {
        [Input("authTTL")]
        public Input<double>? AuthTTL { get; set; }

        [Input("clientId")]
        public Input<string>? ClientId { get; set; }

        [Input("iatTTL")]
        public Input<double>? IatTTL { get; set; }

        [Input("issuer")]
        public Input<string>? Issuer { get; set; }

        public GraphQLApiOpenIDConnectConfigArgs()
        {
        }
    }
}
