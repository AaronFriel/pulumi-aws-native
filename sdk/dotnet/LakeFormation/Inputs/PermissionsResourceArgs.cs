// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.LakeFormation.Inputs
{

    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lakeformation-permissions-resource.html
    /// </summary>
    public sealed class PermissionsResourceArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lakeformation-permissions-resource.html#cfn-lakeformation-permissions-resource-datalocationresource
        /// </summary>
        [Input("DataLocationResource")]
        public Input<Inputs.PermissionsDataLocationResourceArgs>? DataLocationResource { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lakeformation-permissions-resource.html#cfn-lakeformation-permissions-resource-databaseresource
        /// </summary>
        [Input("DatabaseResource")]
        public Input<Inputs.PermissionsDatabaseResourceArgs>? DatabaseResource { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lakeformation-permissions-resource.html#cfn-lakeformation-permissions-resource-tableresource
        /// </summary>
        [Input("TableResource")]
        public Input<Inputs.PermissionsTableResourceArgs>? TableResource { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lakeformation-permissions-resource.html#cfn-lakeformation-permissions-resource-tablewithcolumnsresource
        /// </summary>
        [Input("TableWithColumnsResource")]
        public Input<Inputs.PermissionsTableWithColumnsResourceArgs>? TableWithColumnsResource { get; set; }

        public PermissionsResourceArgs()
        {
        }
    }
}
