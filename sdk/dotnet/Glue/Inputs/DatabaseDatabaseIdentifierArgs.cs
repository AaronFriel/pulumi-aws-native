// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.Glue.Inputs
{

    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-database-databaseidentifier.html
    /// </summary>
    public sealed class DatabaseDatabaseIdentifierArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-database-databaseidentifier.html#cfn-glue-database-databaseidentifier-catalogid
        /// </summary>
        [Input("CatalogId")]
        public Input<string>? CatalogId { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-database-databaseidentifier.html#cfn-glue-database-databaseidentifier-databasename
        /// </summary>
        [Input("DatabaseName")]
        public Input<string>? DatabaseName { get; set; }

        public DatabaseDatabaseIdentifierArgs()
        {
        }
    }
}
