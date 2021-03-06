﻿// Copyright (c) Microsoft Corporation
// All rights reserved

namespace Microsoft.VisualStudio.Text.Adornments
{
    /// <summary>
    /// Enumerates the predefined error types.
    /// </summary>
    public static class PredefinedErrorTypeNames
    {
        /// <summary>
        /// Represents syntax errors.
        /// </summary>
        public const string SyntaxError = "syntax error";

        /// <summary>
        /// Represents compiler errors.
        /// </summary>
        public const string CompilerError = "compiler error";

        /// <summary>
        /// Represents other errors.
        /// </summary>
        public const string OtherError = "other error";

        /// <summary>
        /// Represents compiler warnings.
        /// </summary>
        public const string Warning = "compiler warning";

        /// <summary>
        /// Represents a suggestion.
        /// </summary>
        public const string Suggestion = "suggestion";
    }
}
