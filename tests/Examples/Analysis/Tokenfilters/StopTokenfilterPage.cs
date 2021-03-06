using Elastic.Xunit.XunitPlumbing;
using Nest;
using System.ComponentModel;

namespace Examples.Analysis.Tokenfilters
{
	public class StopTokenfilterPage : ExampleBase
	{
		[U(Skip = "Example not implemented")]
		[Description("analysis/tokenfilters/stop-tokenfilter.asciidoc:31")]
		public void Line31()
		{
			// tag::e9738fe09a99080506a07945795e8eda[]
			var response0 = new SearchResponse<object>();
			// end::e9738fe09a99080506a07945795e8eda[]

			response0.MatchesExample(@"GET /_analyze
			{
			  ""tokenizer"": ""standard"",
			  ""filter"": [ ""stop"" ],
			  ""text"": ""a quick fox jumps over the lazy dog""
			}");
		}

		[U(Skip = "Example not implemented")]
		[Description("analysis/tokenfilters/stop-tokenfilter.asciidoc:106")]
		public void Line106()
		{
			// tag::23dc8c9e5e664cced2d3f876f6f70536[]
			var response0 = new SearchResponse<object>();
			// end::23dc8c9e5e664cced2d3f876f6f70536[]

			response0.MatchesExample(@"PUT /my_index
			{
			  ""settings"": {
			    ""analysis"": {
			      ""analyzer"": {
			        ""my_analyzer"": {
			          ""tokenizer"": ""whitespace"",
			          ""filter"": [ ""stop"" ]
			        }
			      }
			    }
			  }
			}");
		}

		[U(Skip = "Example not implemented")]
		[Description("analysis/tokenfilters/stop-tokenfilter.asciidoc:183")]
		public void Line183()
		{
			// tag::b683b2aa02f50d62a8b73d1f3603f738[]
			var response0 = new SearchResponse<object>();
			// end::b683b2aa02f50d62a8b73d1f3603f738[]

			response0.MatchesExample(@"PUT /my_index
			{
			  ""settings"": {
			    ""analysis"": {
			      ""analyzer"": {
			        ""default"": {
			          ""tokenizer"": ""whitespace"",
			          ""filter"": [ ""my_custom_stop_words_filter"" ]
			        }
			      },
			      ""filter"": {
			        ""my_custom_stop_words_filter"": {
			          ""type"": ""stop"",
			          ""ignore_case"": true
			        }
			      }
			    }
			  }
			}");
		}

		[U(Skip = "Example not implemented")]
		[Description("analysis/tokenfilters/stop-tokenfilter.asciidoc:210")]
		public void Line210()
		{
			// tag::99cde757233651f95081224683960b0e[]
			var response0 = new SearchResponse<object>();
			// end::99cde757233651f95081224683960b0e[]

			response0.MatchesExample(@"PUT /my_index
			{
			  ""settings"": {
			    ""analysis"": {
			      ""analyzer"": {
			        ""default"": {
			          ""tokenizer"": ""whitespace"",
			          ""filter"": [ ""my_custom_stop_words_filter"" ]
			        }
			      },
			      ""filter"": {
			        ""my_custom_stop_words_filter"": {
			          ""type"": ""stop"",
			          ""ignore_case"": true,
			          ""stopwords"": [ ""and"", ""is"", ""the"" ]
			        }
			      }
			    }
			  }
			}");
		}
	}
}