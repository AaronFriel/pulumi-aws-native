// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.MWAA.Outputs
{

    [OutputType]
    public sealed class EnvironmentLoggingConfiguration
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mwaa-environment-loggingconfiguration.html#cfn-mwaa-environment-loggingconfiguration-dagprocessinglogs
        /// </summary>
        public readonly Outputs.EnvironmentModuleLoggingConfiguration? DagProcessingLogs;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mwaa-environment-loggingconfiguration.html#cfn-mwaa-environment-loggingconfiguration-schedulerlogs
        /// </summary>
        public readonly Outputs.EnvironmentModuleLoggingConfiguration? SchedulerLogs;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mwaa-environment-loggingconfiguration.html#cfn-mwaa-environment-loggingconfiguration-tasklogs
        /// </summary>
        public readonly Outputs.EnvironmentModuleLoggingConfiguration? TaskLogs;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mwaa-environment-loggingconfiguration.html#cfn-mwaa-environment-loggingconfiguration-webserverlogs
        /// </summary>
        public readonly Outputs.EnvironmentModuleLoggingConfiguration? WebserverLogs;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mwaa-environment-loggingconfiguration.html#cfn-mwaa-environment-loggingconfiguration-workerlogs
        /// </summary>
        public readonly Outputs.EnvironmentModuleLoggingConfiguration? WorkerLogs;

        [OutputConstructor]
        private EnvironmentLoggingConfiguration(
            Outputs.EnvironmentModuleLoggingConfiguration? DagProcessingLogs,

            Outputs.EnvironmentModuleLoggingConfiguration? SchedulerLogs,

            Outputs.EnvironmentModuleLoggingConfiguration? TaskLogs,

            Outputs.EnvironmentModuleLoggingConfiguration? WebserverLogs,

            Outputs.EnvironmentModuleLoggingConfiguration? WorkerLogs)
        {
            this.DagProcessingLogs = DagProcessingLogs;
            this.SchedulerLogs = SchedulerLogs;
            this.TaskLogs = TaskLogs;
            this.WebserverLogs = WebserverLogs;
            this.WorkerLogs = WorkerLogs;
        }
    }
}
