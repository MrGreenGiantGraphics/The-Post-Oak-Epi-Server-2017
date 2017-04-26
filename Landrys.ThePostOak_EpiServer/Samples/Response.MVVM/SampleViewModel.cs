using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;

namespace Response.MVVM.Samples
{
    public class MyViewModel : INotifyPropertyChanged
    {
        public MyViewModel()
        {
            //Names = new ObservableCollection<string> { "John", "Smith", "Toby", "Emily" };
            //Panel1 = PanelState.On;
        }

        //public void GreetPerson(string name)
        //{
        //    MessageBox.Show("Hello, " + name);
        //}

        //public string Message { get; set; }

        //public void ShowMsgBox()
        //{
        //    if (Message == null)
        //        MessageBox.Show("Enter something in the textbox");
        //    else
        //        MessageBox.Show(Message);
        //}


        //public ObservableCollection<string> Names { get; private set; }

        //private PanelState _panel1;
        //private PanelState _panel2;

        //[VisualStateGroup]
        //public PanelState Panel1
        //{
        //    get { return _panel1; }
        //    set
        //    {
        //        _panel1 = value;
        //        FirePropertyChanged("Panel1");
        //    }
        //}

        //[VisualStateGroup]
        //public PanelState Panel2
        //{
        //    get { return _panel2; }
        //    set
        //    {
        //        _panel2 = value;
        //        FirePropertyChanged("Panel2");
        //    }
        //}

        //public void Panel2TransitionComplete()
        //{
        //    MessageBox.Show("Panel2 Transition complete");
        //}

        //public bool ShowPanel1
        //{
        //    get { return Panel1 == PanelState.On; }
        //    set
        //    {
        //        Panel1 = value ? PanelState.On : PanelState.Off;
        //    }
        //}

        //public bool ShowPanel2
        //{
        //    get { return Panel2 == PanelState.On; }
        //    set
        //    {
        //        Panel2 = value ? PanelState.On : PanelState.Off;
        //    }
        //}

        public object MessageBox { get; private set; }

        private void FirePropertyChanged(string propname)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propname));
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }

    public enum PanelState { Off, On }
}
