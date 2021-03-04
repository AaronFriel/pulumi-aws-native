// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.SSM.Inputs
{

    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-association-parametervalues.html
    /// </summary>
    public sealed class AssociationParameterValuesArgs : Pulumi.ResourceArgs
    {
        [Input("ParameterValues")]
        private InputList<string>? _ParameterValues;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-association-parametervalues.html#cfn-ssm-association-parametervalues-parametervalues
        /// </summary>
        public InputList<string> ParameterValues
        {
            get => _ParameterValues ?? (_ParameterValues = new InputList<string>());
            set => _ParameterValues = value;
        }

        public AssociationParameterValuesArgs()
        {
        }
    }
}
