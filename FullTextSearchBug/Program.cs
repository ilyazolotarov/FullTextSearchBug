using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace FullTextSearchBug
{
	class Program
	{
		static void Main(string[] args)
		{
			var dbcontext = new AppDbContext();

			var res1 = dbcontext.Set<AppEntity>()
				.FirstOrDefault(z => z.SearchVector.Matches(EF.Functions.PhraseToTsQuery("english", "some query"))); //OK

			var cfgName = "english";
			var res2 = dbcontext.Set<AppEntity>()
				.FirstOrDefault(z => z.SearchVector.Matches(EF.Functions.PhraseToTsQuery(cfgName, "some query"))); //Exception
		}
	}
}
