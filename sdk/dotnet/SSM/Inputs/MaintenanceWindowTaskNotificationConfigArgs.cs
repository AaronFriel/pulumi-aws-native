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
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-maintenancewindowtask-notificationconfig.html
    /// </summary>
    public sealed class MaintenanceWindowTaskNotificationConfigArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-maintenancewindowtask-notificationconfig.html#cfn-ssm-maintenancewindowtask-notificationconfig-notificationarn
        /// </summary>
        [Input("notificationArn", required: true)]
        public Input<string> NotificationArn { get; set; } = null!;

        [Input("notificationEvents")]
        private InputList<string>? _notificationEvents;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-maintenancewindowtask-notificationconfig.html#cfn-ssm-maintenancewindowtask-notificationconfig-notificationevents
        /// </summary>
        public InputList<string> NotificationEvents
        {
            get => _notificationEvents ?? (_notificationEvents = new InputList<string>());
            set => _notificationEvents = value;
        }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-maintenancewindowtask-notificationconfig.html#cfn-ssm-maintenancewindowtask-notificationconfig-notificationtype
        /// </summary>
        [Input("notificationType")]
        public Input<string>? NotificationType { get; set; }

        public MaintenanceWindowTaskNotificationConfigArgs()
        {
        }
    }
}