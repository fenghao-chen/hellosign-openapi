<?php
/**
 * AccountResponseQuotas
 *
 * PHP version 7.3
 *
 * @category Class
 * @author   OpenAPI Generator team
 * @see     https://openapi-generator.tech
 */

/**
 * Dropbox Sign API
 *
 * Dropbox Sign v3 API
 *
 * The version of the OpenAPI document: 3.0.0
 * Contact: apisupport@hellosign.com
 * Generated by: https://openapi-generator.tech
 * OpenAPI Generator version: 5.3.0
 */

/**
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */

namespace HelloSignSDK\Model;

use ArrayAccess;
use HelloSignSDK\ObjectSerializer;
use JsonSerializable;

/**
 * AccountResponseQuotas Class Doc Comment
 *
 * @category Class
 * @description Details concerning remaining monthly quotas.
 * @author   OpenAPI Generator team
 * @see     https://openapi-generator.tech
 * @implements \ArrayAccess<TKey, TValue>
 * @template TKey int|null
 * @template TValue mixed|null
 * @internal This class should not be instantiated directly
 */
class AccountResponseQuotas implements ModelInterface, ArrayAccess, JsonSerializable
{
    public const DISCRIMINATOR = null;

    /**
     * The original name of the model.
     *
     * @var string
     */
    protected static $openAPIModelName = 'AccountResponseQuotas';

    /**
     * Array of property to type mappings. Used for (de)serialization
     *
     * @var string[]
     */
    protected static $openAPITypes = [
        'api_signature_requests_left' => 'int',
        'documents_left' => 'int',
        'templates_total' => 'int',
        'templates_left' => 'int',
        'sms_verifications_left' => 'int',
    ];

    /**
     * Array of property to format mappings. Used for (de)serialization
     *
     * @var string[]
     * @phpstan-var array<string, string|null>
     * @psalm-var array<string, string|null>
     */
    protected static $openAPIFormats = [
        'api_signature_requests_left' => null,
        'documents_left' => null,
        'templates_total' => null,
        'templates_left' => null,
        'sms_verifications_left' => null,
    ];

    /**
     * Array of property to type mappings. Used for (de)serialization
     *
     * @return array
     */
    public static function openAPITypes()
    {
        return self::$openAPITypes;
    }

    /**
     * Array of property to format mappings. Used for (de)serialization
     *
     * @return array
     */
    public static function openAPIFormats()
    {
        return self::$openAPIFormats;
    }

    /**
     * Array of attributes where the key is the local name,
     * and the value is the original name
     *
     * @var string[]
     */
    protected static $attributeMap = [
        'api_signature_requests_left' => 'api_signature_requests_left',
        'documents_left' => 'documents_left',
        'templates_total' => 'templates_total',
        'templates_left' => 'templates_left',
        'sms_verifications_left' => 'sms_verifications_left',
    ];

    /**
     * Array of attributes to setter functions (for deserialization of responses)
     *
     * @var string[]
     */
    protected static $setters = [
        'api_signature_requests_left' => 'setApiSignatureRequestsLeft',
        'documents_left' => 'setDocumentsLeft',
        'templates_total' => 'setTemplatesTotal',
        'templates_left' => 'setTemplatesLeft',
        'sms_verifications_left' => 'setSmsVerificationsLeft',
    ];

    /**
     * Array of attributes to getter functions (for serialization of requests)
     *
     * @var string[]
     */
    protected static $getters = [
        'api_signature_requests_left' => 'getApiSignatureRequestsLeft',
        'documents_left' => 'getDocumentsLeft',
        'templates_total' => 'getTemplatesTotal',
        'templates_left' => 'getTemplatesLeft',
        'sms_verifications_left' => 'getSmsVerificationsLeft',
    ];

    /**
     * Array of attributes where the key is the local name,
     * and the value is the original name
     *
     * @return array
     */
    public static function attributeMap()
    {
        return self::$attributeMap;
    }

    /**
     * Array of attributes to setter functions (for deserialization of responses)
     *
     * @return array
     */
    public static function setters()
    {
        return self::$setters;
    }

    /**
     * Array of attributes to getter functions (for serialization of requests)
     *
     * @return array
     */
    public static function getters()
    {
        return self::$getters;
    }

    /**
     * The original name of the model.
     *
     * @return string
     */
    public function getModelName()
    {
        return self::$openAPIModelName;
    }

    /**
     * Associative array for storing property values
     *
     * @var array
     */
    protected $container = [];

    /**
     * Constructor
     *
     * @param array|null $data Associated array of property values
     *                         initializing the model
     */
    public function __construct(array $data = null)
    {
        $this->container['api_signature_requests_left'] = $data['api_signature_requests_left'] ?? null;
        $this->container['documents_left'] = $data['documents_left'] ?? null;
        $this->container['templates_total'] = $data['templates_total'] ?? null;
        $this->container['templates_left'] = $data['templates_left'] ?? null;
        $this->container['sms_verifications_left'] = $data['sms_verifications_left'] ?? null;
    }

    public static function fromArray(array $data): AccountResponseQuotas
    {
        /** @var AccountResponseQuotas $obj */
        $obj = ObjectSerializer::deserialize(
            $data,
            AccountResponseQuotas::class,
        );

        return $obj;
    }

    /**
     * Show all the invalid properties with reasons.
     *
     * @return array invalid properties with reasons
     */
    public function listInvalidProperties()
    {
        $invalidProperties = [];

        return $invalidProperties;
    }

    /**
     * Validate all the properties in the model
     * return true if all passed
     *
     * @return bool True if all properties are valid
     */
    public function valid()
    {
        return count($this->listInvalidProperties()) === 0;
    }

    /**
     * Gets api_signature_requests_left
     *
     * @return int|null
     */
    public function getApiSignatureRequestsLeft()
    {
        return $this->container['api_signature_requests_left'];
    }

    /**
     * Sets api_signature_requests_left
     *
     * @param int|null $api_signature_requests_left API signature requests remaining
     *
     * @return self
     */
    public function setApiSignatureRequestsLeft(?int $api_signature_requests_left)
    {
        $this->container['api_signature_requests_left'] = $api_signature_requests_left;

        return $this;
    }

    /**
     * Gets documents_left
     *
     * @return int|null
     */
    public function getDocumentsLeft()
    {
        return $this->container['documents_left'];
    }

    /**
     * Sets documents_left
     *
     * @param int|null $documents_left signature requests remaining
     *
     * @return self
     */
    public function setDocumentsLeft(?int $documents_left)
    {
        $this->container['documents_left'] = $documents_left;

        return $this;
    }

    /**
     * Gets templates_total
     *
     * @return int|null
     */
    public function getTemplatesTotal()
    {
        return $this->container['templates_total'];
    }

    /**
     * Sets templates_total
     *
     * @param int|null $templates_total total API templates allowed
     *
     * @return self
     */
    public function setTemplatesTotal(?int $templates_total)
    {
        $this->container['templates_total'] = $templates_total;

        return $this;
    }

    /**
     * Gets templates_left
     *
     * @return int|null
     */
    public function getTemplatesLeft()
    {
        return $this->container['templates_left'];
    }

    /**
     * Sets templates_left
     *
     * @param int|null $templates_left API templates remaining
     *
     * @return self
     */
    public function setTemplatesLeft(?int $templates_left)
    {
        $this->container['templates_left'] = $templates_left;

        return $this;
    }

    /**
     * Gets sms_verifications_left
     *
     * @return int|null
     */
    public function getSmsVerificationsLeft()
    {
        return $this->container['sms_verifications_left'];
    }

    /**
     * Sets sms_verifications_left
     *
     * @param int|null $sms_verifications_left SMS verifications  remaining
     *
     * @return self
     */
    public function setSmsVerificationsLeft(?int $sms_verifications_left)
    {
        $this->container['sms_verifications_left'] = $sms_verifications_left;

        return $this;
    }

    /**
     * Returns true if offset exists. False otherwise.
     *
     * @param mixed $offset Offset
     *
     * @return bool
     */
    #[\ReturnTypeWillChange]
    public function offsetExists($offset)
    {
        return isset($this->container[$offset]);
    }

    /**
     * Gets offset.
     *
     * @param mixed $offset Offset
     *
     * @return mixed|null
     */
    #[\ReturnTypeWillChange]
    public function offsetGet($offset)
    {
        return $this->container[$offset] ?? null;
    }

    /**
     * Sets value based on offset.
     *
     * @param mixed $offset Offset
     * @param mixed $value Value to be set
     *
     * @return void
     */
    #[\ReturnTypeWillChange]
    public function offsetSet($offset, $value)
    {
        if (is_null($offset)) {
            $this->container[] = $value;
        } else {
            $this->container[$offset] = $value;
        }
    }

    /**
     * Unsets offset.
     *
     * @param mixed $offset Offset
     *
     * @return void
     */
    #[\ReturnTypeWillChange]
    public function offsetUnset($offset)
    {
        unset($this->container[$offset]);
    }

    /**
     * Serializes the object to a value that can be serialized natively by json_encode().
     * @see https://www.php.net/manual/en/jsonserializable.jsonserialize.php
     *
     * @return scalar|object|array|null returns data which can be serialized by json_encode(), which is a value
     *                                  of any type other than a resource
     */
    #[\ReturnTypeWillChange]
    public function jsonSerialize()
    {
        return ObjectSerializer::sanitizeForSerialization($this);
    }

    /**
     * Gets the string presentation of the object
     *
     * @return string
     */
    public function __toString()
    {
        return json_encode(
            ObjectSerializer::sanitizeForSerialization($this),
            JSON_UNESCAPED_SLASHES
        );
    }

    /**
     * Gets a header-safe presentation of the object
     *
     * @return string
     */
    public function toHeaderValue()
    {
        return json_encode(ObjectSerializer::sanitizeForSerialization($this));
    }
}
