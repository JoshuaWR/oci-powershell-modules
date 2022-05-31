/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20181231
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Management.Automation;
using Oci.CimsService.Requests;
using Oci.CimsService.Responses;
using Oci.CimsService.Models;
using Oci.Common.Model;

namespace Oci.CimsService.Cmdlets
{
    [Cmdlet("New", "OCICimsIncident")]
    [OutputType(new System.Type[] { typeof(Oci.CimsService.Models.Incident), typeof(Oci.CimsService.Responses.CreateIncidentResponse) })]
    public class NewOCICimsIncident : OCIIncidentCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Incident information")]
        public CreateIncident CreateIncidentDetails { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"User OCID for Oracle Identity Cloud Service (IDCS) users who also have a federated Oracle Cloud Infrastructure account.")]
        public string Ocid { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Unique Oracle-assigned identifier for the request. If you need to contact Oracle about a particular request, please provide the request ID.")]
        public string OpcRequestId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The region of the tenancy.")]
        public string Homeregion { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            CreateIncidentRequest request;

            try
            {
                request = new CreateIncidentRequest
                {
                    CreateIncidentDetails = CreateIncidentDetails,
                    Ocid = Ocid,
                    OpcRequestId = OpcRequestId,
                    Homeregion = Homeregion
                };

                response = client.CreateIncident(request).GetAwaiter().GetResult();
                WriteOutput(response, response.Incident);
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

        private CreateIncidentResponse response;
    }
}
