# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from .. import _utilities

__all__ = ['WarmPoolArgs', 'WarmPool']

@pulumi.input_type
class WarmPoolArgs:
    def __init__(__self__, *,
                 auto_scaling_group_name: pulumi.Input[str],
                 max_group_prepared_capacity: Optional[pulumi.Input[int]] = None,
                 min_size: Optional[pulumi.Input[int]] = None,
                 pool_state: Optional[pulumi.Input[str]] = None):
        """
        The set of arguments for constructing a WarmPool resource.
        """
        pulumi.set(__self__, "auto_scaling_group_name", auto_scaling_group_name)
        if max_group_prepared_capacity is not None:
            pulumi.set(__self__, "max_group_prepared_capacity", max_group_prepared_capacity)
        if min_size is not None:
            pulumi.set(__self__, "min_size", min_size)
        if pool_state is not None:
            pulumi.set(__self__, "pool_state", pool_state)

    @property
    @pulumi.getter(name="autoScalingGroupName")
    def auto_scaling_group_name(self) -> pulumi.Input[str]:
        return pulumi.get(self, "auto_scaling_group_name")

    @auto_scaling_group_name.setter
    def auto_scaling_group_name(self, value: pulumi.Input[str]):
        pulumi.set(self, "auto_scaling_group_name", value)

    @property
    @pulumi.getter(name="maxGroupPreparedCapacity")
    def max_group_prepared_capacity(self) -> Optional[pulumi.Input[int]]:
        return pulumi.get(self, "max_group_prepared_capacity")

    @max_group_prepared_capacity.setter
    def max_group_prepared_capacity(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "max_group_prepared_capacity", value)

    @property
    @pulumi.getter(name="minSize")
    def min_size(self) -> Optional[pulumi.Input[int]]:
        return pulumi.get(self, "min_size")

    @min_size.setter
    def min_size(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "min_size", value)

    @property
    @pulumi.getter(name="poolState")
    def pool_state(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "pool_state")

    @pool_state.setter
    def pool_state(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "pool_state", value)


class WarmPool(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 auto_scaling_group_name: Optional[pulumi.Input[str]] = None,
                 max_group_prepared_capacity: Optional[pulumi.Input[int]] = None,
                 min_size: Optional[pulumi.Input[int]] = None,
                 pool_state: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        """
        Resource schema for AWS::AutoScaling::WarmPool.

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: WarmPoolArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Resource schema for AWS::AutoScaling::WarmPool.

        :param str resource_name: The name of the resource.
        :param WarmPoolArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(WarmPoolArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 auto_scaling_group_name: Optional[pulumi.Input[str]] = None,
                 max_group_prepared_capacity: Optional[pulumi.Input[int]] = None,
                 min_size: Optional[pulumi.Input[int]] = None,
                 pool_state: Optional[pulumi.Input[str]] = None,
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
            __props__ = WarmPoolArgs.__new__(WarmPoolArgs)

            if auto_scaling_group_name is None and not opts.urn:
                raise TypeError("Missing required property 'auto_scaling_group_name'")
            __props__.__dict__["auto_scaling_group_name"] = auto_scaling_group_name
            __props__.__dict__["max_group_prepared_capacity"] = max_group_prepared_capacity
            __props__.__dict__["min_size"] = min_size
            __props__.__dict__["pool_state"] = pool_state
        super(WarmPool, __self__).__init__(
            'aws-native:autoscaling:WarmPool',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None) -> 'WarmPool':
        """
        Get an existing WarmPool resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = WarmPoolArgs.__new__(WarmPoolArgs)

        __props__.__dict__["auto_scaling_group_name"] = None
        __props__.__dict__["max_group_prepared_capacity"] = None
        __props__.__dict__["min_size"] = None
        __props__.__dict__["pool_state"] = None
        return WarmPool(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="autoScalingGroupName")
    def auto_scaling_group_name(self) -> pulumi.Output[str]:
        return pulumi.get(self, "auto_scaling_group_name")

    @property
    @pulumi.getter(name="maxGroupPreparedCapacity")
    def max_group_prepared_capacity(self) -> pulumi.Output[Optional[int]]:
        return pulumi.get(self, "max_group_prepared_capacity")

    @property
    @pulumi.getter(name="minSize")
    def min_size(self) -> pulumi.Output[Optional[int]]:
        return pulumi.get(self, "min_size")

    @property
    @pulumi.getter(name="poolState")
    def pool_state(self) -> pulumi.Output[Optional[str]]:
        return pulumi.get(self, "pool_state")

