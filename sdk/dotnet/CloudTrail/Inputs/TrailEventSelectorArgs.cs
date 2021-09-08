// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.CloudTrail.Inputs
{

    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudtrail-trail-eventselector.html
    /// </summary>
    public sealed class TrailEventSelectorArgs : Pulumi.ResourceArgs
    {
        [Input("dataResources")]
        private InputList<Inputs.TrailDataResourceArgs>? _dataResources;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudtrail-trail-eventselector.html#cfn-cloudtrail-trail-eventselector-dataresources
        /// </summary>
        public InputList<Inputs.TrailDataResourceArgs> DataResources
        {
            get => _dataResources ?? (_dataResources = new InputList<Inputs.TrailDataResourceArgs>());
            set => _dataResources = value;
        }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudtrail-trail-eventselector.html#cfn-cloudtrail-trail-eventselector-includemanagementevents
        /// </summary>
        [Input("includeManagementEvents")]
        public Input<bool>? IncludeManagementEvents { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudtrail-trail-eventselector.html#cfn-cloudtrail-trail-eventselector-readwritetype
        /// </summary>
        [Input("readWriteType")]
        public Input<string>? ReadWriteType { get; set; }

        public TrailEventSelectorArgs()
        {
        }
    }
}