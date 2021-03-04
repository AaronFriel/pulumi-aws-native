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
    public sealed class ModelQualityJobDefinitionModelQualityAppSpecification
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelqualityjobdefinition-modelqualityappspecification.html#cfn-sagemaker-modelqualityjobdefinition-modelqualityappspecification-containerarguments
        /// </summary>
        public readonly ImmutableArray<string> ContainerArguments;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelqualityjobdefinition-modelqualityappspecification.html#cfn-sagemaker-modelqualityjobdefinition-modelqualityappspecification-containerentrypoint
        /// </summary>
        public readonly ImmutableArray<string> ContainerEntrypoint;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelqualityjobdefinition-modelqualityappspecification.html#cfn-sagemaker-modelqualityjobdefinition-modelqualityappspecification-environment
        /// </summary>
        public readonly Outputs.ModelQualityJobDefinitionEnvironment? Environment;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelqualityjobdefinition-modelqualityappspecification.html#cfn-sagemaker-modelqualityjobdefinition-modelqualityappspecification-imageuri
        /// </summary>
        public readonly string ImageUri;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelqualityjobdefinition-modelqualityappspecification.html#cfn-sagemaker-modelqualityjobdefinition-modelqualityappspecification-postanalyticsprocessorsourceuri
        /// </summary>
        public readonly string? PostAnalyticsProcessorSourceUri;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelqualityjobdefinition-modelqualityappspecification.html#cfn-sagemaker-modelqualityjobdefinition-modelqualityappspecification-problemtype
        /// </summary>
        public readonly string ProblemType;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelqualityjobdefinition-modelqualityappspecification.html#cfn-sagemaker-modelqualityjobdefinition-modelqualityappspecification-recordpreprocessorsourceuri
        /// </summary>
        public readonly string? RecordPreprocessorSourceUri;

        [OutputConstructor]
        private ModelQualityJobDefinitionModelQualityAppSpecification(
            ImmutableArray<string> ContainerArguments,

            ImmutableArray<string> ContainerEntrypoint,

            Outputs.ModelQualityJobDefinitionEnvironment? Environment,

            string ImageUri,

            string? PostAnalyticsProcessorSourceUri,

            string ProblemType,

            string? RecordPreprocessorSourceUri)
        {
            this.ContainerArguments = ContainerArguments;
            this.ContainerEntrypoint = ContainerEntrypoint;
            this.Environment = Environment;
            this.ImageUri = ImageUri;
            this.PostAnalyticsProcessorSourceUri = PostAnalyticsProcessorSourceUri;
            this.ProblemType = ProblemType;
            this.RecordPreprocessorSourceUri = RecordPreprocessorSourceUri;
        }
    }
}
