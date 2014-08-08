# Basic OAuth 2.0 server on ASP.NET MVC

[![Build status](https://ci.appveyor.com/api/projects/status/23xjt31be9gsql3q)](https://ci.appveyor.com/project/ErikSchierboom/basicoauth2server)

## Introduction
Creating an OAuth 2.0 server is hard. Luckily, the [DotNetOpenAuth](http://www.dotnetopenauth.net/) (DNOA) library takes away a lot of the pain. But still it is quite hard to implement an OAuth 2.0 server using DNOA. Therefore I have created a small ASP.NET MVC 4 website that uses DNOA to function as an OAuth 2.0 server. To be able to test this server, there is also a small console application that connects to the server and requests some tokens. The code has been sprinkled with comments to explain in detail what the application does and why.

## Implementation
The OAuth2Server project contains the implementation of the OAuth 2 server that will output the access tokens. The flow of a token request is as follows:

 1. The token request is made to "/tokens" 
 2. The request is routed by ASP.NET MVC to the `Index` action of the [`TokensController`](OAuth2Server/Controllers/TokensController.cs)
 3. The `Index` action uses the `AuthorizationServer`'s `HandleTokenRequest` method to handle the token request
 4. When the `HandleTokenRequest` is called, a call is made to our [`AuthorizationServerHost`](OAuth2Server/Models/AuthorizationServerHost.cs) class (which was provided as a parameter to `AuthorizationServer`'s constructor)
 5. Depending on the type of token request, either `CheckAuthorizeResourceOwnerCredentialGrant` (for resource owner credentials grants) or `CheckAuthorizeClientCredentialsGrant` (for client credentials grants) is called
 6. In those methods we can check if the token request is valid. Our server verifies the request against some hard-coded values.

## Usage
 1. Clone this project to your development machine
 2. Open the BasicOAuth2Server.sln solution file
 3. Build the solution
 4. Run the OAuth2Server website
 5. Use the website's built in test client or run the OAuth2Client application

## Notes
As the backing store for the nonces and keys is an in-memory data structure, that means that it is not possible to refer to a previously issued token. This means that this demo is *only* about how to return client and user access tokens, you can't actually use them later (as the server would not recognize them). If you want a more advanced example that stores the nonces and keys persistently, check out my [basicoath2server.persistent project](https://github.com/ErikSchierboom/basicoauth2server.persistent).

## License
[Apache License 2.0](LICENSE.md)
