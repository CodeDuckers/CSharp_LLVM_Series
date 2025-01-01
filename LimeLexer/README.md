# Episode 1 - Lexer Foundation
1. Create the C# Console App and create a Lexer.cs class
2. Lexer.cs
	- Setup all class properties
	- Setup class constructor
	- Create the `readChar` function
	- Create the `Models/Token.cs` file
3. Token.cs
	- Create the enum to house all possible token types
	- Setup all properties for the token class
	- Setup constructor
	- Implement the interface functions `Equals`, `GetHashCode`
	- Implement the debug function `Print`
	- Setup the `TokenHelper` static class with all known keywords of our language
	- Implement the `LookupIdent` function
4. Lexer.cs
	- Start implementing the `NextToken` function and the `+` case and `default` case
	- Create and implement the `newToken` helper function
	- Finish all arithmetic operator cases: `- * / % ^`
	- Implement the `peekChar` helper function
	- Finish all comparison operators: `< <= > >= == !=`
	- Finish all symbol operators `: ; , ( ) { } [ ]`
	- Add quotes char case
	- Implement the `readString` function
	- Add the `\0` null terminator case
	- Finish out the `default` case, explaining the functions needed
	- Implement `isLetter`, `isDigit`, `readIdentifier`, and `readNumber`
	- Finally implement the `skipWhitespace` function
	- Call the `skipWhitespace` function in `NextToken`
	- Finish the bottom of `NextToken`
	- Implement a debug `GetAllTokens` function
5. Lexer.cs
	- Add the debug functionality into the main function and run the code