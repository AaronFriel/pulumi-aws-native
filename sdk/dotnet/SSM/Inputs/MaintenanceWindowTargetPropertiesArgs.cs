// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.SSM.Inputs
{

    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssm-maintenancewindowtarget.html
    /// </summary>
    public sealed class MaintenanceWindowTargetPropertiesArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssm-maintenancewindowtarget.html#cfn-ssm-maintenancewindowtarget-description
        /// </summary>
        [Input("Description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssm-maintenancewindowtarget.html#cfn-ssm-maintenancewindowtarget-name
        /// </summary>
        [Input("Name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssm-maintenancewindowtarget.html#cfn-ssm-maintenancewindowtarget-ownerinformation
        /// </summary>
        [Input("OwnerInformation")]
        public Input<string>? OwnerInformation { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssm-maintenancewindowtarget.html#cfn-ssm-maintenancewindowtarget-resourcetype
        /// </summary>
        [Input("ResourceType", required: true)]
        public Input<string> ResourceType { get; set; } = null!;

        [Input("Targets", required: true)]
        private InputList<Inputs.MaintenanceWindowTargetTargetsArgs>? _Targets;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssm-maintenancewindowtarget.html#cfn-ssm-maintenancewindowtarget-targets
        /// </summary>
        public InputList<Inputs.MaintenanceWindowTargetTargetsArgs> Targets
        {
            get => _Targets ?? (_Targets = new InputList<Inputs.MaintenanceWindowTargetTargetsArgs>());
            set => _Targets = value;
        }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssm-maintenancewindowtarget.html#cfn-ssm-maintenancewindowtarget-windowid
        /// </summary>
        [Input("WindowId", required: true)]
        public Input<string> WindowId { get; set; } = null!;

        public MaintenanceWindowTargetPropertiesArgs()
        {
        }
    }
}
