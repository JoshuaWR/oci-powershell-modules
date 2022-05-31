/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20160918
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates.
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
    [Cmdlet("Get", "OCIDatabaseExadataInfrastructureOcpus")]
    [OutputType(new System.Type[] { typeof(Oci.DatabaseService.Models.OCPUs), typeof(Oci.DatabaseService.Responses.GetExadataInfrastructureOcpusResponse) })]
    public class GetOCIDatabaseExadataInfrastructureOcpus : OCIDatabaseCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The Autonomous Exadata Infrastructure  [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm).")]
        public string AutonomousExadataInfrastructureId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Unique identifier for the request.")]
        public string OpcRequestId { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            GetExadataInfrastructureOcpusRequest request;

            try
            {
                request = new GetExadataInfrastructureOcpusRequest
                {
                    AutonomousExadataInfrastructureId = AutonomousExadataInfrastructureId,
                    OpcRequestId = OpcRequestId
                };

                response = client.GetExadataInfrastructureOcpus(request).GetAwaiter().GetResult();
                WriteOutput(response, response.OCPUs);
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

        private GetExadataInfrastructureOcpusResponse response;
    }
}
