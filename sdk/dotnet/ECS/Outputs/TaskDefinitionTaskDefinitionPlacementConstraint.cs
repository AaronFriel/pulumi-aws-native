// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.ECS.Outputs
{

    [OutputType]
    public sealed class TaskDefinitionTaskDefinitionPlacementConstraint
    {
        public readonly string? Expression;
        public readonly string Type;

        [OutputConstructor]
        private TaskDefinitionTaskDefinitionPlacementConstraint(
            string? expression,

            string type)
        {
            Expression = expression;
            Type = type;
        }
    }
}
