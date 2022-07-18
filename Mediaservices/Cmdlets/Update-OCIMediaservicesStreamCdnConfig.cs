/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20211101
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Management.Automation;
using Oci.MediaservicesService.Requests;
using Oci.MediaservicesService.Responses;
using Oci.MediaservicesService.Models;
using Oci.Common.Model;

namespace Oci.MediaservicesService.Cmdlets
{
    [Cmdlet("Update", "OCIMediaservicesStreamCdnConfig")]
    [OutputType(new System.Type[] { typeof(Oci.MediaservicesService.Models.StreamCdnConfig), typeof(Oci.MediaservicesService.Responses.UpdateStreamCdnConfigResponse) })]
    public class UpdateOCIMediaservicesStreamCdnConfig : OCIMediaServicesCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Unique StreamCdnConfig identifier.")]
        public string StreamCdnConfigId { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The information to be updated.")]
        public UpdateStreamCdnConfigDetails UpdateStreamCdnConfigDetails { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"For optimistic concurrency control. In the PUT or DELETE call for a resource, set the `if-match` parameter to the value of the etag from a previous GET or POST response for that resource. The resource will be updated or deleted only if the etag you provide matches the resource's current etag value.")]
        public string IfMatch { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The client request ID for tracing.")]
        public string OpcRequestId { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            UpdateStreamCdnConfigRequest request;

            try
            {
                request = new UpdateStreamCdnConfigRequest
                {
                    StreamCdnConfigId = StreamCdnConfigId,
                    UpdateStreamCdnConfigDetails = UpdateStreamCdnConfigDetails,
                    IfMatch = IfMatch,
                    OpcRequestId = OpcRequestId
                };

                response = client.UpdateStreamCdnConfig(request).GetAwaiter().GetResult();
                WriteOutput(response, response.StreamCdnConfig);
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

        private UpdateStreamCdnConfigResponse response;
    }
}
