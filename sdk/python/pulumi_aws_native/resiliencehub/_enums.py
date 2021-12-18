# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

from enum import Enum

__all__ = [
    'ResiliencyPolicyDataLocationConstraint',
    'ResiliencyPolicyTier',
]


class ResiliencyPolicyDataLocationConstraint(str, Enum):
    """
    Data Location Constraint of the Policy.
    """
    ANY_LOCATION = "AnyLocation"
    SAME_CONTINENT = "SameContinent"
    SAME_COUNTRY = "SameCountry"


class ResiliencyPolicyTier(str, Enum):
    """
    Resiliency Policy Tier.
    """
    MISSION_CRITICAL = "MissionCritical"
    CRITICAL = "Critical"
    IMPORTANT = "Important"
    CORE_SERVICES = "CoreServices"
    NON_CRITICAL = "NonCritical"
