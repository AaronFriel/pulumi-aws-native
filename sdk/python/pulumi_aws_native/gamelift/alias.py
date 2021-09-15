# coding=utf-8
# *** WARNING: this file was generated by pulumigen. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from .. import _utilities
from . import outputs
from ._inputs import *

__all__ = ['AliasArgs', 'Alias']

@pulumi.input_type
class AliasArgs:
    def __init__(__self__, *,
                 name: pulumi.Input[str],
                 routing_strategy: pulumi.Input['AliasRoutingStrategyArgs'],
                 description: Optional[pulumi.Input[str]] = None):
        """
        The set of arguments for constructing a Alias resource.
        :param pulumi.Input[str] name: A descriptive label that is associated with an alias. Alias names do not need to be unique.
        :param pulumi.Input['AliasRoutingStrategyArgs'] routing_strategy: A routing configuration that specifies where traffic is directed for this alias, such as to a fleet or to a message.
        :param pulumi.Input[str] description: A human-readable description of the alias.
        """
        pulumi.set(__self__, "name", name)
        pulumi.set(__self__, "routing_strategy", routing_strategy)
        if description is not None:
            pulumi.set(__self__, "description", description)

    @property
    @pulumi.getter
    def name(self) -> pulumi.Input[str]:
        """
        A descriptive label that is associated with an alias. Alias names do not need to be unique.
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: pulumi.Input[str]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter(name="routingStrategy")
    def routing_strategy(self) -> pulumi.Input['AliasRoutingStrategyArgs']:
        """
        A routing configuration that specifies where traffic is directed for this alias, such as to a fleet or to a message.
        """
        return pulumi.get(self, "routing_strategy")

    @routing_strategy.setter
    def routing_strategy(self, value: pulumi.Input['AliasRoutingStrategyArgs']):
        pulumi.set(self, "routing_strategy", value)

    @property
    @pulumi.getter
    def description(self) -> Optional[pulumi.Input[str]]:
        """
        A human-readable description of the alias.
        """
        return pulumi.get(self, "description")

    @description.setter
    def description(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "description", value)


class Alias(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 routing_strategy: Optional[pulumi.Input[pulumi.InputType['AliasRoutingStrategyArgs']]] = None,
                 __props__=None):
        """
        The AWS::GameLift::Alias resource creates an alias for an Amazon GameLift (GameLift) fleet destination.

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] description: A human-readable description of the alias.
        :param pulumi.Input[str] name: A descriptive label that is associated with an alias. Alias names do not need to be unique.
        :param pulumi.Input[pulumi.InputType['AliasRoutingStrategyArgs']] routing_strategy: A routing configuration that specifies where traffic is directed for this alias, such as to a fleet or to a message.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: AliasArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        The AWS::GameLift::Alias resource creates an alias for an Amazon GameLift (GameLift) fleet destination.

        :param str resource_name: The name of the resource.
        :param AliasArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(AliasArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 routing_strategy: Optional[pulumi.Input[pulumi.InputType['AliasRoutingStrategyArgs']]] = None,
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
            __props__ = AliasArgs.__new__(AliasArgs)

            __props__.__dict__["description"] = description
            if name is None and not opts.urn:
                raise TypeError("Missing required property 'name'")
            __props__.__dict__["name"] = name
            if routing_strategy is None and not opts.urn:
                raise TypeError("Missing required property 'routing_strategy'")
            __props__.__dict__["routing_strategy"] = routing_strategy
            __props__.__dict__["alias_id"] = None
        super(Alias, __self__).__init__(
            'aws-native:gamelift:Alias',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None) -> 'Alias':
        """
        Get an existing Alias resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = AliasArgs.__new__(AliasArgs)

        __props__.__dict__["alias_id"] = None
        __props__.__dict__["description"] = None
        __props__.__dict__["name"] = None
        __props__.__dict__["routing_strategy"] = None
        return Alias(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="aliasId")
    def alias_id(self) -> pulumi.Output[str]:
        """
        Unique alias ID
        """
        return pulumi.get(self, "alias_id")

    @property
    @pulumi.getter
    def description(self) -> pulumi.Output[Optional[str]]:
        """
        A human-readable description of the alias.
        """
        return pulumi.get(self, "description")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        """
        A descriptive label that is associated with an alias. Alias names do not need to be unique.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="routingStrategy")
    def routing_strategy(self) -> pulumi.Output['outputs.AliasRoutingStrategy']:
        """
        A routing configuration that specifies where traffic is directed for this alias, such as to a fleet or to a message.
        """
        return pulumi.get(self, "routing_strategy")

