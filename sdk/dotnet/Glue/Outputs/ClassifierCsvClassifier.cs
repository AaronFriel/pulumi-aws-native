// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.Glue.Outputs
{

    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-classifier-csvclassifier.html
    /// </summary>
    [OutputType]
    public sealed class ClassifierCsvClassifier
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-classifier-csvclassifier.html#cfn-glue-classifier-csvclassifier-allowsinglecolumn
        /// </summary>
        public readonly bool? AllowSingleColumn;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-classifier-csvclassifier.html#cfn-glue-classifier-csvclassifier-containsheader
        /// </summary>
        public readonly string? ContainsHeader;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-classifier-csvclassifier.html#cfn-glue-classifier-csvclassifier-delimiter
        /// </summary>
        public readonly string? Delimiter;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-classifier-csvclassifier.html#cfn-glue-classifier-csvclassifier-disablevaluetrimming
        /// </summary>
        public readonly bool? DisableValueTrimming;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-classifier-csvclassifier.html#cfn-glue-classifier-csvclassifier-header
        /// </summary>
        public readonly ImmutableArray<string> Header;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-classifier-csvclassifier.html#cfn-glue-classifier-csvclassifier-name
        /// </summary>
        public readonly string? Name;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-classifier-csvclassifier.html#cfn-glue-classifier-csvclassifier-quotesymbol
        /// </summary>
        public readonly string? QuoteSymbol;

        [OutputConstructor]
        private ClassifierCsvClassifier(
            bool? allowSingleColumn,

            string? containsHeader,

            string? delimiter,

            bool? disableValueTrimming,

            ImmutableArray<string> header,

            string? name,

            string? quoteSymbol)
        {
            AllowSingleColumn = allowSingleColumn;
            ContainsHeader = containsHeader;
            Delimiter = delimiter;
            DisableValueTrimming = disableValueTrimming;
            Header = header;
            Name = name;
            QuoteSymbol = quoteSymbol;
        }
    }
}