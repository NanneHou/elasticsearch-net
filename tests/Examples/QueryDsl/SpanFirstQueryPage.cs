using Elastic.Xunit.XunitPlumbing;
using Nest;
using System.ComponentModel;

namespace Examples.QueryDsl
{
	public class SpanFirstQueryPage : ExampleBase
	{
		[U(Skip = "Example not implemented")]
		[Description("query-dsl/span-first-query.asciidoc:11")]
		public void Line11()
		{
			// tag::020655381882d0721472a1581e06384a[]
			var response0 = new SearchResponse<object>();
			// end::020655381882d0721472a1581e06384a[]

			response0.MatchesExample(@"GET /_search
			{
			    ""query"": {
			        ""span_first"" : {
			            ""match"" : {
			                ""span_term"" : { ""user"" : ""kimchy"" }
			            },
			            ""end"" : 3
			        }
			    }
			}");
		}
	}
}