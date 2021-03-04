// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.Backup.Inputs
{

    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-backupplan-backupruleresourcetype.html
    /// </summary>
    public sealed class BackupPlanBackupRuleResourceTypeArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-backupplan-backupruleresourcetype.html#cfn-backup-backupplan-backupruleresourcetype-completionwindowminutes
        /// </summary>
        [Input("CompletionWindowMinutes")]
        public Input<double>? CompletionWindowMinutes { get; set; }

        [Input("CopyActions")]
        private InputList<Inputs.BackupPlanCopyActionResourceTypeArgs>? _CopyActions;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-backupplan-backupruleresourcetype.html#cfn-backup-backupplan-backupruleresourcetype-copyactions
        /// </summary>
        public InputList<Inputs.BackupPlanCopyActionResourceTypeArgs> CopyActions
        {
            get => _CopyActions ?? (_CopyActions = new InputList<Inputs.BackupPlanCopyActionResourceTypeArgs>());
            set => _CopyActions = value;
        }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-backupplan-backupruleresourcetype.html#cfn-backup-backupplan-backupruleresourcetype-lifecycle
        /// </summary>
        [Input("Lifecycle")]
        public Input<Inputs.BackupPlanLifecycleResourceTypeArgs>? Lifecycle { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-backupplan-backupruleresourcetype.html#cfn-backup-backupplan-backupruleresourcetype-recoverypointtags
        /// </summary>
        [Input("RecoveryPointTags")]
        public InputUnion<System.Text.Json.JsonElement, string>? RecoveryPointTags { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-backupplan-backupruleresourcetype.html#cfn-backup-backupplan-backupruleresourcetype-rulename
        /// </summary>
        [Input("RuleName", required: true)]
        public Input<string> RuleName { get; set; } = null!;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-backupplan-backupruleresourcetype.html#cfn-backup-backupplan-backupruleresourcetype-scheduleexpression
        /// </summary>
        [Input("ScheduleExpression")]
        public Input<string>? ScheduleExpression { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-backupplan-backupruleresourcetype.html#cfn-backup-backupplan-backupruleresourcetype-startwindowminutes
        /// </summary>
        [Input("StartWindowMinutes")]
        public Input<double>? StartWindowMinutes { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-backupplan-backupruleresourcetype.html#cfn-backup-backupplan-backupruleresourcetype-targetbackupvault
        /// </summary>
        [Input("TargetBackupVault", required: true)]
        public Input<string> TargetBackupVault { get; set; } = null!;

        public BackupPlanBackupRuleResourceTypeArgs()
        {
        }
    }
}
