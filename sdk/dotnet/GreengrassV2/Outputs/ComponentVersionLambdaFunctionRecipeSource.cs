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
    public sealed class ComponentVersionLambdaFunctionRecipeSource
    {
        public readonly object? ComponentDependencies;
        public readonly Outputs.ComponentVersionLambdaExecutionParameters? ComponentLambdaParameters;
        public readonly string? ComponentName;
        public readonly ImmutableArray<Outputs.ComponentVersionComponentPlatform> ComponentPlatforms;
        public readonly string? ComponentVersion;
        public readonly string? LambdaArn;

        [OutputConstructor]
        private ComponentVersionLambdaFunctionRecipeSource(
            object? componentDependencies,

            Outputs.ComponentVersionLambdaExecutionParameters? componentLambdaParameters,

            string? componentName,

            ImmutableArray<Outputs.ComponentVersionComponentPlatform> componentPlatforms,

            string? componentVersion,

            string? lambdaArn)
        {
            ComponentDependencies = componentDependencies;
            ComponentLambdaParameters = componentLambdaParameters;
            ComponentName = componentName;
            ComponentPlatforms = componentPlatforms;
            ComponentVersion = componentVersion;
            LambdaArn = lambdaArn;
        }
    }
}
