using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteX
{
    public class MDISingleton
    {
        private MDISingleton() { }
        private static MDIParentMenu X { get; set; }
        public static MDIParentMenu Criar()
        {
            if(X == null)
            {
                X = new MDIParentMenu();
                return X;
            }
            return X;
        }

    }
}
