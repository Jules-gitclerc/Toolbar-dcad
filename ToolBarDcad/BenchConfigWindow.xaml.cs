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
		private const string _defaultConfigPath = @"\\serv-kalysse\EDatas\Dev\Datas\Bancs\";
		private const string _coloringConfigFile = @"config_couleurs.txt";
		private const string _standardPatereFile = @"config_pateres_standards.txt";
		private const string _boxPatereFile = @"config_pateres_box.txt";
		private const string _filPateresFile = @"config_pateres_fil.txt";
		private const string _editListText = "Editer la liste";
		private const string _savePath = @"C:\KalysseDesignCAD\banc_config.txt";
		private Dictionary<string, string> _fileForEachNameDico = new Dictionary<string, string>();

/*		List<string> standardPatereColorings = new List<string>()
		{
			"575.090 ALU RAL 9006",
			"575.091 INOX RAL 9007",
			"575.001 Gris terre d'ombre RAL 7022",
			"575.002 Noir profond RAL 9005",
			"575.003 Blanc pur RAL 9010",
			"575.004 Bleu clair RAL 5012",
			"575.005 Orangé pur RAL 2004",
			"575.006 Turquoise menthe RAL 6033"
		};
		List<string> filPateres = new List<string>()
		{
			"575.101 Gris terre d'ombre RAL 7022",
			"575.102 Noir profond RAL 9005",
			"575.103 Blanc pur RAL 9010",
			"575.104 Jaune trafic RAL 1023",
			"575.105 Orangé pur RAL 2004",
			"575.106 Rouge signalisation RAL 3020",
			"575.107 Bleu gentiane RAL 5010",
			"575.108 Bleu clair RAL 5012",
			"575.109 Turquoise menthe RAL 6033",
			"575.110 Bleu turquoise RAL 5018",
			"575.111 Grix silex RAL 7032",
			"575.112 Gris clair RAL 7035",
		};
		List<string> boxPatereColorings = new List<string>()
		{
			"575.291 INOX RAL 9007",
			"575.201 Gris terre d'ombre RAL 7022",
			"575.202 Noir profond RAL 9005",
			"575.203 Blanc pur RAL 9010",
			"575.204 Gris clair RAL 7035"
		};
		List<string> colorings = new List<string>()
		{
			"Inox",
			"Blanc pur RAL 9010",
			"Noir profond RAL 9005",
			"Gris terre d'ombre RAL 7022",
			"Gris clair RAL 7035",
		};*/
		List<string> patereTypes = new List<string>()
		{
			"Patères standards",
			"Patères box"
		};
		List<string> lisses = new List<string>()
		{
			"Lisse en sapin rouge",
			"Fil sur lisse métallique"
		};



		public BenchConfigWindow()
		{
			InitializeComponent();

			LoadComboFromFile(LisseColoringCombo, _coloringConfigFile);
			LoadComboFromFile(ConsoleColoringCombo, _coloringConfigFile);
			LoadComboFromFile(PatereColoringCombo, _standardPatereFile);
			LoadCombo(LisseCombo, lisses);
			LoadCombo(PatereTypeCombo, patereTypes);

			SelectCombos();
		}

		private void SelectCombos()
		{
			try
			{
				string[] lines = System.IO.File.ReadAllLines(_savePath);

				ConsoleColoringCombo.SelectedItem = lines[1];
				LisseCombo.SelectedItem = lines[2];
				PatereColoringCombo.SelectedItem = lines[4];
				PatereTypeCombo.SelectedItem = lines[5];

				if (LisseCombo.SelectedItem.ToString() != lisses[0])
					LisseColoringCombo.SelectedItem = lines[3];


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
			}

			if (LisseCombo.SelectedItem.ToString() == lisses[0])
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
			List<string> comboContent = lines.Skip(2).Select(line => line.Split(';')[0]).ToList();

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

		/*
		Format:
		Couleur de la console
		Lisse
		Couleur de la lisse
		Type Patère
		Patère
		Couleur Patère
		*/
		private void WriteToFile()
		{
			if (!IsLoaded)
				return;

			string content = "Format : Couleur de la console\\nLisse\\nCouleur de la lisse\\nType Patère\\nPatère\\nCouleur Patère\n" +
				$"{ConsoleColoringCombo.SelectedItem}\n" +
				$"{LisseCombo.SelectedItem}\n" +
				$"{LisseColoringCombo.SelectedItem}\n" +
				$"{PatereTypeCombo.SelectedItem}\n" +
				$"{PatereColoringCombo.SelectedItem}\n";

			File.WriteAllText(_savePath, content);
/*
Charger le fichier dans les macros DCAD :
Open "o", 1, "C:\KalysseDesignCAD\model_config.txt"
Print #1, sysex$(1)
Print #1, sysex$(2)
Close
*/
		}

		private void LisseCombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			if (LisseCombo.SelectedItem.ToString() == lisses[1])
			{
				PatereTypeCombo.Items.Clear();
				PatereTypeCombo.Items.Add("Patères fil");
				PatereTypeCombo.SelectedIndex = 0;
				LoadComboFromFile(LisseColoringCombo, _coloringConfigFile);
				LoadComboFromFile(PatereColoringCombo, _filPateresFile);
			}
			else
			{
				LisseColoringCombo.Items.Clear();
				LoadCombo(PatereTypeCombo, patereTypes);

				PatereTypeCombo.SelectedIndex = 0;

				if (PatereTypeCombo.SelectedItem.ToString() == patereTypes[0])
				{
					LoadComboFromFile(PatereColoringCombo, _standardPatereFile);
				}
				else
				{
					LoadComboFromFile(PatereColoringCombo, _boxPatereFile);
				}
			}

			WriteToFile();
		}

		private void PatereTypeCombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			if (!IsLoaded)
				return;

			if (LisseCombo.SelectedItem.ToString() == lisses[1])
			{
				LoadComboFromFile(PatereColoringCombo, _filPateresFile);
			}
			else
			{
				if (PatereTypeCombo.SelectedItem == null)
					return;


				if (PatereTypeCombo.SelectedItem.ToString() == patereTypes[0])
				{
					LoadComboFromFile(PatereColoringCombo, _standardPatereFile);
				}
				else
				{
					LoadComboFromFile(PatereColoringCombo, _boxPatereFile);
				}
			}
			WriteToFile();
		}

		private void LisseColoringCombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			if (!IsLoaded)
				return;

			WriteToFile();
		}

		private void PatereColoringCombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			if (!IsLoaded)
				return;

			WriteToFile();
		}

		private void ConsoleColoringCombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			if (!IsLoaded)
				return;

			WriteToFile();
		}
	}
}
