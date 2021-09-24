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

__all__ = ['MemberArgs', 'Member']

@pulumi.input_type
class MemberArgs:
    def __init__(__self__, *,
                 member_configuration: pulumi.Input['MemberMemberConfigurationArgs'],
                 invitation_id: Optional[pulumi.Input[str]] = None,
                 network_configuration: Optional[pulumi.Input['MemberNetworkConfigurationArgs']] = None,
                 network_id: Optional[pulumi.Input[str]] = None):
        """
        The set of arguments for constructing a Member resource.
        """
        pulumi.set(__self__, "member_configuration", member_configuration)
        if invitation_id is not None:
            pulumi.set(__self__, "invitation_id", invitation_id)
        if network_configuration is not None:
            pulumi.set(__self__, "network_configuration", network_configuration)
        if network_id is not None:
            pulumi.set(__self__, "network_id", network_id)

    @property
    @pulumi.getter(name="memberConfiguration")
    def member_configuration(self) -> pulumi.Input['MemberMemberConfigurationArgs']:
        return pulumi.get(self, "member_configuration")

    @member_configuration.setter
    def member_configuration(self, value: pulumi.Input['MemberMemberConfigurationArgs']):
        pulumi.set(self, "member_configuration", value)

    @property
    @pulumi.getter(name="invitationId")
    def invitation_id(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "invitation_id")

    @invitation_id.setter
    def invitation_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "invitation_id", value)

    @property
    @pulumi.getter(name="networkConfiguration")
    def network_configuration(self) -> Optional[pulumi.Input['MemberNetworkConfigurationArgs']]:
        return pulumi.get(self, "network_configuration")

    @network_configuration.setter
    def network_configuration(self, value: Optional[pulumi.Input['MemberNetworkConfigurationArgs']]):
        pulumi.set(self, "network_configuration", value)

    @property
    @pulumi.getter(name="networkId")
    def network_id(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "network_id")

    @network_id.setter
    def network_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "network_id", value)


warnings.warn("""Member is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.""", DeprecationWarning)


class Member(pulumi.CustomResource):
    warnings.warn("""Member is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.""", DeprecationWarning)

    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 invitation_id: Optional[pulumi.Input[str]] = None,
                 member_configuration: Optional[pulumi.Input[pulumi.InputType['MemberMemberConfigurationArgs']]] = None,
                 network_configuration: Optional[pulumi.Input[pulumi.InputType['MemberNetworkConfigurationArgs']]] = None,
                 network_id: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        """
        Resource Type definition for AWS::ManagedBlockchain::Member

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: MemberArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Resource Type definition for AWS::ManagedBlockchain::Member

        :param str resource_name: The name of the resource.
        :param MemberArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(MemberArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 invitation_id: Optional[pulumi.Input[str]] = None,
                 member_configuration: Optional[pulumi.Input[pulumi.InputType['MemberMemberConfigurationArgs']]] = None,
                 network_configuration: Optional[pulumi.Input[pulumi.InputType['MemberNetworkConfigurationArgs']]] = None,
                 network_id: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        pulumi.log.warn("""Member is deprecated: Member is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.""")
        if opts is None:
            opts = pulumi.ResourceOptions()
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.version is None:
            opts.version = _utilities.get_version()
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = MemberArgs.__new__(MemberArgs)

            __props__.__dict__["invitation_id"] = invitation_id
            if member_configuration is None and not opts.urn:
                raise TypeError("Missing required property 'member_configuration'")
            __props__.__dict__["member_configuration"] = member_configuration
            __props__.__dict__["network_configuration"] = network_configuration
            __props__.__dict__["network_id"] = network_id
            __props__.__dict__["member_id"] = None
        super(Member, __self__).__init__(
            'aws-native:managedblockchain:Member',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None) -> 'Member':
        """
        Get an existing Member resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = MemberArgs.__new__(MemberArgs)

        __props__.__dict__["invitation_id"] = None
        __props__.__dict__["member_configuration"] = None
        __props__.__dict__["member_id"] = None
        __props__.__dict__["network_configuration"] = None
        __props__.__dict__["network_id"] = None
        return Member(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="invitationId")
    def invitation_id(self) -> pulumi.Output[Optional[str]]:
        return pulumi.get(self, "invitation_id")

    @property
    @pulumi.getter(name="memberConfiguration")
    def member_configuration(self) -> pulumi.Output['outputs.MemberMemberConfiguration']:
        return pulumi.get(self, "member_configuration")

    @property
    @pulumi.getter(name="memberId")
    def member_id(self) -> pulumi.Output[str]:
        return pulumi.get(self, "member_id")

    @property
    @pulumi.getter(name="networkConfiguration")
    def network_configuration(self) -> pulumi.Output[Optional['outputs.MemberNetworkConfiguration']]:
        return pulumi.get(self, "network_configuration")

    @property
    @pulumi.getter(name="networkId")
    def network_id(self) -> pulumi.Output[Optional[str]]:
        return pulumi.get(self, "network_id")

