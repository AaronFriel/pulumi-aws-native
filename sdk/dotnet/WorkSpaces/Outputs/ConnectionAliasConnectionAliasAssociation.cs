// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.WorkSpaces.Outputs
{

    [OutputType]
    public sealed class ConnectionAliasConnectionAliasAssociation
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspaces-connectionalias-connectionaliasassociation.html#cfn-workspaces-connectionalias-connectionaliasassociation-associatedaccountid
        /// </summary>
        public readonly string? AssociatedAccountId;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspaces-connectionalias-connectionaliasassociation.html#cfn-workspaces-connectionalias-connectionaliasassociation-associationstatus
        /// </summary>
        public readonly string? AssociationStatus;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspaces-connectionalias-connectionaliasassociation.html#cfn-workspaces-connectionalias-connectionaliasassociation-connectionidentifier
        /// </summary>
        public readonly string? ConnectionIdentifier;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspaces-connectionalias-connectionaliasassociation.html#cfn-workspaces-connectionalias-connectionaliasassociation-resourceid
        /// </summary>
        public readonly string? ResourceId;

        [OutputConstructor]
        private ConnectionAliasConnectionAliasAssociation(
            string? AssociatedAccountId,

            string? AssociationStatus,

            string? ConnectionIdentifier,

            string? ResourceId)
        {
            this.AssociatedAccountId = AssociatedAccountId;
            this.AssociationStatus = AssociationStatus;
            this.ConnectionIdentifier = ConnectionIdentifier;
            this.ResourceId = ResourceId;
        }
    }
}
