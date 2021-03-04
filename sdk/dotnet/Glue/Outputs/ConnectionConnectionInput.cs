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
    public sealed class ConnectionConnectionInput
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connection-connectioninput.html#cfn-glue-connection-connectioninput-connectionproperties
        /// </summary>
        public readonly Union<System.Text.Json.JsonElement, string>? ConnectionProperties;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connection-connectioninput.html#cfn-glue-connection-connectioninput-connectiontype
        /// </summary>
        public readonly string ConnectionType;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connection-connectioninput.html#cfn-glue-connection-connectioninput-description
        /// </summary>
        public readonly string? Description;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connection-connectioninput.html#cfn-glue-connection-connectioninput-matchcriteria
        /// </summary>
        public readonly ImmutableArray<string> MatchCriteria;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connection-connectioninput.html#cfn-glue-connection-connectioninput-name
        /// </summary>
        public readonly string? Name;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connection-connectioninput.html#cfn-glue-connection-connectioninput-physicalconnectionrequirements
        /// </summary>
        public readonly Outputs.ConnectionPhysicalConnectionRequirements? PhysicalConnectionRequirements;

        [OutputConstructor]
        private ConnectionConnectionInput(
            Union<System.Text.Json.JsonElement, string>? ConnectionProperties,

            string ConnectionType,

            string? Description,

            ImmutableArray<string> MatchCriteria,

            string? Name,

            Outputs.ConnectionPhysicalConnectionRequirements? PhysicalConnectionRequirements)
        {
            this.ConnectionProperties = ConnectionProperties;
            this.ConnectionType = ConnectionType;
            this.Description = Description;
            this.MatchCriteria = MatchCriteria;
            this.Name = Name;
            this.PhysicalConnectionRequirements = PhysicalConnectionRequirements;
        }
    }
}
