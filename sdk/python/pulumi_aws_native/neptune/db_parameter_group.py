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

__all__ = ['DBParameterGroupArgs', 'DBParameterGroup']

@pulumi.input_type
class DBParameterGroupArgs:
    def __init__(__self__, *,
                 description: pulumi.Input[str],
                 family: pulumi.Input[str],
                 parameters: Any,
                 name: Optional[pulumi.Input[str]] = None,
                 tags: Optional[pulumi.Input[Sequence[pulumi.Input['DBParameterGroupTagArgs']]]] = None):
        """
        The set of arguments for constructing a DBParameterGroup resource.
        """
        pulumi.set(__self__, "description", description)
        pulumi.set(__self__, "family", family)
        pulumi.set(__self__, "parameters", parameters)
        if name is not None:
            pulumi.set(__self__, "name", name)
        if tags is not None:
            pulumi.set(__self__, "tags", tags)

    @property
    @pulumi.getter
    def description(self) -> pulumi.Input[str]:
        return pulumi.get(self, "description")

    @description.setter
    def description(self, value: pulumi.Input[str]):
        pulumi.set(self, "description", value)

    @property
    @pulumi.getter
    def family(self) -> pulumi.Input[str]:
        return pulumi.get(self, "family")

    @family.setter
    def family(self, value: pulumi.Input[str]):
        pulumi.set(self, "family", value)

    @property
    @pulumi.getter
    def parameters(self) -> Any:
        return pulumi.get(self, "parameters")

    @parameters.setter
    def parameters(self, value: Any):
        pulumi.set(self, "parameters", value)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter
    def tags(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['DBParameterGroupTagArgs']]]]:
        return pulumi.get(self, "tags")

    @tags.setter
    def tags(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['DBParameterGroupTagArgs']]]]):
        pulumi.set(self, "tags", value)


warnings.warn("""DBParameterGroup is not yet supported by AWS Cloud Control API, so its creation will currently fail. Please use the classic AWS provider, if possible.""", DeprecationWarning)


class DBParameterGroup(pulumi.CustomResource):
    warnings.warn("""DBParameterGroup is not yet supported by AWS Cloud Control API, so its creation will currently fail. Please use the classic AWS provider, if possible.""", DeprecationWarning)

    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 family: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 parameters: Optional[Any] = None,
                 tags: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['DBParameterGroupTagArgs']]]]] = None,
                 __props__=None):
        """
        Resource Type definition for AWS::Neptune::DBParameterGroup

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: DBParameterGroupArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Resource Type definition for AWS::Neptune::DBParameterGroup

        :param str resource_name: The name of the resource.
        :param DBParameterGroupArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(DBParameterGroupArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 family: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 parameters: Optional[Any] = None,
                 tags: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['DBParameterGroupTagArgs']]]]] = None,
                 __props__=None):
        pulumi.log.warn("""DBParameterGroup is deprecated: DBParameterGroup is not yet supported by AWS Cloud Control API, so its creation will currently fail. Please use the classic AWS provider, if possible.""")
        if opts is None:
            opts = pulumi.ResourceOptions()
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.version is None:
            opts.version = _utilities.get_version()
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = DBParameterGroupArgs.__new__(DBParameterGroupArgs)

            if description is None and not opts.urn:
                raise TypeError("Missing required property 'description'")
            __props__.__dict__["description"] = description
            if family is None and not opts.urn:
                raise TypeError("Missing required property 'family'")
            __props__.__dict__["family"] = family
            __props__.__dict__["name"] = name
            if parameters is None and not opts.urn:
                raise TypeError("Missing required property 'parameters'")
            __props__.__dict__["parameters"] = parameters
            __props__.__dict__["tags"] = tags
        super(DBParameterGroup, __self__).__init__(
            'aws-native:neptune:DBParameterGroup',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None) -> 'DBParameterGroup':
        """
        Get an existing DBParameterGroup resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = DBParameterGroupArgs.__new__(DBParameterGroupArgs)

        __props__.__dict__["description"] = None
        __props__.__dict__["family"] = None
        __props__.__dict__["name"] = None
        __props__.__dict__["parameters"] = None
        __props__.__dict__["tags"] = None
        return DBParameterGroup(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter
    def description(self) -> pulumi.Output[str]:
        return pulumi.get(self, "description")

    @property
    @pulumi.getter
    def family(self) -> pulumi.Output[str]:
        return pulumi.get(self, "family")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[Optional[str]]:
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def parameters(self) -> pulumi.Output[Any]:
        return pulumi.get(self, "parameters")

    @property
    @pulumi.getter
    def tags(self) -> pulumi.Output[Optional[Sequence['outputs.DBParameterGroupTag']]]:
        return pulumi.get(self, "tags")

