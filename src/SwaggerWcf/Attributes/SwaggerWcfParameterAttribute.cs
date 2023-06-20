using System;

namespace SwaggerWcf.Attributes
{
    /// <summary>
    ///     Describe a parameter
    /// </summary>
    [AttributeUsage(AttributeTargets.Parameter)]
    public class SwaggerWcfParameterAttribute : Attribute
    {
        /// <summary>
        ///     Describes a parameter
        /// </summary>
        /// <param name="required">Set parameter as required. Defaults is false.</param>
        /// <param name="description">Parameter description.</param>
        /// <param name="parameterType"></param>
        /// <param name="maxLength"></param>
        /// <param name="minLength"></param>
        /// <param name="pattern"></param>
        public SwaggerWcfParameterAttribute(bool required = false, string description = null ,Type parameterType = null, int maxLength = int.MaxValue, int minLength = int.MinValue, string pattern = null)
        {
            Required = required;
            Description = description;
            ParameterType = parameterType;
            MaxLength = maxLength;
            MinLength = minLength;
            Pattern = pattern;
            ExclusiveMaximum = false;
            ExclusiveMinimum = false;
            Maximum = int.MaxValue;
            Minimum = int.MinValue;
        }

        /// <summary>
        ///     Defines if this parameter is required in operations
        /// </summary>
        public bool Required { get; set; }

        /// <summary>
        ///     Description of this parameter
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        ///     Override parameter type
        /// </summary>
        public Type ParameterType { get; set; }

        public int MaxLength { get; set; }

        public int MinLength { get; set; }

        public int Maximum { get; set; }

        public bool ExclusiveMaximum { get; set; }

        public int Minimum { get; set; }

        public bool ExclusiveMinimum { get; set; }

        public string Pattern { get; set; }
        
    }
}