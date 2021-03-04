// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.RDS.Inputs
{

    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-optiongroup-optionconfigurations.html
    /// </summary>
    public sealed class OptionGroupOptionConfigurationArgs : Pulumi.ResourceArgs
    {
        [Input("DBSecurityGroupMemberships")]
        private InputList<string>? _DBSecurityGroupMemberships;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-optiongroup-optionconfigurations.html#cfn-rds-optiongroup-optionconfigurations-dbsecuritygroupmemberships
        /// </summary>
        public InputList<string> DBSecurityGroupMemberships
        {
            get => _DBSecurityGroupMemberships ?? (_DBSecurityGroupMemberships = new InputList<string>());
            set => _DBSecurityGroupMemberships = value;
        }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-optiongroup-optionconfigurations.html#cfn-rds-optiongroup-optionconfigurations-optionname
        /// </summary>
        [Input("OptionName", required: true)]
        public Input<string> OptionName { get; set; } = null!;

        [Input("OptionSettings")]
        private InputList<Inputs.OptionGroupOptionSettingArgs>? _OptionSettings;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-optiongroup-optionconfigurations.html#cfn-rds-optiongroup-optionconfigurations-optionsettings
        /// </summary>
        public InputList<Inputs.OptionGroupOptionSettingArgs> OptionSettings
        {
            get => _OptionSettings ?? (_OptionSettings = new InputList<Inputs.OptionGroupOptionSettingArgs>());
            set => _OptionSettings = value;
        }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-optiongroup-optionconfigurations.html#cfn-rds-optiongroup-optionconfiguration-optionversion
        /// </summary>
        [Input("OptionVersion")]
        public Input<string>? OptionVersion { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-optiongroup-optionconfigurations.html#cfn-rds-optiongroup-optionconfigurations-port
        /// </summary>
        [Input("Port")]
        public Input<int>? Port { get; set; }

        [Input("VpcSecurityGroupMemberships")]
        private InputList<string>? _VpcSecurityGroupMemberships;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-optiongroup-optionconfigurations.html#cfn-rds-optiongroup-optionconfigurations-vpcsecuritygroupmemberships
        /// </summary>
        public InputList<string> VpcSecurityGroupMemberships
        {
            get => _VpcSecurityGroupMemberships ?? (_VpcSecurityGroupMemberships = new InputList<string>());
            set => _VpcSecurityGroupMemberships = value;
        }

        public OptionGroupOptionConfigurationArgs()
        {
        }
    }
}
