// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.ApplicationInsights.Outputs
{

    /// <summary>
    /// A Windows Event to be monitored for the component.
    /// </summary>
    [OutputType]
    public sealed class ApplicationWindowsEvent
    {
        /// <summary>
        /// The levels of event to log. 
        /// </summary>
        public readonly ImmutableArray<string> EventLevels;
        /// <summary>
        /// The type of Windows Events to log.
        /// </summary>
        public readonly string EventName;
        /// <summary>
        /// The CloudWatch log group name to be associated to the monitored log.
        /// </summary>
        public readonly string LogGroupName;
        /// <summary>
        /// The name of the log pattern set.
        /// </summary>
        public readonly string? PatternSet;

        [OutputConstructor]
        private ApplicationWindowsEvent(
            ImmutableArray<string> eventLevels,

            string eventName,

            string logGroupName,

            string? patternSet)
        {
            EventLevels = eventLevels;
            EventName = eventName;
            LogGroupName = logGroupName;
            PatternSet = patternSet;
        }
    }
}
