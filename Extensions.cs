	/// <summary>Trims the content of the label to the specified characters and leaves the full value in the tooltip</summary>
	/// <param name="lbl">the Label control</param>
	/// <param name="maxLength">max characters allowed before trimming</param>
	/// <remarks>Ellipsies(...) are used at the end if trimmed</remarks>
	public static void TrimToToolTip (this Label lbl, int maxLength) {
		lbl.Text = lbl.Text.Trim();
		if (lbl.Text.Length > maxLength) {
			lbl.ToolTip = lbl.Text;
			lbl.Text = lbl.Text.Left(maxLength - 3) + "...";
		}
	}

	/// <summary>Trims the content of the ListItems to the specified characters and leaves the full value in the tooltip</summary>
	/// <param name="ddl">the DropDownList control</param>
	/// <param name="maxLength">max characters allowed before trimming</param>
	/// <remarks>Ellipsies(...) are used at the end if trimmed</remarks>
	public static void TrimToToolTip (this DropDownList ddl, int maxLength) { 
		foreach (ListItem item in ddl.Items) {
			item.Text = item.Text.Trim();
			if (item.Text.Length > maxLength) {
				item.Attributes["title"] = item.Text;
				item.Text = item.Text.Left(maxLength - 3) + "...";
			}
		} 
	}