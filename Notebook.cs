using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9
{
    internal class Notebook:Product
    {
        #region Prop
        public string Model { get; set; }
        #endregion

        #region Field
        string _brand;
        byte _ram;
        public int _storage;
        #endregion

        #region Full Prop
        public string Brand { 
            get 
            { 
                return _brand;
            } 
            set 
            {
                if (value.Length > 3 && value.Length < 30)
                    _brand = value;
            } 
        }
        public byte Ram 
        {
            get => _ram;
            //set => _ram = (byte)(value > 0 && value < 128 ? value : 0);
            set
            {
                if (value > 0 && value < 128)
                    _ram = value;
            }
        }
        public int Storage { get => _storage; set => _storage = value > 0 ? value : 0; }
        #endregion


        public Notebook(int count,int price, string model) :base(count,price)
        {
            Model = model;
        }
    }
}
