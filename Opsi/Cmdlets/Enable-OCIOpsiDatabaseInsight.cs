/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20200630
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Management.Automation;
using Oci.OpsiService.Requests;
using Oci.OpsiService.Responses;
using Oci.OpsiService.Models;
using Oci.Common.Model;

namespace Oci.OpsiService.Cmdlets
{
    [Cmdlet("Enable", "OCIOpsiDatabaseInsight")]
    [OutputType(new System.Type[] { typeof(Oci.PSModules.Common.Cmdlets.WorkRequest), typeof(Oci.OpsiService.Responses.EnableDatabaseInsightResponse) })]
    public class EnableOCIOpsiDatabaseInsight : OCIOperationsInsightsCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Details for the database to be enabled in Operations Insights. This parameter also accepts subtypes <Oci.OpsiService.Models.EnableEmManagedExternalDatabaseInsightDetails>, <Oci.OpsiService.Models.EnablePeComanagedDatabaseInsightDetails> of type <Oci.OpsiService.Models.EnableDatabaseInsightDetails>.")]
        public EnableDatabaseInsightDetails EnableDatabaseInsightDetails { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Unique database insight identifier")]
        public string DatabaseInsightId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Used for optimistic concurrency control. In the update or delete call for a resource, set the `if-match` parameter to the value of the etag from a previous get, create, or update response for that resource.  The resource will be updated or deleted only if the etag you provide matches the resource's current etag value.")]
        public string IfMatch { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Unique Oracle-assigned identifier for the request. If you need to contact Oracle about a particular request, please provide the request ID.")]
        public string OpcRequestId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"A token that uniquely identifies a request that can be retried in case of a timeout or server error without risk of executing the same action again. Retry tokens expire after 24 hours.

*Note:* Retry tokens can be invalidated before the 24 hour time limit due to conflicting operations, such as a resource being deleted or purged from the system.")]
        public string OpcRetryToken { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            EnableDatabaseInsightRequest request;

            try
            {
                request = new EnableDatabaseInsightRequest
                {
                    EnableDatabaseInsightDetails = EnableDatabaseInsightDetails,
                    DatabaseInsightId = DatabaseInsightId,
                    IfMatch = IfMatch,
                    OpcRequestId = OpcRequestId,
                    OpcRetryToken = OpcRetryToken
                };

                response = client.EnableDatabaseInsight(request).GetAwaiter().GetResult();
                WriteOutput(response, CreateWorkRequestObject(response.OpcWorkRequestId));
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

        private EnableDatabaseInsightResponse response;
    }
}
