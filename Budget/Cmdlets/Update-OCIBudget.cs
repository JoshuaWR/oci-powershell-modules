/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20190111
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Management.Automation;
using Oci.BudgetService.Requests;
using Oci.BudgetService.Responses;
using Oci.BudgetService.Models;
using Oci.Common.Model;

namespace Oci.BudgetService.Cmdlets
{
    [Cmdlet("Update", "OCIBudget")]
    [OutputType(new System.Type[] { typeof(Oci.BudgetService.Models.Budget), typeof(Oci.BudgetService.Responses.UpdateBudgetResponse) })]
    public class UpdateOCIBudget : OCIBudgetCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The unique budget OCID.")]
        public string BudgetId { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The information to be updated.")]
        public UpdateBudgetDetails UpdateBudgetDetails { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"For optimistic concurrency control. In the PUT or DELETE call for a resource, set the `if-match` parameter to the value of the etag from a previous GET or POST response for that resource. The resource will be updated or deleted only if the etag you provide matches the resource's current etag value.")]
        public string IfMatch { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The client request ID for tracing.")]
        public string OpcRequestId { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            UpdateBudgetRequest request;

            try
            {
                request = new UpdateBudgetRequest
                {
                    BudgetId = BudgetId,
                    UpdateBudgetDetails = UpdateBudgetDetails,
                    IfMatch = IfMatch,
                    OpcRequestId = OpcRequestId
                };

                response = client.UpdateBudget(request).GetAwaiter().GetResult();
                WriteOutput(response, response.Budget);
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

        private UpdateBudgetResponse response;
    }
}
