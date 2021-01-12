/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20190325
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2021, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Management.Automation;
using Oci.DatacatalogService.Requests;
using Oci.DatacatalogService.Responses;
using Oci.DatacatalogService.Models;

namespace Oci.DatacatalogService.Cmdlets
{
    [Cmdlet("Get", "OCIDatacatalogJobLog")]
    [OutputType(new System.Type[] { typeof(Oci.DatacatalogService.Models.JobLog), typeof(Oci.DatacatalogService.Responses.GetJobLogResponse) })]
    public class GetOCIDatacatalogJobLog : OCIDataCatalogCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Unique catalog identifier.")]
        public string CatalogId { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Unique job key.")]
        public string JobKey { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The key of the job execution.")]
        public string JobExecutionKey { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Unique job log key.")]
        public string JobLogKey { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Specifies the fields to return in a job log response.")]
        public System.Collections.Generic.List<Oci.DatacatalogService.Requests.GetJobLogRequest.FieldsEnum> Fields { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The client request ID for tracing.")]
        public string OpcRequestId { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            GetJobLogRequest request;

            try
            {
                request = new GetJobLogRequest
                {
                    CatalogId = CatalogId,
                    JobKey = JobKey,
                    JobExecutionKey = JobExecutionKey,
                    JobLogKey = JobLogKey,
                    Fields = Fields,
                    OpcRequestId = OpcRequestId
                };

                response = client.GetJobLog(request).GetAwaiter().GetResult();
                WriteOutput(response, response.JobLog);
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

        private GetJobLogResponse response;
    }
}
