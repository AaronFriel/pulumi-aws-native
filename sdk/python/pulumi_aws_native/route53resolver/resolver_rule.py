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

__all__ = ['ResolverRuleArgs', 'ResolverRule']

@pulumi.input_type
class ResolverRuleArgs:
    def __init__(__self__, *,
                 domain_name: pulumi.Input[str],
                 rule_type: pulumi.Input[str],
                 name: Optional[pulumi.Input[str]] = None,
                 resolver_endpoint_id: Optional[pulumi.Input[str]] = None,
                 tags: Optional[pulumi.Input[Sequence[pulumi.Input['ResolverRuleTagArgs']]]] = None,
                 target_ips: Optional[pulumi.Input[Sequence[pulumi.Input['ResolverRuleTargetAddressArgs']]]] = None):
        """
        The set of arguments for constructing a ResolverRule resource.
        """
        pulumi.set(__self__, "domain_name", domain_name)
        pulumi.set(__self__, "rule_type", rule_type)
        if name is not None:
            pulumi.set(__self__, "name", name)
        if resolver_endpoint_id is not None:
            pulumi.set(__self__, "resolver_endpoint_id", resolver_endpoint_id)
        if tags is not None:
            pulumi.set(__self__, "tags", tags)
        if target_ips is not None:
            pulumi.set(__self__, "target_ips", target_ips)

    @property
    @pulumi.getter(name="domainName")
    def domain_name(self) -> pulumi.Input[str]:
        return pulumi.get(self, "domain_name")

    @domain_name.setter
    def domain_name(self, value: pulumi.Input[str]):
        pulumi.set(self, "domain_name", value)

    @property
    @pulumi.getter(name="ruleType")
    def rule_type(self) -> pulumi.Input[str]:
        return pulumi.get(self, "rule_type")

    @rule_type.setter
    def rule_type(self, value: pulumi.Input[str]):
        pulumi.set(self, "rule_type", value)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter(name="resolverEndpointId")
    def resolver_endpoint_id(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "resolver_endpoint_id")

    @resolver_endpoint_id.setter
    def resolver_endpoint_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "resolver_endpoint_id", value)

    @property
    @pulumi.getter
    def tags(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['ResolverRuleTagArgs']]]]:
        return pulumi.get(self, "tags")

    @tags.setter
    def tags(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['ResolverRuleTagArgs']]]]):
        pulumi.set(self, "tags", value)

    @property
    @pulumi.getter(name="targetIps")
    def target_ips(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['ResolverRuleTargetAddressArgs']]]]:
        return pulumi.get(self, "target_ips")

    @target_ips.setter
    def target_ips(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['ResolverRuleTargetAddressArgs']]]]):
        pulumi.set(self, "target_ips", value)


warnings.warn("""ResolverRule is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.""", DeprecationWarning)


class ResolverRule(pulumi.CustomResource):
    warnings.warn("""ResolverRule is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.""", DeprecationWarning)

    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 domain_name: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 resolver_endpoint_id: Optional[pulumi.Input[str]] = None,
                 rule_type: Optional[pulumi.Input[str]] = None,
                 tags: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['ResolverRuleTagArgs']]]]] = None,
                 target_ips: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['ResolverRuleTargetAddressArgs']]]]] = None,
                 __props__=None):
        """
        Resource Type definition for AWS::Route53Resolver::ResolverRule

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: ResolverRuleArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Resource Type definition for AWS::Route53Resolver::ResolverRule

        :param str resource_name: The name of the resource.
        :param ResolverRuleArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(ResolverRuleArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 domain_name: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 resolver_endpoint_id: Optional[pulumi.Input[str]] = None,
                 rule_type: Optional[pulumi.Input[str]] = None,
                 tags: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['ResolverRuleTagArgs']]]]] = None,
                 target_ips: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['ResolverRuleTargetAddressArgs']]]]] = None,
                 __props__=None):
        pulumi.log.warn("""ResolverRule is deprecated: ResolverRule is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.""")
        if opts is None:
            opts = pulumi.ResourceOptions()
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.version is None:
            opts.version = _utilities.get_version()
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = ResolverRuleArgs.__new__(ResolverRuleArgs)

            if domain_name is None and not opts.urn:
                raise TypeError("Missing required property 'domain_name'")
            __props__.__dict__["domain_name"] = domain_name
            __props__.__dict__["name"] = name
            __props__.__dict__["resolver_endpoint_id"] = resolver_endpoint_id
            if rule_type is None and not opts.urn:
                raise TypeError("Missing required property 'rule_type'")
            __props__.__dict__["rule_type"] = rule_type
            __props__.__dict__["tags"] = tags
            __props__.__dict__["target_ips"] = target_ips
            __props__.__dict__["arn"] = None
            __props__.__dict__["resolver_rule_id"] = None
        super(ResolverRule, __self__).__init__(
            'aws-native:route53resolver:ResolverRule',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None) -> 'ResolverRule':
        """
        Get an existing ResolverRule resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = ResolverRuleArgs.__new__(ResolverRuleArgs)

        __props__.__dict__["arn"] = None
        __props__.__dict__["domain_name"] = None
        __props__.__dict__["name"] = None
        __props__.__dict__["resolver_endpoint_id"] = None
        __props__.__dict__["resolver_rule_id"] = None
        __props__.__dict__["rule_type"] = None
        __props__.__dict__["tags"] = None
        __props__.__dict__["target_ips"] = None
        return ResolverRule(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter
    def arn(self) -> pulumi.Output[str]:
        return pulumi.get(self, "arn")

    @property
    @pulumi.getter(name="domainName")
    def domain_name(self) -> pulumi.Output[str]:
        return pulumi.get(self, "domain_name")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[Optional[str]]:
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="resolverEndpointId")
    def resolver_endpoint_id(self) -> pulumi.Output[Optional[str]]:
        return pulumi.get(self, "resolver_endpoint_id")

    @property
    @pulumi.getter(name="resolverRuleId")
    def resolver_rule_id(self) -> pulumi.Output[str]:
        return pulumi.get(self, "resolver_rule_id")

    @property
    @pulumi.getter(name="ruleType")
    def rule_type(self) -> pulumi.Output[str]:
        return pulumi.get(self, "rule_type")

    @property
    @pulumi.getter
    def tags(self) -> pulumi.Output[Optional[Sequence['outputs.ResolverRuleTag']]]:
        return pulumi.get(self, "tags")

    @property
    @pulumi.getter(name="targetIps")
    def target_ips(self) -> pulumi.Output[Optional[Sequence['outputs.ResolverRuleTargetAddress']]]:
        return pulumi.get(self, "target_ips")

