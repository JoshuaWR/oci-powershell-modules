/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20220528
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Management.Automation;
using Oci.FleetsoftwareupdateService.Requests;
using Oci.FleetsoftwareupdateService.Responses;
using Oci.FleetsoftwareupdateService.Models;
using Oci.Common.Model;

namespace Oci.FleetsoftwareupdateService.Cmdlets
{
    [Cmdlet("Update", "OCIFleetsoftwareupdateFsuAction")]
    [OutputType(new System.Type[] { typeof(Oci.PSModules.Common.Cmdlets.WorkRequest), typeof(Oci.FleetsoftwareupdateService.Responses.UpdateFsuActionResponse) })]
    public class UpdateOCIFleetsoftwareupdateFsuAction : OCIFleetSoftwareUpdateCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Unique Exadata Fleet Update Action identifier.")]
        public string FsuActionId { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The Exadata Fleet Update Action details to be updated. This parameter also accepts subtypes <Oci.FleetsoftwareupdateService.Models.UpdateStageActionDetails>, <Oci.FleetsoftwareupdateService.Models.UpdateApplyActionDetails>, <Oci.FleetsoftwareupdateService.Models.UpdateRollbackActionDetails>, <Oci.FleetsoftwareupdateService.Models.UpdatePrecheckActionDetails>, <Oci.FleetsoftwareupdateService.Models.UpdateCleanupActionDetails> of type <Oci.FleetsoftwareupdateService.Models.UpdateFsuActionDetails>.")]
        public UpdateFsuActionDetails UpdateFsuActionDetails { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"For optimistic concurrency control. In the PUT or DELETE call for a resource, set the `if-match` parameter to the value of the etag from a previous GET or POST response for that resource. The resource will be updated or deleted only if the etag you provide matches the resource's current etag value.")]
        public string IfMatch { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The client request ID for tracing.")]
        public string OpcRequestId { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            UpdateFsuActionRequest request;

            try
            {
                request = new UpdateFsuActionRequest
                {
                    FsuActionId = FsuActionId,
                    UpdateFsuActionDetails = UpdateFsuActionDetails,
                    IfMatch = IfMatch,
                    OpcRequestId = OpcRequestId
                };

                response = client.UpdateFsuAction(request).GetAwaiter().GetResult();
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

        private UpdateFsuActionResponse response;
    }
}
