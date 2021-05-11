/*###########################################################################################################################
 Name: Abigail Herron
 ID: S00200536
 Year: 2
 Date: 11/05/21
 GitHub Repository: https://github.com/AbigailHerron/OOD-Exam
 
 Description: Contains the blueprint for the MainWindow's behaviour patterns
 Properties: db, games
 Methods: Window_Loaded, lbxGames_SelectionChanged, rb_List
 Constructors: Default
 ##########################################################################################################################*/
using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AbigailHerron_S00200536
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /*PROPERTIES ------------------------------------------------------------------------------------------------------*/
        GameData db = new GameData(); // creating database object
        List<Game> games = new List<Game>();

        /*CONSTRUCTORS ----------------------------------------------------------------------------------------------------*/
        /*Constructor: Default
                       1) Initialises components */
        public MainWindow()
        {
            InitializeComponent();
        }// end Default constructor



        /*EVENT BASED METHODS ---------------------------------------------------------------------------------------------*/
        /*Method: Window_Loaded()
                  1) Queries database for Game objects
                  2) Populates lbxGames with Game objects from database */
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var query = from g in db.Games
                        select g as Game;

            lbxGames.ItemsSource = query.ToList();
            games = query.ToList();
        }// end Window_Loaded()


        /*Method: lbxGames_SelectionChanged()
                  1) Executes when the selected item changes
                  2) Updates the tblkPrice and imgGame objects in MainWindow */
        private void lbxGames_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // converting selected item from anonymous type to Game object
            Game selectedGame = lbxGames.SelectedItem as Game;

            // updating window text blocks with object details
            tblkPlatform.Text = selectedGame.Platform;
            tblkPrice.Text = $"{selectedGame.Price:C}";
            tblkDescription.Text = selectedGame.Description;
            
            //imgGame.Source = new BitmapImage(new Uri(selectedGame.GameImage, UriKind.Relative));
        }// end lbxGames_SelectionChanged()



        /*Method: rb_List()
                  1) Executes whenever a RadioButton is selected
                  2) Filters the list of games based on their Platform
                  3) Changes the source of lbxGames to new, updatedGames list */
        private void rb_List(object sender, RoutedEventArgs e)
        {
            List<Game> updatedGames = new List<Game>();

            if (!((bool)rbAll.IsChecked))
            {
                foreach (Game g in games)
                {
                    if ((bool)rbXbox.IsChecked)
                    {
                        if (g.Platform.ToLower().Contains("xbox"))
                            updatedGames.Add(g);
                    }
                    else if ((bool)rbPS.IsChecked)
                    {
                        if (g.Platform.ToLower().Contains("ps"))
                            updatedGames.Add(g);
                    }
                    else if ((bool)rbSwitch.IsChecked)
                    {
                        if (g.Platform.ToLower().Contains("switch"))
                            updatedGames.Add(g);
                    }
                }// end foreach block
                lbxGames.ItemsSource = updatedGames;
            }
            else
                lbxGames.ItemsSource = games;
        }// end rb_List()
    }// end MainWindow class
}// end AbigailHerron_S00200536 namespace
