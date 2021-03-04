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
    public sealed class TableTableInput
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-table-tableinput.html#cfn-glue-table-tableinput-description
        /// </summary>
        public readonly string? Description;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-table-tableinput.html#cfn-glue-table-tableinput-name
        /// </summary>
        public readonly string? Name;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-table-tableinput.html#cfn-glue-table-tableinput-owner
        /// </summary>
        public readonly string? Owner;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-table-tableinput.html#cfn-glue-table-tableinput-parameters
        /// </summary>
        public readonly Union<System.Text.Json.JsonElement, string>? Parameters;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-table-tableinput.html#cfn-glue-table-tableinput-partitionkeys
        /// </summary>
        public readonly ImmutableArray<Outputs.TableColumn> PartitionKeys;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-table-tableinput.html#cfn-glue-table-tableinput-retention
        /// </summary>
        public readonly int? Retention;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-table-tableinput.html#cfn-glue-table-tableinput-storagedescriptor
        /// </summary>
        public readonly Outputs.TableStorageDescriptor? StorageDescriptor;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-table-tableinput.html#cfn-glue-table-tableinput-tabletype
        /// </summary>
        public readonly string? TableType;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-table-tableinput.html#cfn-glue-table-tableinput-targettable
        /// </summary>
        public readonly Outputs.TableTableIdentifier? TargetTable;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-table-tableinput.html#cfn-glue-table-tableinput-viewexpandedtext
        /// </summary>
        public readonly string? ViewExpandedText;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-table-tableinput.html#cfn-glue-table-tableinput-vieworiginaltext
        /// </summary>
        public readonly string? ViewOriginalText;

        [OutputConstructor]
        private TableTableInput(
            string? Description,

            string? Name,

            string? Owner,

            Union<System.Text.Json.JsonElement, string>? Parameters,

            ImmutableArray<Outputs.TableColumn> PartitionKeys,

            int? Retention,

            Outputs.TableStorageDescriptor? StorageDescriptor,

            string? TableType,

            Outputs.TableTableIdentifier? TargetTable,

            string? ViewExpandedText,

            string? ViewOriginalText)
        {
            this.Description = Description;
            this.Name = Name;
            this.Owner = Owner;
            this.Parameters = Parameters;
            this.PartitionKeys = PartitionKeys;
            this.Retention = Retention;
            this.StorageDescriptor = StorageDescriptor;
            this.TableType = TableType;
            this.TargetTable = TargetTable;
            this.ViewExpandedText = ViewExpandedText;
            this.ViewOriginalText = ViewOriginalText;
        }
    }
}
