using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1.Models
{
   public class Function : INotifyPropertyChanged
    {
        string functionName;
        double valueA;
        double valueB;
        int[] itemsC;
        int valueCIndex;
        double valueX;
        double valueY;

        public string FunctionName
        {
            get { return functionName; }
            set
            {
                functionName = value;
                onPropertyChanged("FunctionName");
            }
        }
       
        public double ValueA
        {
            get { return valueA; }
            set
            {
                valueA = value;
                onPropertyChanged("ValueA");
            }
        }
        public double ValueB
        {
            get { return valueB; }
            set
            {
                valueB = value;
                onPropertyChanged("ValueB");
            }
        }
        public int ValueCIndex
        {
            get { return valueCIndex; }
            set
            {
                valueCIndex = value;
                onPropertyChanged("ValueCIndex");
            }
        }
        public int[] ItemsC
        {
            get { return itemsC; }
            set
            {
                itemsC = value;
                onPropertyChanged("ItemsC");
            }
        }
        public double ValueX
        {
            get { return valueX; }
            set
            {
                valueX = value;
                onPropertyChanged("ValueX");
            }
        }
        public double ValueY
        {
            get { return valueY; }
            set
            {
                valueY = value;
                onPropertyChanged("ValueY");
            }
        }       

        public event PropertyChangedEventHandler PropertyChanged;

        void onPropertyChanged(string propertyName)
        {
            if(PropertyChanged !=null)            
                PropertyChanged(null, new PropertyChangedEventArgs(propertyName));            
        }

        public static Function[] GetFunctions()
        {
            var result = new Function[]
            {
                new Function() { FunctionName="Линейная",ValueA=0,ValueB=0,ItemsC = new[]{1,2,3,4,5 },ValueCIndex=0,ValueX=0,ValueY=0 },
                new Function() { FunctionName="Квадратичная",ValueA=0,ValueB=0,ItemsC = new[]{10,20,30,40,50 },ValueCIndex=0,ValueX=0,ValueY=0 },
                new Function() { FunctionName="Кубическая",ValueA=0,ValueB=0,ItemsC = new[]{100,200,300,400,500 },ValueCIndex=0,ValueX=0,ValueY=0 },
                new Function() { FunctionName="4-ой степени",ValueA=0,ValueB=0,ItemsC = new[]{1000,2000,3000,4000,5000 },ValueCIndex=0,ValueX=0,ValueY=0 },
                new Function() { FunctionName="5-ой степени",ValueA=0,ValueB=0,ItemsC = new[]{10000,20000,30000,40000,50000 },ValueCIndex=0,ValueX=0,ValueY=0 }
            };

            return result;
        }
       
    }
}
