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

import axios, { AxiosError, AxiosRequestConfig } from "axios";

/* tslint:disable:no-unused-locals */
import { ErrorResponse } from "../model/errorResponse";
import { UnclaimedDraftCreateEmbeddedRequest } from "../model/unclaimedDraftCreateEmbeddedRequest";
import { UnclaimedDraftCreateEmbeddedWithTemplateRequest } from "../model/unclaimedDraftCreateEmbeddedWithTemplateRequest";
import { UnclaimedDraftCreateRequest } from "../model/unclaimedDraftCreateRequest";
import { UnclaimedDraftCreateResponse } from "../model/unclaimedDraftCreateResponse";
import { UnclaimedDraftEditAndResendRequest } from "../model/unclaimedDraftEditAndResendRequest";

import {
  ObjectSerializer,
  Authentication,
  VoidAuth,
  Interceptor,
} from "../model/models";
import {
  HttpBasicAuth,
  HttpBearerAuth,
  ApiKeyAuth,
  OAuth,
} from "../model/models";

import {
  HttpError,
  optionsI,
  returnTypeT,
  returnTypeI,
  generateFormData,
  toFormData,
  queryParamsSerializer,
} from "./apis";

let defaultBasePath = "https://api.hellosign.com/v3";

// ===============================================
// This file is autogenerated - Please do not edit
// ===============================================

export enum UnclaimedDraftApiApiKeys {}

export class UnclaimedDraftApi {
  protected _basePath = defaultBasePath;
  protected _defaultHeaders: any = {};
  protected _useQuerystring: boolean = false;

  protected authentications = {
    default: <Authentication>new VoidAuth(),
    api_key: new HttpBasicAuth(),
    oauth2: new HttpBearerAuth(),
  };

  protected interceptors: Interceptor[] = [];

  constructor(basePath?: string) {
    if (basePath) {
      this.basePath = basePath;
    }
  }

  set useQuerystring(value: boolean) {
    this._useQuerystring = value;
  }

  set basePath(basePath: string) {
    this._basePath = basePath;
  }

  set defaultHeaders(defaultHeaders: any) {
    this._defaultHeaders = defaultHeaders;
  }

  get defaultHeaders() {
    return this._defaultHeaders;
  }

  get basePath() {
    return this._basePath;
  }

  public setDefaultAuthentication(auth: Authentication) {
    this.authentications.default = auth;
  }

  public setApiKey(key: string) {
    this.authentications.api_key.username = key;
  }

  set username(username: string) {
    this.authentications.api_key.username = username;
  }

  set password(password: string) {
    this.authentications.api_key.password = password;
  }

  set accessToken(accessToken: string | (() => string)) {
    this.authentications.oauth2.accessToken = accessToken;
  }

  public addInterceptor(interceptor: Interceptor) {
    this.interceptors.push(interceptor);
  }

  /**
   * Creates a new Draft that can be claimed using the claim URL. The first authenticated user to access the URL will claim the Draft and will be shown either the \"Sign and send\" or the \"Request signature\" page with the Draft loaded. Subsequent access to the claim URL will result in a 404.
   * @summary Create Unclaimed Draft
   * @param unclaimedDraftCreateRequest
   * @param options
   */
  public async unclaimedDraftCreate(
    unclaimedDraftCreateRequest: UnclaimedDraftCreateRequest,
    options: optionsI = { headers: {} }
  ): Promise<returnTypeT<UnclaimedDraftCreateResponse>> {
    const localVarPath = this.basePath + "/unclaimed_draft/create";
    let localVarQueryParameters: any = {};
    let localVarHeaderParams: any = (<any>Object).assign(
      {},
      this._defaultHeaders
    );
    const produces = ["application/json"];
    // give precedence to 'application/json'
    if (produces.indexOf("application/json") >= 0) {
      localVarHeaderParams["content-type"] = "application/json";
    } else {
      localVarHeaderParams["content-type"] = produces.join(",");
    }
    let localVarFormParams: any = {};
    let localVarBodyParams: any = undefined;

    // verify required parameter 'unclaimedDraftCreateRequest' is not null or undefined
    if (
      unclaimedDraftCreateRequest === null ||
      unclaimedDraftCreateRequest === undefined
    ) {
      throw new Error(
        "Required parameter unclaimedDraftCreateRequest was null or undefined when calling unclaimedDraftCreate."
      );
    }

    (<any>Object).assign(localVarHeaderParams, options.headers);

    let localVarUseFormData = false;

    const result = generateFormData(
      unclaimedDraftCreateRequest,
      UnclaimedDraftCreateRequest.attributeTypeMap
    );
    localVarUseFormData = result.localVarUseFormData;

    let data = {};
    if (localVarUseFormData) {
      const formData = toFormData(result.data);
      data = formData;
      localVarHeaderParams = {
        ...localVarHeaderParams,
        ...formData.getHeaders(),
      };
    } else {
      data = ObjectSerializer.serialize(
        unclaimedDraftCreateRequest,
        "UnclaimedDraftCreateRequest"
      );
    }

    let localVarRequestOptions: AxiosRequestConfig = {
      method: "POST",
      params: localVarQueryParameters,
      headers: localVarHeaderParams,
      url: localVarPath,
      paramsSerializer: this._useQuerystring
        ? queryParamsSerializer
        : undefined,
      responseType: "json",
      data,
    };

    let authenticationPromise = Promise.resolve();
    if (this.authentications.api_key.username) {
      authenticationPromise = authenticationPromise.then(() =>
        this.authentications.api_key.applyToRequest(localVarRequestOptions)
      );
    }
    if (this.authentications.oauth2.accessToken) {
      authenticationPromise = authenticationPromise.then(() =>
        this.authentications.oauth2.applyToRequest(localVarRequestOptions)
      );
    }
    authenticationPromise = authenticationPromise.then(() =>
      this.authentications.default.applyToRequest(localVarRequestOptions)
    );

    let interceptorPromise = authenticationPromise;
    for (const interceptor of this.interceptors) {
      interceptorPromise = interceptorPromise.then(() =>
        interceptor(localVarRequestOptions)
      );
    }

    return interceptorPromise.then(() => {
      return new Promise<returnTypeT<UnclaimedDraftCreateResponse>>(
        (resolve, reject) => {
          axios.request(localVarRequestOptions).then(
            (response) => {
              let body = response.data;

              if (
                response.status &&
                response.status >= 200 &&
                response.status <= 299
              ) {
                body = ObjectSerializer.deserialize(
                  body,
                  "UnclaimedDraftCreateResponse"
                );
                resolve({ response: response, body: body });
              } else {
                reject(new HttpError(response, body, response.status));
              }
            },
            (error: AxiosError) => {
              if (error.response == null) {
                reject(error);
                return;
              }

              const response = error.response;

              let body;

              if (response.status === 200) {
                body = ObjectSerializer.deserialize(
                  response.data,
                  "UnclaimedDraftCreateResponse"
                );

                reject(new HttpError(response, body, response.status));
                return;
              }

              let rangeCodeLeft = Number("4XX"[0] + "00");
              let rangeCodeRight = Number("4XX"[0] + "99");
              if (
                response.status >= rangeCodeLeft &&
                response.status <= rangeCodeRight
              ) {
                body = ObjectSerializer.deserialize(
                  response.data,
                  "ErrorResponse"
                );

                reject(new HttpError(response, body, response.status));
                return;
              }
            }
          );
        }
      );
    });
  }
  /**
   * Creates a new Draft that can be claimed and used in an embedded iFrame. The first authenticated user to access the URL will claim the Draft and will be shown the \"Request signature\" page with the Draft loaded. Subsequent access to the claim URL will result in a `404`. For this embedded endpoint the `requester_email_address` parameter is required.  **NOTE**: Embedded unclaimed drafts can only be accessed in embedded iFrames whereas normal drafts can be used and accessed on Dropbox Sign.
   * @summary Create Embedded Unclaimed Draft
   * @param unclaimedDraftCreateEmbeddedRequest
   * @param options
   */
  public async unclaimedDraftCreateEmbedded(
    unclaimedDraftCreateEmbeddedRequest: UnclaimedDraftCreateEmbeddedRequest,
    options: optionsI = { headers: {} }
  ): Promise<returnTypeT<UnclaimedDraftCreateResponse>> {
    const localVarPath = this.basePath + "/unclaimed_draft/create_embedded";
    let localVarQueryParameters: any = {};
    let localVarHeaderParams: any = (<any>Object).assign(
      {},
      this._defaultHeaders
    );
    const produces = ["application/json"];
    // give precedence to 'application/json'
    if (produces.indexOf("application/json") >= 0) {
      localVarHeaderParams["content-type"] = "application/json";
    } else {
      localVarHeaderParams["content-type"] = produces.join(",");
    }
    let localVarFormParams: any = {};
    let localVarBodyParams: any = undefined;

    // verify required parameter 'unclaimedDraftCreateEmbeddedRequest' is not null or undefined
    if (
      unclaimedDraftCreateEmbeddedRequest === null ||
      unclaimedDraftCreateEmbeddedRequest === undefined
    ) {
      throw new Error(
        "Required parameter unclaimedDraftCreateEmbeddedRequest was null or undefined when calling unclaimedDraftCreateEmbedded."
      );
    }

    (<any>Object).assign(localVarHeaderParams, options.headers);

    let localVarUseFormData = false;

    const result = generateFormData(
      unclaimedDraftCreateEmbeddedRequest,
      UnclaimedDraftCreateEmbeddedRequest.attributeTypeMap
    );
    localVarUseFormData = result.localVarUseFormData;

    let data = {};
    if (localVarUseFormData) {
      const formData = toFormData(result.data);
      data = formData;
      localVarHeaderParams = {
        ...localVarHeaderParams,
        ...formData.getHeaders(),
      };
    } else {
      data = ObjectSerializer.serialize(
        unclaimedDraftCreateEmbeddedRequest,
        "UnclaimedDraftCreateEmbeddedRequest"
      );
    }

    let localVarRequestOptions: AxiosRequestConfig = {
      method: "POST",
      params: localVarQueryParameters,
      headers: localVarHeaderParams,
      url: localVarPath,
      paramsSerializer: this._useQuerystring
        ? queryParamsSerializer
        : undefined,
      responseType: "json",
      data,
    };

    let authenticationPromise = Promise.resolve();
    if (this.authentications.api_key.username) {
      authenticationPromise = authenticationPromise.then(() =>
        this.authentications.api_key.applyToRequest(localVarRequestOptions)
      );
    }
    if (this.authentications.oauth2.accessToken) {
      authenticationPromise = authenticationPromise.then(() =>
        this.authentications.oauth2.applyToRequest(localVarRequestOptions)
      );
    }
    authenticationPromise = authenticationPromise.then(() =>
      this.authentications.default.applyToRequest(localVarRequestOptions)
    );

    let interceptorPromise = authenticationPromise;
    for (const interceptor of this.interceptors) {
      interceptorPromise = interceptorPromise.then(() =>
        interceptor(localVarRequestOptions)
      );
    }

    return interceptorPromise.then(() => {
      return new Promise<returnTypeT<UnclaimedDraftCreateResponse>>(
        (resolve, reject) => {
          axios.request(localVarRequestOptions).then(
            (response) => {
              let body = response.data;

              if (
                response.status &&
                response.status >= 200 &&
                response.status <= 299
              ) {
                body = ObjectSerializer.deserialize(
                  body,
                  "UnclaimedDraftCreateResponse"
                );
                resolve({ response: response, body: body });
              } else {
                reject(new HttpError(response, body, response.status));
              }
            },
            (error: AxiosError) => {
              if (error.response == null) {
                reject(error);
                return;
              }

              const response = error.response;

              let body;

              if (response.status === 200) {
                body = ObjectSerializer.deserialize(
                  response.data,
                  "UnclaimedDraftCreateResponse"
                );

                reject(new HttpError(response, body, response.status));
                return;
              }

              let rangeCodeLeft = Number("4XX"[0] + "00");
              let rangeCodeRight = Number("4XX"[0] + "99");
              if (
                response.status >= rangeCodeLeft &&
                response.status <= rangeCodeRight
              ) {
                body = ObjectSerializer.deserialize(
                  response.data,
                  "ErrorResponse"
                );

                reject(new HttpError(response, body, response.status));
                return;
              }
            }
          );
        }
      );
    });
  }
  /**
   * Creates a new Draft with a previously saved template(s) that can be claimed and used in an embedded iFrame. The first authenticated user to access the URL will claim the Draft and will be shown the \"Request signature\" page with the Draft loaded. Subsequent access to the claim URL will result in a `404`. For this embedded endpoint the `requester_email_address` parameter is required.  **NOTE**: Embedded unclaimed drafts can only be accessed in embedded iFrames whereas normal drafts can be used and accessed on Dropbox Sign.
   * @summary Create Embedded Unclaimed Draft with Template
   * @param unclaimedDraftCreateEmbeddedWithTemplateRequest
   * @param options
   */
  public async unclaimedDraftCreateEmbeddedWithTemplate(
    unclaimedDraftCreateEmbeddedWithTemplateRequest: UnclaimedDraftCreateEmbeddedWithTemplateRequest,
    options: optionsI = { headers: {} }
  ): Promise<returnTypeT<UnclaimedDraftCreateResponse>> {
    const localVarPath =
      this.basePath + "/unclaimed_draft/create_embedded_with_template";
    let localVarQueryParameters: any = {};
    let localVarHeaderParams: any = (<any>Object).assign(
      {},
      this._defaultHeaders
    );
    const produces = ["application/json"];
    // give precedence to 'application/json'
    if (produces.indexOf("application/json") >= 0) {
      localVarHeaderParams["content-type"] = "application/json";
    } else {
      localVarHeaderParams["content-type"] = produces.join(",");
    }
    let localVarFormParams: any = {};
    let localVarBodyParams: any = undefined;

    // verify required parameter 'unclaimedDraftCreateEmbeddedWithTemplateRequest' is not null or undefined
    if (
      unclaimedDraftCreateEmbeddedWithTemplateRequest === null ||
      unclaimedDraftCreateEmbeddedWithTemplateRequest === undefined
    ) {
      throw new Error(
        "Required parameter unclaimedDraftCreateEmbeddedWithTemplateRequest was null or undefined when calling unclaimedDraftCreateEmbeddedWithTemplate."
      );
    }

    (<any>Object).assign(localVarHeaderParams, options.headers);

    let localVarUseFormData = false;

    const result = generateFormData(
      unclaimedDraftCreateEmbeddedWithTemplateRequest,
      UnclaimedDraftCreateEmbeddedWithTemplateRequest.attributeTypeMap
    );
    localVarUseFormData = result.localVarUseFormData;

    let data = {};
    if (localVarUseFormData) {
      const formData = toFormData(result.data);
      data = formData;
      localVarHeaderParams = {
        ...localVarHeaderParams,
        ...formData.getHeaders(),
      };
    } else {
      data = ObjectSerializer.serialize(
        unclaimedDraftCreateEmbeddedWithTemplateRequest,
        "UnclaimedDraftCreateEmbeddedWithTemplateRequest"
      );
    }

    let localVarRequestOptions: AxiosRequestConfig = {
      method: "POST",
      params: localVarQueryParameters,
      headers: localVarHeaderParams,
      url: localVarPath,
      paramsSerializer: this._useQuerystring
        ? queryParamsSerializer
        : undefined,
      responseType: "json",
      data,
    };

    let authenticationPromise = Promise.resolve();
    if (this.authentications.api_key.username) {
      authenticationPromise = authenticationPromise.then(() =>
        this.authentications.api_key.applyToRequest(localVarRequestOptions)
      );
    }
    if (this.authentications.oauth2.accessToken) {
      authenticationPromise = authenticationPromise.then(() =>
        this.authentications.oauth2.applyToRequest(localVarRequestOptions)
      );
    }
    authenticationPromise = authenticationPromise.then(() =>
      this.authentications.default.applyToRequest(localVarRequestOptions)
    );

    let interceptorPromise = authenticationPromise;
    for (const interceptor of this.interceptors) {
      interceptorPromise = interceptorPromise.then(() =>
        interceptor(localVarRequestOptions)
      );
    }

    return interceptorPromise.then(() => {
      return new Promise<returnTypeT<UnclaimedDraftCreateResponse>>(
        (resolve, reject) => {
          axios.request(localVarRequestOptions).then(
            (response) => {
              let body = response.data;

              if (
                response.status &&
                response.status >= 200 &&
                response.status <= 299
              ) {
                body = ObjectSerializer.deserialize(
                  body,
                  "UnclaimedDraftCreateResponse"
                );
                resolve({ response: response, body: body });
              } else {
                reject(new HttpError(response, body, response.status));
              }
            },
            (error: AxiosError) => {
              if (error.response == null) {
                reject(error);
                return;
              }

              const response = error.response;

              let body;

              if (response.status === 200) {
                body = ObjectSerializer.deserialize(
                  response.data,
                  "UnclaimedDraftCreateResponse"
                );

                reject(new HttpError(response, body, response.status));
                return;
              }

              let rangeCodeLeft = Number("4XX"[0] + "00");
              let rangeCodeRight = Number("4XX"[0] + "99");
              if (
                response.status >= rangeCodeLeft &&
                response.status <= rangeCodeRight
              ) {
                body = ObjectSerializer.deserialize(
                  response.data,
                  "ErrorResponse"
                );

                reject(new HttpError(response, body, response.status));
                return;
              }
            }
          );
        }
      );
    });
  }
  /**
   * Creates a new signature request from an embedded request that can be edited prior to being sent to the recipients. Parameter `test_mode` can be edited prior to request. Signers can be edited in embedded editor. Requester\'s email address will remain unchanged if `requester_email_address` parameter is not set.  **NOTE**: Embedded unclaimed drafts can only be accessed in embedded iFrames whereas normal drafts can be used and accessed on Dropbox Sign.
   * @summary Edit and Resend Unclaimed Draft
   * @param signatureRequestId The ID of the signature request to edit and resend.
   * @param unclaimedDraftEditAndResendRequest
   * @param options
   */
  public async unclaimedDraftEditAndResend(
    signatureRequestId: string,
    unclaimedDraftEditAndResendRequest: UnclaimedDraftEditAndResendRequest,
    options: optionsI = { headers: {} }
  ): Promise<returnTypeT<UnclaimedDraftCreateResponse>> {
    const localVarPath =
      this.basePath +
      "/unclaimed_draft/edit_and_resend/{signature_request_id}".replace(
        "{" + "signature_request_id" + "}",
        encodeURIComponent(String(signatureRequestId))
      );
    let localVarQueryParameters: any = {};
    let localVarHeaderParams: any = (<any>Object).assign(
      {},
      this._defaultHeaders
    );
    const produces = ["application/json"];
    // give precedence to 'application/json'
    if (produces.indexOf("application/json") >= 0) {
      localVarHeaderParams["content-type"] = "application/json";
    } else {
      localVarHeaderParams["content-type"] = produces.join(",");
    }
    let localVarFormParams: any = {};
    let localVarBodyParams: any = undefined;

    // verify required parameter 'signatureRequestId' is not null or undefined
    if (signatureRequestId === null || signatureRequestId === undefined) {
      throw new Error(
        "Required parameter signatureRequestId was null or undefined when calling unclaimedDraftEditAndResend."
      );
    }

    // verify required parameter 'unclaimedDraftEditAndResendRequest' is not null or undefined
    if (
      unclaimedDraftEditAndResendRequest === null ||
      unclaimedDraftEditAndResendRequest === undefined
    ) {
      throw new Error(
        "Required parameter unclaimedDraftEditAndResendRequest was null or undefined when calling unclaimedDraftEditAndResend."
      );
    }

    (<any>Object).assign(localVarHeaderParams, options.headers);

    let localVarUseFormData = false;

    const result = generateFormData(
      unclaimedDraftEditAndResendRequest,
      UnclaimedDraftEditAndResendRequest.attributeTypeMap
    );
    localVarUseFormData = result.localVarUseFormData;

    let data = {};
    if (localVarUseFormData) {
      const formData = toFormData(result.data);
      data = formData;
      localVarHeaderParams = {
        ...localVarHeaderParams,
        ...formData.getHeaders(),
      };
    } else {
      data = ObjectSerializer.serialize(
        unclaimedDraftEditAndResendRequest,
        "UnclaimedDraftEditAndResendRequest"
      );
    }

    let localVarRequestOptions: AxiosRequestConfig = {
      method: "POST",
      params: localVarQueryParameters,
      headers: localVarHeaderParams,
      url: localVarPath,
      paramsSerializer: this._useQuerystring
        ? queryParamsSerializer
        : undefined,
      responseType: "json",
      data,
    };

    let authenticationPromise = Promise.resolve();
    if (this.authentications.api_key.username) {
      authenticationPromise = authenticationPromise.then(() =>
        this.authentications.api_key.applyToRequest(localVarRequestOptions)
      );
    }
    if (this.authentications.oauth2.accessToken) {
      authenticationPromise = authenticationPromise.then(() =>
        this.authentications.oauth2.applyToRequest(localVarRequestOptions)
      );
    }
    authenticationPromise = authenticationPromise.then(() =>
      this.authentications.default.applyToRequest(localVarRequestOptions)
    );

    let interceptorPromise = authenticationPromise;
    for (const interceptor of this.interceptors) {
      interceptorPromise = interceptorPromise.then(() =>
        interceptor(localVarRequestOptions)
      );
    }

    return interceptorPromise.then(() => {
      return new Promise<returnTypeT<UnclaimedDraftCreateResponse>>(
        (resolve, reject) => {
          axios.request(localVarRequestOptions).then(
            (response) => {
              let body = response.data;

              if (
                response.status &&
                response.status >= 200 &&
                response.status <= 299
              ) {
                body = ObjectSerializer.deserialize(
                  body,
                  "UnclaimedDraftCreateResponse"
                );
                resolve({ response: response, body: body });
              } else {
                reject(new HttpError(response, body, response.status));
              }
            },
            (error: AxiosError) => {
              if (error.response == null) {
                reject(error);
                return;
              }

              const response = error.response;

              let body;

              if (response.status === 200) {
                body = ObjectSerializer.deserialize(
                  response.data,
                  "UnclaimedDraftCreateResponse"
                );

                reject(new HttpError(response, body, response.status));
                return;
              }

              let rangeCodeLeft = Number("4XX"[0] + "00");
              let rangeCodeRight = Number("4XX"[0] + "99");
              if (
                response.status >= rangeCodeLeft &&
                response.status <= rangeCodeRight
              ) {
                body = ObjectSerializer.deserialize(
                  response.data,
                  "ErrorResponse"
                );

                reject(new HttpError(response, body, response.status));
                return;
              }
            }
          );
        }
      );
    });
  }
}
