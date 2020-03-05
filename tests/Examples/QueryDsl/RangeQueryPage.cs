using System;
using Elastic.Xunit.XunitPlumbing;
using Nest;

namespace Examples.QueryDsl
{
	public class RangeQueryPage : ExampleBase
	{
		[U(Skip = "Example not implemented")]
		public void Line16()
		{
			// tag::a116949e446f34dc25ae57d4b703d0c1[]
			var response0 = new SearchResponse<object>();
			// end::a116949e446f34dc25ae57d4b703d0c1[]

			response0.MatchesExample(@"GET /_search
			{
			    ""query"": {
			        ""range"" : {
			            ""age"" : {
			                ""gte"" : 10,
			                ""lte"" : 20,
			                ""boost"" : 2.0
			            }
			        }
			    }
			}");
		}

		[U(Skip = "Example not implemented")]
		public void Line157()
		{
			// tag::67ceac4bf2d9ac7cc500390544cdcb41[]
			var response0 = new SearchResponse<object>();
			// end::67ceac4bf2d9ac7cc500390544cdcb41[]

			response0.MatchesExample(@"GET /_search
			{
			    ""query"": {
			        ""range"" : {
			            ""timestamp"" : {
			                ""gte"" : ""now-1d/d"",
			                ""lt"" :  ""now/d""
			            }
			        }
			    }
			}");
		}

		[U(Skip = "Example not implemented")]
		public void Line219()
		{
			// tag::5c2f486c27bd5346e512265f93375d16[]
			var response0 = new SearchResponse<object>();
			// end::5c2f486c27bd5346e512265f93375d16[]

			response0.MatchesExample(@"GET /_search
			{
			  ""query"": {
			    ""range"": {
			      ""timestamp"": {
			        ""time_zone"": ""+01:00"",        <1>
			        ""gte"": ""2020-01-01T00:00:00"", <2>
			        ""lte"": ""now""                  <3>
			      }
			    }
			  }
			}");
		}
	}
}
