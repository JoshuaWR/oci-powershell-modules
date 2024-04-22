/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20220126
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Management.Automation;
using Oci.LockboxService.Requests;
using Oci.LockboxService.Responses;
using Oci.LockboxService.Models;
using Oci.Common.Model;

namespace Oci.LockboxService.Cmdlets
{
    /*
     * As per https://github.com/PowerShell/PowerShell/issues/11143, this cmdlet is marked with a default parameter set for proper resolution of the invoked parameter set.
     * Parameter set "Default" contains all the parameters that are defined in this class(including base classes) and are not explicitly tagged with a ParameterSetName.
     */
    [Cmdlet("Export", "OCILockboxAccessRequests", DefaultParameterSetName = Default)]
    [OutputType(new System.Type[] { typeof(System.IO.Stream), typeof(void), typeof(Oci.LockboxService.Responses.ExportAccessRequestsResponse) })]
    public class ExportOCILockboxAccessRequests : OCILockboxCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Exports the list of access requests for given date range in text format")]
        public ExportAccessRequestsDetails ExportAccessRequestsDetails { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The client request ID for tracing.")]
        public string OpcRequestId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"A generic Id query param used to filter lockbox, access request and approval template by Id.")]
        public string Id { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"A filter to return only resources that match the entire display name given.")]
        public string DisplayName { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"A filter to return only resources their lifecycleState matches the given lifecycleState.")]
        public System.Nullable<Oci.LockboxService.Models.AccessRequest.LifecycleStateEnum> LifecycleState { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The name of the lockbox partner.")]
        public System.Nullable<Oci.LockboxService.Models.LockboxPartner> LockboxPartner { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID of the partner.")]
        public string PartnerId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The unique identifier (OCID) of the requestor in which to list resources.")]
        public string RequestorId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The maximum number of items to return.")]
        public System.Nullable<int> Limit { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"A token representing the position at which to start retrieving results. This must come from the `opc-next-page` header field of a previous response.")]
        public string Page { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The sort order to use, either 'ASC' or 'DESC'.")]
        public System.Nullable<Oci.LockboxService.Models.SortOrder> SortOrder { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The field to sort by. Only one sort order may be provided. Default order for timeCreated is descending. Default order for displayName is ascending.")]
        public System.Nullable<Oci.LockboxService.Requests.ExportAccessRequestsRequest.SortByEnum> SortBy { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = "Path to the output file.", ParameterSetName = WriteToFileSet)]
        public string OutputFile { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = "Output the complete response returned by the API Operation. Using this switch will make this Cmdlet output an object containing response headers in-addition to an optional response body.", ParameterSetName = FullResponseSet)]
        public override SwitchParameter FullResponse { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            ExportAccessRequestsRequest request;

            try
            {
                request = new ExportAccessRequestsRequest
                {
                    ExportAccessRequestsDetails = ExportAccessRequestsDetails,
                    OpcRequestId = OpcRequestId,
                    Id = Id,
                    DisplayName = DisplayName,
                    LifecycleState = LifecycleState,
                    LockboxPartner = LockboxPartner,
                    PartnerId = PartnerId,
                    RequestorId = RequestorId,
                    Limit = Limit,
                    Page = Page,
                    SortOrder = SortOrder,
                    SortBy = SortBy
                };

                response = client.ExportAccessRequests(request).GetAwaiter().GetResult();
                HandleOutput();
                
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

        private void HandleOutput()
        {
            if (ParameterSetName.Equals(WriteToFileSet))
            {
                WriteToOutputFile(OutputFile, response.InputStream);
            }
            else
            {
                WriteOutput(response, response.InputStream);
            }
        }

        private ExportAccessRequestsResponse response;
        private const string Default = "Default";
        private const string WriteToFileSet = "WriteToFile";
        private const string FullResponseSet = "FullResponse";
    }
}
