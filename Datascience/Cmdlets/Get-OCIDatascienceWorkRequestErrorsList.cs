/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20190101
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2021, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Management.Automation;
using Oci.DatascienceService.Requests;
using Oci.DatascienceService.Responses;
using Oci.DatascienceService.Models;

namespace Oci.DatascienceService.Cmdlets
{
    [Cmdlet("Get", "OCIDatascienceWorkRequestErrorsList")]
    [OutputType(new System.Type[] { typeof(Oci.DatascienceService.Models.WorkRequestError), typeof(Oci.DatascienceService.Responses.ListWorkRequestErrorsResponse) })]
    public class GetOCIDatascienceWorkRequestErrorsList : OCIDataScienceCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The [OCID](https://docs.cloud.oracle.com/iaas/Content/API/Concepts/identifiers.htm) of the work request.")]
        public string WorkRequestId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Unique Oracle-assigned identifier for the request. If you need to contact Oracle about a particular request, please provide the request ID.")]
        public string OpcRequestId { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            ListWorkRequestErrorsRequest request;

            try
            {
                request = new ListWorkRequestErrorsRequest
                {
                    WorkRequestId = WorkRequestId,
                    OpcRequestId = OpcRequestId
                };

                response = client.ListWorkRequestErrors(request).GetAwaiter().GetResult();
                WriteOutput(response, response.Items, true);
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

        private ListWorkRequestErrorsResponse response;
    }
}
