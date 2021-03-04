// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.CodeArtifact.Outputs
{

    [OutputType]
    public sealed class RepositoryProperties
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codeartifact-repository.html#cfn-codeartifact-repository-description
        /// </summary>
        public readonly string? Description;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codeartifact-repository.html#cfn-codeartifact-repository-domainname
        /// </summary>
        public readonly string DomainName;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codeartifact-repository.html#cfn-codeartifact-repository-domainowner
        /// </summary>
        public readonly string? DomainOwner;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codeartifact-repository.html#cfn-codeartifact-repository-externalconnections
        /// </summary>
        public readonly ImmutableArray<string> ExternalConnections;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codeartifact-repository.html#cfn-codeartifact-repository-permissionspolicydocument
        /// </summary>
        public readonly Union<System.Text.Json.JsonElement, string>? PermissionsPolicyDocument;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codeartifact-repository.html#cfn-codeartifact-repository-repositoryname
        /// </summary>
        public readonly string RepositoryName;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codeartifact-repository.html#cfn-codeartifact-repository-tags
        /// </summary>
        public readonly ImmutableArray<Pulumi.AwsNative.Outputs.Tag> Tags;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codeartifact-repository.html#cfn-codeartifact-repository-upstreams
        /// </summary>
        public readonly ImmutableArray<string> Upstreams;

        [OutputConstructor]
        private RepositoryProperties(
            string? Description,

            string DomainName,

            string? DomainOwner,

            ImmutableArray<string> ExternalConnections,

            Union<System.Text.Json.JsonElement, string>? PermissionsPolicyDocument,

            string RepositoryName,

            ImmutableArray<Pulumi.AwsNative.Outputs.Tag> Tags,

            ImmutableArray<string> Upstreams)
        {
            this.Description = Description;
            this.DomainName = DomainName;
            this.DomainOwner = DomainOwner;
            this.ExternalConnections = ExternalConnections;
            this.PermissionsPolicyDocument = PermissionsPolicyDocument;
            this.RepositoryName = RepositoryName;
            this.Tags = Tags;
            this.Upstreams = Upstreams;
        }
    }
}
