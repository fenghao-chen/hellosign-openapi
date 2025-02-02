# Dropbox\Sign\UnclaimedDraftApi

All URIs are relative to https://api.hellosign.com/v3.

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**unclaimedDraftCreate()**](UnclaimedDraftApi.md#unclaimedDraftCreate) | **POST** /unclaimed_draft/create | Create Unclaimed Draft |
| [**unclaimedDraftCreateEmbedded()**](UnclaimedDraftApi.md#unclaimedDraftCreateEmbedded) | **POST** /unclaimed_draft/create_embedded | Create Embedded Unclaimed Draft |
| [**unclaimedDraftCreateEmbeddedWithTemplate()**](UnclaimedDraftApi.md#unclaimedDraftCreateEmbeddedWithTemplate) | **POST** /unclaimed_draft/create_embedded_with_template | Create Embedded Unclaimed Draft with Template |
| [**unclaimedDraftEditAndResend()**](UnclaimedDraftApi.md#unclaimedDraftEditAndResend) | **POST** /unclaimed_draft/edit_and_resend/{signature_request_id} | Edit and Resend Unclaimed Draft |


## `unclaimedDraftCreate()`

```php
unclaimedDraftCreate($unclaimed_draft_create_request): \Dropbox\Sign\Model\UnclaimedDraftCreateResponse
```

Create Unclaimed Draft

Creates a new Draft that can be claimed using the claim URL. The first authenticated user to access the URL will claim the Draft and will be shown either the \"Sign and send\" or the \"Request signature\" page with the Draft loaded. Subsequent access to the claim URL will result in a 404.

### Example

```php
<?php

require_once __DIR__ . "/vendor/autoload.php";

$config = Dropbox\Sign\Configuration::getDefaultConfiguration();

// Configure HTTP basic authorization: api_key
$config->setUsername("YOUR_API_KEY");

// or, configure Bearer (JWT) authorization: oauth2
// $config->setAccessToken("YOUR_ACCESS_TOKEN");

$unclaimedDraftApi = new Dropbox\Sign\Api\UnclaimedDraftApi($config);

$signer1 = new Dropbox\Sign\Model\SubUnclaimedDraftSigner();
$signer1->setEmailAddress("jack@example.com")
    ->setName("Jack")
    ->setOrder(0);

$signer2 = new Dropbox\Sign\Model\SubUnclaimedDraftSigner();
$signer2->setEmailAddress("jill@example.com")
    ->setName("Jill")
    ->setOrder(1);

$signingOptions = new Dropbox\Sign\Model\SubSigningOptions();
$signingOptions->setDraw(true)
    ->setType(true)
    ->setUpload(true)
    ->setPhone(false)
    ->setDefaultType(Dropbox\Sign\Model\SubSigningOptions::DEFAULT_TYPE_DRAW);

$fieldOptions = new Dropbox\Sign\Model\SubFieldOptions();
$fieldOptions->setDateFormat(Dropbox\Sign\Model\SubFieldOptions::DATE_FORMAT_DD_MM_YYYY);

$data = new Dropbox\Sign\Model\UnclaimedDraftCreateRequest();
$data->setSubject("The NDA we talked about")
    ->setType(Dropbox\Sign\Model\UnclaimedDraftCreateRequest::TYPE_REQUEST_SIGNATURE)
    ->setMessage("Please sign this NDA and then we can discuss more. Let me know if you have any questions.")
    ->setSigners([$signer1, $signer2])
    ->setCcEmailAddresses([
        "lawyer@dropboxsign.com",
        "lawyer@dropboxsign.com",
    ])
    ->setFiles([new SplFileObject(__DIR__ . "/example_signature_request.pdf")])
    ->setMetadata([
        "custom_id" => 1234,
        "custom_text" => "NDA #9",
    ])
    ->setSigningOptions($signingOptions)
    ->setFieldOptions($fieldOptions)
    ->setTestMode(true);

try {
    $result = $unclaimedDraftApi->unclaimedDraftCreate($data);
    print_r($result);
} catch (Dropbox\Sign\ApiException $e) {
    $error = $e->getResponseObject();
    echo "Exception when calling Dropbox Sign API: "
        . print_r($error->getError());
}

```

### Parameters

|Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **unclaimed_draft_create_request** | [**\Dropbox\Sign\Model\UnclaimedDraftCreateRequest**](../Model/UnclaimedDraftCreateRequest.md)|  | |

### Return type

[**\Dropbox\Sign\Model\UnclaimedDraftCreateResponse**](../Model/UnclaimedDraftCreateResponse.md)

### Authorization

[api_key](../../README.md#api_key), [oauth2](../../README.md#oauth2)

### HTTP request headers

- **Content-Type**: `application/json`, `multipart/form-data`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `unclaimedDraftCreateEmbedded()`

```php
unclaimedDraftCreateEmbedded($unclaimed_draft_create_embedded_request): \Dropbox\Sign\Model\UnclaimedDraftCreateResponse
```

Create Embedded Unclaimed Draft

Creates a new Draft that can be claimed and used in an embedded iFrame. The first authenticated user to access the URL will claim the Draft and will be shown the \"Request signature\" page with the Draft loaded. Subsequent access to the claim URL will result in a `404`. For this embedded endpoint the `requester_email_address` parameter is required.  **NOTE**: Embedded unclaimed drafts can only be accessed in embedded iFrames whereas normal drafts can be used and accessed on Dropbox Sign.

### Example

```php
<?php

require_once __DIR__ . "/vendor/autoload.php";

$config = Dropbox\Sign\Configuration::getDefaultConfiguration();

// Configure HTTP basic authorization: api_key
$config->setUsername("YOUR_API_KEY");

// or, configure Bearer (JWT) authorization: oauth2
// $config->setAccessToken("YOUR_ACCESS_TOKEN");

$unclaimedDraftApi = new Dropbox\Sign\Api\UnclaimedDraftApi($config);

$data = new Dropbox\Sign\Model\UnclaimedDraftCreateEmbeddedRequest();
$data->setClientId("ec64a202072370a737edf4a0eb7f4437")
    ->setFiles([new SplFileObject(__DIR__ . "/example_signature_request.pdf")])
    ->setRequesterEmailAddress("jack@dropboxsign.com")
    ->setTestMode(true);

try {
    $result = $unclaimedDraftApi->unclaimedDraftCreateEmbedded($data);
    print_r($result);
} catch (Dropbox\Sign\ApiException $e) {
    $error = $e->getResponseObject();
    echo "Exception when calling Dropbox Sign API: "
        . print_r($error->getError());
}

```

### Parameters

|Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **unclaimed_draft_create_embedded_request** | [**\Dropbox\Sign\Model\UnclaimedDraftCreateEmbeddedRequest**](../Model/UnclaimedDraftCreateEmbeddedRequest.md)|  | |

### Return type

[**\Dropbox\Sign\Model\UnclaimedDraftCreateResponse**](../Model/UnclaimedDraftCreateResponse.md)

### Authorization

[api_key](../../README.md#api_key), [oauth2](../../README.md#oauth2)

### HTTP request headers

- **Content-Type**: `application/json`, `multipart/form-data`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `unclaimedDraftCreateEmbeddedWithTemplate()`

```php
unclaimedDraftCreateEmbeddedWithTemplate($unclaimed_draft_create_embedded_with_template_request): \Dropbox\Sign\Model\UnclaimedDraftCreateResponse
```

Create Embedded Unclaimed Draft with Template

Creates a new Draft with a previously saved template(s) that can be claimed and used in an embedded iFrame. The first authenticated user to access the URL will claim the Draft and will be shown the \"Request signature\" page with the Draft loaded. Subsequent access to the claim URL will result in a `404`. For this embedded endpoint the `requester_email_address` parameter is required.  **NOTE**: Embedded unclaimed drafts can only be accessed in embedded iFrames whereas normal drafts can be used and accessed on Dropbox Sign.

### Example

```php
<?php

require_once __DIR__ . "/vendor/autoload.php";

$config = Dropbox\Sign\Configuration::getDefaultConfiguration();

// Configure HTTP basic authorization: api_key
$config->setUsername("YOUR_API_KEY");

// or, configure Bearer (JWT) authorization: oauth2
// $config->setAccessToken("YOUR_ACCESS_TOKEN");

$unclaimedDraftApi = new Dropbox\Sign\Api\UnclaimedDraftApi($config);

$signer1 = new Dropbox\Sign\Model\SubUnclaimedDraftTemplateSigner();
$signer1->setRole("Client")
    ->setName("George")
    ->setEmailAddress("george@example.com");

$cc1 = new Dropbox\Sign\Model\SubCC();
$cc1->setRole("Accounting")
    ->setEmailAddress("accounting@dropboxsign.com");

$data = new Dropbox\Sign\Model\UnclaimedDraftCreateEmbeddedWithTemplateRequest();
$data->setClientId("ec64a202072370a737edf4a0eb7f4437")
    ->setTemplateIds(["61a832ff0d8423f91d503e76bfbcc750f7417c78"])
    ->setRequesterEmailAddress("jack@dropboxsign.com")
    ->setSigners([$signer1])
    ->setCcs([$cc1])
    ->setTestMode(true);

try {
    $result = $unclaimedDraftApi->unclaimedDraftCreateEmbeddedWithTemplate($data);
    print_r($result);
} catch (Dropbox\Sign\ApiException $e) {
    $error = $e->getResponseObject();
    echo "Exception when calling Dropbox Sign API: "
        . print_r($error->getError());
}

```

### Parameters

|Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **unclaimed_draft_create_embedded_with_template_request** | [**\Dropbox\Sign\Model\UnclaimedDraftCreateEmbeddedWithTemplateRequest**](../Model/UnclaimedDraftCreateEmbeddedWithTemplateRequest.md)|  | |

### Return type

[**\Dropbox\Sign\Model\UnclaimedDraftCreateResponse**](../Model/UnclaimedDraftCreateResponse.md)

### Authorization

[api_key](../../README.md#api_key), [oauth2](../../README.md#oauth2)

### HTTP request headers

- **Content-Type**: `application/json`, `multipart/form-data`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `unclaimedDraftEditAndResend()`

```php
unclaimedDraftEditAndResend($signature_request_id, $unclaimed_draft_edit_and_resend_request): \Dropbox\Sign\Model\UnclaimedDraftCreateResponse
```

Edit and Resend Unclaimed Draft

Creates a new signature request from an embedded request that can be edited prior to being sent to the recipients. Parameter `test_mode` can be edited prior to request. Signers can be edited in embedded editor. Requester's email address will remain unchanged if `requester_email_address` parameter is not set.  **NOTE**: Embedded unclaimed drafts can only be accessed in embedded iFrames whereas normal drafts can be used and accessed on Dropbox Sign.

### Example

```php
<?php

require_once __DIR__ . "/vendor/autoload.php";

$config = Dropbox\Sign\Configuration::getDefaultConfiguration();

// Configure HTTP basic authorization: api_key
$config->setUsername("YOUR_API_KEY");

// or, configure Bearer (JWT) authorization: oauth2
// $config->setAccessToken("YOUR_ACCESS_TOKEN");

$unclaimedDraftApi = new Dropbox\Sign\Api\UnclaimedDraftApi($config);

$data = new Dropbox\Sign\Model\UnclaimedDraftEditAndResendRequest();
$data->setClientId("ec64a202072370a737edf4a0eb7f4437")
    ->setTestMode(true);

$signatureRequestId = "2f9781e1a83jdja934d808c153c2e1d3df6f8f2f";

try {
    $result = $unclaimedDraftApi->unclaimedDraftEditAndResend($signatureRequestId, $data);
    print_r($result);
} catch (Dropbox\Sign\ApiException $e) {
    $error = $e->getResponseObject();
    echo "Exception when calling Dropbox Sign API: "
        . print_r($error->getError());
}

```

### Parameters

|Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **signature_request_id** | **string**| The ID of the signature request to edit and resend. | |
| **unclaimed_draft_edit_and_resend_request** | [**\Dropbox\Sign\Model\UnclaimedDraftEditAndResendRequest**](../Model/UnclaimedDraftEditAndResendRequest.md)|  | |

### Return type

[**\Dropbox\Sign\Model\UnclaimedDraftCreateResponse**](../Model/UnclaimedDraftCreateResponse.md)

### Authorization

[api_key](../../README.md#api_key), [oauth2](../../README.md#oauth2)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)
