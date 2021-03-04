// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.Glue.Outputs
{

    [OutputType]
    public sealed class MLTransformProperties
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-mltransform.html#cfn-glue-mltransform-description
        /// </summary>
        public readonly string? Description;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-mltransform.html#cfn-glue-mltransform-glueversion
        /// </summary>
        public readonly string? GlueVersion;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-mltransform.html#cfn-glue-mltransform-inputrecordtables
        /// </summary>
        public readonly Outputs.MLTransformInputRecordTables InputRecordTables;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-mltransform.html#cfn-glue-mltransform-maxcapacity
        /// </summary>
        public readonly double? MaxCapacity;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-mltransform.html#cfn-glue-mltransform-maxretries
        /// </summary>
        public readonly int? MaxRetries;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-mltransform.html#cfn-glue-mltransform-name
        /// </summary>
        public readonly string? Name;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-mltransform.html#cfn-glue-mltransform-numberofworkers
        /// </summary>
        public readonly int? NumberOfWorkers;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-mltransform.html#cfn-glue-mltransform-role
        /// </summary>
        public readonly string Role;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-mltransform.html#cfn-glue-mltransform-tags
        /// </summary>
        public readonly Union<System.Text.Json.JsonElement, string>? Tags;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-mltransform.html#cfn-glue-mltransform-timeout
        /// </summary>
        public readonly int? Timeout;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-mltransform.html#cfn-glue-mltransform-transformencryption
        /// </summary>
        public readonly Outputs.MLTransformTransformEncryption? TransformEncryption;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-mltransform.html#cfn-glue-mltransform-transformparameters
        /// </summary>
        public readonly Outputs.MLTransformTransformParameters TransformParameters;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-mltransform.html#cfn-glue-mltransform-workertype
        /// </summary>
        public readonly string? WorkerType;

        [OutputConstructor]
        private MLTransformProperties(
            string? Description,

            string? GlueVersion,

            Outputs.MLTransformInputRecordTables InputRecordTables,

            double? MaxCapacity,

            int? MaxRetries,

            string? Name,

            int? NumberOfWorkers,

            string Role,

            Union<System.Text.Json.JsonElement, string>? Tags,

            int? Timeout,

            Outputs.MLTransformTransformEncryption? TransformEncryption,

            Outputs.MLTransformTransformParameters TransformParameters,

            string? WorkerType)
        {
            this.Description = Description;
            this.GlueVersion = GlueVersion;
            this.InputRecordTables = InputRecordTables;
            this.MaxCapacity = MaxCapacity;
            this.MaxRetries = MaxRetries;
            this.Name = Name;
            this.NumberOfWorkers = NumberOfWorkers;
            this.Role = Role;
            this.Tags = Tags;
            this.Timeout = Timeout;
            this.TransformEncryption = TransformEncryption;
            this.TransformParameters = TransformParameters;
            this.WorkerType = WorkerType;
        }
    }
}
