Imports DevExpress.XtraEditors
Imports DevExpress.DashboardCommon

Namespace Pivot_ConditionalFormatting
    Partial Public Class Form1
        Inherits XtraForm

        Public Sub New()
            InitializeComponent()
            Dim dashboard As New Dashboard()
            dashboard.LoadFromXml("..\..\Data\Dashboard.xml")
            Dim pivot As PivotDashboardItem =
                CType(dashboard.Items("pivotDashboardItem1"), PivotDashboardItem)

            Dim firstLevelRule As New PivotItemFormatRule(pivot.Values(0))
            Dim greaterThanCondition As New FormatConditionValue()
            greaterThanCondition.Condition = DashboardFormatCondition.Greater
            greaterThanCondition.Value1 = 30000
            greaterThanCondition.StyleSettings =
                New AppearanceSettings(FormatConditionAppearanceType.Green)
            firstLevelRule.Condition = greaterThanCondition
            firstLevelRule.IntersectionLevelMode = FormatConditionIntersectionLevelMode.FirstLevel

            Dim lastLevelRule As New PivotItemFormatRule(pivot.Values(0))
            Dim rangeCondition As New  _
                FormatConditionRangeGradient(FormatConditionRangeGradientPredefinedType.WhiteGreen)
            lastLevelRule.Condition = rangeCondition
            lastLevelRule.IntersectionLevelMode = FormatConditionIntersectionLevelMode.LastLevel

            Dim grandTotalRule As New PivotItemFormatRule(pivot.Values(0))
            Dim rangeTotalCondition As New  _
                FormatConditionRangeSet(FormatConditionRangeSetPredefinedType.ColorsPaleRedGreenBlue)
            grandTotalRule.Condition = rangeTotalCondition
            grandTotalRule.IntersectionLevelMode = FormatConditionIntersectionLevelMode.SpecificLevel
            grandTotalRule.Level.Row = pivot.Rows(0)

            Dim topCategoryRule As New PivotItemFormatRule(pivot.Values(0))
            Dim topCondition As New FormatConditionTopBottom()
            topCondition.TopBottom = DashboardFormatConditionTopBottomType.Top
            topCondition.RankType = DashboardFormatConditionValueType.Number
            topCondition.Rank = 3
            topCondition.StyleSettings = New IconSettings(FormatConditionIconType.RatingFullGrayStar)
            topCategoryRule.Condition = topCondition
            topCategoryRule.IntersectionLevelMode = FormatConditionIntersectionLevelMode.SpecificLevel
            topCategoryRule.Level.Row = pivot.Rows(0)
            topCategoryRule.DataItemApplyTo = pivot.Rows(0)

            pivot.FormatRules.AddRange(firstLevelRule, lastLevelRule, grandTotalRule, topCategoryRule)
            dashboardViewer1.Dashboard = dashboard
        End Sub
    End Class
End Namespace
