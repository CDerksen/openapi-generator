# OpenAPI Petstore
#
# This is a sample server Petstore server. For this sample, you can use the api key `special-key` to test the authorization filters.
#
# The version of the OpenAPI document: 1.0.0
#
# Generated by: https://openapi-generator.tech
# Generator version: 7.11.0-SNAPSHOT
#

require "../spec_helper"

# Unit tests for Petstore::FakeApi
# Automatically generated by openapi-generator (https://openapi-generator.tech)
# Please update as you see appropriate
Spectator.describe "FakeApi" do
  describe "test an instance of FakeApi" do
    it "should create an instance of FakeApi" do
      api_instance = Petstore::FakeApi.new
      # TODO expect(api_instance).to be_instance_of(Petstore::FakeApi)
    end
  end

  # unit tests for get_parameter_name_mapping
  # parameter name mapping test
  # @param underscore_type _type
  # @param _type type
  # @param type_with_underscore type_
  # @param type_with_dash type-
  # @param http_debug_option http debug option (to test parameter naming option)
  # @param [Hash] opts the optional parameters
  # @return [nil]
  describe "get_parameter_name_mapping test" do
    it "should work" do
      # assertion here. ref: https://crystal-lang.org/reference/guides/testing.html
    end
  end
end
