using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApplication1.Models;

namespace WpfApplication1.ViewModels
{
    public class FunctionViewModel
    {
        // Function[] functions;
        Function selectedFunction;
        public ObservableCollection<Function> Functions { get; private set; }
        public Function SelectedFunction {
            get { return selectedFunction; }
            set {
                selectedFunction = value;
                onPropertyChanged("SelectedFunction");
            }
        }
        public FunctionViewModel()
        {
            Functions = new ObservableCollection<Function>(Function.GetFunctions());
        }

        public event PropertyChangedEventHandler PropertyChanged;
        void onPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(null, new PropertyChangedEventArgs(propertyName));
        }
    }
}
