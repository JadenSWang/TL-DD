using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using BindingSource = System.Windows.Forms.BindingSource;
using System.Windows.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace TL_DD
{
    public partial class MainWindow : INotifyPropertyChanged
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void MainWindow_Load(object sender, EventArgs e)
        {
        }

        private void PopupBox_OnOpened(object sender, RoutedEventArgs e)
        {
        }

        private void PopupBox_OnClosed(object sender, RoutedEventArgs e)
        {
        }

        private void CardItem_Click(object sender, MouseEventArgs e)
        {
            Console.WriteLine("TESTING");
        }

        private void CardItem_MouseEnter(object sender, MouseEventArgs e)
        {
            Console.WriteLine("Mouse Entered");
        }

        private void CardItem_MouseLeave(object sender, MouseEventArgs e)
        {
            Console.WriteLine("Mouse Left");
        }

        #region EventListener Boilerplate
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

        #region Menu Interactions
        private void PinButton_Click(object sender, RoutedEventArgs e)
        {
            bool pinned = PinButton.IsChecked;

            if (pinned)
            {
                this.Topmost = true;
            }
            else
            {
                this.Topmost = false;
            }
        }
        #endregion
    }
}
