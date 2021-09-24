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

__all__ = ['PatchBaselineArgs', 'PatchBaseline']

@pulumi.input_type
class PatchBaselineArgs:
    def __init__(__self__, *,
                 name: pulumi.Input[str],
                 approval_rules: Optional[pulumi.Input['PatchBaselineRuleGroupArgs']] = None,
                 approved_patches: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 approved_patches_compliance_level: Optional[pulumi.Input[str]] = None,
                 approved_patches_enable_non_security: Optional[pulumi.Input[bool]] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 global_filters: Optional[pulumi.Input['PatchBaselinePatchFilterGroupArgs']] = None,
                 operating_system: Optional[pulumi.Input[str]] = None,
                 patch_groups: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 rejected_patches: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 rejected_patches_action: Optional[pulumi.Input[str]] = None,
                 sources: Optional[pulumi.Input[Sequence[pulumi.Input['PatchBaselinePatchSourceArgs']]]] = None,
                 tags: Optional[pulumi.Input[Sequence[pulumi.Input['PatchBaselineTagArgs']]]] = None):
        """
        The set of arguments for constructing a PatchBaseline resource.
        """
        pulumi.set(__self__, "name", name)
        if approval_rules is not None:
            pulumi.set(__self__, "approval_rules", approval_rules)
        if approved_patches is not None:
            pulumi.set(__self__, "approved_patches", approved_patches)
        if approved_patches_compliance_level is not None:
            pulumi.set(__self__, "approved_patches_compliance_level", approved_patches_compliance_level)
        if approved_patches_enable_non_security is not None:
            pulumi.set(__self__, "approved_patches_enable_non_security", approved_patches_enable_non_security)
        if description is not None:
            pulumi.set(__self__, "description", description)
        if global_filters is not None:
            pulumi.set(__self__, "global_filters", global_filters)
        if operating_system is not None:
            pulumi.set(__self__, "operating_system", operating_system)
        if patch_groups is not None:
            pulumi.set(__self__, "patch_groups", patch_groups)
        if rejected_patches is not None:
            pulumi.set(__self__, "rejected_patches", rejected_patches)
        if rejected_patches_action is not None:
            pulumi.set(__self__, "rejected_patches_action", rejected_patches_action)
        if sources is not None:
            pulumi.set(__self__, "sources", sources)
        if tags is not None:
            pulumi.set(__self__, "tags", tags)

    @property
    @pulumi.getter
    def name(self) -> pulumi.Input[str]:
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: pulumi.Input[str]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter(name="approvalRules")
    def approval_rules(self) -> Optional[pulumi.Input['PatchBaselineRuleGroupArgs']]:
        return pulumi.get(self, "approval_rules")

    @approval_rules.setter
    def approval_rules(self, value: Optional[pulumi.Input['PatchBaselineRuleGroupArgs']]):
        pulumi.set(self, "approval_rules", value)

    @property
    @pulumi.getter(name="approvedPatches")
    def approved_patches(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]:
        return pulumi.get(self, "approved_patches")

    @approved_patches.setter
    def approved_patches(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]):
        pulumi.set(self, "approved_patches", value)

    @property
    @pulumi.getter(name="approvedPatchesComplianceLevel")
    def approved_patches_compliance_level(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "approved_patches_compliance_level")

    @approved_patches_compliance_level.setter
    def approved_patches_compliance_level(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "approved_patches_compliance_level", value)

    @property
    @pulumi.getter(name="approvedPatchesEnableNonSecurity")
    def approved_patches_enable_non_security(self) -> Optional[pulumi.Input[bool]]:
        return pulumi.get(self, "approved_patches_enable_non_security")

    @approved_patches_enable_non_security.setter
    def approved_patches_enable_non_security(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "approved_patches_enable_non_security", value)

    @property
    @pulumi.getter
    def description(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "description")

    @description.setter
    def description(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "description", value)

    @property
    @pulumi.getter(name="globalFilters")
    def global_filters(self) -> Optional[pulumi.Input['PatchBaselinePatchFilterGroupArgs']]:
        return pulumi.get(self, "global_filters")

    @global_filters.setter
    def global_filters(self, value: Optional[pulumi.Input['PatchBaselinePatchFilterGroupArgs']]):
        pulumi.set(self, "global_filters", value)

    @property
    @pulumi.getter(name="operatingSystem")
    def operating_system(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "operating_system")

    @operating_system.setter
    def operating_system(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "operating_system", value)

    @property
    @pulumi.getter(name="patchGroups")
    def patch_groups(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]:
        return pulumi.get(self, "patch_groups")

    @patch_groups.setter
    def patch_groups(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]):
        pulumi.set(self, "patch_groups", value)

    @property
    @pulumi.getter(name="rejectedPatches")
    def rejected_patches(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]:
        return pulumi.get(self, "rejected_patches")

    @rejected_patches.setter
    def rejected_patches(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]):
        pulumi.set(self, "rejected_patches", value)

    @property
    @pulumi.getter(name="rejectedPatchesAction")
    def rejected_patches_action(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "rejected_patches_action")

    @rejected_patches_action.setter
    def rejected_patches_action(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "rejected_patches_action", value)

    @property
    @pulumi.getter
    def sources(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['PatchBaselinePatchSourceArgs']]]]:
        return pulumi.get(self, "sources")

    @sources.setter
    def sources(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['PatchBaselinePatchSourceArgs']]]]):
        pulumi.set(self, "sources", value)

    @property
    @pulumi.getter
    def tags(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['PatchBaselineTagArgs']]]]:
        return pulumi.get(self, "tags")

    @tags.setter
    def tags(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['PatchBaselineTagArgs']]]]):
        pulumi.set(self, "tags", value)


warnings.warn("""PatchBaseline is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.""", DeprecationWarning)


class PatchBaseline(pulumi.CustomResource):
    warnings.warn("""PatchBaseline is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.""", DeprecationWarning)

    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 approval_rules: Optional[pulumi.Input[pulumi.InputType['PatchBaselineRuleGroupArgs']]] = None,
                 approved_patches: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 approved_patches_compliance_level: Optional[pulumi.Input[str]] = None,
                 approved_patches_enable_non_security: Optional[pulumi.Input[bool]] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 global_filters: Optional[pulumi.Input[pulumi.InputType['PatchBaselinePatchFilterGroupArgs']]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 operating_system: Optional[pulumi.Input[str]] = None,
                 patch_groups: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 rejected_patches: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 rejected_patches_action: Optional[pulumi.Input[str]] = None,
                 sources: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['PatchBaselinePatchSourceArgs']]]]] = None,
                 tags: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['PatchBaselineTagArgs']]]]] = None,
                 __props__=None):
        """
        Resource Type definition for AWS::SSM::PatchBaseline

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: PatchBaselineArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Resource Type definition for AWS::SSM::PatchBaseline

        :param str resource_name: The name of the resource.
        :param PatchBaselineArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(PatchBaselineArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 approval_rules: Optional[pulumi.Input[pulumi.InputType['PatchBaselineRuleGroupArgs']]] = None,
                 approved_patches: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 approved_patches_compliance_level: Optional[pulumi.Input[str]] = None,
                 approved_patches_enable_non_security: Optional[pulumi.Input[bool]] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 global_filters: Optional[pulumi.Input[pulumi.InputType['PatchBaselinePatchFilterGroupArgs']]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 operating_system: Optional[pulumi.Input[str]] = None,
                 patch_groups: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 rejected_patches: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 rejected_patches_action: Optional[pulumi.Input[str]] = None,
                 sources: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['PatchBaselinePatchSourceArgs']]]]] = None,
                 tags: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['PatchBaselineTagArgs']]]]] = None,
                 __props__=None):
        pulumi.log.warn("""PatchBaseline is deprecated: PatchBaseline is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.""")
        if opts is None:
            opts = pulumi.ResourceOptions()
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.version is None:
            opts.version = _utilities.get_version()
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = PatchBaselineArgs.__new__(PatchBaselineArgs)

            __props__.__dict__["approval_rules"] = approval_rules
            __props__.__dict__["approved_patches"] = approved_patches
            __props__.__dict__["approved_patches_compliance_level"] = approved_patches_compliance_level
            __props__.__dict__["approved_patches_enable_non_security"] = approved_patches_enable_non_security
            __props__.__dict__["description"] = description
            __props__.__dict__["global_filters"] = global_filters
            if name is None and not opts.urn:
                raise TypeError("Missing required property 'name'")
            __props__.__dict__["name"] = name
            __props__.__dict__["operating_system"] = operating_system
            __props__.__dict__["patch_groups"] = patch_groups
            __props__.__dict__["rejected_patches"] = rejected_patches
            __props__.__dict__["rejected_patches_action"] = rejected_patches_action
            __props__.__dict__["sources"] = sources
            __props__.__dict__["tags"] = tags
        super(PatchBaseline, __self__).__init__(
            'aws-native:ssm:PatchBaseline',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None) -> 'PatchBaseline':
        """
        Get an existing PatchBaseline resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = PatchBaselineArgs.__new__(PatchBaselineArgs)

        __props__.__dict__["approval_rules"] = None
        __props__.__dict__["approved_patches"] = None
        __props__.__dict__["approved_patches_compliance_level"] = None
        __props__.__dict__["approved_patches_enable_non_security"] = None
        __props__.__dict__["description"] = None
        __props__.__dict__["global_filters"] = None
        __props__.__dict__["name"] = None
        __props__.__dict__["operating_system"] = None
        __props__.__dict__["patch_groups"] = None
        __props__.__dict__["rejected_patches"] = None
        __props__.__dict__["rejected_patches_action"] = None
        __props__.__dict__["sources"] = None
        __props__.__dict__["tags"] = None
        return PatchBaseline(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="approvalRules")
    def approval_rules(self) -> pulumi.Output[Optional['outputs.PatchBaselineRuleGroup']]:
        return pulumi.get(self, "approval_rules")

    @property
    @pulumi.getter(name="approvedPatches")
    def approved_patches(self) -> pulumi.Output[Optional[Sequence[str]]]:
        return pulumi.get(self, "approved_patches")

    @property
    @pulumi.getter(name="approvedPatchesComplianceLevel")
    def approved_patches_compliance_level(self) -> pulumi.Output[Optional[str]]:
        return pulumi.get(self, "approved_patches_compliance_level")

    @property
    @pulumi.getter(name="approvedPatchesEnableNonSecurity")
    def approved_patches_enable_non_security(self) -> pulumi.Output[Optional[bool]]:
        return pulumi.get(self, "approved_patches_enable_non_security")

    @property
    @pulumi.getter
    def description(self) -> pulumi.Output[Optional[str]]:
        return pulumi.get(self, "description")

    @property
    @pulumi.getter(name="globalFilters")
    def global_filters(self) -> pulumi.Output[Optional['outputs.PatchBaselinePatchFilterGroup']]:
        return pulumi.get(self, "global_filters")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="operatingSystem")
    def operating_system(self) -> pulumi.Output[Optional[str]]:
        return pulumi.get(self, "operating_system")

    @property
    @pulumi.getter(name="patchGroups")
    def patch_groups(self) -> pulumi.Output[Optional[Sequence[str]]]:
        return pulumi.get(self, "patch_groups")

    @property
    @pulumi.getter(name="rejectedPatches")
    def rejected_patches(self) -> pulumi.Output[Optional[Sequence[str]]]:
        return pulumi.get(self, "rejected_patches")

    @property
    @pulumi.getter(name="rejectedPatchesAction")
    def rejected_patches_action(self) -> pulumi.Output[Optional[str]]:
        return pulumi.get(self, "rejected_patches_action")

    @property
    @pulumi.getter
    def sources(self) -> pulumi.Output[Optional[Sequence['outputs.PatchBaselinePatchSource']]]:
        return pulumi.get(self, "sources")

    @property
    @pulumi.getter
    def tags(self) -> pulumi.Output[Optional[Sequence['outputs.PatchBaselineTag']]]:
        return pulumi.get(self, "tags")

