=begin
#HelloSign API

#HelloSign v3 API

The version of the OpenAPI document: 3.0.0
Contact: apisupport@hellosign.com
Generated by: https://openapi-generator.tech
OpenAPI Generator version: 5.3.0

=end

require 'spec_helper'
require 'json_spec'
require_relative '../test_utils'

config = HelloSign.configure
api_client = HelloSign::ApiClient.new(config)

describe HelloSign::EmbeddedApi do
  context 'EmbeddedApiTest' do
    api = HelloSign::EmbeddedApi.new

    it 'testEmbeddedEditUrl' do
      template_id = '5de8179668f2033afac48da1868d0093bf133266'

      request_class = 'EmbeddedEditUrlRequest'
      request_data = get_fixture_data(request_class)[:default]

      response_class = 'EmbeddedEditUrlResponse'
      response_data = get_fixture_data(response_class)[:default]

      set_expected_response(200, JSON.dump(response_data))
      expected = api_client.convert_to_type(response_data, response_class) ||EmbeddedEditUrlResponse
      obj = api_client.convert_to_type(request_data, request_class) || EmbeddedEditUrlRequest

      result = api.embedded_edit_url(template_id, obj)

      expect(result.class.to_s).to eq("HelloSign::#{response_class}")
      expect(result.to_json).to be_json_eql(expected.to_json)
    end

    it 'testEmbeddedSignUrl' do
      signature_id = '50e3542f738adfa7ddd4cbd4c00d2a8ab6e4194b'

      response_class = 'EmbeddedSignUrlResponse'
      response_data = get_fixture_data(response_class)[:default]

      set_expected_response(200, JSON.dump(response_data))
      expected = api_client.convert_to_type(response_data, response_class) || EmbeddedSignUrlResponse

      result = api.embedded_sign_url(signature_id)

      expect(result.class.to_s).to eq("HelloSign::#{response_class}")
      expect(result.to_json).to be_json_eql(expected.to_json)
    end
  end
end