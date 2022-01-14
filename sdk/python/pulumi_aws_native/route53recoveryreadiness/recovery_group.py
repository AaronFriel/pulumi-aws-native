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

__all__ = ['RecoveryGroupArgs', 'RecoveryGroup']

@pulumi.input_type
class RecoveryGroupArgs:
    def __init__(__self__, *,
                 cells: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 recovery_group_name: Optional[pulumi.Input[str]] = None,
                 tags: Optional[pulumi.Input[Sequence[pulumi.Input['RecoveryGroupTagArgs']]]] = None):
        """
        The set of arguments for constructing a RecoveryGroup resource.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] cells: A list of the cell Amazon Resource Names (ARNs) in the recovery group.
        :param pulumi.Input[str] recovery_group_name: The name of the recovery group to create.
        :param pulumi.Input[Sequence[pulumi.Input['RecoveryGroupTagArgs']]] tags: A collection of tags associated with a resource.
        """
        if cells is not None:
            pulumi.set(__self__, "cells", cells)
        if recovery_group_name is not None:
            pulumi.set(__self__, "recovery_group_name", recovery_group_name)
        if tags is not None:
            pulumi.set(__self__, "tags", tags)

    @property
    @pulumi.getter
    def cells(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]:
        """
        A list of the cell Amazon Resource Names (ARNs) in the recovery group.
        """
        return pulumi.get(self, "cells")

    @cells.setter
    def cells(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]):
        pulumi.set(self, "cells", value)

    @property
    @pulumi.getter(name="recoveryGroupName")
    def recovery_group_name(self) -> Optional[pulumi.Input[str]]:
        """
        The name of the recovery group to create.
        """
        return pulumi.get(self, "recovery_group_name")

    @recovery_group_name.setter
    def recovery_group_name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "recovery_group_name", value)

    @property
    @pulumi.getter
    def tags(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['RecoveryGroupTagArgs']]]]:
        """
        A collection of tags associated with a resource.
        """
        return pulumi.get(self, "tags")

    @tags.setter
    def tags(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['RecoveryGroupTagArgs']]]]):
        pulumi.set(self, "tags", value)


class RecoveryGroup(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 cells: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 recovery_group_name: Optional[pulumi.Input[str]] = None,
                 tags: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['RecoveryGroupTagArgs']]]]] = None,
                 __props__=None):
        """
        AWS Route53 Recovery Readiness Recovery Group Schema and API specifications.

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] cells: A list of the cell Amazon Resource Names (ARNs) in the recovery group.
        :param pulumi.Input[str] recovery_group_name: The name of the recovery group to create.
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['RecoveryGroupTagArgs']]]] tags: A collection of tags associated with a resource.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: Optional[RecoveryGroupArgs] = None,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        AWS Route53 Recovery Readiness Recovery Group Schema and API specifications.

        :param str resource_name: The name of the resource.
        :param RecoveryGroupArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(RecoveryGroupArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 cells: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 recovery_group_name: Optional[pulumi.Input[str]] = None,
                 tags: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['RecoveryGroupTagArgs']]]]] = None,
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
            __props__ = RecoveryGroupArgs.__new__(RecoveryGroupArgs)

            __props__.__dict__["cells"] = cells
            __props__.__dict__["recovery_group_name"] = recovery_group_name
            __props__.__dict__["tags"] = tags
            __props__.__dict__["recovery_group_arn"] = None
        super(RecoveryGroup, __self__).__init__(
            'aws-native:route53recoveryreadiness:RecoveryGroup',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None) -> 'RecoveryGroup':
        """
        Get an existing RecoveryGroup resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = RecoveryGroupArgs.__new__(RecoveryGroupArgs)

        __props__.__dict__["cells"] = None
        __props__.__dict__["recovery_group_arn"] = None
        __props__.__dict__["recovery_group_name"] = None
        __props__.__dict__["tags"] = None
        return RecoveryGroup(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter
    def cells(self) -> pulumi.Output[Optional[Sequence[str]]]:
        """
        A list of the cell Amazon Resource Names (ARNs) in the recovery group.
        """
        return pulumi.get(self, "cells")

    @property
    @pulumi.getter(name="recoveryGroupArn")
    def recovery_group_arn(self) -> pulumi.Output[str]:
        """
        A collection of tags associated with a resource.
        """
        return pulumi.get(self, "recovery_group_arn")

    @property
    @pulumi.getter(name="recoveryGroupName")
    def recovery_group_name(self) -> pulumi.Output[str]:
        """
        The name of the recovery group to create.
        """
        return pulumi.get(self, "recovery_group_name")

    @property
    @pulumi.getter
    def tags(self) -> pulumi.Output[Optional[Sequence['outputs.RecoveryGroupTag']]]:
        """
        A collection of tags associated with a resource.
        """
        return pulumi.get(self, "tags")

