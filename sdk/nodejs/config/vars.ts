// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

let __config = new pulumi.Config("aws-native");

/**
 * the region to use for deployments
 */
export let region: string | undefined = __config.get("region");
/**
 * the name of the stack to use for deployments
 */
export let stack: string | undefined = __config.get("stack");
