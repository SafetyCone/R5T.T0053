using System;


namespace R5T.T0053
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class IdentifierTypeCode : IIdentifierTypeCode
    {
        #region Static
        
        public static IdentifierTypeCode Instance { get; } = new();

        #endregion
    }
}