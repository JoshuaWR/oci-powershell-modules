/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20180222
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Management.Automation;
using Oci.ContainerengineService.Requests;
using Oci.ContainerengineService.Responses;
using Oci.ContainerengineService.Models;
using Oci.Common.Model;

namespace Oci.ContainerengineService.Cmdlets
{
    [Cmdlet("Update", "OCIContainerengineNodePool")]
    [OutputType(new System.Type[] { typeof(Oci.PSModules.Common.Cmdlets.WorkRequest), typeof(Oci.ContainerengineService.Responses.UpdateNodePoolResponse) })]
    public class UpdateOCIContainerengineNodePool : OCIContainerEngineCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The OCID of the node pool.")]
        public string NodePoolId { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The fields to update in a node pool.")]
        public UpdateNodePoolDetails UpdateNodePoolDetails { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"For optimistic concurrency control. In the PUT or DELETE call for a resource, set the `if-match` parameter to the value of the etag from a previous GET or POST response for that resource.  The resource will be updated or deleted only if the etag you provide matches the resource's current etag value.")]
        public string IfMatch { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Unique Oracle-assigned identifier for the request. If you need to contact Oracle about a particular request, please provide the request ID.")]
        public string OpcRequestId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Duration after which OKE will give up eviction of the pods on the node. PT0M will indicate you want to delete the node without cordon and drain. Default PT60M, Min PT0M, Max: PT60M. Format ISO 8601 e.g PT30M")]
        public string OverrideEvictionGraceDuration { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"If the underlying compute instance should be deleted if you cannot evict all the pods in grace period")]
        public System.Nullable<bool> IsForceDeletionAfterOverrideGraceDuration { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            UpdateNodePoolRequest request;

            try
            {
                request = new UpdateNodePoolRequest
                {
                    NodePoolId = NodePoolId,
                    UpdateNodePoolDetails = UpdateNodePoolDetails,
                    IfMatch = IfMatch,
                    OpcRequestId = OpcRequestId,
                    OverrideEvictionGraceDuration = OverrideEvictionGraceDuration,
                    IsForceDeletionAfterOverrideGraceDuration = IsForceDeletionAfterOverrideGraceDuration
                };

                response = client.UpdateNodePool(request).GetAwaiter().GetResult();
                WriteOutput(response, CreateWorkRequestObject(response.OpcWorkRequestId));
                FinishProcessing(response);
            }
            catch (OciException ex)
            {
                TerminatingErrorDuringExecution(ex);
            }
            catch (Exception ex)
            {
                TerminatingErrorDuringExecution(ex);
            }
        }

        protected override void StopProcessing()
        {
            base.StopProcessing();
            TerminatingErrorDuringExecution(new OperationCanceledException("Cmdlet execution interrupted"));
        }

        private UpdateNodePoolResponse response;
    }
}
