﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;

namespace WpfApplication1
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : Application
	{
		#region radoutlookbar-selection_0
		private void RadOutlookBar1_SelectionChanged(object sender, RoutedEventArgs e)
		{
			RadOutlookBarItem newSelectedItem = (sender as
			RadOutlookBar).SelectedItem as RadOutlookBarItem;
		}
		private void RadOutlookBar1_PreviewSelectionChanged(object sender, Telerik.Windows.Controls.SelectionChangedEventArgs e)
		{
			//use the Handled property to prevent the selection           
		}
		#endregion
	}
}
