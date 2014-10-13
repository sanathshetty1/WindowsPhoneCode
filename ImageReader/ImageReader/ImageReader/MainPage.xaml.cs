using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using ImageReader.Resources;
using Microsoft.Xna.Framework.Media;

namespace ImageReader
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor


        MediaLibrary m = new MediaLibrary();
        PictureCollection p;

        
        public MainPage()
        {
            InitializeComponent();
            MediaPlayer.Queue.ToString();

            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            foreach (MediaSource source in MediaSource.GetAvailableMediaSources())
            {
                if (source.MediaSourceType == MediaSourceType.LocalDevice)
                {
                    MediaLibrary medLib = new MediaLibrary(source);
                    PictureAlbumCollection allAlbums = medLib.RootPictureAlbum.Albums;

                    foreach (PictureAlbum album in allAlbums)
                    {

                        if (album.Name ==  "Camera Roll")
                        {
                            if (album.Pictures.Count > 0)
	                            {

                                    PictureCollection pc = album.Pictures;
                                    Picture p = pc[0];
                              System.IO.Stream  ste =   p.GetImage();
                                
		 
	                            }  
                        }
                    
                    }
                
                }
            
            }
            AlbumCollection sc = m.Albums;
            PictureAlbum pa = m.RootPictureAlbum;
            PictureCollection savedpicturecolelction =  m.SavedPictures;
            PictureCollection camerapicutres = m.Pictures;


           
        }

        // Sample code for building a localized ApplicationBar
        //private void BuildLocalizedApplicationBar()
        //{
        //    // Set the page's ApplicationBar to a new instance of ApplicationBar.
        //    ApplicationBar = new ApplicationBar();

        //    // Create a new button and set the text value to the localized string from AppResources.
        //    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
        //    appBarButton.Text = AppResources.AppBarButtonText;
        //    ApplicationBar.Buttons.Add(appBarButton);

        //    // Create a new menu item with the localized string from AppResources.
        //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        //    ApplicationBar.MenuItems.Add(appBarMenuItem);
        //}
    }
}