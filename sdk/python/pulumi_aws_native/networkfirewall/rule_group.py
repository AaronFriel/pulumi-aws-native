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

__all__ = ['RuleGroupInitArgs', 'RuleGroup']

@pulumi.input_type
class RuleGroupInitArgs:
    def __init__(__self__, *,
                 capacity: pulumi.Input[int],
                 type: pulumi.Input['RuleGroupTypeEnum'],
                 description: Optional[pulumi.Input[str]] = None,
                 rule_group: Optional[pulumi.Input['RuleGroupArgs']] = None,
                 rule_group_name: Optional[pulumi.Input[str]] = None,
                 tags: Optional[pulumi.Input[Sequence[pulumi.Input['RuleGroupTagArgs']]]] = None):
        """
        The set of arguments for constructing a RuleGroup resource.
        """
        pulumi.set(__self__, "capacity", capacity)
        pulumi.set(__self__, "type", type)
        if description is not None:
            pulumi.set(__self__, "description", description)
        if rule_group is not None:
            pulumi.set(__self__, "rule_group", rule_group)
        if rule_group_name is not None:
            pulumi.set(__self__, "rule_group_name", rule_group_name)
        if tags is not None:
            pulumi.set(__self__, "tags", tags)

    @property
    @pulumi.getter
    def capacity(self) -> pulumi.Input[int]:
        return pulumi.get(self, "capacity")

    @capacity.setter
    def capacity(self, value: pulumi.Input[int]):
        pulumi.set(self, "capacity", value)

    @property
    @pulumi.getter
    def type(self) -> pulumi.Input['RuleGroupTypeEnum']:
        return pulumi.get(self, "type")

    @type.setter
    def type(self, value: pulumi.Input['RuleGroupTypeEnum']):
        pulumi.set(self, "type", value)

    @property
    @pulumi.getter
    def description(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "description")

    @description.setter
    def description(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "description", value)

    @property
    @pulumi.getter(name="ruleGroup")
    def rule_group(self) -> Optional[pulumi.Input['RuleGroupArgs']]:
        return pulumi.get(self, "rule_group")

    @rule_group.setter
    def rule_group(self, value: Optional[pulumi.Input['RuleGroupArgs']]):
        pulumi.set(self, "rule_group", value)

    @property
    @pulumi.getter(name="ruleGroupName")
    def rule_group_name(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "rule_group_name")

    @rule_group_name.setter
    def rule_group_name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "rule_group_name", value)

    @property
    @pulumi.getter
    def tags(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['RuleGroupTagArgs']]]]:
        return pulumi.get(self, "tags")

    @tags.setter
    def tags(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['RuleGroupTagArgs']]]]):
        pulumi.set(self, "tags", value)


class RuleGroup(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 capacity: Optional[pulumi.Input[int]] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 rule_group: Optional[pulumi.Input[pulumi.InputType['RuleGroupArgs']]] = None,
                 rule_group_name: Optional[pulumi.Input[str]] = None,
                 tags: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['RuleGroupTagArgs']]]]] = None,
                 type: Optional[pulumi.Input['RuleGroupTypeEnum']] = None,
                 __props__=None):
        """
        Resource type definition for AWS::NetworkFirewall::RuleGroup

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: RuleGroupInitArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Resource type definition for AWS::NetworkFirewall::RuleGroup

        :param str resource_name: The name of the resource.
        :param RuleGroupInitArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(RuleGroupInitArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 capacity: Optional[pulumi.Input[int]] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 rule_group: Optional[pulumi.Input[pulumi.InputType['RuleGroupArgs']]] = None,
                 rule_group_name: Optional[pulumi.Input[str]] = None,
                 tags: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['RuleGroupTagArgs']]]]] = None,
                 type: Optional[pulumi.Input['RuleGroupTypeEnum']] = None,
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
            __props__ = RuleGroupInitArgs.__new__(RuleGroupInitArgs)

            if capacity is None and not opts.urn:
                raise TypeError("Missing required property 'capacity'")
            __props__.__dict__["capacity"] = capacity
            __props__.__dict__["description"] = description
            __props__.__dict__["rule_group"] = rule_group
            __props__.__dict__["rule_group_name"] = rule_group_name
            __props__.__dict__["tags"] = tags
            if type is None and not opts.urn:
                raise TypeError("Missing required property 'type'")
            __props__.__dict__["type"] = type
            __props__.__dict__["rule_group_arn"] = None
            __props__.__dict__["rule_group_id"] = None
        super(RuleGroup, __self__).__init__(
            'aws-native:networkfirewall:RuleGroup',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None) -> 'RuleGroup':
        """
        Get an existing RuleGroup resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = RuleGroupInitArgs.__new__(RuleGroupInitArgs)

        __props__.__dict__["capacity"] = None
        __props__.__dict__["description"] = None
        __props__.__dict__["rule_group"] = None
        __props__.__dict__["rule_group_arn"] = None
        __props__.__dict__["rule_group_id"] = None
        __props__.__dict__["rule_group_name"] = None
        __props__.__dict__["tags"] = None
        __props__.__dict__["type"] = None
        return RuleGroup(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter
    def capacity(self) -> pulumi.Output[int]:
        return pulumi.get(self, "capacity")

    @property
    @pulumi.getter
    def description(self) -> pulumi.Output[Optional[str]]:
        return pulumi.get(self, "description")

    @property
    @pulumi.getter(name="ruleGroup")
    def rule_group(self) -> pulumi.Output[Optional['outputs.RuleGroup']]:
        return pulumi.get(self, "rule_group")

    @property
    @pulumi.getter(name="ruleGroupArn")
    def rule_group_arn(self) -> pulumi.Output[str]:
        return pulumi.get(self, "rule_group_arn")

    @property
    @pulumi.getter(name="ruleGroupId")
    def rule_group_id(self) -> pulumi.Output[str]:
        return pulumi.get(self, "rule_group_id")

    @property
    @pulumi.getter(name="ruleGroupName")
    def rule_group_name(self) -> pulumi.Output[str]:
        return pulumi.get(self, "rule_group_name")

    @property
    @pulumi.getter
    def tags(self) -> pulumi.Output[Optional[Sequence['outputs.RuleGroupTag']]]:
        return pulumi.get(self, "tags")

    @property
    @pulumi.getter
    def type(self) -> pulumi.Output['RuleGroupTypeEnum']:
        return pulumi.get(self, "type")

