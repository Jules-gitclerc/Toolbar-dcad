using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using ToolBarDcad.DesignCad;
using ToolBarDcad.Paths;

namespace ToolBarDcad
{
	/// <summary>
	/// Logique d'interaction pour BenchConfigWindow.xaml
	/// </summary>
	public partial class BenchConfigWindow : Window
	{
		public static readonly string SavePath = @"C:\KalysseDesignCAD\banc_config.txt";
		private const string _defaultConfigPath = @"\\serv-kalysse\EDatas\Dev\Datas\Bancs\";
		private const string _configColorFile = @"config_couleurs.txt";
		private const string _standardPatereFile = @"config_pateres_standards.txt";
		private const string _boxPatereFile = @"config_pateres_box.txt";
		private const string _pateresFilSurLisseFile = @"config_pateres_fil.txt";
		private const string _typesBoisFile = @"config_lames.txt";
		private const string _typesLisseFile = @"config_types_lisses.txt";
		private const string _pateresLisseSapinFile = @"config_pateres_lisse_sapin.txt";
		private const string _pateresLisseSurFilFile = @"config_pateres_fil_sur_lisse.txt";

		private const string _editListText = "Éditer la liste";
		private Dictionary<string, string> _fileForEachNameDico = new Dictionary<string, string>();

		private List<string> _pateresLisseSapin = new List<string>();


		private List<string> _lisses;
		private MainWindow _mainWindow;

		public DocumentsManager DocsManager { get; }

		public BenchConfigWindow(MainWindow mainWindow)
		{
			InitializeComponent();
			_mainWindow = mainWindow;
			Left = (_mainWindow.Left + _mainWindow.Width) - Width;
			Top = _mainWindow.Top;
			DocsManager = new DocumentsManager(mainWindow.App);
			Topmost = true;


			string[] lines = File.ReadAllLines($@"{_defaultConfigPath}\{_typesLisseFile}");
			_lisses = lines.Skip(2).Select(line => $"{line.Split(';')[0]}").ToList();

			lines = File.ReadAllLines($@"{_defaultConfigPath}\{_pateresLisseSapinFile}");
			_pateresLisseSapin = lines.Skip(2).Select(line => $"{line.Split(';')[0]}").ToList();

			LoadComboFromFile(LisseCombo, _typesLisseFile);
			LoadColoringComboFromFile(LameCombo, _typesBoisFile);
			LoadComboFromFile(PatereTypeCombo, _pateresLisseSapinFile);

			LoadColoringComboFromFile(LisseColoringCombo, _configColorFile);
			LoadColoringComboFromFile(ConsoleColoringCombo, _configColorFile);
			LoadColoringComboFromFile(PatereColoringCombo, _standardPatereFile);

			SelectCombos();

			Loaded += (e, s) => WriteConfigToFile();
		}



		private void SelectCombos()
		{
			try
			{
				string[] lines = System.IO.File.ReadAllLines(SavePath);
				ComboBox[] comboBoxes = new ComboBox[] { ConsoleColoringCombo, LisseCombo, LisseColoringCombo, PatereTypeCombo, PatereColoringCombo, LameCombo };
				string[] indexes = lines[0].Split(new string[] { ";" }, StringSplitOptions.RemoveEmptyEntries);
				int i = 0;

				foreach (var comboBox in comboBoxes)
				{
					comboBox.SelectedIndex = int.Parse(indexes[i]);

					if (comboBox == LisseCombo)
						UpdateLisseCombo();
					else if (comboBox == PatereTypeCombo)
						UpdatePatereTypeCombo();

					i++;
				}
			}
			catch
			{
				// default config
				// lisse combo
				LisseCombo.SelectedIndex = 0;
				UpdateLisseCombo();
				LisseColoringCombo.SelectedIndex = 0;

				// patere type
				PatereTypeCombo.SelectedIndex = 0;
				UpdatePatereTypeCombo();
				PatereColoringCombo.SelectedIndex = 0;

				// console & lames
				ConsoleColoringCombo.SelectedIndex = 3;
				LameCombo.SelectedIndex = 0;

				WriteConfigToFile();
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

			List<string> comboContent = lines.Skip(2).Select(line => $"{line.Split(';')[0]}").ToList();
	
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


		private void LoadColoringComboFromFile(ComboBox combo, string file)
		{
			string[] lines = File.ReadAllLines($@"{_defaultConfigPath}\{file}");
			if (!_fileForEachNameDico.ContainsKey(combo.Name))
			{
				combo.SelectionChanged += EditColoringList;
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

		private void EditColoringList(object sender, SelectionChangedEventArgs e)
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
			LoadColoringComboFromFile(comboBox, file);
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

		// Format du fichier : voir \\serv-kalysse\EDatas\Dev\Doc\DocMacro\Macros Bancs Bois.docx
		private void WriteConfigToFile()
		{
			if (!IsLoaded)
				return;

			ComboBox[] comboBoxes = new ComboBox[] { ConsoleColoringCombo, LisseCombo, LisseColoringCombo, PatereTypeCombo, PatereColoringCombo, LameCombo };
			string content = "";
			foreach (var comboBox in comboBoxes)
			{
				content += $"{comboBox.SelectedIndex};";
			}
			content += "\n";

			List<string> patereDims = new List<string>();

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
					if (comboBox == PatereTypeCombo)
					{
						string file = _fileForEachNameDico[comboBox.Name];
						string[] lines = File.ReadAllLines($@"{_defaultConfigPath}\{file}");

						string selectedLine = lines.Where(line => line.Split(';')[0] == comboBox.SelectedItem.ToString()).FirstOrDefault();
						if (selectedLine == null)
							return;

						patereDims = selectedLine.Split(';').Skip(1).ToList();
					}
				}
				else
				{
					string file = _fileForEachNameDico[comboBox.Name];
					string[] lines = File.ReadAllLines($@"{_defaultConfigPath}\{file}");

					string coloringRAL = comboBox.SelectedItem.ToString().Split(new string[] { " - " }, StringSplitOptions.RemoveEmptyEntries)[0];
					string selectedLine = lines.Where(line => line.Split(';')[0] == coloringRAL).FirstOrDefault();
					if (selectedLine == null)
						return;

					foreach (string attribute in selectedLine.Split(';'))
					{
						content += $"{attribute}\n";
					}
				}
			}

			// add dimensions (length, height, depth) to the content
			foreach (var patereDim in patereDims)
			{
				content += $"{patereDim}\n";
			}

			File.WriteAllText(SavePath, content);
			DocsManager.SetActiveDoc();
			DocsManager.ActiveDoc.RunBasicCAD(@"\\serv-kalysse\BE\Macros et interface\Kalysse DesignCAD\Bancs\Modele\set_config_bancs.d3m");
			Activate();
		}

		private void LisseCombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			if (LisseCombo.SelectedItem == null)
				return;
			if (!LisseCombo.IsDropDownOpen)
				return;

			UpdateLisseCombo();

			WriteConfigToFile();
		}

		

		private void PatereTypeCombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			if (!PatereTypeCombo.IsDropDownOpen)
				return;

			UpdatePatereTypeCombo();
			WriteConfigToFile();
		}

		private void UpdateLisseCombo()
		{
			if (LisseCombo.SelectedItem.ToString() == _lisses[1])
			{
				LoadComboFromFile(PatereTypeCombo, _pateresLisseSurFilFile);
				PatereTypeCombo.SelectedIndex = 0;

				LoadColoringComboFromFile(LisseColoringCombo, _configColorFile);
				LoadColoringComboFromFile(PatereColoringCombo, _pateresFilSurLisseFile);
			}
			else
			{
				LoadColoringComboFromFile(LisseColoringCombo, _typesBoisFile);

				LoadComboFromFile(PatereTypeCombo, _pateresLisseSapinFile);
				PatereTypeCombo.SelectedIndex = 0;

				if (PatereTypeCombo.SelectedItem.ToString() == _pateresLisseSapin[0])
					LoadColoringComboFromFile(PatereColoringCombo, _standardPatereFile);
				else
					LoadColoringComboFromFile(PatereColoringCombo, _boxPatereFile);
			}
		}

		private void UpdatePatereTypeCombo()
		{
			if (LisseCombo.SelectedItem.ToString() == _lisses[1])
			{
				LoadColoringComboFromFile(PatereColoringCombo, _pateresFilSurLisseFile);
			}
			else
			{
				if (PatereTypeCombo.SelectedItem == null)
					return;

				if (PatereTypeCombo.SelectedItem.ToString() == _pateresLisseSapin[0])
				{
					LoadColoringComboFromFile(PatereColoringCombo, _standardPatereFile);
				}
				else
				{
					LoadColoringComboFromFile(PatereColoringCombo, _boxPatereFile);
				}
			}
		}

		private void LisseColoringCombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			if (!LisseColoringCombo.IsDropDownOpen)
				return;

			WriteConfigToFile();
		}

		private void PatereColoringCombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			if (!PatereColoringCombo.IsDropDownOpen)
				return;

			WriteConfigToFile();
		}

		private void ConsoleColoringCombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			if (!ConsoleColoringCombo.IsDropDownOpen)
				return;

			WriteConfigToFile();
		}
	}
}
