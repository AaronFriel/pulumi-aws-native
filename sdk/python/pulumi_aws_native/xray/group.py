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

__all__ = ['GroupArgs', 'Group']

@pulumi.input_type
class GroupArgs:
    def __init__(__self__, *,
                 filter_expression: Optional[pulumi.Input[str]] = None,
                 group_name: Optional[pulumi.Input[str]] = None,
                 insights_configuration: Optional[pulumi.Input['GroupInsightsConfigurationArgs']] = None,
                 tags: Optional[pulumi.Input[Sequence[Any]]] = None):
        """
        The set of arguments for constructing a Group resource.
        :param pulumi.Input[str] filter_expression: The filter expression defining criteria by which to group traces.
        :param pulumi.Input[str] group_name: The case-sensitive name of the new group. Names must be unique.
        """
        if filter_expression is not None:
            pulumi.set(__self__, "filter_expression", filter_expression)
        if group_name is not None:
            pulumi.set(__self__, "group_name", group_name)
        if insights_configuration is not None:
            pulumi.set(__self__, "insights_configuration", insights_configuration)
        if tags is not None:
            pulumi.set(__self__, "tags", tags)

    @property
    @pulumi.getter(name="filterExpression")
    def filter_expression(self) -> Optional[pulumi.Input[str]]:
        """
        The filter expression defining criteria by which to group traces.
        """
        return pulumi.get(self, "filter_expression")

    @filter_expression.setter
    def filter_expression(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "filter_expression", value)

    @property
    @pulumi.getter(name="groupName")
    def group_name(self) -> Optional[pulumi.Input[str]]:
        """
        The case-sensitive name of the new group. Names must be unique.
        """
        return pulumi.get(self, "group_name")

    @group_name.setter
    def group_name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "group_name", value)

    @property
    @pulumi.getter(name="insightsConfiguration")
    def insights_configuration(self) -> Optional[pulumi.Input['GroupInsightsConfigurationArgs']]:
        return pulumi.get(self, "insights_configuration")

    @insights_configuration.setter
    def insights_configuration(self, value: Optional[pulumi.Input['GroupInsightsConfigurationArgs']]):
        pulumi.set(self, "insights_configuration", value)

    @property
    @pulumi.getter
    def tags(self) -> Optional[pulumi.Input[Sequence[Any]]]:
        return pulumi.get(self, "tags")

    @tags.setter
    def tags(self, value: Optional[pulumi.Input[Sequence[Any]]]):
        pulumi.set(self, "tags", value)


class Group(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 filter_expression: Optional[pulumi.Input[str]] = None,
                 group_name: Optional[pulumi.Input[str]] = None,
                 insights_configuration: Optional[pulumi.Input[pulumi.InputType['GroupInsightsConfigurationArgs']]] = None,
                 tags: Optional[pulumi.Input[Sequence[Any]]] = None,
                 __props__=None):
        """
        This schema provides construct and validation rules for AWS-XRay Group resource parameters.

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] filter_expression: The filter expression defining criteria by which to group traces.
        :param pulumi.Input[str] group_name: The case-sensitive name of the new group. Names must be unique.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: Optional[GroupArgs] = None,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        This schema provides construct and validation rules for AWS-XRay Group resource parameters.

        :param str resource_name: The name of the resource.
        :param GroupArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(GroupArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 filter_expression: Optional[pulumi.Input[str]] = None,
                 group_name: Optional[pulumi.Input[str]] = None,
                 insights_configuration: Optional[pulumi.Input[pulumi.InputType['GroupInsightsConfigurationArgs']]] = None,
                 tags: Optional[pulumi.Input[Sequence[Any]]] = None,
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
            __props__ = GroupArgs.__new__(GroupArgs)

            __props__.__dict__["filter_expression"] = filter_expression
            __props__.__dict__["group_name"] = group_name
            __props__.__dict__["insights_configuration"] = insights_configuration
            __props__.__dict__["tags"] = tags
            __props__.__dict__["group_arn"] = None
        super(Group, __self__).__init__(
            'aws-native:xray:Group',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None) -> 'Group':
        """
        Get an existing Group resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = GroupArgs.__new__(GroupArgs)

        __props__.__dict__["filter_expression"] = None
        __props__.__dict__["group_arn"] = None
        __props__.__dict__["group_name"] = None
        __props__.__dict__["insights_configuration"] = None
        __props__.__dict__["tags"] = None
        return Group(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="filterExpression")
    def filter_expression(self) -> pulumi.Output[Optional[str]]:
        """
        The filter expression defining criteria by which to group traces.
        """
        return pulumi.get(self, "filter_expression")

    @property
    @pulumi.getter(name="groupARN")
    def group_arn(self) -> pulumi.Output[str]:
        """
        The ARN of the group that was generated on creation.
        """
        return pulumi.get(self, "group_arn")

    @property
    @pulumi.getter(name="groupName")
    def group_name(self) -> pulumi.Output[Optional[str]]:
        """
        The case-sensitive name of the new group. Names must be unique.
        """
        return pulumi.get(self, "group_name")

    @property
    @pulumi.getter(name="insightsConfiguration")
    def insights_configuration(self) -> pulumi.Output[Optional['outputs.GroupInsightsConfiguration']]:
        return pulumi.get(self, "insights_configuration")

    @property
    @pulumi.getter
    def tags(self) -> pulumi.Output[Optional[Sequence[Any]]]:
        return pulumi.get(self, "tags")

