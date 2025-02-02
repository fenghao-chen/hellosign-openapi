=begin
#Dropbox Sign API

#Dropbox Sign v3 API

The version of the OpenAPI document: 3.0.0
Contact: apisupport@hellosign.com
Generated by: https://openapi-generator.tech
OpenAPI Generator version: 5.3.0

=end

require 'date'
require 'time'

module Dropbox
end

module Dropbox::Sign
  class TemplateResponseDocumentFormField
    # A unique id for the form field.
    attr_accessor :api_id

    # The name of the form field.
    attr_accessor :name

    # The type of this form field. See [field types](/api/reference/constants/#field-types).
    attr_accessor :type

    # The signer of the Form Field.
    attr_accessor :signer

    # The horizontal offset in pixels for this form field.
    attr_accessor :x

    # The vertical offset in pixels for this form field.
    attr_accessor :y

    # The width in pixels of this form field.
    attr_accessor :width

    # The height in pixels of this form field.
    attr_accessor :height

    # Boolean showing whether or not this field is required.
    attr_accessor :required

    # The name of the group this field is in. If this field is not a group, this defaults to `null`.
    attr_accessor :group

    attr_accessor :avg_text_length

    # Whether this form field is multiline text.
    attr_accessor :is_multiline

    # Original font size used in this form field's text.
    attr_accessor :original_font_size

    # Font family used in this form field's text.
    attr_accessor :font_family

    class EnumAttributeValidator
      attr_reader :datatype
      attr_reader :allowable_values

      def initialize(datatype, allowable_values)
        @allowable_values = allowable_values.map do |value|
          case datatype.to_s
          when /Integer/i
            value.to_i
          when /Float/i
            value.to_f
          else
            value
          end
        end
      end

      def valid?(value)
        !value || allowable_values.include?(value)
      end
    end

    # Attribute mapping from ruby-style variable name to JSON key.
    def self.attribute_map
      {
        :'api_id' => :'api_id',
        :'name' => :'name',
        :'type' => :'type',
        :'signer' => :'signer',
        :'x' => :'x',
        :'y' => :'y',
        :'width' => :'width',
        :'height' => :'height',
        :'required' => :'required',
        :'group' => :'group',
        :'avg_text_length' => :'avg_text_length',
        :'is_multiline' => :'isMultiline',
        :'original_font_size' => :'originalFontSize',
        :'font_family' => :'fontFamily'
      }
    end

    # Returns all the JSON keys this model knows about
    def self.acceptable_attributes
      attribute_map.values
    end

    # Returns attribute map of this model + parent
    def self.merged_attributes
      self.attribute_map
    end

    # Attribute type mapping.
    def self.openapi_types
      {
        :'api_id' => :'String',
        :'name' => :'String',
        :'type' => :'String',
        :'signer' => :'String',
        :'x' => :'Integer',
        :'y' => :'Integer',
        :'width' => :'Integer',
        :'height' => :'Integer',
        :'required' => :'Boolean',
        :'group' => :'String',
        :'avg_text_length' => :'TemplateResponseFieldAvgTextLength',
        :'is_multiline' => :'Boolean',
        :'original_font_size' => :'Integer',
        :'font_family' => :'String'
      }
    end

    # Attribute type mapping of this model + parent
    def self.merged_types
      self.openapi_types
    end

    # List of attributes with nullable: true
    def self.openapi_nullable
      Set.new([
        :'group',
        :'is_multiline',
        :'original_font_size',
        :'font_family'
      ])
    end

    # Returns list of attributes with nullable: true of this model + parent
    def self.merged_nullable
      self.openapi_nullable
    end

    # Attempt to instantiate and hydrate a new instance of this class
    # @param [Object] data Data to be converted
    # @return [TemplateResponseDocumentFormField]
    def self.init(data)
      return ApiClient.default.convert_to_type(
        data,
        "TemplateResponseDocumentFormField"
      ) || TemplateResponseDocumentFormField.new
    end

    # Initializes the object
    # @param [Hash] attributes Model attributes in the form of hash
    def initialize(attributes = {})
      if (!attributes.is_a?(Hash))
        fail ArgumentError, "The input argument (attributes) must be a hash in `Dropbox::Sign::TemplateResponseDocumentFormField` initialize method"
      end

      # check to see if the attribute exists and convert string to symbol for hash key
      attributes = attributes.each_with_object({}) { |(k, v), h|
        if (!self.class.merged_attributes.key?(k.to_sym))
          fail ArgumentError, "`#{k}` is not a valid attribute in `Dropbox::Sign::TemplateResponseDocumentFormField`. Please check the name to make sure it's valid. List of attributes: " + self.class.attribute_map.keys.inspect
        end
        h[k.to_sym] = v
      }

      if attributes.key?(:'api_id')
        self.api_id = attributes[:'api_id']
      end

      if attributes.key?(:'name')
        self.name = attributes[:'name']
      end

      if attributes.key?(:'type')
        self.type = attributes[:'type']
      end

      if attributes.key?(:'signer')
        self.signer = attributes[:'signer']
      end

      if attributes.key?(:'x')
        self.x = attributes[:'x']
      end

      if attributes.key?(:'y')
        self.y = attributes[:'y']
      end

      if attributes.key?(:'width')
        self.width = attributes[:'width']
      end

      if attributes.key?(:'height')
        self.height = attributes[:'height']
      end

      if attributes.key?(:'required')
        self.required = attributes[:'required']
      end

      if attributes.key?(:'group')
        self.group = attributes[:'group']
      end

      if attributes.key?(:'avg_text_length')
        self.avg_text_length = attributes[:'avg_text_length']
      end

      if attributes.key?(:'is_multiline')
        self.is_multiline = attributes[:'is_multiline']
      end

      if attributes.key?(:'original_font_size')
        self.original_font_size = attributes[:'original_font_size']
      end

      if attributes.key?(:'font_family')
        self.font_family = attributes[:'font_family']
      end
    end

    # Show invalid properties with the reasons. Usually used together with valid?
    # @return Array for valid properties with the reasons
    def list_invalid_properties
      invalid_properties = Array.new
      invalid_properties
    end

    # Check to see if the all the properties in the model are valid
    # @return true if the model is valid
    def valid?
      type_validator = EnumAttributeValidator.new('String', ["checkbox", "checkbox-merge", "date_signed", "dropdown", "hyperlink", "initials", "signature", "radio", "text", "text-merge"])
      return false unless type_validator.valid?(@type)
      true
    end

    # Custom attribute writer method checking allowed values (enum).
    # @param [Object] type Object to be assigned
    def type=(type)
      validator = EnumAttributeValidator.new('String', ["checkbox", "checkbox-merge", "date_signed", "dropdown", "hyperlink", "initials", "signature", "radio", "text", "text-merge"])
      unless validator.valid?(type)
        fail ArgumentError, "invalid value for \"type\", must be one of #{validator.allowable_values}."
      end
      @type = type
    end

    # Checks equality by comparing each attribute.
    # @param [Object] Object to be compared
    def ==(o)
      return true if self.equal?(o)
      self.class == o.class &&
          api_id == o.api_id &&
          name == o.name &&
          type == o.type &&
          signer == o.signer &&
          x == o.x &&
          y == o.y &&
          width == o.width &&
          height == o.height &&
          required == o.required &&
          group == o.group &&
          avg_text_length == o.avg_text_length &&
          is_multiline == o.is_multiline &&
          original_font_size == o.original_font_size &&
          font_family == o.font_family
    end

    # @see the `==` method
    # @param [Object] Object to be compared
    def eql?(o)
      self == o
    end

    # Calculates hash code according to all attributes.
    # @return [Integer] Hash code
    def hash
      [api_id, name, type, signer, x, y, width, height, required, group, avg_text_length, is_multiline, original_font_size, font_family].hash
    end

    # Builds the object from hash
    # @param [Hash] attributes Model attributes in the form of hash
    # @return [Object] Returns the model itself
    def self.build_from_hash(attributes)
      new.build_from_hash(attributes)
    end

    # Builds the object from hash
    # @param [Hash] attributes Model attributes in the form of hash
    # @return [Object] Returns the model itself
    def build_from_hash(attributes)
      return nil unless attributes.is_a?(Hash)
      attribute_map = self.class.merged_attributes

      self.class.merged_types.each_pair do |key, type|
        if type =~ /\AArray<(.*)>/i
          # check to ensure the input is an array given that the attribute
          # is documented as an array but the input is not
          if attributes[attribute_map[key]].is_a?(Array)
            self.send("#{key}=", attributes[attribute_map[key]].map { |v| _deserialize($1, v) })
          end
        elsif !attributes[attribute_map[key]].nil?
          self.send("#{key}=", _deserialize(type, attributes[attribute_map[key]]))
        end
      end

      self
    end

    # Deserializes the data based on type
    # @param string type Data type
    # @param string value Value to be deserialized
    # @return [Object] Deserialized data
    def _deserialize(type, value)
      case type.to_sym
      when :Time
        Time.parse(value)
      when :Date
        Date.parse(value)
      when :String
        value.to_s
      when :Integer
        value.to_i
      when :Float
        value.to_f
      when :Boolean
        if value.to_s =~ /\A(true|t|yes|y|1)\z/i
          true
        else
          false
        end
      when :File
        value
      when :Object
        # generic object (usually a Hash), return directly
        value
      when /\AArray<(?<inner_type>.+)>\z/
        inner_type = Regexp.last_match[:inner_type]
        value.map { |v| _deserialize(inner_type, v) }
      when /\AHash<(?<k_type>.+?), (?<v_type>.+)>\z/
        k_type = Regexp.last_match[:k_type]
        v_type = Regexp.last_match[:v_type]
        {}.tap do |hash|
          value.each do |k, v|
            hash[_deserialize(k_type, k)] = _deserialize(v_type, v)
          end
        end
      else # model
        # models (e.g. Pet)
        klass = Dropbox::Sign.const_get(type)
        klass.respond_to?(:openapi_one_of) ? klass.build(value) : klass.build_from_hash(value)
      end
    end

    # Returns the string representation of the object
    # @return [String] String presentation of the object
    def to_s
      to_hash.to_s
    end

    # to_body is an alias to to_hash (backward compatibility)
    # @return [Hash] Returns the object in the form of hash
    def to_body
      to_hash
    end

    # Returns the object in the form of hash
    # @return [Hash] Returns the object in the form of hash
    def to_hash(include_nil = true)
      hash = {}
      self.class.merged_attributes.each_pair do |attr, param|
        value = self.send(attr)
        if value.nil?
          next unless include_nil
          is_nullable = self.class.merged_nullable.include?(attr)
          next if !is_nullable || (is_nullable && !instance_variable_defined?(:"@#{attr}"))
        end

        hash[param] = _to_hash(value, include_nil)
      end
      hash
    end

    # Outputs non-array value in the form of hash
    # For object, use to_hash. Otherwise, just return the value
    # @param [Object] value Any valid value
    # @return [Hash] Returns the value in the form of hash
    def _to_hash(value, include_nil = true)
      if value.is_a?(Array)
        value.compact.map { |v| _to_hash(v, include_nil) }
      elsif value.is_a?(Hash)
        {}.tap do |hash|
          value.each { |k, v| hash[k] = _to_hash(v, include_nil) }
        end
      elsif value.respond_to? :to_hash
        value.to_hash(include_nil)
      else
        value
      end
    end

  end

end
