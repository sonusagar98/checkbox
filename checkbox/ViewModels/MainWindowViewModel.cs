using Prism.Mvvm;
using System;
using System.ComponentModel;

namespace checkbox.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "Prism Application";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }
        private bool _isChecked;
        public bool IsChecked
        {
            get { return _isChecked; }
            set
            {
                _isChecked = value;
                OnPropertyChanged(new PropertyChangedEventArgs("IsChecked"));
                FillTextBlock();
            }
        }

        private string _text;
        public string Text
        {
            get { return _text; }
            set {
                _text = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Text"));
            }
        }
        public MainWindowViewModel()
        {
            IsChecked = false;
            FillTextBlock();

        }

        private void FillTextBlock()
        {
            if (IsChecked == true)
            {
                Text = "checkbox Checked";
            }
            else
                Text = "Checkbox Unchecked";
        }
    }
}
