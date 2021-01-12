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
    [Cmdlet("Get", "OCIDatabaseDbSystemPatch")]
    [OutputType(new System.Type[] { typeof(Oci.DatabaseService.Models.Patch), typeof(Oci.DatabaseService.Responses.GetDbSystemPatchResponse) })]
    public class GetOCIDatabaseDbSystemPatch : OCIDatabaseCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The DB system [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm).")]
        public string DbSystemId { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the patch.")]
        public string PatchId { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            GetDbSystemPatchRequest request;

            try
            {
                request = new GetDbSystemPatchRequest
                {
                    DbSystemId = DbSystemId,
                    PatchId = PatchId
                };

                response = client.GetDbSystemPatch(request).GetAwaiter().GetResult();
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

        private GetDbSystemPatchResponse response;
    }
}
