// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.GroundStation.Outputs
{

    [OutputType]
    public sealed class ConfigAttributes
    {
        public readonly string Arn;
        public readonly string Id;
        public readonly string Type;

        [OutputConstructor]
        private ConfigAttributes(
            string Arn,

            string Id,

            string Type)
        {
            this.Arn = Arn;
            this.Id = Id;
            this.Type = Type;
        }
    }
}
