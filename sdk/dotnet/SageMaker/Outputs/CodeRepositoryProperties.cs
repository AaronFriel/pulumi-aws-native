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
    public sealed class CodeRepositoryProperties
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-coderepository.html#cfn-sagemaker-coderepository-coderepositoryname
        /// </summary>
        public readonly string? CodeRepositoryName;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-coderepository.html#cfn-sagemaker-coderepository-gitconfig
        /// </summary>
        public readonly Outputs.CodeRepositoryGitConfig GitConfig;

        [OutputConstructor]
        private CodeRepositoryProperties(
            string? CodeRepositoryName,

            Outputs.CodeRepositoryGitConfig GitConfig)
        {
            this.CodeRepositoryName = CodeRepositoryName;
            this.GitConfig = GitConfig;
        }
    }
}
