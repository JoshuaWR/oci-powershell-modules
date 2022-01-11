/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20190331
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Management.Automation;
using Oci.AnalyticsService.Requests;
using Oci.AnalyticsService.Responses;
using Oci.AnalyticsService.Models;

namespace Oci.AnalyticsService.Cmdlets
{
    [Cmdlet("Update", "OCIAnalyticsInstance")]
    [OutputType(new System.Type[] { typeof(Oci.AnalyticsService.Models.AnalyticsInstance), typeof(Oci.AnalyticsService.Responses.UpdateAnalyticsInstanceResponse) })]
    public class UpdateOCIAnalyticsInstance : OCIAnalyticsCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The OCID of the AnalyticsInstance.")]
        public string AnalyticsInstanceId { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The Analytics Instance fields to update. Fields that are not provided will not be updated.")]
        public UpdateAnalyticsInstanceDetails UpdateAnalyticsInstanceDetails { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"For optimistic concurrency control. In the PUT or DELETE call for a resource, set the `if-match` parameter to the value of the etag from a previous GET or POST response for that resource.  The resource will be updated or deleted only if the etag you provide matches the resource's current etag value.")]
        public string IfMatch { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Unique identifier for the request. If you need to contact Oracle about a particular request, please provide the request ID.")]
        public string OpcRequestId { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            UpdateAnalyticsInstanceRequest request;

            try
            {
                request = new UpdateAnalyticsInstanceRequest
                {
                    AnalyticsInstanceId = AnalyticsInstanceId,
                    UpdateAnalyticsInstanceDetails = UpdateAnalyticsInstanceDetails,
                    IfMatch = IfMatch,
                    OpcRequestId = OpcRequestId
                };

                response = client.UpdateAnalyticsInstance(request).GetAwaiter().GetResult();
                WriteOutput(response, response.AnalyticsInstance);
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

        private UpdateAnalyticsInstanceResponse response;
    }
}
