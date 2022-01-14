# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from .. import _utilities
from . import outputs
from ._enums import *
from ._inputs import *

__all__ = ['ConnectionArgs', 'Connection']

@pulumi.input_type
class ConnectionArgs:
    def __init__(__self__, *,
                 auth_parameters: pulumi.Input['AuthParametersPropertiesArgs'],
                 authorization_type: pulumi.Input['ConnectionAuthorizationType'],
                 description: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None):
        """
        The set of arguments for constructing a Connection resource.
        :param pulumi.Input[str] description: Description of the connection.
        :param pulumi.Input[str] name: Name of the connection.
        """
        pulumi.set(__self__, "auth_parameters", auth_parameters)
        pulumi.set(__self__, "authorization_type", authorization_type)
        if description is not None:
            pulumi.set(__self__, "description", description)
        if name is not None:
            pulumi.set(__self__, "name", name)

    @property
    @pulumi.getter(name="authParameters")
    def auth_parameters(self) -> pulumi.Input['AuthParametersPropertiesArgs']:
        return pulumi.get(self, "auth_parameters")

    @auth_parameters.setter
    def auth_parameters(self, value: pulumi.Input['AuthParametersPropertiesArgs']):
        pulumi.set(self, "auth_parameters", value)

    @property
    @pulumi.getter(name="authorizationType")
    def authorization_type(self) -> pulumi.Input['ConnectionAuthorizationType']:
        return pulumi.get(self, "authorization_type")

    @authorization_type.setter
    def authorization_type(self, value: pulumi.Input['ConnectionAuthorizationType']):
        pulumi.set(self, "authorization_type", value)

    @property
    @pulumi.getter
    def description(self) -> Optional[pulumi.Input[str]]:
        """
        Description of the connection.
        """
        return pulumi.get(self, "description")

    @description.setter
    def description(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "description", value)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[str]]:
        """
        Name of the connection.
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "name", value)


class Connection(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 auth_parameters: Optional[pulumi.Input[pulumi.InputType['AuthParametersPropertiesArgs']]] = None,
                 authorization_type: Optional[pulumi.Input['ConnectionAuthorizationType']] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        """
        Resource Type definition for AWS::Events::Connection.

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] description: Description of the connection.
        :param pulumi.Input[str] name: Name of the connection.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: ConnectionArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Resource Type definition for AWS::Events::Connection.

        :param str resource_name: The name of the resource.
        :param ConnectionArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(ConnectionArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 auth_parameters: Optional[pulumi.Input[pulumi.InputType['AuthParametersPropertiesArgs']]] = None,
                 authorization_type: Optional[pulumi.Input['ConnectionAuthorizationType']] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        if opts is None:
            opts = pulumi.ResourceOptions()
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.version is None:
            opts.version = _utilities.get_version()
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = ConnectionArgs.__new__(ConnectionArgs)

            if auth_parameters is None and not opts.urn:
                raise TypeError("Missing required property 'auth_parameters'")
            __props__.__dict__["auth_parameters"] = auth_parameters
            if authorization_type is None and not opts.urn:
                raise TypeError("Missing required property 'authorization_type'")
            __props__.__dict__["authorization_type"] = authorization_type
            __props__.__dict__["description"] = description
            __props__.__dict__["name"] = name
            __props__.__dict__["arn"] = None
            __props__.__dict__["secret_arn"] = None
        super(Connection, __self__).__init__(
            'aws-native:events:Connection',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None) -> 'Connection':
        """
        Get an existing Connection resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = ConnectionArgs.__new__(ConnectionArgs)

        __props__.__dict__["arn"] = None
        __props__.__dict__["auth_parameters"] = None
        __props__.__dict__["authorization_type"] = None
        __props__.__dict__["description"] = None
        __props__.__dict__["name"] = None
        __props__.__dict__["secret_arn"] = None
        return Connection(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter
    def arn(self) -> pulumi.Output[str]:
        """
        The arn of the connection resource.
        """
        return pulumi.get(self, "arn")

    @property
    @pulumi.getter(name="authParameters")
    def auth_parameters(self) -> pulumi.Output['outputs.AuthParametersProperties']:
        return pulumi.get(self, "auth_parameters")

    @property
    @pulumi.getter(name="authorizationType")
    def authorization_type(self) -> pulumi.Output['ConnectionAuthorizationType']:
        return pulumi.get(self, "authorization_type")

    @property
    @pulumi.getter
    def description(self) -> pulumi.Output[Optional[str]]:
        """
        Description of the connection.
        """
        return pulumi.get(self, "description")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[Optional[str]]:
        """
        Name of the connection.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="secretArn")
    def secret_arn(self) -> pulumi.Output[str]:
        """
        The arn of the secrets manager secret created in the customer account.
        """
        return pulumi.get(self, "secret_arn")

