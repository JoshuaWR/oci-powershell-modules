/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20210201
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Management.Automation;
using Oci.QueueService.Requests;
using Oci.QueueService.Responses;
using Oci.QueueService.Models;
using Oci.Common.Model;

namespace Oci.QueueService.Cmdlets
{
    [Cmdlet("Get", "OCIQueueChannelsList")]
    [OutputType(new System.Type[] { typeof(Oci.QueueService.Models.ChannelCollection), typeof(Oci.QueueService.Responses.ListChannelsResponse) })]
    public class GetOCIQueueChannelsList : OCIQueueCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The unique queue identifier.")]
        public string QueueId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Unique Oracle-assigned identifier for the request. If you need to contact Oracle about a particular request, please provide the request ID.")]
        public string OpcRequestId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"For list pagination. The maximum number of results per page, or items to return in a paginated ""List"" call. For important details about how pagination works, see [List Pagination](https://docs.cloud.oracle.com/iaas/Content/API/Concepts/usingapi.htm#nine).")]
        public System.Nullable<int> Limit { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"For list pagination. The value of the opc-next-page response header from the previous ""List"" call. For important details about how pagination works, see [List Pagination](https://docs.cloud.oracle.com/iaas/Content/API/Concepts/usingapi.htm#nine).")]
        public string Page { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Optional parameter to filter the channels.")]
        public string ChannelFilter { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            ListChannelsRequest request;

            try
            {
                request = new ListChannelsRequest
                {
                    QueueId = QueueId,
                    OpcRequestId = OpcRequestId,
                    Limit = Limit,
                    Page = Page,
                    ChannelFilter = ChannelFilter
                };

                response = client.ListChannels(request).GetAwaiter().GetResult();
                WriteOutput(response, response.ChannelCollection);
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

        private ListChannelsResponse response;
    }
}
