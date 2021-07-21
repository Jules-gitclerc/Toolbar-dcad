using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ToolBarDcad
{
	/// <summary>
	/// Logique d'interaction pour BenchConfigWindow.xaml
	/// </summary>
	public partial class BenchConfigWindow : Window
	{
		public static readonly string SavePath = @"C:\KalysseDesignCAD\banc_config.txt";
		private const string _defaultConfigPath = @"\\serv-kalysse\EDatas\Dev\Datas\Bancs\";
		private const string _colorConfigFile = @"config_couleurs.txt";
		private const string _standardPatereFile = @"config_pateres_standards.txt";
		private const string _boxPatereFile = @"config_pateres_box.txt";
		private const string _filPateresFile = @"config_pateres_fil.txt";
		private const string _editListText = "Éditer la liste";
		private Dictionary<string, string> _fileForEachNameDico = new Dictionary<string, string>();

		private List<string> _patereTypes = new List<string>()
		{
			"Patères standards",
			"Patères box"
		};
		private List<string> _lisses = new List<string>()
		{
			"Lisse en sapin rouge",
			"Fil sur lisse métallique"
		};



		public BenchConfigWindow()
		{
			InitializeComponent();

			LoadComboFromFile(LisseColoringCombo, _colorConfigFile);
			LoadComboFromFile(ConsoleColoringCombo, _colorConfigFile);
			LoadComboFromFile(PatereColoringCombo, _standardPatereFile);
			LoadCombo(LisseCombo, _lisses);
			LoadCombo(PatereTypeCombo, _patereTypes);

			SelectCombos();
		}

		private void SelectCombos()
		{
			try
			{
				string[] lines = System.IO.File.ReadAllLines(SavePath);

				ConsoleColoringCombo.SelectedItem = $"{lines[1]} - {lines[2]}";
				LisseCombo.SelectedItem = $"{lines[3]}";
				PatereTypeCombo.SelectedItem = lines[4];
				PatereColoringCombo.SelectedItem = $"{lines[5]} - {lines[6]}";

				if (LisseCombo.SelectedItem.ToString() != _lisses[0])
					LisseColoringCombo.SelectedItem = $"{lines[8]} - {lines[9]}";
			}
			catch
			{
				// default config
				ConsoleColoringCombo.SelectedIndex = 3;
				PatereColoringCombo.SelectedIndex = 0;
				LisseColoringCombo.SelectedIndex = 0;
				LisseCombo.SelectedIndex = 0;
				if (LisseColoringCombo.IsEnabled)
					PatereTypeCombo.SelectedIndex = 0;

				WriteConfigToFile();
			}

			if (LisseCombo.SelectedItem.ToString() == _lisses[0])
			{
				LisseColoringCombo.Items.Clear();
			}
		}


		private void LoadComboFromFile(ComboBox combo, string file)
		{
			string[] lines = File.ReadAllLines($@"{_defaultConfigPath}\{file}");
			if (!_fileForEachNameDico.ContainsKey(combo.Name))
			{
				combo.SelectionChanged += EditList;
				_fileForEachNameDico.Add(combo.Name, file);
			}
			else
			{
				_fileForEachNameDico[combo.Name] = file;
			}

			List<string> comboContent = lines.Skip(2).Select(line => $"{line.Split(';')[0]} - {line.Split(';')[1]}").ToList();

			LoadCombo(combo, comboContent);
			int last = combo.Items.Add(_editListText);
		}

		private void EditList(object sender, SelectionChangedEventArgs e)
		{
			if (!IsLoaded || e.AddedItems.Count == 0 || (e.AddedItems[0] as string) != _editListText)
				return;
			ComboBox comboBox = (sender as ComboBox);
			string file = _fileForEachNameDico[comboBox.Name];

			Process p = new Process();
			p.StartInfo.WorkingDirectory = @"\\serv-kalysse\EDatas\Logiciels\AttributeConfig\";
			p.StartInfo.FileName = "AttributeConfig.exe";
			p.StartInfo.Arguments = $@"\\serv-kalysse\EDatas\Dev\Datas\Bancs\{file}";
			p.Start();
			p.WaitForExit();
			comboBox.SelectedItem = 0;
			LoadComboFromFile(comboBox, file);
		}

		private void LoadCombo(ComboBox combo, List<string> contentList)
		{
			combo.Items.Clear();
			foreach (var contentLine in contentList)
			{
				combo.Items.Add(contentLine);
			}
			combo.SelectedIndex = 0;
			
		}

		private void WriteConfigToFile()
		{

				ComboBox[] comboBoxes = new ComboBox[] { ConsoleColoringCombo, LisseCombo, LisseColoringCombo, PatereTypeCombo, PatereColoringCombo };
				string content = @"// Format du fichier : voir \\serv-kalysse\EDatas\Dev\Doc\DocMacro\Macros Bancs Bois.docx" + "\n";

				foreach (var comboBox in comboBoxes)
				{
					if (comboBox.SelectedItem == null)
					{
						content += "\n";
						continue;
					}
					if (comboBox.SelectedItem.ToString() == _editListText)
						return;

				if (comboBox == LisseCombo || comboBox == PatereTypeCombo)
				{
					content += $"{comboBox.SelectedItem}\n";
				}
				else
				{

					string file = _fileForEachNameDico[comboBox.Name];
					string[] lines = File.ReadAllLines($@"{_defaultConfigPath}\{file}");

					string coloringRAL = comboBox.SelectedItem.ToString().Split(new string[] { " - " }, StringSplitOptions.RemoveEmptyEntries)[0];
					string selectedLine = lines.Where(line => line.Split(';')[0] == coloringRAL).FirstOrDefault();
					if (selectedLine == null)
						return;

					string[] attributes = selectedLine.Split(';');

					foreach (string attribute in attributes)
					{
						content += $"{attribute}\n";
					}
				}

				File.WriteAllText(SavePath, content);
			}
			
		}

		private void LisseCombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			if (LisseCombo.SelectedItem.ToString() == _lisses[1])
			{
				PatereTypeCombo.Items.Clear();
				PatereTypeCombo.Items.Add("Patères fil");
				PatereTypeCombo.SelectedIndex = 0;
				LoadComboFromFile(LisseColoringCombo, _colorConfigFile);
				LoadComboFromFile(PatereColoringCombo, _filPateresFile);
			}
			else
			{
				LisseColoringCombo.Items.Clear();
				LoadCombo(PatereTypeCombo, _patereTypes);

				PatereTypeCombo.SelectedIndex = 0;

				if (PatereTypeCombo.SelectedItem.ToString() == _patereTypes[0])
				{
					LoadComboFromFile(PatereColoringCombo, _standardPatereFile);
				}
				else
				{
					LoadComboFromFile(PatereColoringCombo, _boxPatereFile);
				}
			}

			WriteConfigToFile();
		}

		private void PatereTypeCombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			if (!IsLoaded)
				return;

			if (LisseCombo.SelectedItem.ToString() == _lisses[1])
			{
				LoadComboFromFile(PatereColoringCombo, _filPateresFile);
			}
			else
			{
				if (PatereTypeCombo.SelectedItem == null)
					return;


				if (PatereTypeCombo.SelectedItem.ToString() == _patereTypes[0])
				{
					LoadComboFromFile(PatereColoringCombo, _standardPatereFile);
				}
				else
				{
					LoadComboFromFile(PatereColoringCombo, _boxPatereFile);
				}
			}
			WriteConfigToFile();
		}

		private void LisseColoringCombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			if (!IsLoaded)
				return;

			WriteConfigToFile();
		}

		private void PatereColoringCombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			if (!IsLoaded)
				return;

			WriteConfigToFile();
		}

		private void ConsoleColoringCombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			if (!IsLoaded)
				return;

			WriteConfigToFile();
		}
	}
}
