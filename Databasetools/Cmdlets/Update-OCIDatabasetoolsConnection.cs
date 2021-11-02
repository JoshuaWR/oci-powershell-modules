/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20201005
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2021, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Management.Automation;
using Oci.DatabasetoolsService.Requests;
using Oci.DatabasetoolsService.Responses;
using Oci.DatabasetoolsService.Models;

namespace Oci.DatabasetoolsService.Cmdlets
{
    [Cmdlet("Update", "OCIDatabasetoolsConnection")]
    [OutputType(new System.Type[] { typeof(Oci.PSModules.Common.Cmdlets.WorkRequest), typeof(Oci.DatabasetoolsService.Responses.UpdateDatabaseToolsConnectionResponse) })]
    public class UpdateOCIDatabasetoolsConnection : OCIDatabaseToolsCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of a DatabaseToolsConnection.")]
        public string DatabaseToolsConnectionId { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The information to be updated. This parameter also accepts subtype <Oci.DatabasetoolsService.Models.UpdateDatabaseToolsConnectionOracleDatabaseDetails> of type <Oci.DatabasetoolsService.Models.UpdateDatabaseToolsConnectionDetails>.")]
        public UpdateDatabaseToolsConnectionDetails UpdateDatabaseToolsConnectionDetails { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"For optimistic concurrency control. In the PUT or DELETE call for a resource, set the `if-match` parameter to the value of the etag from a previous GET or POST response for that resource. The resource will be updated or deleted only if the etag you provide matches the resource's current etag value.")]
        public string IfMatch { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The client request ID for tracing.")]
        public string OpcRequestId { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            UpdateDatabaseToolsConnectionRequest request;

            try
            {
                request = new UpdateDatabaseToolsConnectionRequest
                {
                    DatabaseToolsConnectionId = DatabaseToolsConnectionId,
                    UpdateDatabaseToolsConnectionDetails = UpdateDatabaseToolsConnectionDetails,
                    IfMatch = IfMatch,
                    OpcRequestId = OpcRequestId
                };

                response = client.UpdateDatabaseToolsConnection(request).GetAwaiter().GetResult();
                WriteOutput(response, CreateWorkRequestObject(response.OpcWorkRequestId));
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

        private UpdateDatabaseToolsConnectionResponse response;
    }
}
