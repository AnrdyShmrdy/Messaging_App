using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
namespace Messaging_App.Models;
internal class Home : INotifyPropertyChanged
{
    string _lbltxt = "This is the text to display on the label";
    string _btntxt = "This is the text to display on the button";

    public event PropertyChangedEventHandler PropertyChanged;

    public string LabelText
    {
        get => _lbltxt;
        set
        {
            if (_lbltxt != value)
            {
                _lbltxt = value;
                OnPropertyChanged("LabelText"); // reports this property
            }
        }
    }
    public string ButtonText
    {
        get => _btntxt;
        set => _btntxt = value;
    }

    public void OnPropertyChanged([CallerMemberName] string name = "") =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
}
