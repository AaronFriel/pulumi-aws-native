// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.EventSchemas.Inputs
{

    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eventschemas-discoverer.html
    /// </summary>
    public sealed class DiscovererPropertiesArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eventschemas-discoverer.html#cfn-eventschemas-discoverer-description
        /// </summary>
        [Input("Description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eventschemas-discoverer.html#cfn-eventschemas-discoverer-sourcearn
        /// </summary>
        [Input("SourceArn", required: true)]
        public Input<string> SourceArn { get; set; } = null!;

        [Input("Tags")]
        private InputList<Inputs.DiscovererTagsEntryArgs>? _Tags;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eventschemas-discoverer.html#cfn-eventschemas-discoverer-tags
        /// </summary>
        public InputList<Inputs.DiscovererTagsEntryArgs> Tags
        {
            get => _Tags ?? (_Tags = new InputList<Inputs.DiscovererTagsEntryArgs>());
            set => _Tags = value;
        }

        public DiscovererPropertiesArgs()
        {
        }
    }
}
