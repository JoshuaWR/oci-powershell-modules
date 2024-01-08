/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20180418
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Management.Automation;
using Oci.StreamingService.Requests;
using Oci.StreamingService.Responses;
using Oci.StreamingService.Models;
using Oci.Common.Model;

namespace Oci.StreamingService.Cmdlets
{
    [Cmdlet("Update", "OCIStreamingGroup")]
    [OutputType(new System.Type[] { typeof(void), typeof(Oci.StreamingService.Responses.UpdateGroupResponse) })]
    public class UpdateOCIStreamingGroup : OCIStreamCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The OCID of the stream.")]
        public string StreamId { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The name of the consumer group.")]
        public string GroupName { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The information used to modify the group.")]
        public UpdateGroupDetails UpdateGroupDetails { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The unique Oracle-assigned identifier for the request. If you need to contact Oracle about a particular request, please provide the request ID.")]
        public string OpcRequestId { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            UpdateGroupRequest request;

            try
            {
                request = new UpdateGroupRequest
                {
                    StreamId = StreamId,
                    GroupName = GroupName,
                    UpdateGroupDetails = UpdateGroupDetails,
                    OpcRequestId = OpcRequestId
                };

                response = client.UpdateGroup(request).GetAwaiter().GetResult();
                WriteOutput(response);
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

        private UpdateGroupResponse response;
    }
}
