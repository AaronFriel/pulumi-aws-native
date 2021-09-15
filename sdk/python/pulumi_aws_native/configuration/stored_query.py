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

__all__ = ['StoredQueryArgs', 'StoredQuery']

@pulumi.input_type
class StoredQueryArgs:
    def __init__(__self__, *,
                 query_expression: pulumi.Input[str],
                 query_name: pulumi.Input[str],
                 query_description: Optional[pulumi.Input[str]] = None,
                 tags: Optional[pulumi.Input[Sequence[pulumi.Input['StoredQueryTagArgs']]]] = None):
        """
        The set of arguments for constructing a StoredQuery resource.
        :param pulumi.Input[Sequence[pulumi.Input['StoredQueryTagArgs']]] tags: The tags for the stored query.
        """
        pulumi.set(__self__, "query_expression", query_expression)
        pulumi.set(__self__, "query_name", query_name)
        if query_description is not None:
            pulumi.set(__self__, "query_description", query_description)
        if tags is not None:
            pulumi.set(__self__, "tags", tags)

    @property
    @pulumi.getter(name="queryExpression")
    def query_expression(self) -> pulumi.Input[str]:
        return pulumi.get(self, "query_expression")

    @query_expression.setter
    def query_expression(self, value: pulumi.Input[str]):
        pulumi.set(self, "query_expression", value)

    @property
    @pulumi.getter(name="queryName")
    def query_name(self) -> pulumi.Input[str]:
        return pulumi.get(self, "query_name")

    @query_name.setter
    def query_name(self, value: pulumi.Input[str]):
        pulumi.set(self, "query_name", value)

    @property
    @pulumi.getter(name="queryDescription")
    def query_description(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "query_description")

    @query_description.setter
    def query_description(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "query_description", value)

    @property
    @pulumi.getter
    def tags(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['StoredQueryTagArgs']]]]:
        """
        The tags for the stored query.
        """
        return pulumi.get(self, "tags")

    @tags.setter
    def tags(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['StoredQueryTagArgs']]]]):
        pulumi.set(self, "tags", value)


class StoredQuery(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 query_description: Optional[pulumi.Input[str]] = None,
                 query_expression: Optional[pulumi.Input[str]] = None,
                 query_name: Optional[pulumi.Input[str]] = None,
                 tags: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['StoredQueryTagArgs']]]]] = None,
                 __props__=None):
        """
        Resource Type definition for AWS::Config::StoredQuery

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['StoredQueryTagArgs']]]] tags: The tags for the stored query.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: StoredQueryArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Resource Type definition for AWS::Config::StoredQuery

        :param str resource_name: The name of the resource.
        :param StoredQueryArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(StoredQueryArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 query_description: Optional[pulumi.Input[str]] = None,
                 query_expression: Optional[pulumi.Input[str]] = None,
                 query_name: Optional[pulumi.Input[str]] = None,
                 tags: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['StoredQueryTagArgs']]]]] = None,
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
            __props__ = StoredQueryArgs.__new__(StoredQueryArgs)

            __props__.__dict__["query_description"] = query_description
            if query_expression is None and not opts.urn:
                raise TypeError("Missing required property 'query_expression'")
            __props__.__dict__["query_expression"] = query_expression
            if query_name is None and not opts.urn:
                raise TypeError("Missing required property 'query_name'")
            __props__.__dict__["query_name"] = query_name
            __props__.__dict__["tags"] = tags
            __props__.__dict__["query_arn"] = None
            __props__.__dict__["query_id"] = None
        super(StoredQuery, __self__).__init__(
            'aws-native:configuration:StoredQuery',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None) -> 'StoredQuery':
        """
        Get an existing StoredQuery resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = StoredQueryArgs.__new__(StoredQueryArgs)

        __props__.__dict__["query_arn"] = None
        __props__.__dict__["query_description"] = None
        __props__.__dict__["query_expression"] = None
        __props__.__dict__["query_id"] = None
        __props__.__dict__["query_name"] = None
        __props__.__dict__["tags"] = None
        return StoredQuery(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="queryArn")
    def query_arn(self) -> pulumi.Output[str]:
        return pulumi.get(self, "query_arn")

    @property
    @pulumi.getter(name="queryDescription")
    def query_description(self) -> pulumi.Output[Optional[str]]:
        return pulumi.get(self, "query_description")

    @property
    @pulumi.getter(name="queryExpression")
    def query_expression(self) -> pulumi.Output[str]:
        return pulumi.get(self, "query_expression")

    @property
    @pulumi.getter(name="queryId")
    def query_id(self) -> pulumi.Output[str]:
        return pulumi.get(self, "query_id")

    @property
    @pulumi.getter(name="queryName")
    def query_name(self) -> pulumi.Output[str]:
        return pulumi.get(self, "query_name")

    @property
    @pulumi.getter
    def tags(self) -> pulumi.Output[Optional[Sequence['outputs.StoredQueryTag']]]:
        """
        The tags for the stored query.
        """
        return pulumi.get(self, "tags")

