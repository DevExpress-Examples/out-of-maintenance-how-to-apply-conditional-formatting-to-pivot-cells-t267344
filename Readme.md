<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/Pivot_ConditionalFormatting/Form1.cs) (VB: [Form1.vb](./VB/Pivot_ConditionalFormatting/Form1.vb))
<!-- default file list end -->
# How to Apply Conditional Formatting to Pivot Cells


The following example demonstrates how to apply conditional formatting to Pivot cells at different detail levels.

*  The **Value** format condition ([FormatConditionValue](https://docs.devexpress.com/Dashboard/DevExpress.DashboardCommon.FormatConditionValue)) applies to the first-level data cells.
* The **Range Gradient** condition ([FormatConditionRangeGradient](https://docs.devexpress.com/Dashboard/DevExpress.DashboardCommon.FormatConditionRangeGradient)) is used to highlight the last-level data cells.
* The **Color Range** condition ([FormatConditionRangeSet](https://docs.devexpress.com/Dashboard/DevExpress.DashboardCommon.FormatConditionRangeSet)) classifies values of the Grand Total cells.
* The **Top-Bottom** condition ([FormatConditionTopBottom](https://docs.devexpress.com/Dashboard/DevExpress.DashboardCommon.FormatConditionTopBottom)) highlights row field values from the top 3 categories.

![screenshot](/images/screenshot.png)


