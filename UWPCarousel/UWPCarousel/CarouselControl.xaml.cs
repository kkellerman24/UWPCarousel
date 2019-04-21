using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace UWPCarousel
{
    public class ControlIcon
    {
        public string CItem
        {
            get;
            set;
        }
    }

    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
        public sealed partial class CarouselControl : Page
        {
            ObservableCollection<ControlIcon> items = new ObservableCollection<ControlIcon>();

            public CarouselControl()
            {
                this.InitializeComponent();
                items.Add(new ControlIcon() { CItem = string.Format("ms-appx:///Images//calendar.png") });
                items.Add(new ControlIcon() { CItem = string.Format("ms-appx:///Images//weather.png") });
                items.Add(new ControlIcon() { CItem = string.Format("ms-appx:///Images//home.png") });
                items.Add(new ControlIcon() { CItem = string.Format("ms-appx:///Images//traffic.png") });
                items.Add(new ControlIcon() { CItem = string.Format("ms-appx:///Images//twitter.png") });
                items.Add(new ControlIcon() { CItem = string.Format("ms-appx:///Images//settings.png") });
                MirrorCarousel.ItemsSource = items;

            MirrorCarousel.SelectedIndex = 2; /* initialize index to home */
            
        }

        /// <summary>
        /// for motion sensor call
        /// </summary>
        private void zxLeft()
        {
            if (MirrorCarousel.SelectedIndex != (items.Count -1))
            {
                MirrorCarousel.SelectedIndex++;
                CenterPageDisplay(MirrorCarousel.SelectedIndex);
                //Transition Duration??
                //Set Selected item?
            }

        }

        /// <summary>
        /// for motion sensor call
        /// </summary>
        private void zxRight()
        {
            if (MirrorCarousel.SelectedIndex != 0)
            {
                MirrorCarousel.SelectedIndex--;
                CenterPageDisplay(MirrorCarousel.SelectedIndex);
            }
        }

        /// <summary>
        /// Set the respective page opacity to 1, displaying home means turn all opacities to 0
        /// </summary>
        /// <param name="pageCase"></param>
        private void CenterPageDisplay(int pageCase)
        {
            switch (pageCase)
            {
                case 0:
                    //display calendar
                    break;
                case 1:
                    //display weather
                    break;
                case 2:
                    //display home
                    break;
                case 3:
                    //display traffic
                    break;
                case 4:
                    //display twitter
                    break;
                case 5:
                    //display settings
                    break;
                default:
                    //all opacity set to 0, home displayed (index of 2)
                    break;
            }
        }


    }
}
