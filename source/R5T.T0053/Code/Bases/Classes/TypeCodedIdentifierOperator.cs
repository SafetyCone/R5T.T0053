using System;


namespace R5T.T0053
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class TypeCodedIdentifierOperator : ITypeCodedIdentifierOperator
    {
        #region Static
        
        public static TypeCodedIdentifierOperator Instance { get; } = new();

        #endregion
    }
}