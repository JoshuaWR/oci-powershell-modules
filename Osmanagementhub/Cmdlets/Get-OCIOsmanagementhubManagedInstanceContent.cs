/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20220901
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Management.Automation;
using Oci.OsmanagementhubService.Requests;
using Oci.OsmanagementhubService.Responses;
using Oci.OsmanagementhubService.Models;
using Oci.Common.Model;

namespace Oci.OsmanagementhubService.Cmdlets
{
    /*
     * As per https://github.com/PowerShell/PowerShell/issues/11143, this cmdlet is marked with a default parameter set for proper resolution of the invoked parameter set.
     * Parameter set "Default" contains all the parameters that are defined in this class(including base classes) and are not explicitly tagged with a ParameterSetName.
     */
    [Cmdlet("Get", "OCIOsmanagementhubManagedInstanceContent", DefaultParameterSetName = Default)]
    [OutputType(new System.Type[] { typeof(System.IO.Stream), typeof(void), typeof(Oci.OsmanagementhubService.Responses.GetManagedInstanceContentResponse) })]
    public class GetOCIOsmanagementhubManagedInstanceContent : OCIReportingManagedInstanceCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The OCID of the managed instance.")]
        public string ManagedInstanceId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The assigned erratum name. It's unique and not changeable.

Example: `ELSA-2020-5804`")]
        public System.Collections.Generic.List<string> AdvisoryName { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"A filter to return resources that may partially match the erratum advisory name given.")]
        public string AdvisoryNameContains { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"A filter to return only errata that match the given advisory types.")]
        public System.Collections.Generic.List<Oci.OsmanagementhubService.Requests.GetManagedInstanceContentRequest.AdvisoryTypeEnum> AdvisoryType { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Unique Oracle-assigned identifier for the request. If you need to contact Oracle about a particular request, please provide the request ID.")]
        public string OpcRequestId { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = "Path to the output file.", ParameterSetName = WriteToFileSet)]
        public string OutputFile { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = "Output the complete response returned by the API Operation. Using this switch will make this Cmdlet output an object containing response headers in-addition to an optional response body.", ParameterSetName = FullResponseSet)]
        public override SwitchParameter FullResponse { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            GetManagedInstanceContentRequest request;

            try
            {
                request = new GetManagedInstanceContentRequest
                {
                    ManagedInstanceId = ManagedInstanceId,
                    AdvisoryName = AdvisoryName,
                    AdvisoryNameContains = AdvisoryNameContains,
                    AdvisoryType = AdvisoryType,
                    OpcRequestId = OpcRequestId
                };

                response = client.GetManagedInstanceContent(request).GetAwaiter().GetResult();
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

        private GetManagedInstanceContentResponse response;
        private const string Default = "Default";
        private const string WriteToFileSet = "WriteToFile";
        private const string FullResponseSet = "FullResponse";
    }
}
