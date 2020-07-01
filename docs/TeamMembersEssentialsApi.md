# VimeoOpenApi.Api.TeamMembersEssentialsApi

All URIs are relative to *https://api.vimeo.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetTeamInformation**](TeamMembersEssentialsApi.md#getteaminformation) | **GET** /teammembers/{code} | Get membership information about a team


<a name="getteaminformation"></a>
# **GetTeamInformation**
> void GetTeamInformation (string code)

Get membership information about a team

This method returns information about the membership of the specified team. Usage is currently limited to the team join forms.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class GetTeamInformationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TeamMembersEssentialsApi(config);
            var code = q3u4mrqoc3u4hcnqo34;  // string | The code corresponding to the desired team. This value appears under `TeamUser` > `code`.

            try
            {
                // Get membership information about a team
                apiInstance.GetTeamInformation(code);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TeamMembersEssentialsApi.GetTeamInformation: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **code** | **string**| The code corresponding to the desired team. This value appears under &#x60;TeamUser&#x60; &gt; &#x60;code&#x60;. | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

