/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the codepipeline-2015-07-09.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.CodePipeline.Model;
using Amazon.CodePipeline.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.CodePipeline
{
    /// <summary>
    /// Implementation for accessing CodePipeline
    ///
    /// AWS CodePipeline 
    /// <para>
    ///  <b>Overview</b> 
    /// </para>
    ///  
    /// <para>
    /// This is the AWS CodePipeline API Reference. This guide provides descriptions of the
    /// actions and data types for AWS CodePipeline. Some functionality for your pipeline
    /// is only configurable through the API. For additional information, see the <a href="http://docs.aws.amazon.com/codepipeline/latest/userguide/welcome.html">AWS
    /// CodePipeline User Guide</a>.
    /// </para>
    ///  
    /// <para>
    /// You can use the AWS CodePipeline API to work with pipelines, stages, actions, gates,
    /// and transitions, as described below.
    /// </para>
    ///  
    /// <para>
    ///  <i>Pipelines</i> are models of automated release processes. Each pipeline is uniquely
    /// named, and consists of actions, gates, and stages. 
    /// </para>
    ///  
    /// <para>
    /// You can work with pipelines by calling:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>CreatePipeline</a>, which creates a uniquely-named pipeline.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DeletePipeline</a>, which deletes the specified pipeline.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>GetPipeline</a>, which returns information about a pipeline structure.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>GetPipelineExecution</a>, which returns information about a specific execution
    /// of a pipeline.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>GetPipelineState</a>, which returns information about the current state of the
    /// stages and actions of a pipeline.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>ListPipelines</a>, which gets a summary of all of the pipelines associated with
    /// your account.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>StartPipelineExecution</a>, which runs the the most recent revision of an artifact
    /// through the pipeline.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>UpdatePipeline</a>, which updates a pipeline with edits or changes to the structure
    /// of the pipeline.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Pipelines include <i>stages</i>, which are logical groupings of gates and actions.
    /// Each stage contains one or more actions that must complete before the next stage begins.
    /// A stage will result in success or failure. If a stage fails, then the pipeline stops
    /// at that stage and will remain stopped until either a new version of an artifact appears
    /// in the source location, or a user takes action to re-run the most recent artifact
    /// through the pipeline. You can call <a>GetPipelineState</a>, which displays the status
    /// of a pipeline, including the status of stages in the pipeline, or <a>GetPipeline</a>,
    /// which returns the entire structure of the pipeline, including the stages of that pipeline.
    /// For more information about the structure of stages and actions, also refer to the
    /// <a href="http://docs.aws.amazon.com/codepipeline/latest/userguide/pipeline-structure.html">AWS
    /// CodePipeline Pipeline Structure Reference</a>.
    /// </para>
    ///  
    /// <para>
    /// Pipeline stages include <i>actions</i>, which are categorized into categories such
    /// as source or build actions performed within a stage of a pipeline. For example, you
    /// can use a source action to import artifacts into a pipeline from a source such as
    /// Amazon S3. Like stages, you do not work with actions directly in most cases, but you
    /// do define and interact with actions when working with pipeline operations such as
    /// <a>CreatePipeline</a> and <a>GetPipelineState</a>. 
    /// </para>
    ///  
    /// <para>
    /// Pipelines also include <i>transitions</i>, which allow the transition of artifacts
    /// from one stage to the next in a pipeline after the actions in one stage complete.
    /// </para>
    ///  
    /// <para>
    /// You can work with transitions by calling:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>DisableStageTransition</a>, which prevents artifacts from transitioning to the
    /// next stage in a pipeline.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>EnableStageTransition</a>, which enables transition of artifacts between stages
    /// in a pipeline. 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Using the API to integrate with AWS CodePipeline</b> 
    /// </para>
    ///  
    /// <para>
    /// For third-party integrators or developers who want to create their own integrations
    /// with AWS CodePipeline, the expected sequence varies from the standard API user. In
    /// order to integrate with AWS CodePipeline, developers will need to work with the following
    /// items:
    /// </para>
    ///  
    /// <para>
    ///  <b>Jobs</b>, which are instances of an action. For example, a job for a source action
    /// might import a revision of an artifact from a source. 
    /// </para>
    ///  
    /// <para>
    /// You can work with jobs by calling:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>AcknowledgeJob</a>, which confirms whether a job worker has received the specified
    /// job,
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>GetJobDetails</a>, which returns the details of a job,
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>PollForJobs</a>, which determines whether there are any jobs to act upon, 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>PutJobFailureResult</a>, which provides details of a job failure, and
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>PutJobSuccessResult</a>, which provides details of a job success.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Third party jobs</b>, which are instances of an action created by a partner action
    /// and integrated into AWS CodePipeline. Partner actions are created by members of the
    /// AWS Partner Network.
    /// </para>
    ///  
    /// <para>
    /// You can work with third party jobs by calling:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>AcknowledgeThirdPartyJob</a>, which confirms whether a job worker has received
    /// the specified job,
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>GetThirdPartyJobDetails</a>, which requests the details of a job for a partner
    /// action,
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>PollForThirdPartyJobs</a>, which determines whether there are any jobs to act
    /// upon, 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>PutThirdPartyJobFailureResult</a>, which provides details of a job failure, and
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>PutThirdPartyJobSuccessResult</a>, which provides details of a job success.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class AmazonCodePipelineClient : AmazonServiceClient, IAmazonCodePipeline
    {
        #region Constructors

        /// <summary>
        /// Constructs AmazonCodePipelineClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        public AmazonCodePipelineClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonCodePipelineConfig()) { }

        /// <summary>
        /// Constructs AmazonCodePipelineClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="region">The region to connect.</param>
        public AmazonCodePipelineClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonCodePipelineConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonCodePipelineClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="config">The AmazonCodePipelineClient Configuration Object</param>
        public AmazonCodePipelineClient(AmazonCodePipelineConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonCodePipelineClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonCodePipelineClient(AWSCredentials credentials)
            : this(credentials, new AmazonCodePipelineConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCodePipelineClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCodePipelineClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonCodePipelineConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonCodePipelineClient with AWS Credentials and an
        /// AmazonCodePipelineClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonCodePipelineClient Configuration Object</param>
        public AmazonCodePipelineClient(AWSCredentials credentials, AmazonCodePipelineConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonCodePipelineClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonCodePipelineClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonCodePipelineConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCodePipelineClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCodePipelineClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonCodePipelineConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonCodePipelineClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonCodePipelineClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonCodePipelineClient Configuration Object</param>
        public AmazonCodePipelineClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonCodePipelineConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonCodePipelineClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonCodePipelineClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonCodePipelineConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCodePipelineClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCodePipelineClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonCodePipelineConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonCodePipelineClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonCodePipelineClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonCodePipelineClient Configuration Object</param>
        public AmazonCodePipelineClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonCodePipelineConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides

        /// <summary>
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
        }    


        #endregion

        #region Dispose

        /// <summary>
        /// Disposes the service client.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion

        
        #region  AcknowledgeJob


        /// <summary>
        /// Returns information about a specified job and whether that job has been received by
        /// the job worker. Only used for custom actions.
        /// </summary>
        /// <param name="jobId">The unique system-generated ID of the job for which you want to confirm receipt.</param>
        /// <param name="nonce">A system-generated random number that AWS CodePipeline uses to ensure that the job is being worked on by only one job worker. Get this number from the response of the <a>PollForJobs</a> request that returned this job.</param>
        /// 
        /// <returns>The response from the AcknowledgeJob service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidNonceException">
        /// The specified nonce was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.JobNotFoundException">
        /// The specified job was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/AcknowledgeJob">REST API Reference for AcknowledgeJob Operation</seealso>
        public AcknowledgeJobResponse AcknowledgeJob(string jobId, string nonce)
        {
            var request = new AcknowledgeJobRequest();
            request.JobId = jobId;
            request.Nonce = nonce;
            return AcknowledgeJob(request);
        }


        /// <summary>
        /// Returns information about a specified job and whether that job has been received by
        /// the job worker. Only used for custom actions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AcknowledgeJob service method.</param>
        /// 
        /// <returns>The response from the AcknowledgeJob service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidNonceException">
        /// The specified nonce was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.JobNotFoundException">
        /// The specified job was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/AcknowledgeJob">REST API Reference for AcknowledgeJob Operation</seealso>
        public AcknowledgeJobResponse AcknowledgeJob(AcknowledgeJobRequest request)
        {
            var marshaller = new AcknowledgeJobRequestMarshaller();
            var unmarshaller = AcknowledgeJobResponseUnmarshaller.Instance;

            return Invoke<AcknowledgeJobRequest,AcknowledgeJobResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Returns information about a specified job and whether that job has been received by
        /// the job worker. Only used for custom actions.
        /// </summary>
        /// <param name="jobId">The unique system-generated ID of the job for which you want to confirm receipt.</param>
        /// <param name="nonce">A system-generated random number that AWS CodePipeline uses to ensure that the job is being worked on by only one job worker. Get this number from the response of the <a>PollForJobs</a> request that returned this job.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AcknowledgeJob service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidNonceException">
        /// The specified nonce was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.JobNotFoundException">
        /// The specified job was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/AcknowledgeJob">REST API Reference for AcknowledgeJob Operation</seealso>
        public Task<AcknowledgeJobResponse> AcknowledgeJobAsync(string jobId, string nonce, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new AcknowledgeJobRequest();
            request.JobId = jobId;
            request.Nonce = nonce;
            return AcknowledgeJobAsync(request, cancellationToken);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AcknowledgeJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AcknowledgeJob operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/AcknowledgeJob">REST API Reference for AcknowledgeJob Operation</seealso>
        public Task<AcknowledgeJobResponse> AcknowledgeJobAsync(AcknowledgeJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new AcknowledgeJobRequestMarshaller();
            var unmarshaller = AcknowledgeJobResponseUnmarshaller.Instance;

            return InvokeAsync<AcknowledgeJobRequest,AcknowledgeJobResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  AcknowledgeThirdPartyJob


        /// <summary>
        /// Confirms a job worker has received the specified job. Only used for partner actions.
        /// </summary>
        /// <param name="clientToken">The clientToken portion of the clientId and clientToken pair used to verify that the calling entity is allowed access to the job and its details.</param>
        /// <param name="jobId">The unique system-generated ID of the job.</param>
        /// <param name="nonce">A system-generated random number that AWS CodePipeline uses to ensure that the job is being worked on by only one job worker. Get this number from the response to a <a>GetThirdPartyJobDetails</a> request.</param>
        /// 
        /// <returns>The response from the AcknowledgeThirdPartyJob service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidClientTokenException">
        /// The client token was specified in an invalid format
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidNonceException">
        /// The specified nonce was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.JobNotFoundException">
        /// The specified job was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/AcknowledgeThirdPartyJob">REST API Reference for AcknowledgeThirdPartyJob Operation</seealso>
        public AcknowledgeThirdPartyJobResponse AcknowledgeThirdPartyJob(string clientToken, string jobId, string nonce)
        {
            var request = new AcknowledgeThirdPartyJobRequest();
            request.ClientToken = clientToken;
            request.JobId = jobId;
            request.Nonce = nonce;
            return AcknowledgeThirdPartyJob(request);
        }


        /// <summary>
        /// Confirms a job worker has received the specified job. Only used for partner actions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AcknowledgeThirdPartyJob service method.</param>
        /// 
        /// <returns>The response from the AcknowledgeThirdPartyJob service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidClientTokenException">
        /// The client token was specified in an invalid format
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidNonceException">
        /// The specified nonce was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.JobNotFoundException">
        /// The specified job was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/AcknowledgeThirdPartyJob">REST API Reference for AcknowledgeThirdPartyJob Operation</seealso>
        public AcknowledgeThirdPartyJobResponse AcknowledgeThirdPartyJob(AcknowledgeThirdPartyJobRequest request)
        {
            var marshaller = new AcknowledgeThirdPartyJobRequestMarshaller();
            var unmarshaller = AcknowledgeThirdPartyJobResponseUnmarshaller.Instance;

            return Invoke<AcknowledgeThirdPartyJobRequest,AcknowledgeThirdPartyJobResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Confirms a job worker has received the specified job. Only used for partner actions.
        /// </summary>
        /// <param name="clientToken">The clientToken portion of the clientId and clientToken pair used to verify that the calling entity is allowed access to the job and its details.</param>
        /// <param name="jobId">The unique system-generated ID of the job.</param>
        /// <param name="nonce">A system-generated random number that AWS CodePipeline uses to ensure that the job is being worked on by only one job worker. Get this number from the response to a <a>GetThirdPartyJobDetails</a> request.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AcknowledgeThirdPartyJob service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidClientTokenException">
        /// The client token was specified in an invalid format
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidNonceException">
        /// The specified nonce was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.JobNotFoundException">
        /// The specified job was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/AcknowledgeThirdPartyJob">REST API Reference for AcknowledgeThirdPartyJob Operation</seealso>
        public Task<AcknowledgeThirdPartyJobResponse> AcknowledgeThirdPartyJobAsync(string clientToken, string jobId, string nonce, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new AcknowledgeThirdPartyJobRequest();
            request.ClientToken = clientToken;
            request.JobId = jobId;
            request.Nonce = nonce;
            return AcknowledgeThirdPartyJobAsync(request, cancellationToken);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AcknowledgeThirdPartyJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AcknowledgeThirdPartyJob operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/AcknowledgeThirdPartyJob">REST API Reference for AcknowledgeThirdPartyJob Operation</seealso>
        public Task<AcknowledgeThirdPartyJobResponse> AcknowledgeThirdPartyJobAsync(AcknowledgeThirdPartyJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new AcknowledgeThirdPartyJobRequestMarshaller();
            var unmarshaller = AcknowledgeThirdPartyJobResponseUnmarshaller.Instance;

            return InvokeAsync<AcknowledgeThirdPartyJobRequest,AcknowledgeThirdPartyJobResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateCustomActionType


        /// <summary>
        /// Creates a new custom action that can be used in all pipelines associated with the
        /// AWS account. Only used for custom actions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCustomActionType service method.</param>
        /// 
        /// <returns>The response from the CreateCustomActionType service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.LimitExceededException">
        /// The number of pipelines associated with the AWS account has exceeded the limit allowed
        /// for the account.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/CreateCustomActionType">REST API Reference for CreateCustomActionType Operation</seealso>
        public CreateCustomActionTypeResponse CreateCustomActionType(CreateCustomActionTypeRequest request)
        {
            var marshaller = new CreateCustomActionTypeRequestMarshaller();
            var unmarshaller = CreateCustomActionTypeResponseUnmarshaller.Instance;

            return Invoke<CreateCustomActionTypeRequest,CreateCustomActionTypeResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateCustomActionType operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCustomActionType operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/CreateCustomActionType">REST API Reference for CreateCustomActionType Operation</seealso>
        public Task<CreateCustomActionTypeResponse> CreateCustomActionTypeAsync(CreateCustomActionTypeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateCustomActionTypeRequestMarshaller();
            var unmarshaller = CreateCustomActionTypeResponseUnmarshaller.Instance;

            return InvokeAsync<CreateCustomActionTypeRequest,CreateCustomActionTypeResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreatePipeline


        /// <summary>
        /// Creates a pipeline.
        /// </summary>
        /// <param name="pipeline">Represents the structure of actions and stages to be performed in the pipeline. </param>
        /// 
        /// <returns>The response from the CreatePipeline service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidActionDeclarationException">
        /// The specified action declaration was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidBlockerDeclarationException">
        /// Reserved for future use.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidStageDeclarationException">
        /// The specified stage declaration was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidStructureException">
        /// The specified structure was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.LimitExceededException">
        /// The number of pipelines associated with the AWS account has exceeded the limit allowed
        /// for the account.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.PipelineNameInUseException">
        /// The specified pipeline name is already in use.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/CreatePipeline">REST API Reference for CreatePipeline Operation</seealso>
        public CreatePipelineResponse CreatePipeline(PipelineDeclaration pipeline)
        {
            var request = new CreatePipelineRequest();
            request.Pipeline = pipeline;
            return CreatePipeline(request);
        }


        /// <summary>
        /// Creates a pipeline.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePipeline service method.</param>
        /// 
        /// <returns>The response from the CreatePipeline service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidActionDeclarationException">
        /// The specified action declaration was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidBlockerDeclarationException">
        /// Reserved for future use.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidStageDeclarationException">
        /// The specified stage declaration was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidStructureException">
        /// The specified structure was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.LimitExceededException">
        /// The number of pipelines associated with the AWS account has exceeded the limit allowed
        /// for the account.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.PipelineNameInUseException">
        /// The specified pipeline name is already in use.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/CreatePipeline">REST API Reference for CreatePipeline Operation</seealso>
        public CreatePipelineResponse CreatePipeline(CreatePipelineRequest request)
        {
            var marshaller = new CreatePipelineRequestMarshaller();
            var unmarshaller = CreatePipelineResponseUnmarshaller.Instance;

            return Invoke<CreatePipelineRequest,CreatePipelineResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Creates a pipeline.
        /// </summary>
        /// <param name="pipeline">Represents the structure of actions and stages to be performed in the pipeline. </param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreatePipeline service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidActionDeclarationException">
        /// The specified action declaration was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidBlockerDeclarationException">
        /// Reserved for future use.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidStageDeclarationException">
        /// The specified stage declaration was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidStructureException">
        /// The specified structure was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.LimitExceededException">
        /// The number of pipelines associated with the AWS account has exceeded the limit allowed
        /// for the account.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.PipelineNameInUseException">
        /// The specified pipeline name is already in use.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/CreatePipeline">REST API Reference for CreatePipeline Operation</seealso>
        public Task<CreatePipelineResponse> CreatePipelineAsync(PipelineDeclaration pipeline, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new CreatePipelineRequest();
            request.Pipeline = pipeline;
            return CreatePipelineAsync(request, cancellationToken);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreatePipeline operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePipeline operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/CreatePipeline">REST API Reference for CreatePipeline Operation</seealso>
        public Task<CreatePipelineResponse> CreatePipelineAsync(CreatePipelineRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreatePipelineRequestMarshaller();
            var unmarshaller = CreatePipelineResponseUnmarshaller.Instance;

            return InvokeAsync<CreatePipelineRequest,CreatePipelineResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteCustomActionType


        /// <summary>
        /// Marks a custom action as deleted. PollForJobs for the custom action will fail after
        /// the action is marked for deletion. Only used for custom actions.
        /// 
        ///  <important> 
        /// <para>
        /// You cannot recreate a custom action after it has been deleted unless you increase
        /// the version number of the action.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCustomActionType service method.</param>
        /// 
        /// <returns>The response from the DeleteCustomActionType service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/DeleteCustomActionType">REST API Reference for DeleteCustomActionType Operation</seealso>
        public DeleteCustomActionTypeResponse DeleteCustomActionType(DeleteCustomActionTypeRequest request)
        {
            var marshaller = new DeleteCustomActionTypeRequestMarshaller();
            var unmarshaller = DeleteCustomActionTypeResponseUnmarshaller.Instance;

            return Invoke<DeleteCustomActionTypeRequest,DeleteCustomActionTypeResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCustomActionType operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCustomActionType operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/DeleteCustomActionType">REST API Reference for DeleteCustomActionType Operation</seealso>
        public Task<DeleteCustomActionTypeResponse> DeleteCustomActionTypeAsync(DeleteCustomActionTypeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteCustomActionTypeRequestMarshaller();
            var unmarshaller = DeleteCustomActionTypeResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteCustomActionTypeRequest,DeleteCustomActionTypeResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeletePipeline


        /// <summary>
        /// Deletes the specified pipeline.
        /// </summary>
        /// <param name="name">The name of the pipeline to be deleted.</param>
        /// 
        /// <returns>The response from the DeletePipeline service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/DeletePipeline">REST API Reference for DeletePipeline Operation</seealso>
        public DeletePipelineResponse DeletePipeline(string name)
        {
            var request = new DeletePipelineRequest();
            request.Name = name;
            return DeletePipeline(request);
        }


        /// <summary>
        /// Deletes the specified pipeline.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePipeline service method.</param>
        /// 
        /// <returns>The response from the DeletePipeline service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/DeletePipeline">REST API Reference for DeletePipeline Operation</seealso>
        public DeletePipelineResponse DeletePipeline(DeletePipelineRequest request)
        {
            var marshaller = new DeletePipelineRequestMarshaller();
            var unmarshaller = DeletePipelineResponseUnmarshaller.Instance;

            return Invoke<DeletePipelineRequest,DeletePipelineResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Deletes the specified pipeline.
        /// </summary>
        /// <param name="name">The name of the pipeline to be deleted.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeletePipeline service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/DeletePipeline">REST API Reference for DeletePipeline Operation</seealso>
        public Task<DeletePipelineResponse> DeletePipelineAsync(string name, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new DeletePipelineRequest();
            request.Name = name;
            return DeletePipelineAsync(request, cancellationToken);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeletePipeline operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePipeline operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/DeletePipeline">REST API Reference for DeletePipeline Operation</seealso>
        public Task<DeletePipelineResponse> DeletePipelineAsync(DeletePipelineRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeletePipelineRequestMarshaller();
            var unmarshaller = DeletePipelineResponseUnmarshaller.Instance;

            return InvokeAsync<DeletePipelineRequest,DeletePipelineResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DisableStageTransition


        /// <summary>
        /// Prevents artifacts in a pipeline from transitioning to the next stage in the pipeline.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableStageTransition service method.</param>
        /// 
        /// <returns>The response from the DisableStageTransition service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.PipelineNotFoundException">
        /// The specified pipeline was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.StageNotFoundException">
        /// The specified stage was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/DisableStageTransition">REST API Reference for DisableStageTransition Operation</seealso>
        public DisableStageTransitionResponse DisableStageTransition(DisableStageTransitionRequest request)
        {
            var marshaller = new DisableStageTransitionRequestMarshaller();
            var unmarshaller = DisableStageTransitionResponseUnmarshaller.Instance;

            return Invoke<DisableStageTransitionRequest,DisableStageTransitionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisableStageTransition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisableStageTransition operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/DisableStageTransition">REST API Reference for DisableStageTransition Operation</seealso>
        public Task<DisableStageTransitionResponse> DisableStageTransitionAsync(DisableStageTransitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DisableStageTransitionRequestMarshaller();
            var unmarshaller = DisableStageTransitionResponseUnmarshaller.Instance;

            return InvokeAsync<DisableStageTransitionRequest,DisableStageTransitionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  EnableStageTransition


        /// <summary>
        /// Enables artifacts in a pipeline to transition to a stage in a pipeline.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableStageTransition service method.</param>
        /// 
        /// <returns>The response from the EnableStageTransition service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.PipelineNotFoundException">
        /// The specified pipeline was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.StageNotFoundException">
        /// The specified stage was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/EnableStageTransition">REST API Reference for EnableStageTransition Operation</seealso>
        public EnableStageTransitionResponse EnableStageTransition(EnableStageTransitionRequest request)
        {
            var marshaller = new EnableStageTransitionRequestMarshaller();
            var unmarshaller = EnableStageTransitionResponseUnmarshaller.Instance;

            return Invoke<EnableStageTransitionRequest,EnableStageTransitionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the EnableStageTransition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableStageTransition operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/EnableStageTransition">REST API Reference for EnableStageTransition Operation</seealso>
        public Task<EnableStageTransitionResponse> EnableStageTransitionAsync(EnableStageTransitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new EnableStageTransitionRequestMarshaller();
            var unmarshaller = EnableStageTransitionResponseUnmarshaller.Instance;

            return InvokeAsync<EnableStageTransitionRequest,EnableStageTransitionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetJobDetails


        /// <summary>
        /// Returns information about a job. Only used for custom actions.
        /// 
        ///  <important> 
        /// <para>
        /// When this API is called, AWS CodePipeline returns temporary credentials for the Amazon
        /// S3 bucket used to store artifacts for the pipeline, if the action requires access
        /// to that Amazon S3 bucket for input or output artifacts. Additionally, this API returns
        /// any secret values defined for the action.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="jobId">The unique system-generated ID for the job.</param>
        /// 
        /// <returns>The response from the GetJobDetails service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.JobNotFoundException">
        /// The specified job was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/GetJobDetails">REST API Reference for GetJobDetails Operation</seealso>
        public GetJobDetailsResponse GetJobDetails(string jobId)
        {
            var request = new GetJobDetailsRequest();
            request.JobId = jobId;
            return GetJobDetails(request);
        }


        /// <summary>
        /// Returns information about a job. Only used for custom actions.
        /// 
        ///  <important> 
        /// <para>
        /// When this API is called, AWS CodePipeline returns temporary credentials for the Amazon
        /// S3 bucket used to store artifacts for the pipeline, if the action requires access
        /// to that Amazon S3 bucket for input or output artifacts. Additionally, this API returns
        /// any secret values defined for the action.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetJobDetails service method.</param>
        /// 
        /// <returns>The response from the GetJobDetails service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.JobNotFoundException">
        /// The specified job was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/GetJobDetails">REST API Reference for GetJobDetails Operation</seealso>
        public GetJobDetailsResponse GetJobDetails(GetJobDetailsRequest request)
        {
            var marshaller = new GetJobDetailsRequestMarshaller();
            var unmarshaller = GetJobDetailsResponseUnmarshaller.Instance;

            return Invoke<GetJobDetailsRequest,GetJobDetailsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Returns information about a job. Only used for custom actions.
        /// 
        ///  <important> 
        /// <para>
        /// When this API is called, AWS CodePipeline returns temporary credentials for the Amazon
        /// S3 bucket used to store artifacts for the pipeline, if the action requires access
        /// to that Amazon S3 bucket for input or output artifacts. Additionally, this API returns
        /// any secret values defined for the action.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="jobId">The unique system-generated ID for the job.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetJobDetails service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.JobNotFoundException">
        /// The specified job was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/GetJobDetails">REST API Reference for GetJobDetails Operation</seealso>
        public Task<GetJobDetailsResponse> GetJobDetailsAsync(string jobId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new GetJobDetailsRequest();
            request.JobId = jobId;
            return GetJobDetailsAsync(request, cancellationToken);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetJobDetails operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetJobDetails operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/GetJobDetails">REST API Reference for GetJobDetails Operation</seealso>
        public Task<GetJobDetailsResponse> GetJobDetailsAsync(GetJobDetailsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetJobDetailsRequestMarshaller();
            var unmarshaller = GetJobDetailsResponseUnmarshaller.Instance;

            return InvokeAsync<GetJobDetailsRequest,GetJobDetailsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetPipeline


        /// <summary>
        /// Returns the metadata, structure, stages, and actions of a pipeline. Can be used to
        /// return the entire structure of a pipeline in JSON format, which can then be modified
        /// and used to update the pipeline structure with <a>UpdatePipeline</a>.
        /// </summary>
        /// <param name="name">The name of the pipeline for which you want to get information. Pipeline names must be unique under an Amazon Web Services (AWS) user account.</param>
        /// <param name="version">The version number of the pipeline. If you do not specify a version, defaults to the most current version.</param>
        /// 
        /// <returns>The response from the GetPipeline service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.PipelineNotFoundException">
        /// The specified pipeline was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.PipelineVersionNotFoundException">
        /// The specified pipeline version was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/GetPipeline">REST API Reference for GetPipeline Operation</seealso>
        public GetPipelineResponse GetPipeline(string name, int version)
        {
            var request = new GetPipelineRequest();
            request.Name = name;
            request.Version = version;
            return GetPipeline(request);
        }


        /// <summary>
        /// Returns the metadata, structure, stages, and actions of a pipeline. Can be used to
        /// return the entire structure of a pipeline in JSON format, which can then be modified
        /// and used to update the pipeline structure with <a>UpdatePipeline</a>.
        /// </summary>
        /// <param name="name">The name of the pipeline for which you want to get information. Pipeline names must be unique under an Amazon Web Services (AWS) user account.</param>
        /// 
        /// <returns>The response from the GetPipeline service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.PipelineNotFoundException">
        /// The specified pipeline was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.PipelineVersionNotFoundException">
        /// The specified pipeline version was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/GetPipeline">REST API Reference for GetPipeline Operation</seealso>
        public GetPipelineResponse GetPipeline(string name)
        {
            var request = new GetPipelineRequest();
            request.Name = name;
            return GetPipeline(request);
        }


        /// <summary>
        /// Returns the metadata, structure, stages, and actions of a pipeline. Can be used to
        /// return the entire structure of a pipeline in JSON format, which can then be modified
        /// and used to update the pipeline structure with <a>UpdatePipeline</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPipeline service method.</param>
        /// 
        /// <returns>The response from the GetPipeline service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.PipelineNotFoundException">
        /// The specified pipeline was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.PipelineVersionNotFoundException">
        /// The specified pipeline version was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/GetPipeline">REST API Reference for GetPipeline Operation</seealso>
        public GetPipelineResponse GetPipeline(GetPipelineRequest request)
        {
            var marshaller = new GetPipelineRequestMarshaller();
            var unmarshaller = GetPipelineResponseUnmarshaller.Instance;

            return Invoke<GetPipelineRequest,GetPipelineResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Returns the metadata, structure, stages, and actions of a pipeline. Can be used to
        /// return the entire structure of a pipeline in JSON format, which can then be modified
        /// and used to update the pipeline structure with <a>UpdatePipeline</a>.
        /// </summary>
        /// <param name="name">The name of the pipeline for which you want to get information. Pipeline names must be unique under an Amazon Web Services (AWS) user account.</param>
        /// <param name="version">The version number of the pipeline. If you do not specify a version, defaults to the most current version.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetPipeline service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.PipelineNotFoundException">
        /// The specified pipeline was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.PipelineVersionNotFoundException">
        /// The specified pipeline version was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/GetPipeline">REST API Reference for GetPipeline Operation</seealso>
        public Task<GetPipelineResponse> GetPipelineAsync(string name, int version, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new GetPipelineRequest();
            request.Name = name;
            request.Version = version;
            return GetPipelineAsync(request, cancellationToken);
        }


        /// <summary>
        /// Returns the metadata, structure, stages, and actions of a pipeline. Can be used to
        /// return the entire structure of a pipeline in JSON format, which can then be modified
        /// and used to update the pipeline structure with <a>UpdatePipeline</a>.
        /// </summary>
        /// <param name="name">The name of the pipeline for which you want to get information. Pipeline names must be unique under an Amazon Web Services (AWS) user account.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetPipeline service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.PipelineNotFoundException">
        /// The specified pipeline was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.PipelineVersionNotFoundException">
        /// The specified pipeline version was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/GetPipeline">REST API Reference for GetPipeline Operation</seealso>
        public Task<GetPipelineResponse> GetPipelineAsync(string name, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new GetPipelineRequest();
            request.Name = name;
            return GetPipelineAsync(request, cancellationToken);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetPipeline operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPipeline operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/GetPipeline">REST API Reference for GetPipeline Operation</seealso>
        public Task<GetPipelineResponse> GetPipelineAsync(GetPipelineRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetPipelineRequestMarshaller();
            var unmarshaller = GetPipelineResponseUnmarshaller.Instance;

            return InvokeAsync<GetPipelineRequest,GetPipelineResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetPipelineExecution


        /// <summary>
        /// Returns information about an execution of a pipeline, including details about artifacts,
        /// the pipeline execution ID, and the name, version, and status of the pipeline.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPipelineExecution service method.</param>
        /// 
        /// <returns>The response from the GetPipelineExecution service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.PipelineExecutionNotFoundException">
        /// The pipeline execution was specified in an invalid format or cannot be found, or an
        /// execution ID does not belong to the specified pipeline.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.PipelineNotFoundException">
        /// The specified pipeline was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/GetPipelineExecution">REST API Reference for GetPipelineExecution Operation</seealso>
        public GetPipelineExecutionResponse GetPipelineExecution(GetPipelineExecutionRequest request)
        {
            var marshaller = new GetPipelineExecutionRequestMarshaller();
            var unmarshaller = GetPipelineExecutionResponseUnmarshaller.Instance;

            return Invoke<GetPipelineExecutionRequest,GetPipelineExecutionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetPipelineExecution operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPipelineExecution operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/GetPipelineExecution">REST API Reference for GetPipelineExecution Operation</seealso>
        public Task<GetPipelineExecutionResponse> GetPipelineExecutionAsync(GetPipelineExecutionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetPipelineExecutionRequestMarshaller();
            var unmarshaller = GetPipelineExecutionResponseUnmarshaller.Instance;

            return InvokeAsync<GetPipelineExecutionRequest,GetPipelineExecutionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetPipelineState


        /// <summary>
        /// Returns information about the state of a pipeline, including the stages and actions.
        /// </summary>
        /// <param name="name">The name of the pipeline about which you want to get information.</param>
        /// 
        /// <returns>The response from the GetPipelineState service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.PipelineNotFoundException">
        /// The specified pipeline was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/GetPipelineState">REST API Reference for GetPipelineState Operation</seealso>
        public GetPipelineStateResponse GetPipelineState(string name)
        {
            var request = new GetPipelineStateRequest();
            request.Name = name;
            return GetPipelineState(request);
        }


        /// <summary>
        /// Returns information about the state of a pipeline, including the stages and actions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPipelineState service method.</param>
        /// 
        /// <returns>The response from the GetPipelineState service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.PipelineNotFoundException">
        /// The specified pipeline was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/GetPipelineState">REST API Reference for GetPipelineState Operation</seealso>
        public GetPipelineStateResponse GetPipelineState(GetPipelineStateRequest request)
        {
            var marshaller = new GetPipelineStateRequestMarshaller();
            var unmarshaller = GetPipelineStateResponseUnmarshaller.Instance;

            return Invoke<GetPipelineStateRequest,GetPipelineStateResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Returns information about the state of a pipeline, including the stages and actions.
        /// </summary>
        /// <param name="name">The name of the pipeline about which you want to get information.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetPipelineState service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.PipelineNotFoundException">
        /// The specified pipeline was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/GetPipelineState">REST API Reference for GetPipelineState Operation</seealso>
        public Task<GetPipelineStateResponse> GetPipelineStateAsync(string name, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new GetPipelineStateRequest();
            request.Name = name;
            return GetPipelineStateAsync(request, cancellationToken);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetPipelineState operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPipelineState operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/GetPipelineState">REST API Reference for GetPipelineState Operation</seealso>
        public Task<GetPipelineStateResponse> GetPipelineStateAsync(GetPipelineStateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetPipelineStateRequestMarshaller();
            var unmarshaller = GetPipelineStateResponseUnmarshaller.Instance;

            return InvokeAsync<GetPipelineStateRequest,GetPipelineStateResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetThirdPartyJobDetails


        /// <summary>
        /// Requests the details of a job for a third party action. Only used for partner actions.
        /// 
        ///  <important> 
        /// <para>
        /// When this API is called, AWS CodePipeline returns temporary credentials for the Amazon
        /// S3 bucket used to store artifacts for the pipeline, if the action requires access
        /// to that Amazon S3 bucket for input or output artifacts. Additionally, this API returns
        /// any secret values defined for the action.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="clientToken">The clientToken portion of the clientId and clientToken pair used to verify that the calling entity is allowed access to the job and its details.</param>
        /// <param name="jobId">The unique system-generated ID used for identifying the job.</param>
        /// 
        /// <returns>The response from the GetThirdPartyJobDetails service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidClientTokenException">
        /// The client token was specified in an invalid format
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidJobException">
        /// The specified job was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.JobNotFoundException">
        /// The specified job was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/GetThirdPartyJobDetails">REST API Reference for GetThirdPartyJobDetails Operation</seealso>
        public GetThirdPartyJobDetailsResponse GetThirdPartyJobDetails(string clientToken, string jobId)
        {
            var request = new GetThirdPartyJobDetailsRequest();
            request.ClientToken = clientToken;
            request.JobId = jobId;
            return GetThirdPartyJobDetails(request);
        }


        /// <summary>
        /// Requests the details of a job for a third party action. Only used for partner actions.
        /// 
        ///  <important> 
        /// <para>
        /// When this API is called, AWS CodePipeline returns temporary credentials for the Amazon
        /// S3 bucket used to store artifacts for the pipeline, if the action requires access
        /// to that Amazon S3 bucket for input or output artifacts. Additionally, this API returns
        /// any secret values defined for the action.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetThirdPartyJobDetails service method.</param>
        /// 
        /// <returns>The response from the GetThirdPartyJobDetails service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidClientTokenException">
        /// The client token was specified in an invalid format
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidJobException">
        /// The specified job was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.JobNotFoundException">
        /// The specified job was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/GetThirdPartyJobDetails">REST API Reference for GetThirdPartyJobDetails Operation</seealso>
        public GetThirdPartyJobDetailsResponse GetThirdPartyJobDetails(GetThirdPartyJobDetailsRequest request)
        {
            var marshaller = new GetThirdPartyJobDetailsRequestMarshaller();
            var unmarshaller = GetThirdPartyJobDetailsResponseUnmarshaller.Instance;

            return Invoke<GetThirdPartyJobDetailsRequest,GetThirdPartyJobDetailsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Requests the details of a job for a third party action. Only used for partner actions.
        /// 
        ///  <important> 
        /// <para>
        /// When this API is called, AWS CodePipeline returns temporary credentials for the Amazon
        /// S3 bucket used to store artifacts for the pipeline, if the action requires access
        /// to that Amazon S3 bucket for input or output artifacts. Additionally, this API returns
        /// any secret values defined for the action.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="clientToken">The clientToken portion of the clientId and clientToken pair used to verify that the calling entity is allowed access to the job and its details.</param>
        /// <param name="jobId">The unique system-generated ID used for identifying the job.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetThirdPartyJobDetails service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidClientTokenException">
        /// The client token was specified in an invalid format
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidJobException">
        /// The specified job was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.JobNotFoundException">
        /// The specified job was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/GetThirdPartyJobDetails">REST API Reference for GetThirdPartyJobDetails Operation</seealso>
        public Task<GetThirdPartyJobDetailsResponse> GetThirdPartyJobDetailsAsync(string clientToken, string jobId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new GetThirdPartyJobDetailsRequest();
            request.ClientToken = clientToken;
            request.JobId = jobId;
            return GetThirdPartyJobDetailsAsync(request, cancellationToken);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetThirdPartyJobDetails operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetThirdPartyJobDetails operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/GetThirdPartyJobDetails">REST API Reference for GetThirdPartyJobDetails Operation</seealso>
        public Task<GetThirdPartyJobDetailsResponse> GetThirdPartyJobDetailsAsync(GetThirdPartyJobDetailsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetThirdPartyJobDetailsRequestMarshaller();
            var unmarshaller = GetThirdPartyJobDetailsResponseUnmarshaller.Instance;

            return InvokeAsync<GetThirdPartyJobDetailsRequest,GetThirdPartyJobDetailsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListActionTypes


        /// <summary>
        /// Gets a summary of all AWS CodePipeline action types associated with your account.
        /// </summary>
        /// 
        /// <returns>The response from the ListActionTypes service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidNextTokenException">
        /// The next token was specified in an invalid format. Make sure that the next token you
        /// provided is the token returned by a previous call.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/ListActionTypes">REST API Reference for ListActionTypes Operation</seealso>
        public ListActionTypesResponse ListActionTypes()
        {
            var request = new ListActionTypesRequest();
            return ListActionTypes(request);
        }


        /// <summary>
        /// Gets a summary of all AWS CodePipeline action types associated with your account.
        /// </summary>
        /// <param name="actionOwnerFilter">Filters the list of action types to those created by a specified entity.</param>
        /// 
        /// <returns>The response from the ListActionTypes service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidNextTokenException">
        /// The next token was specified in an invalid format. Make sure that the next token you
        /// provided is the token returned by a previous call.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/ListActionTypes">REST API Reference for ListActionTypes Operation</seealso>
        public ListActionTypesResponse ListActionTypes(ActionOwner actionOwnerFilter)
        {
            var request = new ListActionTypesRequest();
            request.ActionOwnerFilter = actionOwnerFilter;
            return ListActionTypes(request);
        }


        /// <summary>
        /// Gets a summary of all AWS CodePipeline action types associated with your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListActionTypes service method.</param>
        /// 
        /// <returns>The response from the ListActionTypes service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidNextTokenException">
        /// The next token was specified in an invalid format. Make sure that the next token you
        /// provided is the token returned by a previous call.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/ListActionTypes">REST API Reference for ListActionTypes Operation</seealso>
        public ListActionTypesResponse ListActionTypes(ListActionTypesRequest request)
        {
            var marshaller = new ListActionTypesRequestMarshaller();
            var unmarshaller = ListActionTypesResponseUnmarshaller.Instance;

            return Invoke<ListActionTypesRequest,ListActionTypesResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Gets a summary of all AWS CodePipeline action types associated with your account.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListActionTypes service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidNextTokenException">
        /// The next token was specified in an invalid format. Make sure that the next token you
        /// provided is the token returned by a previous call.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/ListActionTypes">REST API Reference for ListActionTypes Operation</seealso>
        public Task<ListActionTypesResponse> ListActionTypesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new ListActionTypesRequest();
            return ListActionTypesAsync(request, cancellationToken);
        }


        /// <summary>
        /// Gets a summary of all AWS CodePipeline action types associated with your account.
        /// </summary>
        /// <param name="actionOwnerFilter">Filters the list of action types to those created by a specified entity.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListActionTypes service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidNextTokenException">
        /// The next token was specified in an invalid format. Make sure that the next token you
        /// provided is the token returned by a previous call.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/ListActionTypes">REST API Reference for ListActionTypes Operation</seealso>
        public Task<ListActionTypesResponse> ListActionTypesAsync(ActionOwner actionOwnerFilter, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new ListActionTypesRequest();
            request.ActionOwnerFilter = actionOwnerFilter;
            return ListActionTypesAsync(request, cancellationToken);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListActionTypes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListActionTypes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/ListActionTypes">REST API Reference for ListActionTypes Operation</seealso>
        public Task<ListActionTypesResponse> ListActionTypesAsync(ListActionTypesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListActionTypesRequestMarshaller();
            var unmarshaller = ListActionTypesResponseUnmarshaller.Instance;

            return InvokeAsync<ListActionTypesRequest,ListActionTypesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListPipelineExecutions


        /// <summary>
        /// Gets a summary of the most recent executions for a pipeline.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPipelineExecutions service method.</param>
        /// 
        /// <returns>The response from the ListPipelineExecutions service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidNextTokenException">
        /// The next token was specified in an invalid format. Make sure that the next token you
        /// provided is the token returned by a previous call.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.PipelineNotFoundException">
        /// The specified pipeline was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/ListPipelineExecutions">REST API Reference for ListPipelineExecutions Operation</seealso>
        public ListPipelineExecutionsResponse ListPipelineExecutions(ListPipelineExecutionsRequest request)
        {
            var marshaller = new ListPipelineExecutionsRequestMarshaller();
            var unmarshaller = ListPipelineExecutionsResponseUnmarshaller.Instance;

            return Invoke<ListPipelineExecutionsRequest,ListPipelineExecutionsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListPipelineExecutions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPipelineExecutions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/ListPipelineExecutions">REST API Reference for ListPipelineExecutions Operation</seealso>
        public Task<ListPipelineExecutionsResponse> ListPipelineExecutionsAsync(ListPipelineExecutionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListPipelineExecutionsRequestMarshaller();
            var unmarshaller = ListPipelineExecutionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListPipelineExecutionsRequest,ListPipelineExecutionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListPipelines


        /// <summary>
        /// Gets a summary of all of the pipelines associated with your account.
        /// </summary>
        /// 
        /// <returns>The response from the ListPipelines service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidNextTokenException">
        /// The next token was specified in an invalid format. Make sure that the next token you
        /// provided is the token returned by a previous call.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/ListPipelines">REST API Reference for ListPipelines Operation</seealso>
        public ListPipelinesResponse ListPipelines()
        {
            var request = new ListPipelinesRequest();
            return ListPipelines(request);
        }


        /// <summary>
        /// Gets a summary of all of the pipelines associated with your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPipelines service method.</param>
        /// 
        /// <returns>The response from the ListPipelines service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidNextTokenException">
        /// The next token was specified in an invalid format. Make sure that the next token you
        /// provided is the token returned by a previous call.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/ListPipelines">REST API Reference for ListPipelines Operation</seealso>
        public ListPipelinesResponse ListPipelines(ListPipelinesRequest request)
        {
            var marshaller = new ListPipelinesRequestMarshaller();
            var unmarshaller = ListPipelinesResponseUnmarshaller.Instance;

            return Invoke<ListPipelinesRequest,ListPipelinesResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Gets a summary of all of the pipelines associated with your account.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPipelines service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidNextTokenException">
        /// The next token was specified in an invalid format. Make sure that the next token you
        /// provided is the token returned by a previous call.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/ListPipelines">REST API Reference for ListPipelines Operation</seealso>
        public Task<ListPipelinesResponse> ListPipelinesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new ListPipelinesRequest();
            return ListPipelinesAsync(request, cancellationToken);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListPipelines operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPipelines operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/ListPipelines">REST API Reference for ListPipelines Operation</seealso>
        public Task<ListPipelinesResponse> ListPipelinesAsync(ListPipelinesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListPipelinesRequestMarshaller();
            var unmarshaller = ListPipelinesResponseUnmarshaller.Instance;

            return InvokeAsync<ListPipelinesRequest,ListPipelinesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PollForJobs


        /// <summary>
        /// Returns information about any jobs for AWS CodePipeline to act upon.
        /// 
        ///  <important> 
        /// <para>
        /// When this API is called, AWS CodePipeline returns temporary credentials for the Amazon
        /// S3 bucket used to store artifacts for the pipeline, if the action requires access
        /// to that Amazon S3 bucket for input or output artifacts. Additionally, this API returns
        /// any secret values defined for the action.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PollForJobs service method.</param>
        /// 
        /// <returns>The response from the PollForJobs service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.ActionTypeNotFoundException">
        /// The specified action type cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/PollForJobs">REST API Reference for PollForJobs Operation</seealso>
        public PollForJobsResponse PollForJobs(PollForJobsRequest request)
        {
            var marshaller = new PollForJobsRequestMarshaller();
            var unmarshaller = PollForJobsResponseUnmarshaller.Instance;

            return Invoke<PollForJobsRequest,PollForJobsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PollForJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PollForJobs operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/PollForJobs">REST API Reference for PollForJobs Operation</seealso>
        public Task<PollForJobsResponse> PollForJobsAsync(PollForJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new PollForJobsRequestMarshaller();
            var unmarshaller = PollForJobsResponseUnmarshaller.Instance;

            return InvokeAsync<PollForJobsRequest,PollForJobsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PollForThirdPartyJobs


        /// <summary>
        /// Determines whether there are any third party jobs for a job worker to act on. Only
        /// used for partner actions.
        /// 
        ///  <important> 
        /// <para>
        /// When this API is called, AWS CodePipeline returns temporary credentials for the Amazon
        /// S3 bucket used to store artifacts for the pipeline, if the action requires access
        /// to that Amazon S3 bucket for input or output artifacts.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PollForThirdPartyJobs service method.</param>
        /// 
        /// <returns>The response from the PollForThirdPartyJobs service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.ActionTypeNotFoundException">
        /// The specified action type cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/PollForThirdPartyJobs">REST API Reference for PollForThirdPartyJobs Operation</seealso>
        public PollForThirdPartyJobsResponse PollForThirdPartyJobs(PollForThirdPartyJobsRequest request)
        {
            var marshaller = new PollForThirdPartyJobsRequestMarshaller();
            var unmarshaller = PollForThirdPartyJobsResponseUnmarshaller.Instance;

            return Invoke<PollForThirdPartyJobsRequest,PollForThirdPartyJobsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PollForThirdPartyJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PollForThirdPartyJobs operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/PollForThirdPartyJobs">REST API Reference for PollForThirdPartyJobs Operation</seealso>
        public Task<PollForThirdPartyJobsResponse> PollForThirdPartyJobsAsync(PollForThirdPartyJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new PollForThirdPartyJobsRequestMarshaller();
            var unmarshaller = PollForThirdPartyJobsResponseUnmarshaller.Instance;

            return InvokeAsync<PollForThirdPartyJobsRequest,PollForThirdPartyJobsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PutActionRevision


        /// <summary>
        /// Provides information to AWS CodePipeline about new revisions to a source.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutActionRevision service method.</param>
        /// 
        /// <returns>The response from the PutActionRevision service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.ActionNotFoundException">
        /// The specified action cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.PipelineNotFoundException">
        /// The specified pipeline was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.StageNotFoundException">
        /// The specified stage was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/PutActionRevision">REST API Reference for PutActionRevision Operation</seealso>
        public PutActionRevisionResponse PutActionRevision(PutActionRevisionRequest request)
        {
            var marshaller = new PutActionRevisionRequestMarshaller();
            var unmarshaller = PutActionRevisionResponseUnmarshaller.Instance;

            return Invoke<PutActionRevisionRequest,PutActionRevisionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutActionRevision operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutActionRevision operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/PutActionRevision">REST API Reference for PutActionRevision Operation</seealso>
        public Task<PutActionRevisionResponse> PutActionRevisionAsync(PutActionRevisionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new PutActionRevisionRequestMarshaller();
            var unmarshaller = PutActionRevisionResponseUnmarshaller.Instance;

            return InvokeAsync<PutActionRevisionRequest,PutActionRevisionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PutApprovalResult


        /// <summary>
        /// Provides the response to a manual approval request to AWS CodePipeline. Valid responses
        /// include Approved and Rejected.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutApprovalResult service method.</param>
        /// 
        /// <returns>The response from the PutApprovalResult service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.ActionNotFoundException">
        /// The specified action cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ApprovalAlreadyCompletedException">
        /// The approval action has already been approved or rejected.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidApprovalTokenException">
        /// The approval request already received a response or has expired.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.PipelineNotFoundException">
        /// The specified pipeline was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.StageNotFoundException">
        /// The specified stage was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/PutApprovalResult">REST API Reference for PutApprovalResult Operation</seealso>
        public PutApprovalResultResponse PutApprovalResult(PutApprovalResultRequest request)
        {
            var marshaller = new PutApprovalResultRequestMarshaller();
            var unmarshaller = PutApprovalResultResponseUnmarshaller.Instance;

            return Invoke<PutApprovalResultRequest,PutApprovalResultResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutApprovalResult operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutApprovalResult operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/PutApprovalResult">REST API Reference for PutApprovalResult Operation</seealso>
        public Task<PutApprovalResultResponse> PutApprovalResultAsync(PutApprovalResultRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new PutApprovalResultRequestMarshaller();
            var unmarshaller = PutApprovalResultResponseUnmarshaller.Instance;

            return InvokeAsync<PutApprovalResultRequest,PutApprovalResultResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PutJobFailureResult


        /// <summary>
        /// Represents the failure of a job as returned to the pipeline by a job worker. Only
        /// used for custom actions.
        /// </summary>
        /// <param name="jobId">The unique system-generated ID of the job that failed. This is the same ID returned from PollForJobs.</param>
        /// <param name="failureDetails">The details about the failure of a job.</param>
        /// 
        /// <returns>The response from the PutJobFailureResult service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidJobStateException">
        /// The specified job state was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.JobNotFoundException">
        /// The specified job was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/PutJobFailureResult">REST API Reference for PutJobFailureResult Operation</seealso>
        public PutJobFailureResultResponse PutJobFailureResult(string jobId, FailureDetails failureDetails)
        {
            var request = new PutJobFailureResultRequest();
            request.JobId = jobId;
            request.FailureDetails = failureDetails;
            return PutJobFailureResult(request);
        }


        /// <summary>
        /// Represents the failure of a job as returned to the pipeline by a job worker. Only
        /// used for custom actions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutJobFailureResult service method.</param>
        /// 
        /// <returns>The response from the PutJobFailureResult service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidJobStateException">
        /// The specified job state was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.JobNotFoundException">
        /// The specified job was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/PutJobFailureResult">REST API Reference for PutJobFailureResult Operation</seealso>
        public PutJobFailureResultResponse PutJobFailureResult(PutJobFailureResultRequest request)
        {
            var marshaller = new PutJobFailureResultRequestMarshaller();
            var unmarshaller = PutJobFailureResultResponseUnmarshaller.Instance;

            return Invoke<PutJobFailureResultRequest,PutJobFailureResultResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Represents the failure of a job as returned to the pipeline by a job worker. Only
        /// used for custom actions.
        /// </summary>
        /// <param name="jobId">The unique system-generated ID of the job that failed. This is the same ID returned from PollForJobs.</param>
        /// <param name="failureDetails">The details about the failure of a job.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutJobFailureResult service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidJobStateException">
        /// The specified job state was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.JobNotFoundException">
        /// The specified job was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/PutJobFailureResult">REST API Reference for PutJobFailureResult Operation</seealso>
        public Task<PutJobFailureResultResponse> PutJobFailureResultAsync(string jobId, FailureDetails failureDetails, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new PutJobFailureResultRequest();
            request.JobId = jobId;
            request.FailureDetails = failureDetails;
            return PutJobFailureResultAsync(request, cancellationToken);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutJobFailureResult operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutJobFailureResult operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/PutJobFailureResult">REST API Reference for PutJobFailureResult Operation</seealso>
        public Task<PutJobFailureResultResponse> PutJobFailureResultAsync(PutJobFailureResultRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new PutJobFailureResultRequestMarshaller();
            var unmarshaller = PutJobFailureResultResponseUnmarshaller.Instance;

            return InvokeAsync<PutJobFailureResultRequest,PutJobFailureResultResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PutJobSuccessResult


        /// <summary>
        /// Represents the success of a job as returned to the pipeline by a job worker. Only
        /// used for custom actions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutJobSuccessResult service method.</param>
        /// 
        /// <returns>The response from the PutJobSuccessResult service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidJobStateException">
        /// The specified job state was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.JobNotFoundException">
        /// The specified job was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/PutJobSuccessResult">REST API Reference for PutJobSuccessResult Operation</seealso>
        public PutJobSuccessResultResponse PutJobSuccessResult(PutJobSuccessResultRequest request)
        {
            var marshaller = new PutJobSuccessResultRequestMarshaller();
            var unmarshaller = PutJobSuccessResultResponseUnmarshaller.Instance;

            return Invoke<PutJobSuccessResultRequest,PutJobSuccessResultResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutJobSuccessResult operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutJobSuccessResult operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/PutJobSuccessResult">REST API Reference for PutJobSuccessResult Operation</seealso>
        public Task<PutJobSuccessResultResponse> PutJobSuccessResultAsync(PutJobSuccessResultRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new PutJobSuccessResultRequestMarshaller();
            var unmarshaller = PutJobSuccessResultResponseUnmarshaller.Instance;

            return InvokeAsync<PutJobSuccessResultRequest,PutJobSuccessResultResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PutThirdPartyJobFailureResult


        /// <summary>
        /// Represents the failure of a third party job as returned to the pipeline by a job worker.
        /// Only used for partner actions.
        /// </summary>
        /// <param name="jobId">The ID of the job that failed. This is the same ID returned from PollForThirdPartyJobs.</param>
        /// <param name="clientToken">The clientToken portion of the clientId and clientToken pair used to verify that the calling entity is allowed access to the job and its details.</param>
        /// <param name="failureDetails">Represents information about failure details.</param>
        /// 
        /// <returns>The response from the PutThirdPartyJobFailureResult service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidClientTokenException">
        /// The client token was specified in an invalid format
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidJobStateException">
        /// The specified job state was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.JobNotFoundException">
        /// The specified job was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/PutThirdPartyJobFailureResult">REST API Reference for PutThirdPartyJobFailureResult Operation</seealso>
        public PutThirdPartyJobFailureResultResponse PutThirdPartyJobFailureResult(string jobId, string clientToken, FailureDetails failureDetails)
        {
            var request = new PutThirdPartyJobFailureResultRequest();
            request.JobId = jobId;
            request.ClientToken = clientToken;
            request.FailureDetails = failureDetails;
            return PutThirdPartyJobFailureResult(request);
        }


        /// <summary>
        /// Represents the failure of a third party job as returned to the pipeline by a job worker.
        /// Only used for partner actions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutThirdPartyJobFailureResult service method.</param>
        /// 
        /// <returns>The response from the PutThirdPartyJobFailureResult service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidClientTokenException">
        /// The client token was specified in an invalid format
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidJobStateException">
        /// The specified job state was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.JobNotFoundException">
        /// The specified job was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/PutThirdPartyJobFailureResult">REST API Reference for PutThirdPartyJobFailureResult Operation</seealso>
        public PutThirdPartyJobFailureResultResponse PutThirdPartyJobFailureResult(PutThirdPartyJobFailureResultRequest request)
        {
            var marshaller = new PutThirdPartyJobFailureResultRequestMarshaller();
            var unmarshaller = PutThirdPartyJobFailureResultResponseUnmarshaller.Instance;

            return Invoke<PutThirdPartyJobFailureResultRequest,PutThirdPartyJobFailureResultResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Represents the failure of a third party job as returned to the pipeline by a job worker.
        /// Only used for partner actions.
        /// </summary>
        /// <param name="jobId">The ID of the job that failed. This is the same ID returned from PollForThirdPartyJobs.</param>
        /// <param name="clientToken">The clientToken portion of the clientId and clientToken pair used to verify that the calling entity is allowed access to the job and its details.</param>
        /// <param name="failureDetails">Represents information about failure details.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutThirdPartyJobFailureResult service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidClientTokenException">
        /// The client token was specified in an invalid format
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidJobStateException">
        /// The specified job state was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.JobNotFoundException">
        /// The specified job was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/PutThirdPartyJobFailureResult">REST API Reference for PutThirdPartyJobFailureResult Operation</seealso>
        public Task<PutThirdPartyJobFailureResultResponse> PutThirdPartyJobFailureResultAsync(string jobId, string clientToken, FailureDetails failureDetails, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new PutThirdPartyJobFailureResultRequest();
            request.JobId = jobId;
            request.ClientToken = clientToken;
            request.FailureDetails = failureDetails;
            return PutThirdPartyJobFailureResultAsync(request, cancellationToken);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutThirdPartyJobFailureResult operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutThirdPartyJobFailureResult operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/PutThirdPartyJobFailureResult">REST API Reference for PutThirdPartyJobFailureResult Operation</seealso>
        public Task<PutThirdPartyJobFailureResultResponse> PutThirdPartyJobFailureResultAsync(PutThirdPartyJobFailureResultRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new PutThirdPartyJobFailureResultRequestMarshaller();
            var unmarshaller = PutThirdPartyJobFailureResultResponseUnmarshaller.Instance;

            return InvokeAsync<PutThirdPartyJobFailureResultRequest,PutThirdPartyJobFailureResultResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PutThirdPartyJobSuccessResult


        /// <summary>
        /// Represents the success of a third party job as returned to the pipeline by a job worker.
        /// Only used for partner actions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutThirdPartyJobSuccessResult service method.</param>
        /// 
        /// <returns>The response from the PutThirdPartyJobSuccessResult service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidClientTokenException">
        /// The client token was specified in an invalid format
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidJobStateException">
        /// The specified job state was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.JobNotFoundException">
        /// The specified job was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/PutThirdPartyJobSuccessResult">REST API Reference for PutThirdPartyJobSuccessResult Operation</seealso>
        public PutThirdPartyJobSuccessResultResponse PutThirdPartyJobSuccessResult(PutThirdPartyJobSuccessResultRequest request)
        {
            var marshaller = new PutThirdPartyJobSuccessResultRequestMarshaller();
            var unmarshaller = PutThirdPartyJobSuccessResultResponseUnmarshaller.Instance;

            return Invoke<PutThirdPartyJobSuccessResultRequest,PutThirdPartyJobSuccessResultResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutThirdPartyJobSuccessResult operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutThirdPartyJobSuccessResult operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/PutThirdPartyJobSuccessResult">REST API Reference for PutThirdPartyJobSuccessResult Operation</seealso>
        public Task<PutThirdPartyJobSuccessResultResponse> PutThirdPartyJobSuccessResultAsync(PutThirdPartyJobSuccessResultRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new PutThirdPartyJobSuccessResultRequestMarshaller();
            var unmarshaller = PutThirdPartyJobSuccessResultResponseUnmarshaller.Instance;

            return InvokeAsync<PutThirdPartyJobSuccessResultRequest,PutThirdPartyJobSuccessResultResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RetryStageExecution


        /// <summary>
        /// Resumes the pipeline execution by retrying the last failed actions in a stage.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RetryStageExecution service method.</param>
        /// 
        /// <returns>The response from the RetryStageExecution service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.NotLatestPipelineExecutionException">
        /// The stage has failed in a later run of the pipeline and the pipelineExecutionId associated
        /// with the request is out of date.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.PipelineNotFoundException">
        /// The specified pipeline was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.StageNotFoundException">
        /// The specified stage was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.StageNotRetryableException">
        /// The specified stage can't be retried because the pipeline structure or stage state
        /// changed after the stage was not completed; the stage contains no failed actions; one
        /// or more actions are still in progress; or another retry attempt is already in progress.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/RetryStageExecution">REST API Reference for RetryStageExecution Operation</seealso>
        public RetryStageExecutionResponse RetryStageExecution(RetryStageExecutionRequest request)
        {
            var marshaller = new RetryStageExecutionRequestMarshaller();
            var unmarshaller = RetryStageExecutionResponseUnmarshaller.Instance;

            return Invoke<RetryStageExecutionRequest,RetryStageExecutionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RetryStageExecution operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RetryStageExecution operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/RetryStageExecution">REST API Reference for RetryStageExecution Operation</seealso>
        public Task<RetryStageExecutionResponse> RetryStageExecutionAsync(RetryStageExecutionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RetryStageExecutionRequestMarshaller();
            var unmarshaller = RetryStageExecutionResponseUnmarshaller.Instance;

            return InvokeAsync<RetryStageExecutionRequest,RetryStageExecutionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  StartPipelineExecution


        /// <summary>
        /// Starts the specified pipeline. Specifically, it begins processing the latest commit
        /// to the source location specified as part of the pipeline.
        /// </summary>
        /// <param name="name">The name of the pipeline to start.</param>
        /// 
        /// <returns>The response from the StartPipelineExecution service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.PipelineNotFoundException">
        /// The specified pipeline was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/StartPipelineExecution">REST API Reference for StartPipelineExecution Operation</seealso>
        public StartPipelineExecutionResponse StartPipelineExecution(string name)
        {
            var request = new StartPipelineExecutionRequest();
            request.Name = name;
            return StartPipelineExecution(request);
        }


        /// <summary>
        /// Starts the specified pipeline. Specifically, it begins processing the latest commit
        /// to the source location specified as part of the pipeline.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartPipelineExecution service method.</param>
        /// 
        /// <returns>The response from the StartPipelineExecution service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.PipelineNotFoundException">
        /// The specified pipeline was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/StartPipelineExecution">REST API Reference for StartPipelineExecution Operation</seealso>
        public StartPipelineExecutionResponse StartPipelineExecution(StartPipelineExecutionRequest request)
        {
            var marshaller = new StartPipelineExecutionRequestMarshaller();
            var unmarshaller = StartPipelineExecutionResponseUnmarshaller.Instance;

            return Invoke<StartPipelineExecutionRequest,StartPipelineExecutionResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Starts the specified pipeline. Specifically, it begins processing the latest commit
        /// to the source location specified as part of the pipeline.
        /// </summary>
        /// <param name="name">The name of the pipeline to start.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartPipelineExecution service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.PipelineNotFoundException">
        /// The specified pipeline was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/StartPipelineExecution">REST API Reference for StartPipelineExecution Operation</seealso>
        public Task<StartPipelineExecutionResponse> StartPipelineExecutionAsync(string name, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new StartPipelineExecutionRequest();
            request.Name = name;
            return StartPipelineExecutionAsync(request, cancellationToken);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartPipelineExecution operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartPipelineExecution operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/StartPipelineExecution">REST API Reference for StartPipelineExecution Operation</seealso>
        public Task<StartPipelineExecutionResponse> StartPipelineExecutionAsync(StartPipelineExecutionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new StartPipelineExecutionRequestMarshaller();
            var unmarshaller = StartPipelineExecutionResponseUnmarshaller.Instance;

            return InvokeAsync<StartPipelineExecutionRequest,StartPipelineExecutionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdatePipeline


        /// <summary>
        /// Updates a specified pipeline with edits or changes to its structure. Use a JSON file
        /// with the pipeline structure in conjunction with UpdatePipeline to provide the full
        /// structure of the pipeline. Updating the pipeline increases the version number of the
        /// pipeline by 1.
        /// </summary>
        /// <param name="pipeline">The name of the pipeline to be updated.</param>
        /// 
        /// <returns>The response from the UpdatePipeline service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidActionDeclarationException">
        /// The specified action declaration was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidBlockerDeclarationException">
        /// Reserved for future use.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidStageDeclarationException">
        /// The specified stage declaration was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidStructureException">
        /// The specified structure was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/UpdatePipeline">REST API Reference for UpdatePipeline Operation</seealso>
        public UpdatePipelineResponse UpdatePipeline(PipelineDeclaration pipeline)
        {
            var request = new UpdatePipelineRequest();
            request.Pipeline = pipeline;
            return UpdatePipeline(request);
        }


        /// <summary>
        /// Updates a specified pipeline with edits or changes to its structure. Use a JSON file
        /// with the pipeline structure in conjunction with UpdatePipeline to provide the full
        /// structure of the pipeline. Updating the pipeline increases the version number of the
        /// pipeline by 1.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePipeline service method.</param>
        /// 
        /// <returns>The response from the UpdatePipeline service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidActionDeclarationException">
        /// The specified action declaration was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidBlockerDeclarationException">
        /// Reserved for future use.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidStageDeclarationException">
        /// The specified stage declaration was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidStructureException">
        /// The specified structure was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/UpdatePipeline">REST API Reference for UpdatePipeline Operation</seealso>
        public UpdatePipelineResponse UpdatePipeline(UpdatePipelineRequest request)
        {
            var marshaller = new UpdatePipelineRequestMarshaller();
            var unmarshaller = UpdatePipelineResponseUnmarshaller.Instance;

            return Invoke<UpdatePipelineRequest,UpdatePipelineResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Updates a specified pipeline with edits or changes to its structure. Use a JSON file
        /// with the pipeline structure in conjunction with UpdatePipeline to provide the full
        /// structure of the pipeline. Updating the pipeline increases the version number of the
        /// pipeline by 1.
        /// </summary>
        /// <param name="pipeline">The name of the pipeline to be updated.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdatePipeline service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidActionDeclarationException">
        /// The specified action declaration was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidBlockerDeclarationException">
        /// Reserved for future use.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidStageDeclarationException">
        /// The specified stage declaration was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidStructureException">
        /// The specified structure was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/UpdatePipeline">REST API Reference for UpdatePipeline Operation</seealso>
        public Task<UpdatePipelineResponse> UpdatePipelineAsync(PipelineDeclaration pipeline, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new UpdatePipelineRequest();
            request.Pipeline = pipeline;
            return UpdatePipelineAsync(request, cancellationToken);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdatePipeline operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdatePipeline operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/UpdatePipeline">REST API Reference for UpdatePipeline Operation</seealso>
        public Task<UpdatePipelineResponse> UpdatePipelineAsync(UpdatePipelineRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdatePipelineRequestMarshaller();
            var unmarshaller = UpdatePipelineResponseUnmarshaller.Instance;

            return InvokeAsync<UpdatePipelineRequest,UpdatePipelineResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
    }
}