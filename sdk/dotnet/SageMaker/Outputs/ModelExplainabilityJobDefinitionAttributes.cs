// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.SageMaker.Outputs
{

    [OutputType]
    public sealed class ModelExplainabilityJobDefinitionAttributes
    {
        public readonly string CreationTime;
        public readonly string JobDefinitionArn;

        [OutputConstructor]
        private ModelExplainabilityJobDefinitionAttributes(
            string CreationTime,

            string JobDefinitionArn)
        {
            this.CreationTime = CreationTime;
            this.JobDefinitionArn = JobDefinitionArn;
        }
    }
}
