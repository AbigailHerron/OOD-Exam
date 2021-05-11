/*###########################################################################################################################
 Name: Abigail Herron
 ID: S00200536
 Year: 2
 Date: 11/05/21
 GitHub Repository: https://github.com/AbigailHerron/OOD-Exam
 
 Description: Contains the blueprint for the MainWindow's behaviour patterns
 Properties: db
 Methods: Window_Loaded, lbxGames_SelectionChanged
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
                        select g;

            lbxGames.ItemsSource = query.ToList();
        }// end Window_Loaded()


        /*Method: lbxGames_SelectionChanged()
                  1) Executes when the selected item changes
                  2) Updates the tblkPrice and imgGame objects in MainWindow */
        private void lbxGames_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // converting selected item from anonymous type to Game object
            Game selectedGame = lbxGames.SelectedItem as Game;

            // updating window objects
            tblkPrice.Text = $"{selectedGame.Price:C}";
            imgGame.Source = new BitmapImage(new Uri(selectedGame.GameImage, UriKind.Relative));
        }// end lbxGames_SelectionChanged()
    }// end MainWindow class
}// end AbigailHerron_S00200536 namespace
