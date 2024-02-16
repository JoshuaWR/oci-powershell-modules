/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20220618
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Management.Automation;
using Oci.DesktopsService.Requests;
using Oci.DesktopsService.Responses;
using Oci.DesktopsService.Models;
using Oci.Common.Model;

namespace Oci.DesktopsService.Cmdlets
{
    [Cmdlet("Start", "OCIDesktopsDesktop")]
    [OutputType(new System.Type[] { typeof(Oci.PSModules.Common.Cmdlets.WorkRequest), typeof(Oci.DesktopsService.Responses.StartDesktopResponse) })]
    public class StartOCIDesktopsDesktop : OCIDesktopServiceCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The OCID of the desktop.")]
        public string DesktopId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The unique identifier of the request.")]
        public string OpcRequestId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"For optimistic concurrency control.")]
        public string IfMatch { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"A token that uniquely identifies a request.")]
        public string OpcRetryToken { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            StartDesktopRequest request;

            try
            {
                request = new StartDesktopRequest
                {
                    DesktopId = DesktopId,
                    OpcRequestId = OpcRequestId,
                    IfMatch = IfMatch,
                    OpcRetryToken = OpcRetryToken
                };

                response = client.StartDesktop(request).GetAwaiter().GetResult();
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

        private StartDesktopResponse response;
    }
}
