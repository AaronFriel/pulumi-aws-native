// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.ApplicationInsights.Inputs
{

    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationinsights-application-subcomponentconfigurationdetails.html
    /// </summary>
    public sealed class ApplicationSubComponentConfigurationDetailsArgs : Pulumi.ResourceArgs
    {
        [Input("AlarmMetrics")]
        private InputList<Inputs.ApplicationAlarmMetricArgs>? _AlarmMetrics;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationinsights-application-subcomponentconfigurationdetails.html#cfn-applicationinsights-application-subcomponentconfigurationdetails-alarmmetrics
        /// </summary>
        public InputList<Inputs.ApplicationAlarmMetricArgs> AlarmMetrics
        {
            get => _AlarmMetrics ?? (_AlarmMetrics = new InputList<Inputs.ApplicationAlarmMetricArgs>());
            set => _AlarmMetrics = value;
        }

        [Input("Logs")]
        private InputList<Inputs.ApplicationLogArgs>? _Logs;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationinsights-application-subcomponentconfigurationdetails.html#cfn-applicationinsights-application-subcomponentconfigurationdetails-logs
        /// </summary>
        public InputList<Inputs.ApplicationLogArgs> Logs
        {
            get => _Logs ?? (_Logs = new InputList<Inputs.ApplicationLogArgs>());
            set => _Logs = value;
        }

        [Input("WindowsEvents")]
        private InputList<Inputs.ApplicationWindowsEventArgs>? _WindowsEvents;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationinsights-application-subcomponentconfigurationdetails.html#cfn-applicationinsights-application-subcomponentconfigurationdetails-windowsevents
        /// </summary>
        public InputList<Inputs.ApplicationWindowsEventArgs> WindowsEvents
        {
            get => _WindowsEvents ?? (_WindowsEvents = new InputList<Inputs.ApplicationWindowsEventArgs>());
            set => _WindowsEvents = value;
        }

        public ApplicationSubComponentConfigurationDetailsArgs()
        {
        }
    }
}
