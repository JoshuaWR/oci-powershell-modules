/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20210101
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Management.Automation;
using Oci.AilanguageService.Requests;
using Oci.AilanguageService.Responses;
using Oci.AilanguageService.Models;
using Oci.Common.Model;

namespace Oci.AilanguageService.Cmdlets
{
    [Cmdlet("Invoke", "OCIAilanguageBatchDetectLanguageKeyPhrases")]
    [OutputType(new System.Type[] { typeof(Oci.AilanguageService.Models.BatchDetectLanguageKeyPhrasesResult), typeof(Oci.AilanguageService.Responses.BatchDetectLanguageKeyPhrasesResponse) })]
    public class InvokeOCIAilanguageBatchDetectLanguageKeyPhrases : OCIAIServiceLanguageCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The details to make keyPhrase detect call.")]
        public BatchDetectLanguageKeyPhrasesDetails BatchDetectLanguageKeyPhrasesDetails { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The client request ID for tracing.")]
        public string OpcRequestId { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            BatchDetectLanguageKeyPhrasesRequest request;

            try
            {
                request = new BatchDetectLanguageKeyPhrasesRequest
                {
                    BatchDetectLanguageKeyPhrasesDetails = BatchDetectLanguageKeyPhrasesDetails,
                    OpcRequestId = OpcRequestId
                };

                response = client.BatchDetectLanguageKeyPhrases(request).GetAwaiter().GetResult();
                WriteOutput(response, response.BatchDetectLanguageKeyPhrasesResult);
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

        private BatchDetectLanguageKeyPhrasesResponse response;
    }
}
