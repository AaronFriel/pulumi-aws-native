// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.AppSync.Outputs
{

    [OutputType]
    public sealed class GraphQLApiOpenIDConnectConfig
    {
        public readonly double? AuthTTL;
        public readonly string? ClientId;
        public readonly double? IatTTL;
        public readonly string? Issuer;

        [OutputConstructor]
        private GraphQLApiOpenIDConnectConfig(
            double? authTTL,

            string? clientId,

            double? iatTTL,

            string? issuer)
        {
            AuthTTL = authTTL;
            ClientId = clientId;
            IatTTL = iatTTL;
            Issuer = issuer;
        }
    }
}
