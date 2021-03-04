// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.MediaLive.Inputs
{

    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-input.html
    /// </summary>
    public sealed class InputPropertiesArgs : Pulumi.ResourceArgs
    {
        [Input("Destinations")]
        private InputList<Inputs.InputInputDestinationRequestArgs>? _Destinations;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-input.html#cfn-medialive-input-destinations
        /// </summary>
        public InputList<Inputs.InputInputDestinationRequestArgs> Destinations
        {
            get => _Destinations ?? (_Destinations = new InputList<Inputs.InputInputDestinationRequestArgs>());
            set => _Destinations = value;
        }

        [Input("InputDevices")]
        private InputList<Inputs.InputInputDeviceSettingsArgs>? _InputDevices;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-input.html#cfn-medialive-input-inputdevices
        /// </summary>
        public InputList<Inputs.InputInputDeviceSettingsArgs> InputDevices
        {
            get => _InputDevices ?? (_InputDevices = new InputList<Inputs.InputInputDeviceSettingsArgs>());
            set => _InputDevices = value;
        }

        [Input("InputSecurityGroups")]
        private InputList<string>? _InputSecurityGroups;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-input.html#cfn-medialive-input-inputsecuritygroups
        /// </summary>
        public InputList<string> InputSecurityGroups
        {
            get => _InputSecurityGroups ?? (_InputSecurityGroups = new InputList<string>());
            set => _InputSecurityGroups = value;
        }

        [Input("MediaConnectFlows")]
        private InputList<Inputs.InputMediaConnectFlowRequestArgs>? _MediaConnectFlows;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-input.html#cfn-medialive-input-mediaconnectflows
        /// </summary>
        public InputList<Inputs.InputMediaConnectFlowRequestArgs> MediaConnectFlows
        {
            get => _MediaConnectFlows ?? (_MediaConnectFlows = new InputList<Inputs.InputMediaConnectFlowRequestArgs>());
            set => _MediaConnectFlows = value;
        }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-input.html#cfn-medialive-input-name
        /// </summary>
        [Input("Name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-input.html#cfn-medialive-input-rolearn
        /// </summary>
        [Input("RoleArn")]
        public Input<string>? RoleArn { get; set; }

        [Input("Sources")]
        private InputList<Inputs.InputInputSourceRequestArgs>? _Sources;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-input.html#cfn-medialive-input-sources
        /// </summary>
        public InputList<Inputs.InputInputSourceRequestArgs> Sources
        {
            get => _Sources ?? (_Sources = new InputList<Inputs.InputInputSourceRequestArgs>());
            set => _Sources = value;
        }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-input.html#cfn-medialive-input-tags
        /// </summary>
        [Input("Tags")]
        public InputUnion<System.Text.Json.JsonElement, string>? Tags { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-input.html#cfn-medialive-input-type
        /// </summary>
        [Input("Type")]
        public Input<string>? Type { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-input.html#cfn-medialive-input-vpc
        /// </summary>
        [Input("Vpc")]
        public Input<Inputs.InputInputVpcRequestArgs>? Vpc { get; set; }

        public InputPropertiesArgs()
        {
        }
    }
}
