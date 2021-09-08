// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.Glue.Outputs
{

    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-table-schemareference.html
    /// </summary>
    [OutputType]
    public sealed class TableSchemaReference
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-table-schemareference.html#cfn-glue-table-schemareference-schemaid
        /// </summary>
        public readonly Outputs.TableSchemaId? SchemaId;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-table-schemareference.html#cfn-glue-table-schemareference-schemaversionid
        /// </summary>
        public readonly string? SchemaVersionId;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-table-schemareference.html#cfn-glue-table-schemareference-schemaversionnumber
        /// </summary>
        public readonly int? SchemaVersionNumber;

        [OutputConstructor]
        private TableSchemaReference(
            Outputs.TableSchemaId? schemaId,

            string? schemaVersionId,

            int? schemaVersionNumber)
        {
            SchemaId = schemaId;
            SchemaVersionId = schemaVersionId;
            SchemaVersionNumber = schemaVersionNumber;
        }
    }
}