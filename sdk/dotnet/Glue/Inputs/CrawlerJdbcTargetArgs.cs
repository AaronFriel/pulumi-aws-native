// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.Glue.Inputs
{

    public sealed class CrawlerJdbcTargetArgs : Pulumi.ResourceArgs
    {
        [Input("connectionName")]
        public Input<string>? ConnectionName { get; set; }

        [Input("exclusions")]
        private InputList<string>? _exclusions;
        public InputList<string> Exclusions
        {
            get => _exclusions ?? (_exclusions = new InputList<string>());
            set => _exclusions = value;
        }

        [Input("path")]
        public Input<string>? Path { get; set; }

        public CrawlerJdbcTargetArgs()
        {
        }
    }
}
