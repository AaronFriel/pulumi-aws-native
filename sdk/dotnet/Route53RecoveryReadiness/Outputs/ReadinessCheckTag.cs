// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.Route53RecoveryReadiness.Outputs
{

    [OutputType]
    public sealed class ReadinessCheckTag
    {
        public readonly string Key;
        public readonly ImmutableArray<string> Value;

        [OutputConstructor]
        private ReadinessCheckTag(
            string key,

            ImmutableArray<string> value)
        {
            Key = key;
            Value = value;
        }
    }
}
