// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.Lex.Outputs
{

    /// <summary>
    /// Response that Amazon Lex sends to the user when the intent is closed.
    /// </summary>
    [OutputType]
    public sealed class BotIntentClosingSetting
    {
        public readonly Outputs.BotResponseSpecification ClosingResponse;
        public readonly bool? IsActive;

        [OutputConstructor]
        private BotIntentClosingSetting(
            Outputs.BotResponseSpecification closingResponse,

            bool? isActive)
        {
            ClosingResponse = closingResponse;
            IsActive = isActive;
        }
    }
}
