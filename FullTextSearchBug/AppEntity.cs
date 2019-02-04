using NpgsqlTypes;

namespace FullTextSearchBug
{
	public class AppEntity
	{
		public int Id { get; set; }
		public NpgsqlTsVector SearchVector { get; set; }
	}
}