// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.DynamoDB.Inputs
{

    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dynamodb-table.html
    /// </summary>
    public sealed class TablePropertiesArgs : Pulumi.ResourceArgs
    {
        [Input("AttributeDefinitions")]
        private InputList<Inputs.TableAttributeDefinitionArgs>? _AttributeDefinitions;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dynamodb-table.html#cfn-dynamodb-table-attributedef
        /// </summary>
        public InputList<Inputs.TableAttributeDefinitionArgs> AttributeDefinitions
        {
            get => _AttributeDefinitions ?? (_AttributeDefinitions = new InputList<Inputs.TableAttributeDefinitionArgs>());
            set => _AttributeDefinitions = value;
        }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dynamodb-table.html#cfn-dynamodb-table-billingmode
        /// </summary>
        [Input("BillingMode")]
        public Input<string>? BillingMode { get; set; }

        [Input("GlobalSecondaryIndexes")]
        private InputList<Inputs.TableGlobalSecondaryIndexArgs>? _GlobalSecondaryIndexes;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dynamodb-table.html#cfn-dynamodb-table-gsi
        /// </summary>
        public InputList<Inputs.TableGlobalSecondaryIndexArgs> GlobalSecondaryIndexes
        {
            get => _GlobalSecondaryIndexes ?? (_GlobalSecondaryIndexes = new InputList<Inputs.TableGlobalSecondaryIndexArgs>());
            set => _GlobalSecondaryIndexes = value;
        }

        [Input("KeySchema", required: true)]
        private InputList<Inputs.TableKeySchemaArgs>? _KeySchema;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dynamodb-table.html#cfn-dynamodb-table-keyschema
        /// </summary>
        public InputList<Inputs.TableKeySchemaArgs> KeySchema
        {
            get => _KeySchema ?? (_KeySchema = new InputList<Inputs.TableKeySchemaArgs>());
            set => _KeySchema = value;
        }

        [Input("LocalSecondaryIndexes")]
        private InputList<Inputs.TableLocalSecondaryIndexArgs>? _LocalSecondaryIndexes;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dynamodb-table.html#cfn-dynamodb-table-lsi
        /// </summary>
        public InputList<Inputs.TableLocalSecondaryIndexArgs> LocalSecondaryIndexes
        {
            get => _LocalSecondaryIndexes ?? (_LocalSecondaryIndexes = new InputList<Inputs.TableLocalSecondaryIndexArgs>());
            set => _LocalSecondaryIndexes = value;
        }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dynamodb-table.html#cfn-dynamodb-table-pointintimerecoveryspecification
        /// </summary>
        [Input("PointInTimeRecoverySpecification")]
        public Input<Inputs.TablePointInTimeRecoverySpecificationArgs>? PointInTimeRecoverySpecification { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dynamodb-table.html#cfn-dynamodb-table-provisionedthroughput
        /// </summary>
        [Input("ProvisionedThroughput")]
        public Input<Inputs.TableProvisionedThroughputArgs>? ProvisionedThroughput { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dynamodb-table.html#cfn-dynamodb-table-ssespecification
        /// </summary>
        [Input("SSESpecification")]
        public Input<Inputs.TableSSESpecificationArgs>? SSESpecification { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dynamodb-table.html#cfn-dynamodb-table-streamspecification
        /// </summary>
        [Input("StreamSpecification")]
        public Input<Inputs.TableStreamSpecificationArgs>? StreamSpecification { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dynamodb-table.html#cfn-dynamodb-table-tablename
        /// </summary>
        [Input("TableName")]
        public Input<string>? TableName { get; set; }

        [Input("Tags")]
        private InputList<Pulumi.AwsNative.Inputs.TagArgs>? _Tags;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dynamodb-table.html#cfn-dynamodb-table-tags
        /// </summary>
        public InputList<Pulumi.AwsNative.Inputs.TagArgs> Tags
        {
            get => _Tags ?? (_Tags = new InputList<Pulumi.AwsNative.Inputs.TagArgs>());
            set => _Tags = value;
        }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dynamodb-table.html#cfn-dynamodb-table-timetolivespecification
        /// </summary>
        [Input("TimeToLiveSpecification")]
        public Input<Inputs.TableTimeToLiveSpecificationArgs>? TimeToLiveSpecification { get; set; }

        public TablePropertiesArgs()
        {
        }
    }
}
