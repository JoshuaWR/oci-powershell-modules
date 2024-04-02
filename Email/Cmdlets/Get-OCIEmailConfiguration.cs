/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20170907
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Management.Automation;
using Oci.EmailService.Requests;
using Oci.EmailService.Responses;
using Oci.EmailService.Models;
using Oci.Common.Model;

namespace Oci.EmailService.Cmdlets
{
    [Cmdlet("Get", "OCIEmailConfiguration")]
    [OutputType(new System.Type[] { typeof(Oci.EmailService.Models.Configuration), typeof(Oci.EmailService.Responses.GetEmailConfigurationResponse) })]
    public class GetOCIEmailConfiguration : OCIEmailCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The OCID for the compartment.")]
        public string CompartmentId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The request ID for tracing from the system")]
        public string OpcRequestId { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            GetEmailConfigurationRequest request;

            try
            {
                request = new GetEmailConfigurationRequest
                {
                    CompartmentId = CompartmentId,
                    OpcRequestId = OpcRequestId
                };

                response = client.GetEmailConfiguration(request).GetAwaiter().GetResult();
                WriteOutput(response, response.Configuration);
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

        private GetEmailConfigurationResponse response;
    }
}
