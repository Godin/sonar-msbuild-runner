﻿//-----------------------------------------------------------------------
// <copyright file="WellKnownProjectProperties.cs" company="SonarSource SA and Microsoft Corporation">
//   Copyright (c) SonarSource SA and Microsoft Corporation.  All rights reserved.
//   Licensed under the MIT License. See License.txt in the project root for license information.
// </copyright>
//-----------------------------------------------------------------------

using System.Collections.Generic;

namespace SonarQube.MSBuild.Tasks.IntegrationTests
{
    /// <summary>
    /// Dictionary with strongly-typed accessors for some well-known properties
    /// </summary>
    internal class WellKnownProjectProperties : Dictionary<string, string>
    {
        #region Public properties

        public string SonarQubeExclude
        {
            get { return this.GetValueOrNull(TargetProperties.SonarQubeExcludeMetadata); }
            set { this[TargetProperties.SonarQubeExcludeMetadata] = value; }
        }

        public string SonarQubeTargetsPath
        {
            get { return this.GetValueOrNull(TargetProperties.SonarQubeTargetsPath); }
            set { this[TargetProperties.SonarQubeTargetsPath] = value; }
        }

        public string SonarQubeOutputPath
        {
            get { return this.GetValueOrNull(TargetProperties.SonarQubeOutputPath); }
            set { this[TargetProperties.SonarQubeOutputPath] = value; }
        }

        public string SonarQubeConfigPath
        {
            get { return this.GetValueOrNull(TargetProperties.SonarQubeConfigPath); }
            set { this[TargetProperties.SonarQubeConfigPath] = value; }
        }

        public string SonarQubeTempPath
        {
            get { return this.GetValueOrNull(TargetProperties.SonarQubeTempPath); }
            set { this[TargetProperties.SonarQubeTempPath] = value; }
        }

        public string RunCodeAnalysis
        {
            get { return this.GetValueOrNull(TargetProperties.RunCodeAnalysis); }
            set { this[TargetProperties.RunCodeAnalysis] = value; }
        }

        public string CodeAnalysisLogFile
        {
            get { return this.GetValueOrNull(TargetProperties.CodeAnalysisLogFile); }
            set { this[TargetProperties.CodeAnalysisLogFile] = value; }
        }

        public string CodeAnalysisRuleset
        {
            get { return this.GetValueOrNull(TargetProperties.CodeAnalysisRuleset); }
            set { this[TargetProperties.CodeAnalysisRuleset] = value; }
        }

        public string ResolvedCodeAnalysisRuleset
        {
            get { return this.GetValueOrNull(TargetProperties.ResolvedCodeAnalysisRuleset); }
            set { this[TargetProperties.ResolvedCodeAnalysisRuleset] = value; }
        }

        public string ErrorLog
        {
            get { return this.GetValueOrNull(TargetProperties.ErrorLog); }
            set { this[TargetProperties.ErrorLog] = value; }
        }

        public string WarningsAsErrors
        {
            get { return this.GetValueOrNull(TargetProperties.WarningsAsErrors); }
            set { this[TargetProperties.WarningsAsErrors] = value; }
        }

        public string TreatWarningsAsErrors
        {
            get { return this.GetValueOrNull(TargetProperties.TreatWarningsAsErrors); }
            set { this[TargetProperties.TreatWarningsAsErrors] = value; }
        }

        public string WarningLevel
        {
            get { return this.GetValueOrNull(TargetProperties.WarningLevel); }
            set { this[TargetProperties.WarningLevel] = value; }
        }

        public string AssemblyName
        {
            get { return this.GetValueOrNull(TargetProperties.AssemblyName); }
            set { this[TargetProperties.AssemblyName] = value; }
        }

        public string TeamBuildLegacyBuildDirectory
        {
            get { return this.GetValueOrNull(TargetProperties.BuildDirectory_Legacy); }
            set { this[TargetProperties.BuildDirectory_Legacy] = value; }
        }

        public string TeamBuild2105BuildDirectory
        {
            get { return this.GetValueOrNull(TargetProperties.BuildDirectory_TFS2015); }
            set { this[TargetProperties.BuildDirectory_TFS2015] = value; }
        }

        public string MSBuildExtensionsPath
        {
            get { return this.GetValueOrNull(TargetProperties.MSBuildExtensionsPath); }
            set { this[TargetProperties.MSBuildExtensionsPath] = value; }
        }

        public string SonarTestProject
        {
            get { return this.GetValueOrNull(TargetProperties.SonarQubeTestProject); }
            set { this[TargetProperties.SonarQubeTestProject] = value; }
        }

        public string ProjectTypeGuids
        {
            get { return this.GetValueOrNull(TargetProperties.ProjectTypeGuids); }
            set { this[TargetProperties.ProjectTypeGuids] = value; }
        }

        #endregion

        #region Private methods

        private string GetValueOrNull(string key)
        {
            string value;
            this.TryGetValue(key, out value);
            return value;
        }

        #endregion
    }
}
