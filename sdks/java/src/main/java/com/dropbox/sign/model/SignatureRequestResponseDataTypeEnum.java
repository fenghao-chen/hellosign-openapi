/*
 * Dropbox Sign API
 * Dropbox Sign v3 API
 *
 * The version of the OpenAPI document: 3.0.0
 * Contact: apisupport@hellosign.com
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */


package com.dropbox.sign.model;

import java.util.Objects;
import java.util.Arrays;
import java.util.Map;
import java.util.HashMap;
import com.fasterxml.jackson.annotation.JsonPropertyOrder;
import com.dropbox.sign.JSON;


import com.fasterxml.jackson.annotation.JsonCreator;
import com.fasterxml.jackson.annotation.JsonValue;

/**
 * Gets or Sets SignatureRequestResponseDataTypeEnum
 */
public enum SignatureRequestResponseDataTypeEnum {
  
  TEXT("text"),
  
  CHECKBOX("checkbox"),
  
  DATE_SIGNED("date_signed"),
  
  DROPDOWN("dropdown"),
  
  INITIALS("initials"),
  
  RADIO("radio"),
  
  SIGNATURE("signature"),
  
  TEXT_MERGE("text-merge"),
  
  CHECKBOX_MERGE("checkbox-merge");

  private String value;

  SignatureRequestResponseDataTypeEnum(String value) {
    this.value = value;
  }

  @JsonValue
  public String getValue() {
    return value;
  }

  @Override
  public String toString() {
    return String.valueOf(value);
  }

  @JsonCreator
  public static SignatureRequestResponseDataTypeEnum fromValue(String value) {
    for (SignatureRequestResponseDataTypeEnum b : SignatureRequestResponseDataTypeEnum.values()) {
      if (b.value.equals(value)) {
        return b;
      }
    }
    throw new IllegalArgumentException("Unexpected value '" + value + "'");
  }
}

