--String Functions

--ASCII -Takes character as input and return ascii code of that character

select ASCII('A')

--CHAR - Takes integer as input and return it's ascii code 


select CHAR(65) as CharacterOFASCII;

--LTRIM - Removes the extra spaces form left side of string 
--RTRIM - Removes extra spaces from right side of the string 
--LOWER - Convert input string into Lowes case
--UPPER - Convert input string into Upper case
--Reverse - Reverse all the characters of the string 
--LEN - Return count of total character in the string


--ASCII - 			Return the ASCII code value of a character

--CHAR -			Convert an ASCII value to a character

--CHARINDEX -		Search for a substring inside a string starting from a specified location and return the position of the substring.

--CONCAT -			Join two or more strings into one string

--CONCAT_WS -		Concatenate multiple strings with a separator into a single string

--DIFFERENCE -		Compare the SOUNDEX() values of two strings

--FORMAT -			Return a value formatted with the specified format and optional culture

--LEFT -			Extract a given a number of characters from a character string starting from the left

--LEN -				Return a number of characters of a character string

--LOWER -			Convert a string to lowercase

--LTRIM -			Return a new string from a specified string after removing all leading blanks

--NCHAR -			Return the Unicode character with the specified integer code, as defined by the Unicode standard

--PATINDEX -		Returns the starting position of the first occurrence of a pattern in a string.

--QUOTENAME -		Returns a Unicode string with the delimiters added to make the input string a valid delimited identifier

--REPLACE -			Replace all occurrences of a substring, within a string, with another substring

--REPLICATE -		Return a string repeated a specified number of times

--REVERSE -			Return the reverse order of a character string

--RIGHT -			Extract a given a number of characters from a character string starting from the right

--RTRIM -			Return a new string from a specified string after removing all trailing blanks

--SOUNDEX -			Return a four-character (SOUNDEX) code of a string based on how it is spoken

--SPACE -			Returns a string of repeated spaces.

--STR -				Returns character data converted from numeric data.

--STRING_AGG -		Concatenate rows of strings with a specified separator into a new string

--STRING_ESCAPE -	Escapes special characters in a string and returns a new string with escaped characters

--STRING_SPLIT -	A table-valued function that splits a string into rows of substrings based on a specified separator.

--STUFF -			Delete a part of a string and then insert another substring into the string starting at a specified position.

--SUBSTRING -		Extract a substring within a string starting from a specified location with a specified length

--TRANSLATE -		Replace several single-characters, one-to-one translation in one operation.

--TRIM -			Return a new string from a specified string after removing all leading and trailing blanks

--UNICODE -			Returns the integer value, as defined by the Unicode standard, of a character.

--UPPER -			Convert a string to uppercase


select Len('Vishal') as LengthOfString;

select concat('Gohil ' , 'Vishal') as fullname;


--Write a Query to print A - Z

Declare @Val int
set @Val = 65
while(@val <= 90)
begin 
print char(@val)
set @val = @val+1
end

--General use of string functions in database

select FirstName, LastName, 
-- Query for mask email address - Sa*****@sss.com
-- Table for this query is not present in this database
	SUBSTRING(Email,1,2) + REPLICATE('*',5) + SUBSTRING(Email, CHARINDEX('@',Email), LEN(Email)-charindex('@',Email)+1) as Email
from employee

