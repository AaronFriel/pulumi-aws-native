// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.AppFlow.Outputs
{

    [OutputType]
    public sealed class ConnectorProfileProperties
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appflow-connectorprofile.html#cfn-appflow-connectorprofile-connectionmode
        /// </summary>
        public readonly string ConnectionMode;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appflow-connectorprofile.html#cfn-appflow-connectorprofile-connectorprofileconfig
        /// </summary>
        public readonly Outputs.ConnectorProfileConnectorProfileConfig? ConnectorProfileConfig;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appflow-connectorprofile.html#cfn-appflow-connectorprofile-connectorprofilename
        /// </summary>
        public readonly string ConnectorProfileName;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appflow-connectorprofile.html#cfn-appflow-connectorprofile-connectortype
        /// </summary>
        public readonly string ConnectorType;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appflow-connectorprofile.html#cfn-appflow-connectorprofile-kmsarn
        /// </summary>
        public readonly string? KMSArn;

        [OutputConstructor]
        private ConnectorProfileProperties(
            string ConnectionMode,

            Outputs.ConnectorProfileConnectorProfileConfig? ConnectorProfileConfig,

            string ConnectorProfileName,

            string ConnectorType,

            string? KMSArn)
        {
            this.ConnectionMode = ConnectionMode;
            this.ConnectorProfileConfig = ConnectorProfileConfig;
            this.ConnectorProfileName = ConnectorProfileName;
            this.ConnectorType = ConnectorType;
            this.KMSArn = KMSArn;
        }
    }
}
