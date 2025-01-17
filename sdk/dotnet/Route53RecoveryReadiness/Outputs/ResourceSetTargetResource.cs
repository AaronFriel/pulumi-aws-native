// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.Route53RecoveryReadiness.Outputs
{

    /// <summary>
    /// The target resource that the Route 53 record points to.
    /// </summary>
    [OutputType]
    public sealed class ResourceSetTargetResource
    {
        public readonly Outputs.ResourceSetNLBResource? NLBResource;
        public readonly Outputs.ResourceSetR53ResourceRecord? R53Resource;

        [OutputConstructor]
        private ResourceSetTargetResource(
            Outputs.ResourceSetNLBResource? nLBResource,

            Outputs.ResourceSetR53ResourceRecord? r53Resource)
        {
            NLBResource = nLBResource;
            R53Resource = r53Resource;
        }
    }
}
