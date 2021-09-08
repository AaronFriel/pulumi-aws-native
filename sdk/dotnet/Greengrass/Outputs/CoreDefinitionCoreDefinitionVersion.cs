// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.Greengrass.Outputs
{

    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-coredefinition-coredefinitionversion.html
    /// </summary>
    [OutputType]
    public sealed class CoreDefinitionCoreDefinitionVersion
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-coredefinition-coredefinitionversion.html#cfn-greengrass-coredefinition-coredefinitionversion-cores
        /// </summary>
        public readonly ImmutableArray<Outputs.CoreDefinitionCore> Cores;

        [OutputConstructor]
        private CoreDefinitionCoreDefinitionVersion(ImmutableArray<Outputs.CoreDefinitionCore> cores)
        {
            Cores = cores;
        }
    }
}