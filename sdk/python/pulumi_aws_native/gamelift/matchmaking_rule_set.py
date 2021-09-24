# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from .. import _utilities

__all__ = ['MatchmakingRuleSetArgs', 'MatchmakingRuleSet']

@pulumi.input_type
class MatchmakingRuleSetArgs:
    def __init__(__self__, *,
                 name: pulumi.Input[str],
                 rule_set_body: pulumi.Input[str]):
        """
        The set of arguments for constructing a MatchmakingRuleSet resource.
        """
        pulumi.set(__self__, "name", name)
        pulumi.set(__self__, "rule_set_body", rule_set_body)

    @property
    @pulumi.getter
    def name(self) -> pulumi.Input[str]:
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: pulumi.Input[str]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter(name="ruleSetBody")
    def rule_set_body(self) -> pulumi.Input[str]:
        return pulumi.get(self, "rule_set_body")

    @rule_set_body.setter
    def rule_set_body(self, value: pulumi.Input[str]):
        pulumi.set(self, "rule_set_body", value)


warnings.warn("""MatchmakingRuleSet is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.""", DeprecationWarning)


class MatchmakingRuleSet(pulumi.CustomResource):
    warnings.warn("""MatchmakingRuleSet is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.""", DeprecationWarning)

    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 rule_set_body: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        """
        Resource Type definition for AWS::GameLift::MatchmakingRuleSet

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: MatchmakingRuleSetArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Resource Type definition for AWS::GameLift::MatchmakingRuleSet

        :param str resource_name: The name of the resource.
        :param MatchmakingRuleSetArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(MatchmakingRuleSetArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 rule_set_body: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        pulumi.log.warn("""MatchmakingRuleSet is deprecated: MatchmakingRuleSet is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.""")
        if opts is None:
            opts = pulumi.ResourceOptions()
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.version is None:
            opts.version = _utilities.get_version()
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = MatchmakingRuleSetArgs.__new__(MatchmakingRuleSetArgs)

            if name is None and not opts.urn:
                raise TypeError("Missing required property 'name'")
            __props__.__dict__["name"] = name
            if rule_set_body is None and not opts.urn:
                raise TypeError("Missing required property 'rule_set_body'")
            __props__.__dict__["rule_set_body"] = rule_set_body
            __props__.__dict__["arn"] = None
        super(MatchmakingRuleSet, __self__).__init__(
            'aws-native:gamelift:MatchmakingRuleSet',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None) -> 'MatchmakingRuleSet':
        """
        Get an existing MatchmakingRuleSet resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = MatchmakingRuleSetArgs.__new__(MatchmakingRuleSetArgs)

        __props__.__dict__["arn"] = None
        __props__.__dict__["name"] = None
        __props__.__dict__["rule_set_body"] = None
        return MatchmakingRuleSet(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter
    def arn(self) -> pulumi.Output[str]:
        return pulumi.get(self, "arn")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="ruleSetBody")
    def rule_set_body(self) -> pulumi.Output[str]:
        return pulumi.get(self, "rule_set_body")

