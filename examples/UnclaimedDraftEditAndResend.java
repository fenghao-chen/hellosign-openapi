import com.dropbox.sign.ApiClient;
import com.dropbox.sign.ApiException;
import com.dropbox.sign.Configuration;
import com.dropbox.sign.api.*;
import com.dropbox.sign.auth.HttpBasicAuth;
import com.dropbox.sign.model.*;

public class Example {
    public static void main(String[] args) {
        ApiClient apiClient = Configuration.getDefaultApiClient();

        // Configure HTTP basic authorization: api_key
        HttpBasicAuth apiKey = (HttpBasicAuth) apiClient
            .getAuthentication("api_key");
        apiKey.setUsername("YOUR_API_KEY");

        // or, configure Bearer (JWT) authorization: oauth2
        /*
        HttpBearerAuth oauth2 = (HttpBearerAuth) apiClient
            .getAuthentication("oauth2");

        oauth2.setBearerToken("YOUR_ACCESS_TOKEN");
        */

        UnclaimedDraftApi unclaimedDraftApi = new UnclaimedDraftApi(apiClient);

        UnclaimedDraftEditAndResendRequest data = new UnclaimedDraftEditAndResendRequest()
            .clientId("1a659d9ad95bccd307ecad78d72192f8")
            .testMode(true);

        String signatureRequestId = "2f9781e1a83jdja934d808c153c2e1d3df6f8f2f";

        try {
            UnclaimedDraftCreateResponse result = unclaimedDraftApi.unclaimedDraftEditAndResend(signatureRequestId, data);
            System.out.println(result);
        } catch (ApiException e) {
            System.err.println("Exception when calling AccountApi#accountCreate");
            System.err.println("Status code: " + e.getCode());
            System.err.println("Reason: " + e.getResponseBody());
            System.err.println("Response headers: " + e.getResponseHeaders());
            e.printStackTrace();
        }
    }
}
