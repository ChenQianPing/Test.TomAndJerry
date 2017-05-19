using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.TomAndJerry
{
    public class Cat
    {
        private readonly string _name;

        public Cat(string name)
        {
            this._name = name;
        }
        public delegate void CatCallEventHandler(); // 猫叫的委托  
        public event CatCallEventHandler Catevent;  // 猫叫事件  

        public void Call()
        {
            Console.WriteLine($"猫{_name}叫：喵，喵，喵");
            Catevent?.Invoke();
        }
    }
}
