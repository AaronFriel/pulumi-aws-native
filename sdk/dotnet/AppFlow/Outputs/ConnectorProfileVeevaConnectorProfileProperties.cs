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
    public sealed class ConnectorProfileVeevaConnectorProfileProperties
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-veevaconnectorprofileproperties.html#cfn-appflow-connectorprofile-veevaconnectorprofileproperties-instanceurl
        /// </summary>
        public readonly string InstanceUrl;

        [OutputConstructor]
        private ConnectorProfileVeevaConnectorProfileProperties(string InstanceUrl)
        {
            this.InstanceUrl = InstanceUrl;
        }
    }
}
