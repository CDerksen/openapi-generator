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

# Unit tests for Petstore::Pet
# Automatically generated by openapi-generator (https://openapi-generator.tech)
# Please update as you see appropriate
Spectator.describe Petstore::Pet do
  describe "test an instance of Pet" do
    # it "should fail to compile if any required properties is missing" do
    #   assert_compilation_error(path: "./pet_compilation_error_spec.cr", message: "Error: expected argument 'name' to 'Petstore::Pet.new' to be String, not Nil")
    # end

    it "should create an instance of Pet with only required properties" do
      pet = Petstore::Pet.new(id: nil, category: nil, name: "new pet", photo_urls: Array(String).new, tags: nil, status: nil)
      expect(pet).to be_a(Petstore::Pet)
    end

    it "should create an instance of Pet with all properties" do
      pet_id = 12345_i64
      pet = Petstore::Pet.new(id: pet_id, category: Petstore::Category.new(id: pet_id + 10, name: "crystal category"), name: "crystal", photo_urls: ["https://crystal-lang.org"], tags: [Petstore::Tag.new(id: pet_id + 100, name: "crystal tag")], status: "available")
      expect(pet).to be_a(Petstore::Pet)
    end
  end

  describe "#from_json" do
    it "should instantiate a new instance from json string with required properties" do
      pet = Petstore::Pet.from_json("{\"name\": \"json pet\", \"photoUrls\": []}")
      expect(pet).to be_a(Petstore::Pet)
      expect(pet.name).to eq "json pet"
      expect(pet.photo_urls).to eq Array(String).new
    end

    it "should raise error when instantiating a new instance from json string with missing required properties" do
      expect_raises(JSON::SerializableError, /Missing JSON attribute: name/) do
        Petstore::Pet.from_json("{\"photoUrls\": []}")
      end
      expect_raises(JSON::SerializableError, /Missing JSON attribute: photoUrls/) do
        Petstore::Pet.from_json("{\"name\": \"json pet\"}")
      end
    end

    it "should raise error when instantiating a new instance from json string with required properties set to null value" do
      expect_raises(JSON::SerializableError, /Expected String but was Null/) do
        Petstore::Pet.from_json("{\"name\": null, \"photoUrls\": []}")
      end
      expect_raises(JSON::SerializableError, /Expected BeginArray but was Null/) do
        Petstore::Pet.from_json("{\"name\": \"json pet\", \"photoUrls\": null}")
      end
    end
  end

  describe "test attribute 'id'" do
    it "should work" do
      # assertion here. ref: https://crystal-lang.org/reference/guides/testing.html
    end
  end

  describe "test attribute 'category'" do
    it "should work" do
      # assertion here. ref: https://crystal-lang.org/reference/guides/testing.html
    end
  end

  describe "test attribute 'name'" do
    it "should work" do
      # assertion here. ref: https://crystal-lang.org/reference/guides/testing.html
    end
  end

  describe "test attribute 'photo_urls'" do
    it "should work" do
      # assertion here. ref: https://crystal-lang.org/reference/guides/testing.html
    end
  end

  describe "test attribute 'tags'" do
    it "should work" do
      # assertion here. ref: https://crystal-lang.org/reference/guides/testing.html
    end
  end

  describe "test attribute 'status'" do
    it "should work" do
      # assertion here. ref: https://crystal-lang.org/reference/guides/testing.html
      # validator = Petstore::EnumTest::EnumAttributeValidator.new("String", ["available", "pending", "sold"])
      # validator.allowable_values.each do |value|
      #   expect { instance.status = value }.not_to raise_error
      # end
    end
  end
end
