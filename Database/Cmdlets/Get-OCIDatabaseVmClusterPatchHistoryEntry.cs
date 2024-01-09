/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20160918
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Management.Automation;
using Oci.DatabaseService.Requests;
using Oci.DatabaseService.Responses;
using Oci.DatabaseService.Models;
using Oci.Common.Model;

namespace Oci.DatabaseService.Cmdlets
{
    [Cmdlet("Get", "OCIDatabaseVmClusterPatchHistoryEntry")]
    [OutputType(new System.Type[] { typeof(Oci.DatabaseService.Models.PatchHistoryEntry), typeof(Oci.DatabaseService.Responses.GetVmClusterPatchHistoryEntryResponse) })]
    public class GetOCIDatabaseVmClusterPatchHistoryEntry : OCIDatabaseCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The VM cluster [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm).")]
        public string VmClusterId { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the patch history entry.")]
        public string PatchHistoryEntryId { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            GetVmClusterPatchHistoryEntryRequest request;

            try
            {
                request = new GetVmClusterPatchHistoryEntryRequest
                {
                    VmClusterId = VmClusterId,
                    PatchHistoryEntryId = PatchHistoryEntryId
                };

                response = client.GetVmClusterPatchHistoryEntry(request).GetAwaiter().GetResult();
                WriteOutput(response, response.PatchHistoryEntry);
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

        private GetVmClusterPatchHistoryEntryResponse response;
    }
}
