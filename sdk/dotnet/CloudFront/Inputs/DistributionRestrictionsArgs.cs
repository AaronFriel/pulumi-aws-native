// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.CloudFront.Inputs
{

    public sealed class DistributionRestrictionsArgs : Pulumi.ResourceArgs
    {
        [Input("geoRestriction", required: true)]
        public Input<Inputs.DistributionGeoRestrictionArgs> GeoRestriction { get; set; } = null!;

        public DistributionRestrictionsArgs()
        {
        }
    }
}
