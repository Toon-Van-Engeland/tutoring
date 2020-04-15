using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Hangman
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly List<Shape> _hangmanFrameList;
        private readonly List<TextBlock> _lettersTextBlocks;
        private int _numberOfWrongGuesses;
        private string _correctWord;

        public MainWindow()
        {
            InitializeComponent();

            _hangmanFrameList = new List<Shape>()
            {
                Line1,
                Line2,
                Line3,
                Line4,
                Line5,
                Line6,
                HeadEllipse,
                Line7,
                Line8,
                Line9,
                Line10
            };

            _lettersTextBlocks = new List<TextBlock>()
            {
                Letter1TextBlock,
                Letter2TextBlock,
                Letter3TextBlock,
                Letter4TextBlock,
                Letter5TextBlock,
                Letter6TextBlock,
                Letter7TextBlock,
                Letter8TextBlock,
                Letter9TextBlock,
                Letter10TextBlock,
                Letter11TextBlock,
                Letter12TextBlock,
            };

            _numberOfWrongGuesses = 0;
        }

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            //TODO In deze methode maken we het begin van het spel
            //TODO de tekst zal uit de passwordbox worden gelezen en klaar gezet
            //TODO Een goede gok zal worden duidelijk gemaakt door de letters zichtbaar te maken


            //TODO Haal het woord uit de PasswordBox en sla dit op in _correctWord
            //TODO zorg dat het woord in hoofdletters wordt bijgehouden

            #region Tip 1

            //In een passwordbox zit de string in het Password veld

            #endregion

            #region Tip 2

            //Met de ToUpper kan je een string in hoofdletters zetten

            #endregion

            #region Oplossing

            //_correctWord = InitializeWordPasswordBox.Password.ToUpper();

            #endregion

            //TODO Loop door het woord en vul het in in de letter TextBlocks

            #region Tip 1

            //Je kan loopen door een woord char char met een foreach

            #endregion

            #region Tip 2

            //Houd bij bij de hoeveelste letter je zit (0,1,2...)

            #endregion

            #region Tip 3

            //Je zal de textblocks een voor een moeten opvragen en de letter als text moeten zetten.

            #endregion

            #region Oplossing

            //int index = 0;
            //foreach (char letter in _correctWord)
            //{
            //    _lettersTextBlocks[index].Text = letter.ToString();
            //    index++;
            //}

            #endregion

            //TODO zorg dat het veld nu wordt klaargemaakt voor gebruik
            //TODO GEBRUIK DE METHODES VAN DE REST VAN DE KLASSE

            #region Tip 1

            //Verberg de hangman, verberg de letters en zorg dat je velden kan raden.

            #endregion

            #region Tip 2

            //Zet het aantal foute gokken ook op 0

            #endregion

            #region Oplossing

            //_numberOfWrongGuesses = 0;
            //HideTheHangman();
            //HideAllLetters();
            //EnableGuessFields();

            #endregion

            //TODO Zorg dat de overige velden die niet gebruikt worden leeg en zichtbaar zijn (dit zijn immers al goede gokken)

            #region Tip 1

            //Je kan je hier gebruik maken van die index van daarstraks om verder te gaan en de overige velden leeg te maken

            #endregion

            #region Oplossing

            //while (index < _lettersTextBlocks.Count)
            //{
            //    _lettersTextBlocks[index].Text = "";
            //    _lettersTextBlocks[index].Visibility = Visibility.Visible;
            //    index++;
            //}

            #endregion


        }

        private void GuessButton_Click(object sender, RoutedEventArgs e)
        {
            //TODO Dit is de core van het spel
            //TODO We gaan hier de letter die wordt ingegeven controleren of ze in het woord voorkomt
            //TODO als de letter voorkomt dan gaan we deze letter in het woord zichtbaar maken waar hij overal staat
            //TODO als de letter niet in het woord voorkomt dan wordt een beetje van de galg getekend
            //TODO als het woord volledig geraden is dan gaan we de gebruiker een winstboodschap tonen
            //TODO we gaan dit stap voor stap opbouwen

            //TODO allereerst gaan we controleren of er wel een iets is ingevuld in de TextBox

            #region Tip

            //Gebruik de length property van de text in de textbox

            #endregion

            #region Oplossing

            //if (GuessingLetterTextBox.Text.Length == 0)
            //{
            //    MessageBox.Show("You must fill in a letter.");
            //    return;
            //}

            #endregion

            //TODO haal de letter uit de TextBox en sla dit op in een char

            #region Tip 1

            //Denk eraan dat je dit als hoofdletter wilt hebben

            #endregion

            #region Tip 2

            //Met de methode ToCharArray() van een string verander je de string in een char[] (raadpleeg dan de eerste char)

            #endregion

            #region Oplossing

            //char guessedLetter = GuessingLetterTextBox.Text.ToUpper().ToCharArray()[0];

            #endregion

            //TODO loop nu ofwel over de TextBoxes ofwel het woord (ik raad aan het woord (_correctWord))
            //TODO en ga kijken of de geraden letter in het woord voorkomt

            #region Tip 1

            //Als je de index bijhoudt doorheen de loop dan zit je ook altijd op de juiste plaats in de _letterTextBlocks list

            #endregion

            #region Tip 2

            //Houd met een boolean (bool) bij of een gok goed of fout was, dit gaat straks van pas komen

            #endregion

            #region Tip 3

            //Maak de TextBlock zichtbaar als de letter in het woord zit

            #endregion

            #region Oplossing

            //bool guessWasWrong = true;
            //int index = 0;
            //foreach (char letter in _correctWord)
            //{
            //    if (letter == guessedLetter)
            //    {
            //        guessWasWrong = false;
            //        _lettersTextBlocks[index].Visibility = Visibility.Visible;
            //    }

            //    index++;
            //}

            #endregion

            //TODO ga nu de gebruiker een deel van de galg tonen als de gok fout was

            #region Tip 1

            //maak gebruik van de _hangmanFrameList

            #endregion

            #region Tip 2

            //Met _hangmanFrameList[_numberOfWrongGuesses] krijg je het volgende item dat zichtbaar moet worden gemaakt

            #endregion

            #region Tip 3

            //Op de 11de verkeerde gok is iemand verloren en worden de velden disabled en is de hangman volledig zichtbaar

            #endregion

            #region Oplossing

            //if (guessWasWrong)
            //{
            //    _hangmanFrameList[_numberOfWrongGuesses].Visibility = Visibility.Visible;
            //    _numberOfWrongGuesses++;
            //    if (_numberOfWrongGuesses == 11)
            //    {
            //        _numberOfWrongGuesses = 0;
            //        DisableGuessFields();
            //        ShowAllLetters();
            //        MessageBox.Show($"You lose the word was {_correctWord}");
            //    }
            //    return;
            //}

            #endregion

            //TODO Toon nu de gebruiker een boodschap als hij gewonnen heeft en zorg dat er geen gokken meer kunnen worden gedaan

            #region Tip

            //Maak gebruik van de CheckWinningConditions() methode

            #endregion

            #region Oplossing

            //if (CheckWinningConditions())
            //{
            //    DisableGuessFields();
            //    MessageBox.Show("Congratulations, you have guessed the right word!");
            //}

            #endregion


        }

        private void SolveButton_Click(object sender, RoutedEventArgs e)
        {
            //TODO hier gaan we een volledige woordgok beoordelen

            //TODO haal het woord uit de textbox en zet het in hoofdletters

            #region Tip 1

            //Access de string door Text property te raadplegen van de TextBox

            #endregion

            #region Tip 2

            //De ToUpper zorgt dat een string in hoofdletters staat

            #endregion

            #region Oplossing

            //string guessingWord = GuessingWordTextBox.Text.ToUpper();

            #endregion

            //TODO Kijk of het woord klopt, als het klopt dan toon je het woord en zet je velden uit en toon je een boodschap

            #region Tip 1

            //Maak hier gebruik van een if-lus

            #endregion

            #region Tip 2

            //Maak gebruik van de methodes die in deze klasse staan

            #endregion

            #region Oplossing

            //if (guessingWord == _correctWord)
            //{
            //    DisableGuessFields();
            //    ShowAllLetters();
            //    MessageBox.Show("Congratulations, you have guessed the right word!");
            //}

            #endregion

            //TODO als het niet klopt zorg dan dat de gebruiker een strafpunt krijgt en mogelijk ook de eindboodschap

            #region Tip 1

            //maak gebruik van de _hangmanFrameList

            #endregion

            #region Tip 2

            //Met _hangmanFrameList[_numberOfWrongGuesses] krijg je het volgende item dat zichtbaar moet worden gemaakt

            #endregion

            #region Tip 3

            //Op de 11de verkeerde gok is iemand verloren en worden de velden disabled en is de hangman volledig zichtbaar

            #endregion

            #region Oplossing

            //else
            //{
            //    _hangmanFrameList[_numberOfWrongGuesses].Visibility = Visibility.Visible;
            //    _numberOfWrongGuesses++;
            //    if (_numberOfWrongGuesses == 11)
            //    {
            //        _numberOfWrongGuesses = 0;
            //        DisableGuessFields();
            //        ShowAllLetters();
            //        MessageBox.Show($"You lose the word was {_correctWord}");
            //    }
            //}

            #endregion
        }

        private void EnableGuessFields()
        {
            //TODO zorg hier dat de textboxes en buttons voor het raden aanstaan

            #region Tip

            //Maak gebruik van de property IsEnabled van de velden

            #endregion

            #region Oplossing

            //GuessButton.IsEnabled = true;
            //GuessingLetterTextBox.IsEnabled = true;
            //SolveButton.IsEnabled = true;
            //GuessingWordTextBox.IsEnabled = true;

            #endregion

        }

        private void DisableGuessFields()
        {
            //TODO zorg hier dat de textboxes en buttons voor het raden uitstaan

            #region Tip

            //Maak gebruik van de property IsEnabled van de velden

            #endregion

            #region Oplossing

            //GuessButton.IsEnabled = false;
            //GuessingLetterTextBox.IsEnabled = false;
            //SolveButton.IsEnabled = false;
            //GuessingWordTextBox.IsEnabled = false;

            #endregion

        }

        private void ShowAllLetters()
        {
            //TODO loop hier door de letters TextBlocks en maak deze zichtbaar

            #region Tip 1

            //Maak gebruik van de list _lettersTextBlocks

            #endregion

            #region Tip 2

            //maak een loop doorheen deze lijst

            #endregion

            #region Tip 3

            //Gebruik de property Visibility van de textblocks

            #endregion

            #region Oplossing

            //foreach (TextBlock letterTextBlock in _lettersTextBlocks)
            //{
            //    letterTextBlock.Visibility = Visibility.Visible;
            //}

            #endregion

        }

        private void HideAllLetters()
        {
            //TODO loop hier door de letters TextBlocks en maak deze onzichtbaar

            #region Tip 1

            //Maak gebruik van de list _lettersTextBlocks

            #endregion

            #region Tip 2

            //maak een loop doorheen deze lijst

            #endregion

            #region Tip 3

            //Gebruik de property Visibility van de textblocks

            #endregion

            #region Oplossing

            //foreach (TextBlock letterTextBlock in _lettersTextBlocks)
            //{
            //    letterTextBlock.Visibility = Visibility.Hidden;
            //}

            #endregion

        }

        private void HideTheHangman()
        {
            //TODO loop hier door de shapes van de hangman en maak deze onzichtbaar

            #region Tip 1

            //Maak gebruik van de list _hangmanFrameList

            #endregion

            #region Tip 2

            //maak een loop doorheen deze lijst

            #endregion

            #region Tip 3

            //Maak gebruik van de property Visibility van de Shapes

            #endregion

            #region Oplossing

            //foreach (Shape shape in _hangmanFrameList)
            //{
            //    shape.Visibility = Visibility.Hidden;
            //}

            #endregion

        }

        private bool CheckWinningConditions()
        {
            //TODO Kijk of alle letters goed zijn geraden

            #region Tip 1

            //Een letter is goed geraden als de textblock ervan zichtbaar is

            #endregion

            #region Tip 2

            //Je kan alle textblocks doorlopen door middel van de lijst _lettersTextBlocks

            #endregion

            #region Tip 3

            //Je kan de zichtbaarheid controleren door Visibility op te vragen
            //Of maak gebruik van IsVisible

            #endregion

            #region Oplossing

            //bool youWon = true;

            //foreach (TextBlock lettersTextBlock in _lettersTextBlocks)
            //{
            //    if (lettersTextBlock.Visibility == Visibility.Hidden)
            //    {
            //        youWon = false;
            //    }
            //}

            //return youWon;

            #endregion

            //TODO vervang deze regel met je implementatie
            return false;
        }
    }
}
