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

__all__ = ['DBSecurityGroupArgs', 'DBSecurityGroup']

@pulumi.input_type
class DBSecurityGroupArgs:
    def __init__(__self__, *,
                 d_b_security_group_ingress: pulumi.Input[Sequence[pulumi.Input['DBSecurityGroupIngressArgs']]],
                 group_description: pulumi.Input[str],
                 e_c2_vpc_id: Optional[pulumi.Input[str]] = None,
                 tags: Optional[pulumi.Input[Sequence[pulumi.Input['DBSecurityGroupTagArgs']]]] = None):
        """
        The set of arguments for constructing a DBSecurityGroup resource.
        """
        pulumi.set(__self__, "d_b_security_group_ingress", d_b_security_group_ingress)
        pulumi.set(__self__, "group_description", group_description)
        if e_c2_vpc_id is not None:
            pulumi.set(__self__, "e_c2_vpc_id", e_c2_vpc_id)
        if tags is not None:
            pulumi.set(__self__, "tags", tags)

    @property
    @pulumi.getter(name="dBSecurityGroupIngress")
    def d_b_security_group_ingress(self) -> pulumi.Input[Sequence[pulumi.Input['DBSecurityGroupIngressArgs']]]:
        return pulumi.get(self, "d_b_security_group_ingress")

    @d_b_security_group_ingress.setter
    def d_b_security_group_ingress(self, value: pulumi.Input[Sequence[pulumi.Input['DBSecurityGroupIngressArgs']]]):
        pulumi.set(self, "d_b_security_group_ingress", value)

    @property
    @pulumi.getter(name="groupDescription")
    def group_description(self) -> pulumi.Input[str]:
        return pulumi.get(self, "group_description")

    @group_description.setter
    def group_description(self, value: pulumi.Input[str]):
        pulumi.set(self, "group_description", value)

    @property
    @pulumi.getter(name="eC2VpcId")
    def e_c2_vpc_id(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "e_c2_vpc_id")

    @e_c2_vpc_id.setter
    def e_c2_vpc_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "e_c2_vpc_id", value)

    @property
    @pulumi.getter
    def tags(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['DBSecurityGroupTagArgs']]]]:
        return pulumi.get(self, "tags")

    @tags.setter
    def tags(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['DBSecurityGroupTagArgs']]]]):
        pulumi.set(self, "tags", value)


warnings.warn("""DBSecurityGroup is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.""", DeprecationWarning)


class DBSecurityGroup(pulumi.CustomResource):
    warnings.warn("""DBSecurityGroup is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.""", DeprecationWarning)

    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 d_b_security_group_ingress: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['DBSecurityGroupIngressArgs']]]]] = None,
                 e_c2_vpc_id: Optional[pulumi.Input[str]] = None,
                 group_description: Optional[pulumi.Input[str]] = None,
                 tags: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['DBSecurityGroupTagArgs']]]]] = None,
                 __props__=None):
        """
        Resource Type definition for AWS::RDS::DBSecurityGroup

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: DBSecurityGroupArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Resource Type definition for AWS::RDS::DBSecurityGroup

        :param str resource_name: The name of the resource.
        :param DBSecurityGroupArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(DBSecurityGroupArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 d_b_security_group_ingress: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['DBSecurityGroupIngressArgs']]]]] = None,
                 e_c2_vpc_id: Optional[pulumi.Input[str]] = None,
                 group_description: Optional[pulumi.Input[str]] = None,
                 tags: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['DBSecurityGroupTagArgs']]]]] = None,
                 __props__=None):
        pulumi.log.warn("""DBSecurityGroup is deprecated: DBSecurityGroup is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.""")
        if opts is None:
            opts = pulumi.ResourceOptions()
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.version is None:
            opts.version = _utilities.get_version()
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = DBSecurityGroupArgs.__new__(DBSecurityGroupArgs)

            if d_b_security_group_ingress is None and not opts.urn:
                raise TypeError("Missing required property 'd_b_security_group_ingress'")
            __props__.__dict__["d_b_security_group_ingress"] = d_b_security_group_ingress
            __props__.__dict__["e_c2_vpc_id"] = e_c2_vpc_id
            if group_description is None and not opts.urn:
                raise TypeError("Missing required property 'group_description'")
            __props__.__dict__["group_description"] = group_description
            __props__.__dict__["tags"] = tags
        super(DBSecurityGroup, __self__).__init__(
            'aws-native:rds:DBSecurityGroup',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None) -> 'DBSecurityGroup':
        """
        Get an existing DBSecurityGroup resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = DBSecurityGroupArgs.__new__(DBSecurityGroupArgs)

        __props__.__dict__["d_b_security_group_ingress"] = None
        __props__.__dict__["e_c2_vpc_id"] = None
        __props__.__dict__["group_description"] = None
        __props__.__dict__["tags"] = None
        return DBSecurityGroup(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="dBSecurityGroupIngress")
    def d_b_security_group_ingress(self) -> pulumi.Output[Sequence['outputs.DBSecurityGroupIngress']]:
        return pulumi.get(self, "d_b_security_group_ingress")

    @property
    @pulumi.getter(name="eC2VpcId")
    def e_c2_vpc_id(self) -> pulumi.Output[Optional[str]]:
        return pulumi.get(self, "e_c2_vpc_id")

    @property
    @pulumi.getter(name="groupDescription")
    def group_description(self) -> pulumi.Output[str]:
        return pulumi.get(self, "group_description")

    @property
    @pulumi.getter
    def tags(self) -> pulumi.Output[Optional[Sequence['outputs.DBSecurityGroupTag']]]:
        return pulumi.get(self, "tags")

