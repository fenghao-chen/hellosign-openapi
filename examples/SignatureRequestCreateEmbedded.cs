using System;
using System.Collections.Generic;
using System.IO;
using Dropbox.Sign.Api;
using Dropbox.Sign.Client;
using Dropbox.Sign.Model;

public class Example
{
    public static void Main()
    {
        var config = new Configuration();
        // Configure HTTP basic authorization: api_key
        config.Username = "YOUR_API_KEY";

        // or, configure Bearer (JWT) authorization: oauth2
        // config.AccessToken = "YOUR_BEARER_TOKEN";

        var signatureRequestApi = new SignatureRequestApi(config);

        var signer1 = new SubSignatureRequestSigner(
            emailAddress: "jack@example.com",
            name: "Jack",
            order: 0
        );

        var signer2 = new SubSignatureRequestSigner(
            emailAddress: "jill@example.com",
            name: "Jill",
            order: 1
        );

        var signingOptions = new SubSigningOptions(
            draw: true,
            type: true,
            upload: true,
            phone: true,
            defaultType: SubSigningOptions.DefaultTypeEnum.Draw
        );

        var files = new List<Stream> {
            new FileStream(
                "./example_signature_request.pdf",
                FileMode.Open,
                FileAccess.Read,
                FileShare.Read
            )
        };

        var data = new SignatureRequestCreateEmbeddedRequest(
            clientId: "ec64a202072370a737edf4a0eb7f4437",
            title: "NDA with Acme Co.",
            subject: "The NDA we talked about",
            message: "Please sign this NDA and then we can discuss more. Let me know if you have any questions.",
            signers: new List<SubSignatureRequestSigner>(){signer1, signer2},
            ccEmailAddresses: new List<string>(){"lawyer@dropboxsign.com", "lawyer@dropboxsign.com"},
            files: files,
            signingOptions: signingOptions,
            testMode: true
        );

        try
        {
            var result = signatureRequestApi.SignatureRequestCreateEmbedded(data);
            Console.WriteLine(result);
        }
        catch (ApiException e)
        {
            Console.WriteLine("Exception when calling Dropbox Sign API: " + e.Message);
            Console.WriteLine("Status Code: " + e.ErrorCode);
            Console.WriteLine(e.StackTrace);
        }
    }
}
