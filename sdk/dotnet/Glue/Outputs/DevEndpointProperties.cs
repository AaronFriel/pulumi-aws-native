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
    public sealed class DevEndpointProperties
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-devendpoint.html#cfn-glue-devendpoint-arguments
        /// </summary>
        public readonly Union<System.Text.Json.JsonElement, string>? Arguments;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-devendpoint.html#cfn-glue-devendpoint-endpointname
        /// </summary>
        public readonly string? EndpointName;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-devendpoint.html#cfn-glue-devendpoint-extrajarss3path
        /// </summary>
        public readonly string? ExtraJarsS3Path;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-devendpoint.html#cfn-glue-devendpoint-extrapythonlibss3path
        /// </summary>
        public readonly string? ExtraPythonLibsS3Path;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-devendpoint.html#cfn-glue-devendpoint-glueversion
        /// </summary>
        public readonly string? GlueVersion;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-devendpoint.html#cfn-glue-devendpoint-numberofnodes
        /// </summary>
        public readonly int? NumberOfNodes;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-devendpoint.html#cfn-glue-devendpoint-numberofworkers
        /// </summary>
        public readonly int? NumberOfWorkers;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-devendpoint.html#cfn-glue-devendpoint-publickey
        /// </summary>
        public readonly string? PublicKey;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-devendpoint.html#cfn-glue-devendpoint-publickeys
        /// </summary>
        public readonly ImmutableArray<string> PublicKeys;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-devendpoint.html#cfn-glue-devendpoint-rolearn
        /// </summary>
        public readonly string RoleArn;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-devendpoint.html#cfn-glue-devendpoint-securityconfiguration
        /// </summary>
        public readonly string? SecurityConfiguration;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-devendpoint.html#cfn-glue-devendpoint-securitygroupids
        /// </summary>
        public readonly ImmutableArray<string> SecurityGroupIds;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-devendpoint.html#cfn-glue-devendpoint-subnetid
        /// </summary>
        public readonly string? SubnetId;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-devendpoint.html#cfn-glue-devendpoint-tags
        /// </summary>
        public readonly Union<System.Text.Json.JsonElement, string>? Tags;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-devendpoint.html#cfn-glue-devendpoint-workertype
        /// </summary>
        public readonly string? WorkerType;

        [OutputConstructor]
        private DevEndpointProperties(
            Union<System.Text.Json.JsonElement, string>? Arguments,

            string? EndpointName,

            string? ExtraJarsS3Path,

            string? ExtraPythonLibsS3Path,

            string? GlueVersion,

            int? NumberOfNodes,

            int? NumberOfWorkers,

            string? PublicKey,

            ImmutableArray<string> PublicKeys,

            string RoleArn,

            string? SecurityConfiguration,

            ImmutableArray<string> SecurityGroupIds,

            string? SubnetId,

            Union<System.Text.Json.JsonElement, string>? Tags,

            string? WorkerType)
        {
            this.Arguments = Arguments;
            this.EndpointName = EndpointName;
            this.ExtraJarsS3Path = ExtraJarsS3Path;
            this.ExtraPythonLibsS3Path = ExtraPythonLibsS3Path;
            this.GlueVersion = GlueVersion;
            this.NumberOfNodes = NumberOfNodes;
            this.NumberOfWorkers = NumberOfWorkers;
            this.PublicKey = PublicKey;
            this.PublicKeys = PublicKeys;
            this.RoleArn = RoleArn;
            this.SecurityConfiguration = SecurityConfiguration;
            this.SecurityGroupIds = SecurityGroupIds;
            this.SubnetId = SubnetId;
            this.Tags = Tags;
            this.WorkerType = WorkerType;
        }
    }
}
