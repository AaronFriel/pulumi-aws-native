// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.Greengrass.Outputs
{

    [OutputType]
    public sealed class SubscriptionDefinitionAttributes
    {
        public readonly string Arn;
        public readonly string Id;
        public readonly string LatestVersionArn;
        public readonly string Name;

        [OutputConstructor]
        private SubscriptionDefinitionAttributes(
            string Arn,

            string Id,

            string LatestVersionArn,

            string Name)
        {
            this.Arn = Arn;
            this.Id = Id;
            this.LatestVersionArn = LatestVersionArn;
            this.Name = Name;
        }
    }
}
