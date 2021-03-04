// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.Events.Outputs
{

    [OutputType]
    public sealed class EventBusPolicyProperties
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-events-eventbuspolicy.html#cfn-events-eventbuspolicy-action
        /// </summary>
        public readonly string? Action;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-events-eventbuspolicy.html#cfn-events-eventbuspolicy-condition
        /// </summary>
        public readonly Outputs.EventBusPolicyCondition? Condition;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-events-eventbuspolicy.html#cfn-events-eventbuspolicy-eventbusname
        /// </summary>
        public readonly string? EventBusName;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-events-eventbuspolicy.html#cfn-events-eventbuspolicy-principal
        /// </summary>
        public readonly string? Principal;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-events-eventbuspolicy.html#cfn-events-eventbuspolicy-statement
        /// </summary>
        public readonly Union<System.Text.Json.JsonElement, string>? Statement;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-events-eventbuspolicy.html#cfn-events-eventbuspolicy-statementid
        /// </summary>
        public readonly string StatementId;

        [OutputConstructor]
        private EventBusPolicyProperties(
            string? Action,

            Outputs.EventBusPolicyCondition? Condition,

            string? EventBusName,

            string? Principal,

            Union<System.Text.Json.JsonElement, string>? Statement,

            string StatementId)
        {
            this.Action = Action;
            this.Condition = Condition;
            this.EventBusName = EventBusName;
            this.Principal = Principal;
            this.Statement = Statement;
            this.StatementId = StatementId;
        }
    }
}
