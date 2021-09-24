// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.Glue.Inputs
{

    public sealed class TableSkewedInfoArgs : Pulumi.ResourceArgs
    {
        [Input("skewedColumnNames")]
        private InputList<string>? _skewedColumnNames;
        public InputList<string> SkewedColumnNames
        {
            get => _skewedColumnNames ?? (_skewedColumnNames = new InputList<string>());
            set => _skewedColumnNames = value;
        }

        [Input("skewedColumnValueLocationMaps")]
        public Input<object>? SkewedColumnValueLocationMaps { get; set; }

        [Input("skewedColumnValues")]
        private InputList<string>? _skewedColumnValues;
        public InputList<string> SkewedColumnValues
        {
            get => _skewedColumnValues ?? (_skewedColumnValues = new InputList<string>());
            set => _skewedColumnValues = value;
        }

        public TableSkewedInfoArgs()
        {
        }
    }
}