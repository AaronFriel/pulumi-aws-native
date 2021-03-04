// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.Route53.Outputs
{

    [OutputType]
    public sealed class RecordSetGeoLocation
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53-recordset-geolocation.html#cfn-route53-recordset-geolocation-continentcode
        /// </summary>
        public readonly string? ContinentCode;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53-recordset-geolocation.html#cfn-route53-recordset-geolocation-countrycode
        /// </summary>
        public readonly string? CountryCode;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53-recordset-geolocation.html#cfn-route53-recordset-geolocation-subdivisioncode
        /// </summary>
        public readonly string? SubdivisionCode;

        [OutputConstructor]
        private RecordSetGeoLocation(
            string? ContinentCode,

            string? CountryCode,

            string? SubdivisionCode)
        {
            this.ContinentCode = ContinentCode;
            this.CountryCode = CountryCode;
            this.SubdivisionCode = SubdivisionCode;
        }
    }
}
