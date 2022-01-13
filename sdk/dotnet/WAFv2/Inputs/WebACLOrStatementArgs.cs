// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.WAFv2.Inputs
{

    public sealed class WebACLOrStatementArgs : Pulumi.ResourceArgs
    {
        [Input("statements", required: true)]
        private InputList<Inputs.WebACLStatementArgs>? _statements;
        public InputList<Inputs.WebACLStatementArgs> Statements
        {
            get => _statements ?? (_statements = new InputList<Inputs.WebACLStatementArgs>());
            set => _statements = value;
        }

        public WebACLOrStatementArgs()
        {
        }
    }
}
