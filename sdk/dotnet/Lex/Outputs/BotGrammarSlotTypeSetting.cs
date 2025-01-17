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
    /// Settings required for a slot type based on a grammar that you provide.
    /// </summary>
    [OutputType]
    public sealed class BotGrammarSlotTypeSetting
    {
        public readonly Outputs.BotGrammarSlotTypeSource? Source;

        [OutputConstructor]
        private BotGrammarSlotTypeSetting(Outputs.BotGrammarSlotTypeSource? source)
        {
            Source = source;
        }
    }
}
