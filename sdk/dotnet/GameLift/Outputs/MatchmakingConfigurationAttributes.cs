// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.GameLift.Outputs
{

    [OutputType]
    public sealed class MatchmakingConfigurationAttributes
    {
        public readonly string Arn;
        public readonly string Name;

        [OutputConstructor]
        private MatchmakingConfigurationAttributes(
            string Arn,

            string Name)
        {
            this.Arn = Arn;
            this.Name = Name;
        }
    }
}
