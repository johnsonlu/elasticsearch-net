using Elastic.Xunit.XunitPlumbing;
using Nest;

namespace Examples.XPack.Docs.En.Security.Authentication
{
	public class SamlGuidePage : ExampleBase
	{
		[U(Skip = "Example not implemented")]
		public void Line644()
		{
			// tag::d08f4dfec37979c1442564e64bd74617[]
			var response0 = new SearchResponse<object>();
			// end::d08f4dfec37979c1442564e64bd74617[]

			response0.MatchesExample(@"PUT /_security/role_mapping/saml-kibana
			{
			  ""roles"": [ ""kibana_user"" ],
			  ""enabled"": true,
			  ""rules"": {
			    ""field"": { ""realm.name"": ""saml1"" }
			  }
			}");
		}

		[U(Skip = "Example not implemented")]
		public void Line679()
		{
			// tag::3806cae804fe77bf38b85561592c745b[]
			var response0 = new SearchResponse<object>();
			// end::3806cae804fe77bf38b85561592c745b[]

			response0.MatchesExample(@"PUT /_security/role_mapping/saml-finance
			{
			  ""roles"": [ ""finance_data"" ],
			  ""enabled"": true,
			  ""rules"": { ""all"": [
			        { ""field"": { ""realm.name"": ""saml1"" } },
			        { ""field"": { ""groups"": ""finance-team"" } }
			  ] }
			}");
		}

		[U(Skip = "Example not implemented")]
		public void Line897()
		{
			// tag::49cb3f48a0097bfc597c52fa51c6d379[]
			var response0 = new SearchResponse<object>();
			// end::49cb3f48a0097bfc597c52fa51c6d379[]

			response0.MatchesExample(@"POST /_security/role/saml-service-role
			{
			  ""cluster"" : [""manage_saml"", ""manage_token""]
			}");
		}

		[U(Skip = "Example not implemented")]
		public void Line905()
		{
			// tag::b2b26f8568c5dba7649e79f09b859272[]
			var response0 = new SearchResponse<object>();
			// end::b2b26f8568c5dba7649e79f09b859272[]

			response0.MatchesExample(@"POST /_security/user/saml-service-user
			{
			  ""password"" : ""<somePasswordHere>"",
			  ""roles""    : [""saml-service-role""]
			}");
		}

		[U(Skip = "Example not implemented")]
		public void Line925()
		{
			// tag::a5dfcfd1cfb3558e7912456669c92eee[]
			var response0 = new SearchResponse<object>();
			// end::a5dfcfd1cfb3558e7912456669c92eee[]

			response0.MatchesExample(@"POST /_security/saml/prepare
			{
			  ""realm"" : ""saml1""
			}");
		}

		[U(Skip = "Example not implemented")]
		public void Line948()
		{
			// tag::8e208098a0156c4c92afe0a06960b230[]
			var response0 = new SearchResponse<object>();
			// end::8e208098a0156c4c92afe0a06960b230[]

			response0.MatchesExample(@"POST /_security/saml/authenticate
			{
			  ""content"" : ""PHNhbWxwOlJlc3BvbnNlIHhtbG5zOnNhbWxwPSJ1cm46b2FzaXM6bmFtZXM6dGM6U0FNTDoyLjA6cHJvdG9jb2wiIHhtbG5zOnNhbWw9InVybjpvYXNpczpuYW1lczp0YzpTQU1MOjIuMD....."",
			  ""ids"" : [""4fee3b046395c4e751011e97f8900b5273d56685""]
			}");
		}

		[U(Skip = "Example not implemented")]
		public void Line977()
		{
			// tag::9eda9c39428b0c2c53cbd8ee7ae0f888[]
			var response0 = new SearchResponse<object>();
			// end::9eda9c39428b0c2c53cbd8ee7ae0f888[]

			response0.MatchesExample(@"POST /_security/saml/authenticate
			{
			  ""content"" : ""PHNhbWxwOlJlc3BvbnNlIHhtbG5zOnNhbWxwPSJ1cm46b2FzaXM6bmFtZXM6dGM6U0FNTDoyLjA6cHJvdG9jb2wiIHhtbG5zOnNhbWw9InVybjpvYXNpczpuYW1lczp0YzpTQU1MOjIuMD....."",
			  ""ids"" : []
			}");
		}

		[U(Skip = "Example not implemented")]
		public void Line992()
		{
			// tag::553904c175a76d5ba83bc5d46fff7373[]
			var response0 = new SearchResponse<object>();
			// end::553904c175a76d5ba83bc5d46fff7373[]

			response0.MatchesExample(@"POST /_security/saml/logout
			{
			  ""token"" : ""46ToAxZVaXVVZTVKOVF5YU04ZFJVUDVSZlV3"",
			  ""refresh_token"": ""mJdXLtmvTUSpoLwMvdBt_w""
			}");
		}

		[U(Skip = "Example not implemented")]
		public void Line1010()
		{
			// tag::a71154ea11a5214f409ecfd118e9b5e3[]
			var response0 = new SearchResponse<object>();
			// end::a71154ea11a5214f409ecfd118e9b5e3[]

			response0.MatchesExample(@"POST /_security/saml/invalidate
			{
			  ""query"" : ""SAMLRequest=nZFda4MwFIb%2FiuS%2BmviRpqFaClKQdbvo2g12M2KMraCJ9cRR9utnW4Wyi13sMie873MeznJ1aWrnS3VQGR0j4mLkKC1NUeljjA77zYyhVbIE0dR%2By7fmaHq7U%2BdegXWGpAZ%2B%2F4pR32luBFTAtWgUcCv56%2Fp5y30X87Yz1khTIycdgpUW9kY7WdsC9zxoXTvMvWuVV98YyMnSGH2SYE5pwALBIr9QKiwDGpW0oGVUznGeMyJZKFkQ4jBf5HnhUymjIhzCAL3KNFihbYx8TBYzzGaY7EnIyZwHzCWMfiDnbRIftkSjJr%2BFu0e9v%2B0EgOquRiiZjKpiVFp6j50T4WXoyNJ%2FEWC9fdqc1t%2F1%2B2F3aUpjzhPiXpqMz1%2FHSn4A&SigAlg=http%3A%2F%2Fwww.w3.org%2F2001%2F04%2Fxmldsig-more%23rsa-sha256&Signature=MsAYz2NFdovMG2mXf6TSpu5vlQQyEJAg%2B4KCwBqJTmrb3yGXKUtIgvjqf88eCAK32v3eN8vupjPC8LglYmke1ZnjK0%2FKxzkvSjTVA7mMQe2AQdKbkyC038zzRq%2FYHcjFDE%2Bz0qISwSHZY2NyLePmwU7SexEXnIz37jKC6NMEhus%3D"",
			  ""realm"" : ""saml1""
			}");
		}
	}
}