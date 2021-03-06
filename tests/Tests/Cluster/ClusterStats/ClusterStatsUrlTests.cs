﻿using System.Threading.Tasks;
using Elastic.Xunit.XunitPlumbing;
using Nest;
using Tests.Framework.EndpointTests;
using static Tests.Framework.EndpointTests.UrlTester;

namespace Tests.Cluster.ClusterStats
{
	public class ClusterStatsUrlTests : UrlTestsBase
	{
		[U] public override async Task Urls()
		{
			await GET("/_cluster/stats")
					.Fluent(c => c.Cluster.Stats())
					.Request(c => c.Cluster.Stats(new ClusterStatsRequest()))
					.FluentAsync(c => c.Cluster.StatsAsync())
					.RequestAsync(c => c.Cluster.StatsAsync(new ClusterStatsRequest()))
				;

			await GET("/_cluster/stats/nodes/foo")
					.Fluent(c => c.Cluster.Stats(s => s.NodeId("foo")))
					.Request(c => c.Cluster.Stats(new ClusterStatsRequest("foo")))
					.FluentAsync(c => c.Cluster.StatsAsync(s => s.NodeId("foo")))
					.RequestAsync(c => c.Cluster.StatsAsync(new ClusterStatsRequest("foo")))
				;
		}
	}
}
