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
    public sealed class FunctionDefinitionVersionDefaultConfig
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-functiondefinitionversion-defaultconfig.html#cfn-greengrass-functiondefinitionversion-defaultconfig-execution
        /// </summary>
        public readonly Outputs.FunctionDefinitionVersionExecution Execution;

        [OutputConstructor]
        private FunctionDefinitionVersionDefaultConfig(Outputs.FunctionDefinitionVersionExecution Execution)
        {
            this.Execution = Execution;
        }
    }
}
