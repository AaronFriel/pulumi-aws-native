// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.GreengrassV2.Outputs
{

    [OutputType]
    public sealed class ComponentVersionLambdaLinuxProcessParams
    {
        public readonly Outputs.ComponentVersionLambdaContainerParams? ContainerParams;
        public readonly string? IsolationMode;

        [OutputConstructor]
        private ComponentVersionLambdaLinuxProcessParams(
            Outputs.ComponentVersionLambdaContainerParams? containerParams,

            string? isolationMode)
        {
            ContainerParams = containerParams;
            IsolationMode = isolationMode;
        }
    }
}
