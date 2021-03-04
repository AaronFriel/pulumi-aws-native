// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.OpsWorks.Inputs
{

    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opsworks-instance-timebasedautoscaling.html
    /// </summary>
    public sealed class InstanceTimeBasedAutoScalingArgs : Pulumi.ResourceArgs
    {
        [Input("Friday")]
        private InputMap<string>? _Friday;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opsworks-instance-timebasedautoscaling.html#cfn-opsworks-instance-timebasedautoscaling-friday
        /// </summary>
        public InputMap<string> Friday
        {
            get => _Friday ?? (_Friday = new InputMap<string>());
            set => _Friday = value;
        }

        [Input("Monday")]
        private InputMap<string>? _Monday;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opsworks-instance-timebasedautoscaling.html#cfn-opsworks-instance-timebasedautoscaling-monday
        /// </summary>
        public InputMap<string> Monday
        {
            get => _Monday ?? (_Monday = new InputMap<string>());
            set => _Monday = value;
        }

        [Input("Saturday")]
        private InputMap<string>? _Saturday;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opsworks-instance-timebasedautoscaling.html#cfn-opsworks-instance-timebasedautoscaling-saturday
        /// </summary>
        public InputMap<string> Saturday
        {
            get => _Saturday ?? (_Saturday = new InputMap<string>());
            set => _Saturday = value;
        }

        [Input("Sunday")]
        private InputMap<string>? _Sunday;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opsworks-instance-timebasedautoscaling.html#cfn-opsworks-instance-timebasedautoscaling-sunday
        /// </summary>
        public InputMap<string> Sunday
        {
            get => _Sunday ?? (_Sunday = new InputMap<string>());
            set => _Sunday = value;
        }

        [Input("Thursday")]
        private InputMap<string>? _Thursday;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opsworks-instance-timebasedautoscaling.html#cfn-opsworks-instance-timebasedautoscaling-thursday
        /// </summary>
        public InputMap<string> Thursday
        {
            get => _Thursday ?? (_Thursday = new InputMap<string>());
            set => _Thursday = value;
        }

        [Input("Tuesday")]
        private InputMap<string>? _Tuesday;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opsworks-instance-timebasedautoscaling.html#cfn-opsworks-instance-timebasedautoscaling-tuesday
        /// </summary>
        public InputMap<string> Tuesday
        {
            get => _Tuesday ?? (_Tuesday = new InputMap<string>());
            set => _Tuesday = value;
        }

        [Input("Wednesday")]
        private InputMap<string>? _Wednesday;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opsworks-instance-timebasedautoscaling.html#cfn-opsworks-instance-timebasedautoscaling-wednesday
        /// </summary>
        public InputMap<string> Wednesday
        {
            get => _Wednesday ?? (_Wednesday = new InputMap<string>());
            set => _Wednesday = value;
        }

        public InstanceTimeBasedAutoScalingArgs()
        {
        }
    }
}
