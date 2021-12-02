// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.Lex.Inputs
{

    /// <summary>
    /// A custom slot type.
    /// </summary>
    public sealed class BotSlotTypeArgs : Pulumi.ResourceArgs
    {
        [Input("description")]
        public Input<string>? Description { get; set; }

        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        [Input("parentSlotTypeSignature")]
        public Input<string>? ParentSlotTypeSignature { get; set; }

        [Input("slotTypeValues")]
        private InputList<Inputs.BotSlotTypeValueArgs>? _slotTypeValues;
        public InputList<Inputs.BotSlotTypeValueArgs> SlotTypeValues
        {
            get => _slotTypeValues ?? (_slotTypeValues = new InputList<Inputs.BotSlotTypeValueArgs>());
            set => _slotTypeValues = value;
        }

        [Input("valueSelectionSetting", required: true)]
        public Input<Inputs.BotSlotValueSelectionSettingArgs> ValueSelectionSetting { get; set; } = null!;

        public BotSlotTypeArgs()
        {
        }
    }
}