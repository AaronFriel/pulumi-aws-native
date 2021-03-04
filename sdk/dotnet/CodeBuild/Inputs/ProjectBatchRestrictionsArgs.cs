// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.CodeBuild.Inputs
{

    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-project-batchrestrictions.html
    /// </summary>
    public sealed class ProjectBatchRestrictionsArgs : Pulumi.ResourceArgs
    {
        [Input("ComputeTypesAllowed")]
        private InputList<string>? _ComputeTypesAllowed;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-project-batchrestrictions.html#cfn-codebuild-project-batchrestrictions-computetypesallowed
        /// </summary>
        public InputList<string> ComputeTypesAllowed
        {
            get => _ComputeTypesAllowed ?? (_ComputeTypesAllowed = new InputList<string>());
            set => _ComputeTypesAllowed = value;
        }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-project-batchrestrictions.html#cfn-codebuild-project-batchrestrictions-maximumbuildsallowed
        /// </summary>
        [Input("MaximumBuildsAllowed")]
        public Input<int>? MaximumBuildsAllowed { get; set; }

        public ProjectBatchRestrictionsArgs()
        {
        }
    }
}
