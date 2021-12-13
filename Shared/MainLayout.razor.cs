using Microsoft.AspNetCore.Components;
using MudBlazor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace LearnOn.Shared
{
    public partial class MainLayout
    {
        public string Language { get; set; }

		private bool _isLightMode = true;

		public bool _sidebarOpen = false;
		private MudTheme _currentTheme = new MudTheme();

		
		protected string[] customers = { "English", "Hindi", "Tamil", "Telegu", "Kannada", "Bengali", "Malayalam", "Grantha"};


        void OnChange(object value, string name)
        {
           Language = value is IEnumerable<object> ? string.Join(", ", (IEnumerable<object>)value) : value.ToString();

            Console.WriteLine($"{name} value changed to {Language}");
            
        }

		//private void ToggleTheme()
		//{
		//	_isLightMode = !_isLightMode;

		//	if (!_isLightMode)
		//	{
		//		_currentTheme = GenerateDarkTheme();
		//	}
		//	else
		//	{
		//		_currentTheme = new MudTheme();
		//	}
		//}

		private void ToggleTheme(MudTheme changedTheme) => _currentTheme = changedTheme;

		private void ToggleSidebar() => _sidebarOpen = !_sidebarOpen;

		//private MudTheme GenerateDarkTheme() =>
		//	new MudTheme
		//	{
		//		Palette = new Palette()
		//		{
		//			Black = "#27272f",
		//			Background = "#32333d",
		//			BackgroundGrey = "#27272f",
		//			Surface = "#373740",
		//			TextPrimary = "#ffffffb3",
		//			TextSecondary = "rgba(255,255,255, 0.50)",
		//			AppbarBackground = "#27272f",
		//			AppbarText = "#ffffffb3",
		//			DrawerBackground = "#27272f",
		//			DrawerText = "#ffffffb3",
		//			DrawerIcon = "#ffffffb3"
		//		}
		//	};



	}
}
