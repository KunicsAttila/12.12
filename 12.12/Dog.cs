using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12._12
{
    class Dog
    {
        public string name { get; private set; }  // prop + Tab
        public int age { get; set; }
        public Dog(string name, int age) {
            if (name.Length < 1)
            {
                throw new Exception("Névtelen kutya");
            }
            this.name = name;
            this.age = age;
        }
        public void Bark()  // Bark: Ugatás(angol)
        {
            MessageBox.Show($"Vau vau mondja: {name}");
        }
    }
}
