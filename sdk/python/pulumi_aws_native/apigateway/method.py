# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from .. import _utilities
from . import outputs
from ._inputs import *

__all__ = ['MethodArgs', 'Method']

@pulumi.input_type
class MethodArgs:
    def __init__(__self__, *,
                 http_method: pulumi.Input[str],
                 resource_id: pulumi.Input[str],
                 rest_api_id: pulumi.Input[str],
                 api_key_required: Optional[pulumi.Input[bool]] = None,
                 authorization_scopes: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 authorization_type: Optional[pulumi.Input[str]] = None,
                 authorizer_id: Optional[pulumi.Input[str]] = None,
                 integration: Optional[pulumi.Input['MethodIntegrationArgs']] = None,
                 method_responses: Optional[pulumi.Input[Sequence[pulumi.Input['MethodMethodResponseArgs']]]] = None,
                 operation_name: Optional[pulumi.Input[str]] = None,
                 request_models: Optional[Any] = None,
                 request_parameters: Optional[Any] = None,
                 request_validator_id: Optional[pulumi.Input[str]] = None):
        """
        The set of arguments for constructing a Method resource.
        """
        pulumi.set(__self__, "http_method", http_method)
        pulumi.set(__self__, "resource_id", resource_id)
        pulumi.set(__self__, "rest_api_id", rest_api_id)
        if api_key_required is not None:
            pulumi.set(__self__, "api_key_required", api_key_required)
        if authorization_scopes is not None:
            pulumi.set(__self__, "authorization_scopes", authorization_scopes)
        if authorization_type is not None:
            pulumi.set(__self__, "authorization_type", authorization_type)
        if authorizer_id is not None:
            pulumi.set(__self__, "authorizer_id", authorizer_id)
        if integration is not None:
            pulumi.set(__self__, "integration", integration)
        if method_responses is not None:
            pulumi.set(__self__, "method_responses", method_responses)
        if operation_name is not None:
            pulumi.set(__self__, "operation_name", operation_name)
        if request_models is not None:
            pulumi.set(__self__, "request_models", request_models)
        if request_parameters is not None:
            pulumi.set(__self__, "request_parameters", request_parameters)
        if request_validator_id is not None:
            pulumi.set(__self__, "request_validator_id", request_validator_id)

    @property
    @pulumi.getter(name="httpMethod")
    def http_method(self) -> pulumi.Input[str]:
        return pulumi.get(self, "http_method")

    @http_method.setter
    def http_method(self, value: pulumi.Input[str]):
        pulumi.set(self, "http_method", value)

    @property
    @pulumi.getter(name="resourceId")
    def resource_id(self) -> pulumi.Input[str]:
        return pulumi.get(self, "resource_id")

    @resource_id.setter
    def resource_id(self, value: pulumi.Input[str]):
        pulumi.set(self, "resource_id", value)

    @property
    @pulumi.getter(name="restApiId")
    def rest_api_id(self) -> pulumi.Input[str]:
        return pulumi.get(self, "rest_api_id")

    @rest_api_id.setter
    def rest_api_id(self, value: pulumi.Input[str]):
        pulumi.set(self, "rest_api_id", value)

    @property
    @pulumi.getter(name="apiKeyRequired")
    def api_key_required(self) -> Optional[pulumi.Input[bool]]:
        return pulumi.get(self, "api_key_required")

    @api_key_required.setter
    def api_key_required(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "api_key_required", value)

    @property
    @pulumi.getter(name="authorizationScopes")
    def authorization_scopes(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]:
        return pulumi.get(self, "authorization_scopes")

    @authorization_scopes.setter
    def authorization_scopes(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]):
        pulumi.set(self, "authorization_scopes", value)

    @property
    @pulumi.getter(name="authorizationType")
    def authorization_type(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "authorization_type")

    @authorization_type.setter
    def authorization_type(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "authorization_type", value)

    @property
    @pulumi.getter(name="authorizerId")
    def authorizer_id(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "authorizer_id")

    @authorizer_id.setter
    def authorizer_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "authorizer_id", value)

    @property
    @pulumi.getter
    def integration(self) -> Optional[pulumi.Input['MethodIntegrationArgs']]:
        return pulumi.get(self, "integration")

    @integration.setter
    def integration(self, value: Optional[pulumi.Input['MethodIntegrationArgs']]):
        pulumi.set(self, "integration", value)

    @property
    @pulumi.getter(name="methodResponses")
    def method_responses(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['MethodMethodResponseArgs']]]]:
        return pulumi.get(self, "method_responses")

    @method_responses.setter
    def method_responses(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['MethodMethodResponseArgs']]]]):
        pulumi.set(self, "method_responses", value)

    @property
    @pulumi.getter(name="operationName")
    def operation_name(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "operation_name")

    @operation_name.setter
    def operation_name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "operation_name", value)

    @property
    @pulumi.getter(name="requestModels")
    def request_models(self) -> Optional[Any]:
        return pulumi.get(self, "request_models")

    @request_models.setter
    def request_models(self, value: Optional[Any]):
        pulumi.set(self, "request_models", value)

    @property
    @pulumi.getter(name="requestParameters")
    def request_parameters(self) -> Optional[Any]:
        return pulumi.get(self, "request_parameters")

    @request_parameters.setter
    def request_parameters(self, value: Optional[Any]):
        pulumi.set(self, "request_parameters", value)

    @property
    @pulumi.getter(name="requestValidatorId")
    def request_validator_id(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "request_validator_id")

    @request_validator_id.setter
    def request_validator_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "request_validator_id", value)


warnings.warn("""Method is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.""", DeprecationWarning)


class Method(pulumi.CustomResource):
    warnings.warn("""Method is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.""", DeprecationWarning)

    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 api_key_required: Optional[pulumi.Input[bool]] = None,
                 authorization_scopes: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 authorization_type: Optional[pulumi.Input[str]] = None,
                 authorizer_id: Optional[pulumi.Input[str]] = None,
                 http_method: Optional[pulumi.Input[str]] = None,
                 integration: Optional[pulumi.Input[pulumi.InputType['MethodIntegrationArgs']]] = None,
                 method_responses: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['MethodMethodResponseArgs']]]]] = None,
                 operation_name: Optional[pulumi.Input[str]] = None,
                 request_models: Optional[Any] = None,
                 request_parameters: Optional[Any] = None,
                 request_validator_id: Optional[pulumi.Input[str]] = None,
                 resource_id: Optional[pulumi.Input[str]] = None,
                 rest_api_id: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        """
        Resource Type definition for AWS::ApiGateway::Method

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: MethodArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Resource Type definition for AWS::ApiGateway::Method

        :param str resource_name: The name of the resource.
        :param MethodArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(MethodArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 api_key_required: Optional[pulumi.Input[bool]] = None,
                 authorization_scopes: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 authorization_type: Optional[pulumi.Input[str]] = None,
                 authorizer_id: Optional[pulumi.Input[str]] = None,
                 http_method: Optional[pulumi.Input[str]] = None,
                 integration: Optional[pulumi.Input[pulumi.InputType['MethodIntegrationArgs']]] = None,
                 method_responses: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['MethodMethodResponseArgs']]]]] = None,
                 operation_name: Optional[pulumi.Input[str]] = None,
                 request_models: Optional[Any] = None,
                 request_parameters: Optional[Any] = None,
                 request_validator_id: Optional[pulumi.Input[str]] = None,
                 resource_id: Optional[pulumi.Input[str]] = None,
                 rest_api_id: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        pulumi.log.warn("""Method is deprecated: Method is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.""")
        if opts is None:
            opts = pulumi.ResourceOptions()
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.version is None:
            opts.version = _utilities.get_version()
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = MethodArgs.__new__(MethodArgs)

            __props__.__dict__["api_key_required"] = api_key_required
            __props__.__dict__["authorization_scopes"] = authorization_scopes
            __props__.__dict__["authorization_type"] = authorization_type
            __props__.__dict__["authorizer_id"] = authorizer_id
            if http_method is None and not opts.urn:
                raise TypeError("Missing required property 'http_method'")
            __props__.__dict__["http_method"] = http_method
            __props__.__dict__["integration"] = integration
            __props__.__dict__["method_responses"] = method_responses
            __props__.__dict__["operation_name"] = operation_name
            __props__.__dict__["request_models"] = request_models
            __props__.__dict__["request_parameters"] = request_parameters
            __props__.__dict__["request_validator_id"] = request_validator_id
            if resource_id is None and not opts.urn:
                raise TypeError("Missing required property 'resource_id'")
            __props__.__dict__["resource_id"] = resource_id
            if rest_api_id is None and not opts.urn:
                raise TypeError("Missing required property 'rest_api_id'")
            __props__.__dict__["rest_api_id"] = rest_api_id
        super(Method, __self__).__init__(
            'aws-native:apigateway:Method',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None) -> 'Method':
        """
        Get an existing Method resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = MethodArgs.__new__(MethodArgs)

        __props__.__dict__["api_key_required"] = None
        __props__.__dict__["authorization_scopes"] = None
        __props__.__dict__["authorization_type"] = None
        __props__.__dict__["authorizer_id"] = None
        __props__.__dict__["http_method"] = None
        __props__.__dict__["integration"] = None
        __props__.__dict__["method_responses"] = None
        __props__.__dict__["operation_name"] = None
        __props__.__dict__["request_models"] = None
        __props__.__dict__["request_parameters"] = None
        __props__.__dict__["request_validator_id"] = None
        __props__.__dict__["resource_id"] = None
        __props__.__dict__["rest_api_id"] = None
        return Method(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="apiKeyRequired")
    def api_key_required(self) -> pulumi.Output[Optional[bool]]:
        return pulumi.get(self, "api_key_required")

    @property
    @pulumi.getter(name="authorizationScopes")
    def authorization_scopes(self) -> pulumi.Output[Optional[Sequence[str]]]:
        return pulumi.get(self, "authorization_scopes")

    @property
    @pulumi.getter(name="authorizationType")
    def authorization_type(self) -> pulumi.Output[Optional[str]]:
        return pulumi.get(self, "authorization_type")

    @property
    @pulumi.getter(name="authorizerId")
    def authorizer_id(self) -> pulumi.Output[Optional[str]]:
        return pulumi.get(self, "authorizer_id")

    @property
    @pulumi.getter(name="httpMethod")
    def http_method(self) -> pulumi.Output[str]:
        return pulumi.get(self, "http_method")

    @property
    @pulumi.getter
    def integration(self) -> pulumi.Output[Optional['outputs.MethodIntegration']]:
        return pulumi.get(self, "integration")

    @property
    @pulumi.getter(name="methodResponses")
    def method_responses(self) -> pulumi.Output[Optional[Sequence['outputs.MethodMethodResponse']]]:
        return pulumi.get(self, "method_responses")

    @property
    @pulumi.getter(name="operationName")
    def operation_name(self) -> pulumi.Output[Optional[str]]:
        return pulumi.get(self, "operation_name")

    @property
    @pulumi.getter(name="requestModels")
    def request_models(self) -> pulumi.Output[Optional[Any]]:
        return pulumi.get(self, "request_models")

    @property
    @pulumi.getter(name="requestParameters")
    def request_parameters(self) -> pulumi.Output[Optional[Any]]:
        return pulumi.get(self, "request_parameters")

    @property
    @pulumi.getter(name="requestValidatorId")
    def request_validator_id(self) -> pulumi.Output[Optional[str]]:
        return pulumi.get(self, "request_validator_id")

    @property
    @pulumi.getter(name="resourceId")
    def resource_id(self) -> pulumi.Output[str]:
        return pulumi.get(self, "resource_id")

    @property
    @pulumi.getter(name="restApiId")
    def rest_api_id(self) -> pulumi.Output[str]:
        return pulumi.get(self, "rest_api_id")

