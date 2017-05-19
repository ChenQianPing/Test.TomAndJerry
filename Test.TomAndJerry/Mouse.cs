using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.TomAndJerry
{
    public class Mouse
    {
        private readonly string _name;
        public Mouse(Cat c, string name)
        {
            this._name = name;
            c.Catevent += new Cat.CatCallEventHandler(this.Run);  // 注册事件    
        }
        public void Run()
        {
            Console.WriteLine($"老鼠{_name}开始逃跑");
        }
    }
}
