/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20220915
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2023, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Management.Automation;
using Oci.PsqlService.Requests;
using Oci.PsqlService.Responses;
using Oci.PsqlService.Models;
using Oci.Common.Model;

namespace Oci.PsqlService.Cmdlets
{
    [Cmdlet("Update", "OCIPsqlDbSystemDbInstance")]
    [OutputType(new System.Type[] { typeof(Oci.PSModules.Common.Cmdlets.WorkRequest), typeof(Oci.PsqlService.Responses.UpdateDbSystemDbInstanceResponse) })]
    public class UpdateOCIPsqlDbSystemDbInstance : OCIPostgresqlCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"unique DbSystem identifier")]
        public string DbSystemId { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"unique DbInstance identifier")]
        public string DbInstanceId { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"DdInstance update parameters.")]
        public UpdateDbSystemDbInstanceDetails UpdateDbSystemDbInstanceDetails { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"For optimistic concurrency control. In the PUT or DELETE call")]
        public string IfMatch { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The client request ID for tracing.")]
        public string OpcRequestId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"A token that uniquely identifies a request so it can be retried in case of a timeout or")]
        public string OpcRetryToken { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            UpdateDbSystemDbInstanceRequest request;

            try
            {
                request = new UpdateDbSystemDbInstanceRequest
                {
                    DbSystemId = DbSystemId,
                    DbInstanceId = DbInstanceId,
                    UpdateDbSystemDbInstanceDetails = UpdateDbSystemDbInstanceDetails,
                    IfMatch = IfMatch,
                    OpcRequestId = OpcRequestId,
                    OpcRetryToken = OpcRetryToken
                };

                response = client.UpdateDbSystemDbInstance(request).GetAwaiter().GetResult();
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

        private UpdateDbSystemDbInstanceResponse response;
    }
}
