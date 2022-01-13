// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.Backup.Inputs
{

    public sealed class BackupSelectionResourceTypeConditionsPropertiesArgs : Pulumi.ResourceArgs
    {
        [Input("stringEquals")]
        private InputList<Inputs.BackupSelectionConditionParameterArgs>? _stringEquals;
        public InputList<Inputs.BackupSelectionConditionParameterArgs> StringEquals
        {
            get => _stringEquals ?? (_stringEquals = new InputList<Inputs.BackupSelectionConditionParameterArgs>());
            set => _stringEquals = value;
        }

        [Input("stringLike")]
        private InputList<Inputs.BackupSelectionConditionParameterArgs>? _stringLike;
        public InputList<Inputs.BackupSelectionConditionParameterArgs> StringLike
        {
            get => _stringLike ?? (_stringLike = new InputList<Inputs.BackupSelectionConditionParameterArgs>());
            set => _stringLike = value;
        }

        [Input("stringNotEquals")]
        private InputList<Inputs.BackupSelectionConditionParameterArgs>? _stringNotEquals;
        public InputList<Inputs.BackupSelectionConditionParameterArgs> StringNotEquals
        {
            get => _stringNotEquals ?? (_stringNotEquals = new InputList<Inputs.BackupSelectionConditionParameterArgs>());
            set => _stringNotEquals = value;
        }

        [Input("stringNotLike")]
        private InputList<Inputs.BackupSelectionConditionParameterArgs>? _stringNotLike;
        public InputList<Inputs.BackupSelectionConditionParameterArgs> StringNotLike
        {
            get => _stringNotLike ?? (_stringNotLike = new InputList<Inputs.BackupSelectionConditionParameterArgs>());
            set => _stringNotLike = value;
        }

        public BackupSelectionResourceTypeConditionsPropertiesArgs()
        {
        }
    }
}
