// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.ElasticLoadBalancingV2.Outputs
{

    [OutputType]
    public sealed class ListenerRuleAuthenticateOidcConfig
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listenerrule-authenticateoidcconfig.html#cfn-elasticloadbalancingv2-listenerrule-authenticateoidcconfig-authenticationrequestextraparams
        /// </summary>
        public readonly ImmutableDictionary<string, string>? AuthenticationRequestExtraParams;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listenerrule-authenticateoidcconfig.html#cfn-elasticloadbalancingv2-listenerrule-authenticateoidcconfig-authorizationendpoint
        /// </summary>
        public readonly string AuthorizationEndpoint;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listenerrule-authenticateoidcconfig.html#cfn-elasticloadbalancingv2-listenerrule-authenticateoidcconfig-clientid
        /// </summary>
        public readonly string ClientId;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listenerrule-authenticateoidcconfig.html#cfn-elasticloadbalancingv2-listenerrule-authenticateoidcconfig-clientsecret
        /// </summary>
        public readonly string ClientSecret;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listenerrule-authenticateoidcconfig.html#cfn-elasticloadbalancingv2-listenerrule-authenticateoidcconfig-issuer
        /// </summary>
        public readonly string Issuer;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listenerrule-authenticateoidcconfig.html#cfn-elasticloadbalancingv2-listenerrule-authenticateoidcconfig-onunauthenticatedrequest
        /// </summary>
        public readonly string? OnUnauthenticatedRequest;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listenerrule-authenticateoidcconfig.html#cfn-elasticloadbalancingv2-listenerrule-authenticateoidcconfig-scope
        /// </summary>
        public readonly string? Scope;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listenerrule-authenticateoidcconfig.html#cfn-elasticloadbalancingv2-listenerrule-authenticateoidcconfig-sessioncookiename
        /// </summary>
        public readonly string? SessionCookieName;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listenerrule-authenticateoidcconfig.html#cfn-elasticloadbalancingv2-listenerrule-authenticateoidcconfig-sessiontimeout
        /// </summary>
        public readonly int? SessionTimeout;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listenerrule-authenticateoidcconfig.html#cfn-elasticloadbalancingv2-listenerrule-authenticateoidcconfig-tokenendpoint
        /// </summary>
        public readonly string TokenEndpoint;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listenerrule-authenticateoidcconfig.html#cfn-elasticloadbalancingv2-listenerrule-authenticateoidcconfig-userinfoendpoint
        /// </summary>
        public readonly string UserInfoEndpoint;

        [OutputConstructor]
        private ListenerRuleAuthenticateOidcConfig(
            ImmutableDictionary<string, string>? AuthenticationRequestExtraParams,

            string AuthorizationEndpoint,

            string ClientId,

            string ClientSecret,

            string Issuer,

            string? OnUnauthenticatedRequest,

            string? Scope,

            string? SessionCookieName,

            int? SessionTimeout,

            string TokenEndpoint,

            string UserInfoEndpoint)
        {
            this.AuthenticationRequestExtraParams = AuthenticationRequestExtraParams;
            this.AuthorizationEndpoint = AuthorizationEndpoint;
            this.ClientId = ClientId;
            this.ClientSecret = ClientSecret;
            this.Issuer = Issuer;
            this.OnUnauthenticatedRequest = OnUnauthenticatedRequest;
            this.Scope = Scope;
            this.SessionCookieName = SessionCookieName;
            this.SessionTimeout = SessionTimeout;
            this.TokenEndpoint = TokenEndpoint;
            this.UserInfoEndpoint = UserInfoEndpoint;
        }
    }
}
