<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128580678/18.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T267344)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/Pivot_ConditionalFormatting/Form1.cs) (VB: [Form1.vb](./VB/Pivot_ConditionalFormatting/Form1.vb))
<!-- default file list end -->
# Dashboard for WinForms - How to Apply Conditional Formatting to Pivot Cells


The following example demonstrates how to apply conditional formatting to Pivot cells at different detail levels.

*  The **Value** format rule ([FormatConditionValue](https://docs.devexpress.com/Dashboard/DevExpress.DashboardCommon.FormatConditionValue)) applies to the first-level data cells.
* The **Range Gradient** format rule ([FormatConditionRangeGradient](https://docs.devexpress.com/Dashboard/DevExpress.DashboardCommon.FormatConditionRangeGradient)) is used to highlight the last-level data cells.
* The **Color Range** format rule ([FormatConditionRangeSet](https://docs.devexpress.com/Dashboard/DevExpress.DashboardCommon.FormatConditionRangeSet)) classifies values of the Grand Total cells.
* The **Top-Bottom** format rule ([FormatConditionTopBottom](https://docs.devexpress.com/Dashboard/DevExpress.DashboardCommon.FormatConditionTopBottom)) highlights row field values from the top 3 categories.

![screenshot](/images/screenshot.png)

## Documentation

* [Conditional Formatting](https://docs.devexpress.com/Dashboard/116914/common-features/appearance-customization/conditional-formatting)
* [Pivot - Conditional Formatting](https://docs.devexpress.com/Dashboard/401934)
