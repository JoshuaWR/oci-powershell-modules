/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 1.0.015
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2021, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Management.Automation;
using Oci.DtsService.Requests;
using Oci.DtsService.Responses;
using Oci.DtsService.Models;

namespace Oci.DtsService.Cmdlets
{
    [Cmdlet("Remove", "OCIDtsApplianceExportJob", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.High)]
    [OutputType(new System.Type[] { typeof(void), typeof(Oci.DtsService.Responses.DeleteApplianceExportJobResponse) })]
    public class RemoveOCIDtsApplianceExportJob : OCIApplianceExportJobCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"ID of the Appliance Export Job")]
        public string ApplianceExportJobId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The entity tag to match. Optional, if set, the update will be successful only if the object's tag matches the tag specified in the request.")]
        public string IfMatch { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Unique Oracle-assigned identifier for the request. If you need to contact Oracle about a particular request, please provide the request ID.")]
        public string OpcRequestId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = "Ignore confirmation and force the Cmdlet to complete action.")]
        public SwitchParameter Force { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();

            if (!ConfirmDelete("OCIDtsApplianceExportJob", "Remove"))
            {
               return;
            }

            DeleteApplianceExportJobRequest request;

            try
            {
                request = new DeleteApplianceExportJobRequest
                {
                    ApplianceExportJobId = ApplianceExportJobId,
                    IfMatch = IfMatch,
                    OpcRequestId = OpcRequestId
                };

                response = client.DeleteApplianceExportJob(request).GetAwaiter().GetResult();
                WriteOutput(response);
                FinishProcessing(response);
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

        private DeleteApplianceExportJobResponse response;
    }
}
