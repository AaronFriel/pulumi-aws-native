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
    public sealed class NotebookInstanceLifecycleConfigProperties
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-notebookinstancelifecycleconfig.html#cfn-sagemaker-notebookinstancelifecycleconfig-notebookinstancelifecycleconfigname
        /// </summary>
        public readonly string? NotebookInstanceLifecycleConfigName;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-notebookinstancelifecycleconfig.html#cfn-sagemaker-notebookinstancelifecycleconfig-oncreate
        /// </summary>
        public readonly ImmutableArray<Outputs.NotebookInstanceLifecycleConfigNotebookInstanceLifecycleHook> OnCreate;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-notebookinstancelifecycleconfig.html#cfn-sagemaker-notebookinstancelifecycleconfig-onstart
        /// </summary>
        public readonly ImmutableArray<Outputs.NotebookInstanceLifecycleConfigNotebookInstanceLifecycleHook> OnStart;

        [OutputConstructor]
        private NotebookInstanceLifecycleConfigProperties(
            string? NotebookInstanceLifecycleConfigName,

            ImmutableArray<Outputs.NotebookInstanceLifecycleConfigNotebookInstanceLifecycleHook> OnCreate,

            ImmutableArray<Outputs.NotebookInstanceLifecycleConfigNotebookInstanceLifecycleHook> OnStart)
        {
            this.NotebookInstanceLifecycleConfigName = NotebookInstanceLifecycleConfigName;
            this.OnCreate = OnCreate;
            this.OnStart = OnStart;
        }
    }
}
