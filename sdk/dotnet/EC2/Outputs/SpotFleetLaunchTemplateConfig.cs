// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.EC2.Outputs
{

    [OutputType]
    public sealed class SpotFleetLaunchTemplateConfig
    {
        public readonly Outputs.SpotFleetFleetLaunchTemplateSpecification? LaunchTemplateSpecification;
        public readonly ImmutableArray<Outputs.SpotFleetLaunchTemplateOverrides> Overrides;

        [OutputConstructor]
        private SpotFleetLaunchTemplateConfig(
            Outputs.SpotFleetFleetLaunchTemplateSpecification? launchTemplateSpecification,

            ImmutableArray<Outputs.SpotFleetLaunchTemplateOverrides> overrides)
        {
            LaunchTemplateSpecification = launchTemplateSpecification;
            Overrides = overrides;
        }
    }
}
