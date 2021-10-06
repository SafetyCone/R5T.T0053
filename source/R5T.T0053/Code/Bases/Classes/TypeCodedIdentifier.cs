using System;


namespace R5T.T0053
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class TypeCodedIdentifier : ITypeCodedIdentifier
    {
        #region Static
        
        public static TypeCodedIdentifier Instance { get; } = new();

        #endregion
    }
}