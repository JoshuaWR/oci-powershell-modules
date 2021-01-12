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
    [Cmdlet("New", "OCIDatascienceModel")]
    [OutputType(new System.Type[] { typeof(Oci.DatascienceService.Models.Model), typeof(Oci.DatascienceService.Responses.CreateModelResponse) })]
    public class NewOCIDatascienceModel : OCIDataScienceCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Details for creating a new model.")]
        public CreateModelDetails CreateModelDetails { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Unique Oracle-assigned identifier for the request. If you need to contact Oracle about a particular request, please provide the request ID.")]
        public string OpcRequestId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"A token that uniquely identifies a request so it can be retried in case of a timeout or server error without risk of executing that same action again. Retry tokens expire after 24 hours, but can be invalidated before then due to conflicting operations. For example, if a resource has been deleted and purged from the system, then a retry of the original creation request might be rejected.")]
        public string OpcRetryToken { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            CreateModelRequest request;

            try
            {
                request = new CreateModelRequest
                {
                    CreateModelDetails = CreateModelDetails,
                    OpcRequestId = OpcRequestId,
                    OpcRetryToken = OpcRetryToken
                };

                response = client.CreateModel(request).GetAwaiter().GetResult();
                WriteOutput(response, response.Model);
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

        private CreateModelResponse response;
    }
}
