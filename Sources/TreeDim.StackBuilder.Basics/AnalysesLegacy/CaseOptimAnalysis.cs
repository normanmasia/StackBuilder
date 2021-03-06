﻿#region Using directives
using System;
using System.Collections.Generic;
using System.Text;
#endregion

namespace treeDiM.StackBuilder.Basics
{
    /// <summary>
    /// 
    /// </summary>
    public class CaseOptimAnalysis : AnalysisLegacy
    {
        #region Data members
        #endregion

        #region Constructor
        public CaseOptimAnalysis(
            BProperties boxProperties
            , PalletProperties palletProperties
            , PalletConstraintSet palletConstraintSet
            , ParamSetPackOptim caseOptimConstraintSet)
            : base(boxProperties.ParentDocument)
        {
        }
        #endregion
    }
}
