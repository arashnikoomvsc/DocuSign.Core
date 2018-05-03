# DocuSign.Core
DocuSign REST API Client Library (Generated from Swagger documentation) for .NET Core 2.0

# Requirements
- Visual Studio 2017
- .NET Core 2.0

# Installation
```
PM> Install-Package DocuSign.Core
```
Or
```
dotnet add package DocuSign.Core
```
# Usage Example
```csharp
string username = "[YOUR EMAIL]";
string password = "[YOUR PASSWORD]";
string integratorKey = "[INTEGRATOR KEY]";

// initialize client for desired environment (for production change to www)
ApiClient apiClient = new ApiClient("https://demo.docusign.net/restapi");
Configuration.Default.ApiClient = apiClient;

// configure 'X-DocuSign-Authentication' header
string authHeader = "{\"Username\":\"" + username + "\", \"Password\":\"" + password + "\", \"IntegratorKey\":\"" + integratorKey + "\"}";
Configuration.Default.AddDefaultHeader("X-DocuSign-Authentication", authHeader);

// we will retrieve this from the login API call
string accountId = null;

/////////////////////////////////////////////////////////////////
// STEP 1: LOGIN API        
/////////////////////////////////////////////////////////////////

// login call is available in the authentication api 
AuthenticationApi authApi = new AuthenticationApi();
Authentication loginInfo = authApi.LoginInformationGetLoginInformation();

// parse the first account ID that is returned (user might belong to multiple accounts)
accountId = loginInfo.LoginAccounts[0].AccountId;

// Update ApiClient with the new base url from login call
string[] separatingStrings = { "/v2" };
apiClient = new ApiClient(loginInfo.LoginAccounts[0].BaseUrl.Split(separatingStrings, StringSplitOptions.RemoveEmptyEntries)[0]);

/////////////////////////////////////////////////////////////////
// STEP 2: CREATE ENVELOPE API        
/////////////////////////////////////////////////////////////////				

var doc = new Document();
doc.DocumentBase64 = Convert.ToBase64String(File.ReadAllBytes("[PATH TO PDF FILE]"));
doc.DocumentId = "1";
doc.FileExtension = "pdf";
doc.Name = "MyFile.pdf";

// create a new envelope which we will use to send the signature request
EnvelopeDefinition envDef = new EnvelopeDefinition();
envDef.Status = "sent";
envDef.EmailSubject = "eSign With Payment From API";
envDef.Documents = new List<Document>();
envDef.Documents.Add(doc);

// Add a recipient to sign the documeent
Signer signer = new Signer();
signer.Email = "[CUSTOMER EMAIL ADDRESS]";
signer.Name = "[CUSTOMER NAME]";
signer.RecipientId = "1";

// Create a |SignHere| tab somewhere on the document for the recipient to sign
signer.Tabs = new EnvelopeRecipientTabs();
signer.Tabs.SignHereTabs = new List<SignHere>();

SignHere signHere = new SignHere();
signHere.AnchorString = "/sign";
signHere.DocumentId = "1";
signHere.PageNumber = "1";
signHere.RecipientId = "1";

signer.Tabs.SignHereTabs.Add(signHere);

envDef.Recipients = new EnvelopeRecipients();
envDef.Recipients.Signers = new List<Signer>();
envDef.Recipients.Signers.Add(signer);

// Create envelope
EnvelopesApi envelopesApi = new EnvelopesApi();
EnvelopeSummary envelopeSummary = envelopesApi.EnvelopesPostEnvelopes(accountId, null, null, null, envDef);
```
