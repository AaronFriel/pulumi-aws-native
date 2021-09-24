# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from .. import _utilities

__all__ = ['GatewayResponseArgs', 'GatewayResponse']

@pulumi.input_type
class GatewayResponseArgs:
    def __init__(__self__, *,
                 response_type: pulumi.Input[str],
                 rest_api_id: pulumi.Input[str],
                 response_parameters: Optional[Any] = None,
                 response_templates: Optional[Any] = None,
                 status_code: Optional[pulumi.Input[str]] = None):
        """
        The set of arguments for constructing a GatewayResponse resource.
        """
        pulumi.set(__self__, "response_type", response_type)
        pulumi.set(__self__, "rest_api_id", rest_api_id)
        if response_parameters is not None:
            pulumi.set(__self__, "response_parameters", response_parameters)
        if response_templates is not None:
            pulumi.set(__self__, "response_templates", response_templates)
        if status_code is not None:
            pulumi.set(__self__, "status_code", status_code)

    @property
    @pulumi.getter(name="responseType")
    def response_type(self) -> pulumi.Input[str]:
        return pulumi.get(self, "response_type")

    @response_type.setter
    def response_type(self, value: pulumi.Input[str]):
        pulumi.set(self, "response_type", value)

    @property
    @pulumi.getter(name="restApiId")
    def rest_api_id(self) -> pulumi.Input[str]:
        return pulumi.get(self, "rest_api_id")

    @rest_api_id.setter
    def rest_api_id(self, value: pulumi.Input[str]):
        pulumi.set(self, "rest_api_id", value)

    @property
    @pulumi.getter(name="responseParameters")
    def response_parameters(self) -> Optional[Any]:
        return pulumi.get(self, "response_parameters")

    @response_parameters.setter
    def response_parameters(self, value: Optional[Any]):
        pulumi.set(self, "response_parameters", value)

    @property
    @pulumi.getter(name="responseTemplates")
    def response_templates(self) -> Optional[Any]:
        return pulumi.get(self, "response_templates")

    @response_templates.setter
    def response_templates(self, value: Optional[Any]):
        pulumi.set(self, "response_templates", value)

    @property
    @pulumi.getter(name="statusCode")
    def status_code(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "status_code")

    @status_code.setter
    def status_code(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "status_code", value)


warnings.warn("""GatewayResponse is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.""", DeprecationWarning)


class GatewayResponse(pulumi.CustomResource):
    warnings.warn("""GatewayResponse is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.""", DeprecationWarning)

    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 response_parameters: Optional[Any] = None,
                 response_templates: Optional[Any] = None,
                 response_type: Optional[pulumi.Input[str]] = None,
                 rest_api_id: Optional[pulumi.Input[str]] = None,
                 status_code: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        """
        Resource Type definition for AWS::ApiGateway::GatewayResponse

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: GatewayResponseArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Resource Type definition for AWS::ApiGateway::GatewayResponse

        :param str resource_name: The name of the resource.
        :param GatewayResponseArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(GatewayResponseArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 response_parameters: Optional[Any] = None,
                 response_templates: Optional[Any] = None,
                 response_type: Optional[pulumi.Input[str]] = None,
                 rest_api_id: Optional[pulumi.Input[str]] = None,
                 status_code: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        pulumi.log.warn("""GatewayResponse is deprecated: GatewayResponse is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.""")
        if opts is None:
            opts = pulumi.ResourceOptions()
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.version is None:
            opts.version = _utilities.get_version()
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = GatewayResponseArgs.__new__(GatewayResponseArgs)

            __props__.__dict__["response_parameters"] = response_parameters
            __props__.__dict__["response_templates"] = response_templates
            if response_type is None and not opts.urn:
                raise TypeError("Missing required property 'response_type'")
            __props__.__dict__["response_type"] = response_type
            if rest_api_id is None and not opts.urn:
                raise TypeError("Missing required property 'rest_api_id'")
            __props__.__dict__["rest_api_id"] = rest_api_id
            __props__.__dict__["status_code"] = status_code
        super(GatewayResponse, __self__).__init__(
            'aws-native:apigateway:GatewayResponse',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None) -> 'GatewayResponse':
        """
        Get an existing GatewayResponse resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = GatewayResponseArgs.__new__(GatewayResponseArgs)

        __props__.__dict__["response_parameters"] = None
        __props__.__dict__["response_templates"] = None
        __props__.__dict__["response_type"] = None
        __props__.__dict__["rest_api_id"] = None
        __props__.__dict__["status_code"] = None
        return GatewayResponse(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="responseParameters")
    def response_parameters(self) -> pulumi.Output[Optional[Any]]:
        return pulumi.get(self, "response_parameters")

    @property
    @pulumi.getter(name="responseTemplates")
    def response_templates(self) -> pulumi.Output[Optional[Any]]:
        return pulumi.get(self, "response_templates")

    @property
    @pulumi.getter(name="responseType")
    def response_type(self) -> pulumi.Output[str]:
        return pulumi.get(self, "response_type")

    @property
    @pulumi.getter(name="restApiId")
    def rest_api_id(self) -> pulumi.Output[str]:
        return pulumi.get(self, "rest_api_id")

    @property
    @pulumi.getter(name="statusCode")
    def status_code(self) -> pulumi.Output[Optional[str]]:
        return pulumi.get(self, "status_code")

