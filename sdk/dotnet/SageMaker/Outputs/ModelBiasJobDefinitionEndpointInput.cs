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
    public sealed class ModelBiasJobDefinitionEndpointInput
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelbiasjobdefinition-endpointinput.html#cfn-sagemaker-modelbiasjobdefinition-endpointinput-endtimeoffset
        /// </summary>
        public readonly string? EndTimeOffset;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelbiasjobdefinition-endpointinput.html#cfn-sagemaker-modelbiasjobdefinition-endpointinput-endpointname
        /// </summary>
        public readonly string EndpointName;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelbiasjobdefinition-endpointinput.html#cfn-sagemaker-modelbiasjobdefinition-endpointinput-featuresattribute
        /// </summary>
        public readonly string? FeaturesAttribute;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelbiasjobdefinition-endpointinput.html#cfn-sagemaker-modelbiasjobdefinition-endpointinput-inferenceattribute
        /// </summary>
        public readonly string? InferenceAttribute;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelbiasjobdefinition-endpointinput.html#cfn-sagemaker-modelbiasjobdefinition-endpointinput-localpath
        /// </summary>
        public readonly string LocalPath;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelbiasjobdefinition-endpointinput.html#cfn-sagemaker-modelbiasjobdefinition-endpointinput-probabilityattribute
        /// </summary>
        public readonly string? ProbabilityAttribute;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelbiasjobdefinition-endpointinput.html#cfn-sagemaker-modelbiasjobdefinition-endpointinput-probabilitythresholdattribute
        /// </summary>
        public readonly double? ProbabilityThresholdAttribute;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelbiasjobdefinition-endpointinput.html#cfn-sagemaker-modelbiasjobdefinition-endpointinput-s3datadistributiontype
        /// </summary>
        public readonly string? S3DataDistributionType;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelbiasjobdefinition-endpointinput.html#cfn-sagemaker-modelbiasjobdefinition-endpointinput-s3inputmode
        /// </summary>
        public readonly string? S3InputMode;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelbiasjobdefinition-endpointinput.html#cfn-sagemaker-modelbiasjobdefinition-endpointinput-starttimeoffset
        /// </summary>
        public readonly string? StartTimeOffset;

        [OutputConstructor]
        private ModelBiasJobDefinitionEndpointInput(
            string? EndTimeOffset,

            string EndpointName,

            string? FeaturesAttribute,

            string? InferenceAttribute,

            string LocalPath,

            string? ProbabilityAttribute,

            double? ProbabilityThresholdAttribute,

            string? S3DataDistributionType,

            string? S3InputMode,

            string? StartTimeOffset)
        {
            this.EndTimeOffset = EndTimeOffset;
            this.EndpointName = EndpointName;
            this.FeaturesAttribute = FeaturesAttribute;
            this.InferenceAttribute = InferenceAttribute;
            this.LocalPath = LocalPath;
            this.ProbabilityAttribute = ProbabilityAttribute;
            this.ProbabilityThresholdAttribute = ProbabilityThresholdAttribute;
            this.S3DataDistributionType = S3DataDistributionType;
            this.S3InputMode = S3InputMode;
            this.StartTimeOffset = StartTimeOffset;
        }
    }
}
