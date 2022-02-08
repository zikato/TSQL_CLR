DROP FUNCTION IF EXISTS dbo.[RegexMatches]
GO
CREATE FUNCTION [dbo].RegexMatches 
(
	@StringToParse [nvarchar](MAX)
	, @Pattern nvarchar(max) 	
)
RETURNS TABLE (RegexMatch nvarchar(max))
AS EXTERNAL NAME CLR.RegexFunctions.RegexMatches;
