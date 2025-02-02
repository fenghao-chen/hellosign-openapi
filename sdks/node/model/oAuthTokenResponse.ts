/**
 * The MIT License (MIT)
 *
 * Copyright (C) 2023 dropbox.com
 *
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 *
 * The above copyright notice and this permission notice shall be included in all
 * copies or substantial portions of the Software.
 *
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
 * SOFTWARE.
 */

import { RequestFile, AttributeTypeMap, ObjectSerializer } from "./models";

export class OAuthTokenResponse {
  "accessToken"?: string;
  "tokenType"?: string;
  "refreshToken"?: string;
  /**
   * Number of seconds until the `access_token` expires. Uses epoch time.
   */
  "expiresIn"?: number;
  "state"?: string | null;

  static discriminator: string | undefined = undefined;

  static attributeTypeMap: AttributeTypeMap = [
    {
      name: "accessToken",
      baseName: "access_token",
      type: "string",
    },
    {
      name: "tokenType",
      baseName: "token_type",
      type: "string",
    },
    {
      name: "refreshToken",
      baseName: "refresh_token",
      type: "string",
    },
    {
      name: "expiresIn",
      baseName: "expires_in",
      type: "number",
    },
    {
      name: "state",
      baseName: "state",
      type: "string",
    },
  ];

  static getAttributeTypeMap(): AttributeTypeMap {
    return OAuthTokenResponse.attributeTypeMap;
  }

  /** Attempt to instantiate and hydrate a new instance of this class */
  static init(data: any): OAuthTokenResponse {
    return ObjectSerializer.deserialize(data, "OAuthTokenResponse");
  }
}
