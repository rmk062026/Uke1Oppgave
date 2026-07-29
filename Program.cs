// Code information variables
string codeTitle = "";
string codeDescription = "";


// TODO : Store title and desc in another way
// Error codes
//  Code 400
string badRequestTitle = "400: Bad request";
string badRequestDesc = "The server can’t process the request because of a client error.";

// Code 401
string unauthorizedTitle = "401: Unauthorized";
string unauthorizedDesc = "The client doesn’t have the proper credentials to access the resource";

// Code 403
string forbiddenTitle = "403: Forbidden";
string forbiddenDesc = "The client isn’t authorized to access the resource, even though the server knows the client’s identity.";

// Code 404
string notFoundTitle = "404: Not found";
string notFoundDesc = "The server can’t find the resource. Often because a browser is requesting an incorrect URL or the content no longer exists.";

// Code 408
string requestTimeoutTitle = "408: Request timeout";
string requestTimeoutDesc = "The server gave up waiting because the client didn’t complete the request fast enough";

// Server Error Codes
// Code 500
string internalServerErrorTitle = "500: Internal server error";
string internalServerErrorDesc = "The server encountered an error and couldn’t complete the request";

// Application start
Console.WriteLine("HTTP status searcher!");
Console.WriteLine("*********************\n");
Console.WriteLine("Enter status code:");
string input = Console.ReadLine()!;

if (int.TryParse(input, out int code))
{

    // Find matching HTTP status code
    switch (code)
    {
        case 400:
            codeTitle = badRequestTitle;
            codeDescription = badRequestDesc;
            break;

        case 401:
            codeTitle = unauthorizedTitle;
            codeDescription = unauthorizedDesc;
            break;
        case 403:
            codeTitle = forbiddenTitle;
            codeDescription = forbiddenDesc;
            break;
        case 404:
            codeTitle = notFoundTitle;
            codeDescription = notFoundDesc;
            break;
        case 408:
            codeTitle = requestTimeoutTitle;
            codeDescription = requestTimeoutDesc;
            break;
        case 500:
            codeTitle = internalServerErrorTitle;
            codeDescription = internalServerErrorDesc;
            break;
        default:
            codeTitle = "Code not found.";
            codeDescription = "Use 400, 401, 403, 404, 408 and 500.";
            break;
    }
    Console.WriteLine($"HTTP Code: {codeTitle}");
    Console.WriteLine($"Description: {codeDescription}");
}
else
{
    Console.WriteLine($"Type just numbers...");
}