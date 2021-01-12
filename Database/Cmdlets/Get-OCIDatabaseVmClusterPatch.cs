/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20160918
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2021, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Management.Automation;
using Oci.DatabaseService.Requests;
using Oci.DatabaseService.Responses;
using Oci.DatabaseService.Models;

namespace Oci.DatabaseService.Cmdlets
{
    [Cmdlet("Get", "OCIDatabaseVmClusterPatch")]
    [OutputType(new System.Type[] { typeof(Oci.DatabaseService.Models.Patch), typeof(Oci.DatabaseService.Responses.GetVmClusterPatchResponse) })]
    public class GetOCIDatabaseVmClusterPatch : OCIDatabaseCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The VM cluster [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm).")]
        public string VmClusterId { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the patch.")]
        public string PatchId { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            GetVmClusterPatchRequest request;

            try
            {
                request = new GetVmClusterPatchRequest
                {
                    VmClusterId = VmClusterId,
                    PatchId = PatchId
                };

                response = client.GetVmClusterPatch(request).GetAwaiter().GetResult();
                WriteOutput(response, response.Patch);
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

        private GetVmClusterPatchResponse response;
    }
}
