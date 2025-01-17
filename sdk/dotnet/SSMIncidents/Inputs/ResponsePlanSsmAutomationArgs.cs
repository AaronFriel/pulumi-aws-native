// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.SSMIncidents.Inputs
{

    /// <summary>
    /// The configuration to use when starting the SSM automation document.
    /// </summary>
    public sealed class ResponsePlanSsmAutomationArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The document name to use when starting the SSM automation document.
        /// </summary>
        [Input("documentName", required: true)]
        public Input<string> DocumentName { get; set; } = null!;

        /// <summary>
        /// The version of the document to use when starting the SSM automation document.
        /// </summary>
        [Input("documentVersion")]
        public Input<string>? DocumentVersion { get; set; }

        [Input("parameters")]
        private InputList<Inputs.ResponsePlanSsmParameterArgs>? _parameters;

        /// <summary>
        /// The parameters to set when starting the SSM automation document.
        /// </summary>
        public InputList<Inputs.ResponsePlanSsmParameterArgs> Parameters
        {
            get => _parameters ?? (_parameters = new InputList<Inputs.ResponsePlanSsmParameterArgs>());
            set => _parameters = value;
        }

        /// <summary>
        /// The role ARN to use when starting the SSM automation document.
        /// </summary>
        [Input("roleArn", required: true)]
        public Input<string> RoleArn { get; set; } = null!;

        /// <summary>
        /// The account type to use when starting the SSM automation document.
        /// </summary>
        [Input("targetAccount")]
        public Input<Pulumi.AwsNative.SSMIncidents.ResponsePlanSsmAutomationTargetAccount>? TargetAccount { get; set; }

        public ResponsePlanSsmAutomationArgs()
        {
        }
    }
}
