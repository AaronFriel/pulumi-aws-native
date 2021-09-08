// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.SageMaker.Outputs
{

    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-datacaptureconfig.html
    /// </summary>
    [OutputType]
    public sealed class EndpointConfigDataCaptureConfig
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-datacaptureconfig.html#cfn-sagemaker-endpointconfig-datacaptureconfig-capturecontenttypeheader
        /// </summary>
        public readonly Outputs.EndpointConfigCaptureContentTypeHeader? CaptureContentTypeHeader;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-datacaptureconfig.html#cfn-sagemaker-endpointconfig-datacaptureconfig-captureoptions
        /// </summary>
        public readonly ImmutableArray<Outputs.EndpointConfigCaptureOption> CaptureOptions;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-datacaptureconfig.html#cfn-sagemaker-endpointconfig-datacaptureconfig-destinations3uri
        /// </summary>
        public readonly string DestinationS3Uri;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-datacaptureconfig.html#cfn-sagemaker-endpointconfig-datacaptureconfig-enablecapture
        /// </summary>
        public readonly bool? EnableCapture;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-datacaptureconfig.html#cfn-sagemaker-endpointconfig-datacaptureconfig-initialsamplingpercentage
        /// </summary>
        public readonly int InitialSamplingPercentage;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-datacaptureconfig.html#cfn-sagemaker-endpointconfig-datacaptureconfig-kmskeyid
        /// </summary>
        public readonly string? KmsKeyId;

        [OutputConstructor]
        private EndpointConfigDataCaptureConfig(
            Outputs.EndpointConfigCaptureContentTypeHeader? captureContentTypeHeader,

            ImmutableArray<Outputs.EndpointConfigCaptureOption> captureOptions,

            string destinationS3Uri,

            bool? enableCapture,

            int initialSamplingPercentage,

            string? kmsKeyId)
        {
            CaptureContentTypeHeader = captureContentTypeHeader;
            CaptureOptions = captureOptions;
            DestinationS3Uri = destinationS3Uri;
            EnableCapture = enableCapture;
            InitialSamplingPercentage = initialSamplingPercentage;
            KmsKeyId = kmsKeyId;
        }
    }
}