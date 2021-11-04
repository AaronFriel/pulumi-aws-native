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

__all__ = ['ConnectionArgs', 'Connection']

@pulumi.input_type
class ConnectionArgs:
    def __init__(__self__, *,
                 connection_name: Optional[pulumi.Input[str]] = None,
                 host_arn: Optional[pulumi.Input[str]] = None,
                 provider_type: Optional[pulumi.Input[str]] = None,
                 tags: Optional[pulumi.Input[Sequence[pulumi.Input['ConnectionTagArgs']]]] = None):
        """
        The set of arguments for constructing a Connection resource.
        :param pulumi.Input[str] connection_name: The name of the connection. Connection names must be unique in an AWS user account.
        :param pulumi.Input[str] host_arn: The host arn configured to represent the infrastructure where your third-party provider is installed. You must specify either a ProviderType or a HostArn.
        :param pulumi.Input[str] provider_type: The name of the external provider where your third-party code repository is configured. You must specify either a ProviderType or a HostArn.
        :param pulumi.Input[Sequence[pulumi.Input['ConnectionTagArgs']]] tags: Specifies the tags applied to a connection.
        """
        if connection_name is not None:
            pulumi.set(__self__, "connection_name", connection_name)
        if host_arn is not None:
            pulumi.set(__self__, "host_arn", host_arn)
        if provider_type is not None:
            pulumi.set(__self__, "provider_type", provider_type)
        if tags is not None:
            pulumi.set(__self__, "tags", tags)

    @property
    @pulumi.getter(name="connectionName")
    def connection_name(self) -> Optional[pulumi.Input[str]]:
        """
        The name of the connection. Connection names must be unique in an AWS user account.
        """
        return pulumi.get(self, "connection_name")

    @connection_name.setter
    def connection_name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "connection_name", value)

    @property
    @pulumi.getter(name="hostArn")
    def host_arn(self) -> Optional[pulumi.Input[str]]:
        """
        The host arn configured to represent the infrastructure where your third-party provider is installed. You must specify either a ProviderType or a HostArn.
        """
        return pulumi.get(self, "host_arn")

    @host_arn.setter
    def host_arn(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "host_arn", value)

    @property
    @pulumi.getter(name="providerType")
    def provider_type(self) -> Optional[pulumi.Input[str]]:
        """
        The name of the external provider where your third-party code repository is configured. You must specify either a ProviderType or a HostArn.
        """
        return pulumi.get(self, "provider_type")

    @provider_type.setter
    def provider_type(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "provider_type", value)

    @property
    @pulumi.getter
    def tags(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['ConnectionTagArgs']]]]:
        """
        Specifies the tags applied to a connection.
        """
        return pulumi.get(self, "tags")

    @tags.setter
    def tags(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['ConnectionTagArgs']]]]):
        pulumi.set(self, "tags", value)


class Connection(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 connection_name: Optional[pulumi.Input[str]] = None,
                 host_arn: Optional[pulumi.Input[str]] = None,
                 provider_type: Optional[pulumi.Input[str]] = None,
                 tags: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['ConnectionTagArgs']]]]] = None,
                 __props__=None):
        """
        Schema for AWS::CodeStarConnections::Connection resource which can be used to connect external source providers with AWS CodePipeline

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] connection_name: The name of the connection. Connection names must be unique in an AWS user account.
        :param pulumi.Input[str] host_arn: The host arn configured to represent the infrastructure where your third-party provider is installed. You must specify either a ProviderType or a HostArn.
        :param pulumi.Input[str] provider_type: The name of the external provider where your third-party code repository is configured. You must specify either a ProviderType or a HostArn.
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['ConnectionTagArgs']]]] tags: Specifies the tags applied to a connection.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: Optional[ConnectionArgs] = None,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Schema for AWS::CodeStarConnections::Connection resource which can be used to connect external source providers with AWS CodePipeline

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
                 connection_name: Optional[pulumi.Input[str]] = None,
                 host_arn: Optional[pulumi.Input[str]] = None,
                 provider_type: Optional[pulumi.Input[str]] = None,
                 tags: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['ConnectionTagArgs']]]]] = None,
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

            __props__.__dict__["connection_name"] = connection_name
            __props__.__dict__["host_arn"] = host_arn
            __props__.__dict__["provider_type"] = provider_type
            __props__.__dict__["tags"] = tags
            __props__.__dict__["connection_arn"] = None
            __props__.__dict__["connection_status"] = None
            __props__.__dict__["owner_account_id"] = None
        super(Connection, __self__).__init__(
            'aws-native:codestarconnections:Connection',
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

        __props__.__dict__["connection_arn"] = None
        __props__.__dict__["connection_name"] = None
        __props__.__dict__["connection_status"] = None
        __props__.__dict__["host_arn"] = None
        __props__.__dict__["owner_account_id"] = None
        __props__.__dict__["provider_type"] = None
        __props__.__dict__["tags"] = None
        return Connection(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="connectionArn")
    def connection_arn(self) -> pulumi.Output[str]:
        """
        The Amazon Resource Name (ARN) of the  connection. The ARN is used as the connection reference when the connection is shared between AWS services.
        """
        return pulumi.get(self, "connection_arn")

    @property
    @pulumi.getter(name="connectionName")
    def connection_name(self) -> pulumi.Output[str]:
        """
        The name of the connection. Connection names must be unique in an AWS user account.
        """
        return pulumi.get(self, "connection_name")

    @property
    @pulumi.getter(name="connectionStatus")
    def connection_status(self) -> pulumi.Output[str]:
        """
        The current status of the connection.
        """
        return pulumi.get(self, "connection_status")

    @property
    @pulumi.getter(name="hostArn")
    def host_arn(self) -> pulumi.Output[Optional[str]]:
        """
        The host arn configured to represent the infrastructure where your third-party provider is installed. You must specify either a ProviderType or a HostArn.
        """
        return pulumi.get(self, "host_arn")

    @property
    @pulumi.getter(name="ownerAccountId")
    def owner_account_id(self) -> pulumi.Output[str]:
        """
        The name of the external provider where your third-party code repository is configured. For Bitbucket, this is the account ID of the owner of the Bitbucket repository.
        """
        return pulumi.get(self, "owner_account_id")

    @property
    @pulumi.getter(name="providerType")
    def provider_type(self) -> pulumi.Output[Optional[str]]:
        """
        The name of the external provider where your third-party code repository is configured. You must specify either a ProviderType or a HostArn.
        """
        return pulumi.get(self, "provider_type")

    @property
    @pulumi.getter
    def tags(self) -> pulumi.Output[Optional[Sequence['outputs.ConnectionTag']]]:
        """
        Specifies the tags applied to a connection.
        """
        return pulumi.get(self, "tags")

