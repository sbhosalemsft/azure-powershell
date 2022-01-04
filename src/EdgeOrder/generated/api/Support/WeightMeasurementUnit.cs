// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Support
{

    /// <summary>Unit for the dimensions of weight.</summary>
    public partial struct WeightMeasurementUnit :
        System.IEquatable<WeightMeasurementUnit>
    {
        /// <summary>Kilograms.</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Support.WeightMeasurementUnit Kgs = @"KGS";

        /// <summary>Pounds.</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Support.WeightMeasurementUnit Lbs = @"LBS";

        /// <summary>the value for an instance of the <see cref="WeightMeasurementUnit" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to WeightMeasurementUnit</summary>
        /// <param name="value">the value to convert to an instance of <see cref="WeightMeasurementUnit" />.</param>
        internal static object CreateFrom(object value)
        {
            return new WeightMeasurementUnit(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type WeightMeasurementUnit</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Support.WeightMeasurementUnit e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type WeightMeasurementUnit (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is WeightMeasurementUnit && Equals((WeightMeasurementUnit)obj);
        }

        /// <summary>Returns hashCode for enum WeightMeasurementUnit</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Returns string representation for WeightMeasurementUnit</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Creates an instance of the <see cref="WeightMeasurementUnit" Enum class./></summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private WeightMeasurementUnit(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Implicit operator to convert string to WeightMeasurementUnit</summary>
        /// <param name="value">the value to convert to an instance of <see cref="WeightMeasurementUnit" />.</param>

        public static implicit operator WeightMeasurementUnit(string value)
        {
            return new WeightMeasurementUnit(value);
        }

        /// <summary>Implicit operator to convert WeightMeasurementUnit to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="WeightMeasurementUnit" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Support.WeightMeasurementUnit e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum WeightMeasurementUnit</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Support.WeightMeasurementUnit e1, Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Support.WeightMeasurementUnit e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum WeightMeasurementUnit</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Support.WeightMeasurementUnit e1, Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Support.WeightMeasurementUnit e2)
        {
            return e2.Equals(e1);
        }
    }
}