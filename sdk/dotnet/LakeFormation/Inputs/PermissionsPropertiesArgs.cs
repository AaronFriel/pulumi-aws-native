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
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lakeformation-permissions.html
    /// </summary>
    public sealed class PermissionsPropertiesArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lakeformation-permissions.html#cfn-lakeformation-permissions-datalakeprincipal
        /// </summary>
        [Input("DataLakePrincipal", required: true)]
        public Input<Inputs.PermissionsDataLakePrincipalArgs> DataLakePrincipal { get; set; } = null!;

        [Input("Permissions")]
        private InputList<string>? _Permissions;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lakeformation-permissions.html#cfn-lakeformation-permissions-permissions
        /// </summary>
        public InputList<string> Permissions
        {
            get => _Permissions ?? (_Permissions = new InputList<string>());
            set => _Permissions = value;
        }

        [Input("PermissionsWithGrantOption")]
        private InputList<string>? _PermissionsWithGrantOption;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lakeformation-permissions.html#cfn-lakeformation-permissions-permissionswithgrantoption
        /// </summary>
        public InputList<string> PermissionsWithGrantOption
        {
            get => _PermissionsWithGrantOption ?? (_PermissionsWithGrantOption = new InputList<string>());
            set => _PermissionsWithGrantOption = value;
        }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lakeformation-permissions.html#cfn-lakeformation-permissions-resource
        /// </summary>
        [Input("Resource", required: true)]
        public Input<Inputs.PermissionsResourceArgs> Resource { get; set; } = null!;

        public PermissionsPropertiesArgs()
        {
        }
    }
}
