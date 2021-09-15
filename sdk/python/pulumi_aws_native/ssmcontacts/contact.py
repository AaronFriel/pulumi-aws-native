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

__all__ = ['ContactArgs', 'Contact']

@pulumi.input_type
class ContactArgs:
    def __init__(__self__, *,
                 alias: pulumi.Input[str],
                 display_name: pulumi.Input[str],
                 plan: pulumi.Input[Sequence[pulumi.Input['ContactStageArgs']]],
                 type: pulumi.Input[str]):
        """
        The set of arguments for constructing a Contact resource.
        :param pulumi.Input[str] alias: Alias of the contact. String value with 20 to 256 characters. Only alphabetical, numeric characters, dash, or underscore allowed.
        :param pulumi.Input[str] display_name: Name of the contact. String value with 3 to 256 characters. Only alphabetical, space, numeric characters, dash, or underscore allowed.
        :param pulumi.Input[Sequence[pulumi.Input['ContactStageArgs']]] plan: The stages that an escalation plan or engagement plan engages contacts and contact methods in.
        :param pulumi.Input[str] type: Contact type, which specify type of contact. Currently supported values: “PERSONAL”, “SHARED”, “OTHER“.
        """
        pulumi.set(__self__, "alias", alias)
        pulumi.set(__self__, "display_name", display_name)
        pulumi.set(__self__, "plan", plan)
        pulumi.set(__self__, "type", type)

    @property
    @pulumi.getter
    def alias(self) -> pulumi.Input[str]:
        """
        Alias of the contact. String value with 20 to 256 characters. Only alphabetical, numeric characters, dash, or underscore allowed.
        """
        return pulumi.get(self, "alias")

    @alias.setter
    def alias(self, value: pulumi.Input[str]):
        pulumi.set(self, "alias", value)

    @property
    @pulumi.getter(name="displayName")
    def display_name(self) -> pulumi.Input[str]:
        """
        Name of the contact. String value with 3 to 256 characters. Only alphabetical, space, numeric characters, dash, or underscore allowed.
        """
        return pulumi.get(self, "display_name")

    @display_name.setter
    def display_name(self, value: pulumi.Input[str]):
        pulumi.set(self, "display_name", value)

    @property
    @pulumi.getter
    def plan(self) -> pulumi.Input[Sequence[pulumi.Input['ContactStageArgs']]]:
        """
        The stages that an escalation plan or engagement plan engages contacts and contact methods in.
        """
        return pulumi.get(self, "plan")

    @plan.setter
    def plan(self, value: pulumi.Input[Sequence[pulumi.Input['ContactStageArgs']]]):
        pulumi.set(self, "plan", value)

    @property
    @pulumi.getter
    def type(self) -> pulumi.Input[str]:
        """
        Contact type, which specify type of contact. Currently supported values: “PERSONAL”, “SHARED”, “OTHER“.
        """
        return pulumi.get(self, "type")

    @type.setter
    def type(self, value: pulumi.Input[str]):
        pulumi.set(self, "type", value)


class Contact(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 alias: Optional[pulumi.Input[str]] = None,
                 display_name: Optional[pulumi.Input[str]] = None,
                 plan: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['ContactStageArgs']]]]] = None,
                 type: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        """
        Resource Type definition for AWS::SSMContacts::Contact

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] alias: Alias of the contact. String value with 20 to 256 characters. Only alphabetical, numeric characters, dash, or underscore allowed.
        :param pulumi.Input[str] display_name: Name of the contact. String value with 3 to 256 characters. Only alphabetical, space, numeric characters, dash, or underscore allowed.
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['ContactStageArgs']]]] plan: The stages that an escalation plan or engagement plan engages contacts and contact methods in.
        :param pulumi.Input[str] type: Contact type, which specify type of contact. Currently supported values: “PERSONAL”, “SHARED”, “OTHER“.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: ContactArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Resource Type definition for AWS::SSMContacts::Contact

        :param str resource_name: The name of the resource.
        :param ContactArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(ContactArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 alias: Optional[pulumi.Input[str]] = None,
                 display_name: Optional[pulumi.Input[str]] = None,
                 plan: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['ContactStageArgs']]]]] = None,
                 type: Optional[pulumi.Input[str]] = None,
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
            __props__ = ContactArgs.__new__(ContactArgs)

            if alias is None and not opts.urn:
                raise TypeError("Missing required property 'alias'")
            __props__.__dict__["alias"] = alias
            if display_name is None and not opts.urn:
                raise TypeError("Missing required property 'display_name'")
            __props__.__dict__["display_name"] = display_name
            if plan is None and not opts.urn:
                raise TypeError("Missing required property 'plan'")
            __props__.__dict__["plan"] = plan
            if type is None and not opts.urn:
                raise TypeError("Missing required property 'type'")
            __props__.__dict__["type"] = type
            __props__.__dict__["arn"] = None
        super(Contact, __self__).__init__(
            'aws-native:ssmcontacts:Contact',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None) -> 'Contact':
        """
        Get an existing Contact resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = ContactArgs.__new__(ContactArgs)

        __props__.__dict__["alias"] = None
        __props__.__dict__["arn"] = None
        __props__.__dict__["display_name"] = None
        __props__.__dict__["plan"] = None
        __props__.__dict__["type"] = None
        return Contact(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter
    def alias(self) -> pulumi.Output[str]:
        """
        Alias of the contact. String value with 20 to 256 characters. Only alphabetical, numeric characters, dash, or underscore allowed.
        """
        return pulumi.get(self, "alias")

    @property
    @pulumi.getter
    def arn(self) -> pulumi.Output[str]:
        """
        The Amazon Resource Name (ARN) of the contact.
        """
        return pulumi.get(self, "arn")

    @property
    @pulumi.getter(name="displayName")
    def display_name(self) -> pulumi.Output[str]:
        """
        Name of the contact. String value with 3 to 256 characters. Only alphabetical, space, numeric characters, dash, or underscore allowed.
        """
        return pulumi.get(self, "display_name")

    @property
    @pulumi.getter
    def plan(self) -> pulumi.Output[Sequence['outputs.ContactStage']]:
        """
        The stages that an escalation plan or engagement plan engages contacts and contact methods in.
        """
        return pulumi.get(self, "plan")

    @property
    @pulumi.getter
    def type(self) -> pulumi.Output[str]:
        """
        Contact type, which specify type of contact. Currently supported values: “PERSONAL”, “SHARED”, “OTHER“.
        """
        return pulumi.get(self, "type")

