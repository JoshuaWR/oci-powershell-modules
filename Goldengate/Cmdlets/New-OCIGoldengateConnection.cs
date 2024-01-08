/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20200407
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Management.Automation;
using Oci.GoldengateService.Requests;
using Oci.GoldengateService.Responses;
using Oci.GoldengateService.Models;
using Oci.Common.Model;

namespace Oci.GoldengateService.Cmdlets
{
    [Cmdlet("New", "OCIGoldengateConnection")]
    [OutputType(new System.Type[] { typeof(Oci.GoldengateService.Models.Connection), typeof(Oci.GoldengateService.Responses.CreateConnectionResponse) })]
    public class NewOCIGoldengateConnection : OCIGoldenGateCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Specification of the Connection to create. This parameter also accepts subtypes <Oci.GoldengateService.Models.CreatePostgresqlConnectionDetails>, <Oci.GoldengateService.Models.CreateKafkaSchemaRegistryConnectionDetails>, <Oci.GoldengateService.Models.CreateMicrosoftSqlserverConnectionDetails>, <Oci.GoldengateService.Models.CreateJavaMessageServiceConnectionDetails>, <Oci.GoldengateService.Models.CreateGoogleBigQueryConnectionDetails>, <Oci.GoldengateService.Models.CreateAmazonKinesisConnectionDetails>, <Oci.GoldengateService.Models.CreateSnowflakeConnectionDetails>, <Oci.GoldengateService.Models.CreateAzureDataLakeStorageConnectionDetails>, <Oci.GoldengateService.Models.CreateMongoDbConnectionDetails>, <Oci.GoldengateService.Models.CreateAmazonS3ConnectionDetails>, <Oci.GoldengateService.Models.CreateHdfsConnectionDetails>, <Oci.GoldengateService.Models.CreateOciObjectStorageConnectionDetails>, <Oci.GoldengateService.Models.CreateElasticsearchConnectionDetails>, <Oci.GoldengateService.Models.CreateAzureSynapseConnectionDetails>, <Oci.GoldengateService.Models.CreateRedisConnectionDetails>, <Oci.GoldengateService.Models.CreateMysqlConnectionDetails>, <Oci.GoldengateService.Models.CreateGenericConnectionDetails>, <Oci.GoldengateService.Models.CreateGoogleCloudStorageConnectionDetails>, <Oci.GoldengateService.Models.CreateKafkaConnectionDetails>, <Oci.GoldengateService.Models.CreateOracleConnectionDetails>, <Oci.GoldengateService.Models.CreateGoldenGateConnectionDetails>, <Oci.GoldengateService.Models.CreateAmazonRedshiftConnectionDetails>, <Oci.GoldengateService.Models.CreateOracleNosqlConnectionDetails> of type <Oci.GoldengateService.Models.CreateConnectionDetails>.")]
        public CreateConnectionDetails CreateConnectionDetails { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"A token that uniquely identifies a request so it can be retried, in case of a timeout or server error, without the risk of executing that same action again. Retry tokens expire after 24 hours but can be invalidated before then due to conflicting operations. For example, if a resource was deleted and purged from the system, then a retry of the original creation request is rejected.")]
        public string OpcRetryToken { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The client request ID for tracing.")]
        public string OpcRequestId { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            CreateConnectionRequest request;

            try
            {
                request = new CreateConnectionRequest
                {
                    CreateConnectionDetails = CreateConnectionDetails,
                    OpcRetryToken = OpcRetryToken,
                    OpcRequestId = OpcRequestId
                };

                response = client.CreateConnection(request).GetAwaiter().GetResult();
                WriteOutput(response, response.Connection);
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

        private CreateConnectionResponse response;
    }
}
