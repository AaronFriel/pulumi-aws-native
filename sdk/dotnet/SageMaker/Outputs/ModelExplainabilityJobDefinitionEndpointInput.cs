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
    public sealed class ModelExplainabilityJobDefinitionEndpointInput
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelexplainabilityjobdefinition-endpointinput.html#cfn-sagemaker-modelexplainabilityjobdefinition-endpointinput-endpointname
        /// </summary>
        public readonly string EndpointName;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelexplainabilityjobdefinition-endpointinput.html#cfn-sagemaker-modelexplainabilityjobdefinition-endpointinput-featuresattribute
        /// </summary>
        public readonly string? FeaturesAttribute;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelexplainabilityjobdefinition-endpointinput.html#cfn-sagemaker-modelexplainabilityjobdefinition-endpointinput-inferenceattribute
        /// </summary>
        public readonly string? InferenceAttribute;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelexplainabilityjobdefinition-endpointinput.html#cfn-sagemaker-modelexplainabilityjobdefinition-endpointinput-localpath
        /// </summary>
        public readonly string LocalPath;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelexplainabilityjobdefinition-endpointinput.html#cfn-sagemaker-modelexplainabilityjobdefinition-endpointinput-probabilityattribute
        /// </summary>
        public readonly string? ProbabilityAttribute;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelexplainabilityjobdefinition-endpointinput.html#cfn-sagemaker-modelexplainabilityjobdefinition-endpointinput-s3datadistributiontype
        /// </summary>
        public readonly string? S3DataDistributionType;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelexplainabilityjobdefinition-endpointinput.html#cfn-sagemaker-modelexplainabilityjobdefinition-endpointinput-s3inputmode
        /// </summary>
        public readonly string? S3InputMode;

        [OutputConstructor]
        private ModelExplainabilityJobDefinitionEndpointInput(
            string EndpointName,

            string? FeaturesAttribute,

            string? InferenceAttribute,

            string LocalPath,

            string? ProbabilityAttribute,

            string? S3DataDistributionType,

            string? S3InputMode)
        {
            this.EndpointName = EndpointName;
            this.FeaturesAttribute = FeaturesAttribute;
            this.InferenceAttribute = InferenceAttribute;
            this.LocalPath = LocalPath;
            this.ProbabilityAttribute = ProbabilityAttribute;
            this.S3DataDistributionType = S3DataDistributionType;
            this.S3InputMode = S3InputMode;
        }
    }
}
