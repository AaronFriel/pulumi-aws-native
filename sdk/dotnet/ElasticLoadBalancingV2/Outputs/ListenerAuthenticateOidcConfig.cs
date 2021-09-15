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
    public sealed class ListenerAuthenticateOidcConfig
    {
        public readonly object? AuthenticationRequestExtraParams;
        public readonly string AuthorizationEndpoint;
        public readonly string ClientId;
        public readonly string ClientSecret;
        public readonly string Issuer;
        public readonly string? OnUnauthenticatedRequest;
        public readonly string? Scope;
        public readonly string? SessionCookieName;
        public readonly string? SessionTimeout;
        public readonly string TokenEndpoint;
        public readonly string UserInfoEndpoint;

        [OutputConstructor]
        private ListenerAuthenticateOidcConfig(
            object? authenticationRequestExtraParams,

            string authorizationEndpoint,

            string clientId,

            string clientSecret,

            string issuer,

            string? onUnauthenticatedRequest,

            string? scope,

            string? sessionCookieName,

            string? sessionTimeout,

            string tokenEndpoint,

            string userInfoEndpoint)
        {
            AuthenticationRequestExtraParams = authenticationRequestExtraParams;
            AuthorizationEndpoint = authorizationEndpoint;
            ClientId = clientId;
            ClientSecret = clientSecret;
            Issuer = issuer;
            OnUnauthenticatedRequest = onUnauthenticatedRequest;
            Scope = scope;
            SessionCookieName = sessionCookieName;
            SessionTimeout = sessionTimeout;
            TokenEndpoint = tokenEndpoint;
            UserInfoEndpoint = userInfoEndpoint;
        }
    }
}
