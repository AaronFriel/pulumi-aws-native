// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.DirectoryService.Inputs
{

    public sealed class MicrosoftADVpcSettingsArgs : Pulumi.ResourceArgs
    {
        [Input("subnetIds", required: true)]
        private InputList<string>? _subnetIds;
        public InputList<string> SubnetIds
        {
            get => _subnetIds ?? (_subnetIds = new InputList<string>());
            set => _subnetIds = value;
        }

        [Input("vpcId", required: true)]
        public Input<string> VpcId { get; set; } = null!;

        public MicrosoftADVpcSettingsArgs()
        {
        }
    }
}