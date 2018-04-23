using DevExpress.XtraEditors;
using DevExpress.DashboardCommon;

namespace Pivot_ConditionalFormatting {
    public partial class Form1 : XtraForm {
        public Form1() {
            InitializeComponent();
            Dashboard dashboard = new Dashboard();
            dashboard.LoadFromXml(@"..\..\Data\Dashboard.xml");
            PivotDashboardItem pivot = (PivotDashboardItem)dashboard.Items["pivotDashboardItem1"];

            PivotItemFormatRule firstLevelRule = new PivotItemFormatRule(pivot.Values[0]);
            FormatConditionValue greaterThanCondition = new FormatConditionValue();
            greaterThanCondition.Condition = DashboardFormatCondition.Greater;
            greaterThanCondition.Value1 = 30000;
            greaterThanCondition.StyleSettings =
                new AppearanceSettings(FormatConditionAppearanceType.Green);
            firstLevelRule.Condition = greaterThanCondition;
            firstLevelRule.IntersectionLevelMode = FormatConditionIntersectionLevelMode.FirstLevel;

            PivotItemFormatRule lastLevelRule = new PivotItemFormatRule(pivot.Values[0]);
            FormatConditionRangeGradient rangeCondition =
                new FormatConditionRangeGradient(FormatConditionRangeGradientPredefinedType.WhiteGreen);
            lastLevelRule.Condition = rangeCondition;
            lastLevelRule.IntersectionLevelMode = FormatConditionIntersectionLevelMode.LastLevel;

            PivotItemFormatRule grandTotalRule = new PivotItemFormatRule(pivot.Values[0]);
            FormatConditionRangeSet rangeTotalCondition = 
                new FormatConditionRangeSet(FormatConditionRangeSetPredefinedType.ColorsPaleRedGreenBlue);
            grandTotalRule.Condition = rangeTotalCondition;
            grandTotalRule.IntersectionLevelMode = FormatConditionIntersectionLevelMode.SpecificLevel;
            grandTotalRule.Level.Row = pivot.Rows[0];

            PivotItemFormatRule topCategoryRule = new PivotItemFormatRule(pivot.Values[0]);
            FormatConditionTopBottom topCondition = new FormatConditionTopBottom();
            topCondition.TopBottom = DashboardFormatConditionTopBottomType.Top;
            topCondition.RankType = DashboardFormatConditionValueType.Number;
            topCondition.Rank = 3;
            topCondition.StyleSettings = new IconSettings(FormatConditionIconType.RatingFullGrayStar);
            topCategoryRule.Condition = topCondition;
            topCategoryRule.IntersectionLevelMode = FormatConditionIntersectionLevelMode.SpecificLevel;
            topCategoryRule.Level.Row = pivot.Rows[0];
            topCategoryRule.DataItemApplyTo = pivot.Rows[0];

            pivot.FormatRules.AddRange(firstLevelRule, lastLevelRule, grandTotalRule, topCategoryRule);
            dashboardViewer1.Dashboard = dashboard;
        }
    }
}
