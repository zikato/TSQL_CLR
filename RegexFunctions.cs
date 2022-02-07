using System.Collections;
using System.Data.SqlTypes;
using System.Text.RegularExpressions;
using Microsoft.SqlServer.Server;

public partial class RegexFunctions
{
	private static void FillValues(object obj, out SqlString Value)
	{
		Value = ((Match)obj).Value;
	}

	[SqlFunction(DataAccess = DataAccessKind.Read
		, IsDeterministic = true
		, IsPrecise = true
		, SystemDataAccess = SystemDataAccessKind.None
		, FillRowMethodName = "FillValues"
		, TableDefinition = "RegexMatch nvarchar(max)")]
	public static IEnumerable RegexMatches([SqlFacet(MaxSize = -1)] SqlString StringToParse, SqlString Pattern)
	{
		return Regex.Matches(StringToParse.ToString(), Pattern.ToString());
	}
}
