﻿using System.Threading.Tasks;
using Elastic.Xunit.XunitPlumbing;
using Nest;
using Tests.Framework.EndpointTests;
using static Tests.Framework.EndpointTests.UrlTester;

namespace Tests.XPack.MachineLearning.GetInfluencers
{
	public class GetInfluencersUrlTests : UrlTestsBase
	{
		[U] public override async Task Urls() => await POST("/_ml/anomaly_detectors/job_id/results/influencers")
			.Fluent(c => c.MachineLearning.GetInfluencers("job_id"))
			.Request(c => c.MachineLearning.GetInfluencers(new GetInfluencersRequest("job_id")))
			.FluentAsync(c => c.MachineLearning.GetInfluencersAsync("job_id"))
			.RequestAsync(c => c.MachineLearning.GetInfluencersAsync(new GetInfluencersRequest("job_id")));
	}
}
