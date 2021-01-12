/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20190801
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2021, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Management.Automation;
using Oci.OsmanagementService.Requests;
using Oci.OsmanagementService.Responses;
using Oci.OsmanagementService.Models;

namespace Oci.OsmanagementService.Cmdlets
{
    [Cmdlet("Get", "OCIOsmanagementErratum")]
    [OutputType(new System.Type[] { typeof(Oci.OsmanagementService.Models.Erratum), typeof(Oci.OsmanagementService.Responses.GetErratumResponse) })]
    public class GetOCIOsmanagementErratum : OCIOsManagementCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The OCID of the erratum.")]
        public string ErratumId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The client request ID for tracing.")]
        public string OpcRequestId { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            GetErratumRequest request;

            try
            {
                request = new GetErratumRequest
                {
                    ErratumId = ErratumId,
                    OpcRequestId = OpcRequestId
                };

                response = client.GetErratum(request).GetAwaiter().GetResult();
                WriteOutput(response, response.Erratum);
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

        private GetErratumResponse response;
    }
}
