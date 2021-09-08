// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.CodeBuild.Outputs
{

    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-project-artifacts.html
    /// </summary>
    [OutputType]
    public sealed class ProjectArtifacts
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-project-artifacts.html#cfn-codebuild-project-artifacts-artifactidentifier
        /// </summary>
        public readonly string? ArtifactIdentifier;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-project-artifacts.html#cfn-codebuild-project-artifacts-encryptiondisabled
        /// </summary>
        public readonly bool? EncryptionDisabled;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-project-artifacts.html#cfn-codebuild-project-artifacts-location
        /// </summary>
        public readonly string? Location;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-project-artifacts.html#cfn-codebuild-project-artifacts-name
        /// </summary>
        public readonly string? Name;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-project-artifacts.html#cfn-codebuild-project-artifacts-namespacetype
        /// </summary>
        public readonly string? NamespaceType;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-project-artifacts.html#cfn-codebuild-project-artifacts-overrideartifactname
        /// </summary>
        public readonly bool? OverrideArtifactName;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-project-artifacts.html#cfn-codebuild-project-artifacts-packaging
        /// </summary>
        public readonly string? Packaging;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-project-artifacts.html#cfn-codebuild-project-artifacts-path
        /// </summary>
        public readonly string? Path;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-project-artifacts.html#cfn-codebuild-project-artifacts-type
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private ProjectArtifacts(
            string? artifactIdentifier,

            bool? encryptionDisabled,

            string? location,

            string? name,

            string? namespaceType,

            bool? overrideArtifactName,

            string? packaging,

            string? path,

            string type)
        {
            ArtifactIdentifier = artifactIdentifier;
            EncryptionDisabled = encryptionDisabled;
            Location = location;
            Name = name;
            NamespaceType = namespaceType;
            OverrideArtifactName = overrideArtifactName;
            Packaging = packaging;
            Path = path;
            Type = type;
        }
    }
}