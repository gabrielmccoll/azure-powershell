namespace Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801
{
    using Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.PowerShell;

    /// <summary>Definition of a single resource metric.</summary>
    [System.ComponentModel.TypeConverter(typeof(MetricSpecificationTypeConverter))]
    public partial class MetricSpecification
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.MetricSpecification"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IMetricSpecification" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IMetricSpecification DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new MetricSpecification(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.MetricSpecification"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IMetricSpecification" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IMetricSpecification DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new MetricSpecification(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="MetricSpecification" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IMetricSpecification FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.MetricSpecification"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal MetricSpecification(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IMetricSpecificationInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IMetricSpecificationInternal)this).Name, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IMetricSpecificationInternal)this).AggregationType = (string) content.GetValueForProperty("AggregationType",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IMetricSpecificationInternal)this).AggregationType, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IMetricSpecificationInternal)this).Availability = (Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IMetricAvailability[]) content.GetValueForProperty("Availability",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IMetricSpecificationInternal)this).Availability, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IMetricAvailability>(__y, Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.MetricAvailabilityTypeConverter.ConvertFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IMetricSpecificationInternal)this).Category = (string) content.GetValueForProperty("Category",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IMetricSpecificationInternal)this).Category, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IMetricSpecificationInternal)this).Dimension = (Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IDimension[]) content.GetValueForProperty("Dimension",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IMetricSpecificationInternal)this).Dimension, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IDimension>(__y, Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.DimensionTypeConverter.ConvertFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IMetricSpecificationInternal)this).DisplayDescription = (string) content.GetValueForProperty("DisplayDescription",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IMetricSpecificationInternal)this).DisplayDescription, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IMetricSpecificationInternal)this).DisplayName = (string) content.GetValueForProperty("DisplayName",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IMetricSpecificationInternal)this).DisplayName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IMetricSpecificationInternal)this).EnableRegionalMdmAccount = (bool?) content.GetValueForProperty("EnableRegionalMdmAccount",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IMetricSpecificationInternal)this).EnableRegionalMdmAccount, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IMetricSpecificationInternal)this).FillGapWithZero = (bool?) content.GetValueForProperty("FillGapWithZero",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IMetricSpecificationInternal)this).FillGapWithZero, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IMetricSpecificationInternal)this).IsInternal = (bool?) content.GetValueForProperty("IsInternal",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IMetricSpecificationInternal)this).IsInternal, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IMetricSpecificationInternal)this).MetricFilterPattern = (string) content.GetValueForProperty("MetricFilterPattern",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IMetricSpecificationInternal)this).MetricFilterPattern, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IMetricSpecificationInternal)this).SourceMdmAccount = (string) content.GetValueForProperty("SourceMdmAccount",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IMetricSpecificationInternal)this).SourceMdmAccount, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IMetricSpecificationInternal)this).SourceMdmNamespace = (string) content.GetValueForProperty("SourceMdmNamespace",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IMetricSpecificationInternal)this).SourceMdmNamespace, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IMetricSpecificationInternal)this).SupportedTimeGrainType = (string[]) content.GetValueForProperty("SupportedTimeGrainType",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IMetricSpecificationInternal)this).SupportedTimeGrainType, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IMetricSpecificationInternal)this).SupportsInstanceLevelAggregation = (bool?) content.GetValueForProperty("SupportsInstanceLevelAggregation",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IMetricSpecificationInternal)this).SupportsInstanceLevelAggregation, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IMetricSpecificationInternal)this).Unit = (string) content.GetValueForProperty("Unit",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IMetricSpecificationInternal)this).Unit, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.MetricSpecification"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal MetricSpecification(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IMetricSpecificationInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IMetricSpecificationInternal)this).Name, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IMetricSpecificationInternal)this).AggregationType = (string) content.GetValueForProperty("AggregationType",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IMetricSpecificationInternal)this).AggregationType, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IMetricSpecificationInternal)this).Availability = (Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IMetricAvailability[]) content.GetValueForProperty("Availability",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IMetricSpecificationInternal)this).Availability, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IMetricAvailability>(__y, Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.MetricAvailabilityTypeConverter.ConvertFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IMetricSpecificationInternal)this).Category = (string) content.GetValueForProperty("Category",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IMetricSpecificationInternal)this).Category, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IMetricSpecificationInternal)this).Dimension = (Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IDimension[]) content.GetValueForProperty("Dimension",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IMetricSpecificationInternal)this).Dimension, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IDimension>(__y, Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.DimensionTypeConverter.ConvertFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IMetricSpecificationInternal)this).DisplayDescription = (string) content.GetValueForProperty("DisplayDescription",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IMetricSpecificationInternal)this).DisplayDescription, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IMetricSpecificationInternal)this).DisplayName = (string) content.GetValueForProperty("DisplayName",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IMetricSpecificationInternal)this).DisplayName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IMetricSpecificationInternal)this).EnableRegionalMdmAccount = (bool?) content.GetValueForProperty("EnableRegionalMdmAccount",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IMetricSpecificationInternal)this).EnableRegionalMdmAccount, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IMetricSpecificationInternal)this).FillGapWithZero = (bool?) content.GetValueForProperty("FillGapWithZero",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IMetricSpecificationInternal)this).FillGapWithZero, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IMetricSpecificationInternal)this).IsInternal = (bool?) content.GetValueForProperty("IsInternal",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IMetricSpecificationInternal)this).IsInternal, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IMetricSpecificationInternal)this).MetricFilterPattern = (string) content.GetValueForProperty("MetricFilterPattern",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IMetricSpecificationInternal)this).MetricFilterPattern, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IMetricSpecificationInternal)this).SourceMdmAccount = (string) content.GetValueForProperty("SourceMdmAccount",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IMetricSpecificationInternal)this).SourceMdmAccount, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IMetricSpecificationInternal)this).SourceMdmNamespace = (string) content.GetValueForProperty("SourceMdmNamespace",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IMetricSpecificationInternal)this).SourceMdmNamespace, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IMetricSpecificationInternal)this).SupportedTimeGrainType = (string[]) content.GetValueForProperty("SupportedTimeGrainType",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IMetricSpecificationInternal)this).SupportedTimeGrainType, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IMetricSpecificationInternal)this).SupportsInstanceLevelAggregation = (bool?) content.GetValueForProperty("SupportsInstanceLevelAggregation",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IMetricSpecificationInternal)this).SupportsInstanceLevelAggregation, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IMetricSpecificationInternal)this).Unit = (string) content.GetValueForProperty("Unit",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IMetricSpecificationInternal)this).Unit, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Definition of a single resource metric.
    [System.ComponentModel.TypeConverter(typeof(MetricSpecificationTypeConverter))]
    public partial interface IMetricSpecification

    {

    }
}