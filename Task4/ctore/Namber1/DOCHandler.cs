using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4.ctore.Namber1
{
    public class DOCHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("Вы открыли документ в формате DOC");
        }
        public override void Create()
        {
            Console.WriteLine("Вы создали документ в формате DOC");
        }
        public override void Chenge()
        {
            Console.WriteLine("Вы редактируете документ в формате DOC");
        }
        public override void Save()
        {
            Console.WriteLine("Вы сохранили документ в формате DOC");
        }
    }
}
