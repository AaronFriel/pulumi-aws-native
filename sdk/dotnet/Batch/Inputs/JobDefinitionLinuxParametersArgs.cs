// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.Batch.Inputs
{

    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-containerproperties-linuxparameters.html
    /// </summary>
    public sealed class JobDefinitionLinuxParametersArgs : Pulumi.ResourceArgs
    {
        [Input("Devices")]
        private InputList<Inputs.JobDefinitionDeviceArgs>? _Devices;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-containerproperties-linuxparameters.html#cfn-batch-jobdefinition-containerproperties-linuxparameters-devices
        /// </summary>
        public InputList<Inputs.JobDefinitionDeviceArgs> Devices
        {
            get => _Devices ?? (_Devices = new InputList<Inputs.JobDefinitionDeviceArgs>());
            set => _Devices = value;
        }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-containerproperties-linuxparameters.html#cfn-batch-jobdefinition-containerproperties-linuxparameters-initprocessenabled
        /// </summary>
        [Input("InitProcessEnabled")]
        public Input<bool>? InitProcessEnabled { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-containerproperties-linuxparameters.html#cfn-batch-jobdefinition-containerproperties-linuxparameters-maxswap
        /// </summary>
        [Input("MaxSwap")]
        public Input<int>? MaxSwap { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-containerproperties-linuxparameters.html#cfn-batch-jobdefinition-containerproperties-linuxparameters-sharedmemorysize
        /// </summary>
        [Input("SharedMemorySize")]
        public Input<int>? SharedMemorySize { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-containerproperties-linuxparameters.html#cfn-batch-jobdefinition-containerproperties-linuxparameters-swappiness
        /// </summary>
        [Input("Swappiness")]
        public Input<int>? Swappiness { get; set; }

        [Input("Tmpfs")]
        private InputList<Inputs.JobDefinitionTmpfsArgs>? _Tmpfs;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-containerproperties-linuxparameters.html#cfn-batch-jobdefinition-containerproperties-linuxparameters-tmpfs
        /// </summary>
        public InputList<Inputs.JobDefinitionTmpfsArgs> Tmpfs
        {
            get => _Tmpfs ?? (_Tmpfs = new InputList<Inputs.JobDefinitionTmpfsArgs>());
            set => _Tmpfs = value;
        }

        public JobDefinitionLinuxParametersArgs()
        {
        }
    }
}
