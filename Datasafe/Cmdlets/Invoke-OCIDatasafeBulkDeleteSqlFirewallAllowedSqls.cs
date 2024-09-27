/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20181201
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Management.Automation;
using Oci.DatasafeService.Requests;
using Oci.DatasafeService.Responses;
using Oci.DatasafeService.Models;
using Oci.Common.Model;

namespace Oci.DatasafeService.Cmdlets
{
    [Cmdlet("Invoke", "OCIDatasafeBulkDeleteSqlFirewallAllowedSqls")]
    [OutputType(new System.Type[] { typeof(Oci.PSModules.Common.Cmdlets.WorkRequest), typeof(Oci.DatasafeService.Responses.BulkDeleteSqlFirewallAllowedSqlsResponse) })]
    public class InvokeOCIDatasafeBulkDeleteSqlFirewallAllowedSqls : OCIDataSafeCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Details of the allowed sql to be deleted from the SQL firewall policy.")]
        public BulkDeleteSqlFirewallAllowedSqlsDetails BulkDeleteSqlFirewallAllowedSqlsDetails { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Unique identifier for the request.")]
        public string OpcRequestId { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            BulkDeleteSqlFirewallAllowedSqlsRequest request;

            try
            {
                request = new BulkDeleteSqlFirewallAllowedSqlsRequest
                {
                    BulkDeleteSqlFirewallAllowedSqlsDetails = BulkDeleteSqlFirewallAllowedSqlsDetails,
                    OpcRequestId = OpcRequestId
                };

                response = client.BulkDeleteSqlFirewallAllowedSqls(request).GetAwaiter().GetResult();
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

        private BulkDeleteSqlFirewallAllowedSqlsResponse response;
    }
}
