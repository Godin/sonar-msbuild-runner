﻿//-----------------------------------------------------------------------
// <copyright file="MockRoslynV1SarifFixer.cs" company="SonarSource SA and Microsoft Corporation">
//   Copyright (c) SonarSource SA and Microsoft Corporation.  All rights reserved.
//   Licensed under the MIT License. See License.txt in the project root for license information.
// </copyright>
//-----------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SonarQube.Common;

namespace SonarRunner.Shim.Tests
{
    class MockRoslynV1SarifFixer : IRoslynV1SarifFixer
    {

        #region Test Hooks

        public string ReturnVal { get; set; }

        public int CallCount { get; set; }

        public MockRoslynV1SarifFixer(string returnVal)
        {
            this.ReturnVal = returnVal;
            this.CallCount = 0;
        }

        #endregion

        #region IRoslynV1SarifFixer

        public string LoadAndFixFile(string sarifPath, ILogger logger)
        {
            CallCount++;
            return ReturnVal;
        }

        #endregion
    }
}
