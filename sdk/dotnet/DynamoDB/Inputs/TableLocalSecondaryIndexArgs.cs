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
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-lsi.html
    /// </summary>
    public sealed class TableLocalSecondaryIndexArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-lsi.html#cfn-dynamodb-lsi-indexname
        /// </summary>
        [Input("IndexName", required: true)]
        public Input<string> IndexName { get; set; } = null!;

        [Input("KeySchema", required: true)]
        private InputList<Inputs.TableKeySchemaArgs>? _KeySchema;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-lsi.html#cfn-dynamodb-lsi-keyschema
        /// </summary>
        public InputList<Inputs.TableKeySchemaArgs> KeySchema
        {
            get => _KeySchema ?? (_KeySchema = new InputList<Inputs.TableKeySchemaArgs>());
            set => _KeySchema = value;
        }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-lsi.html#cfn-dynamodb-lsi-projection
        /// </summary>
        [Input("Projection", required: true)]
        public Input<Inputs.TableProjectionArgs> Projection { get; set; } = null!;

        public TableLocalSecondaryIndexArgs()
        {
        }
    }
}
