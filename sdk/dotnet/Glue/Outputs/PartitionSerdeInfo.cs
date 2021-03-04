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
    public sealed class PartitionSerdeInfo
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-partition-serdeinfo.html#cfn-glue-partition-serdeinfo-name
        /// </summary>
        public readonly string? Name;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-partition-serdeinfo.html#cfn-glue-partition-serdeinfo-parameters
        /// </summary>
        public readonly Union<System.Text.Json.JsonElement, string>? Parameters;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-partition-serdeinfo.html#cfn-glue-partition-serdeinfo-serializationlibrary
        /// </summary>
        public readonly string? SerializationLibrary;

        [OutputConstructor]
        private PartitionSerdeInfo(
            string? Name,

            Union<System.Text.Json.JsonElement, string>? Parameters,

            string? SerializationLibrary)
        {
            this.Name = Name;
            this.Parameters = Parameters;
            this.SerializationLibrary = SerializationLibrary;
        }
    }
}
