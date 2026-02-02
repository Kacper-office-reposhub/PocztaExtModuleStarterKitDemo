using Soneta.Business;
using Soneta.Handel;
using Soneta.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PocztaExtModuleStarterKitDemo._10._2._3_Implementacja_interfejsu_użytkownika
//namespace enova365.PocztaExt.WiadomosciExt
{
    public class DokumentyWiadomosciParams : ContextBase
    {
        private const string Key = "Soneta.PocztaExt.DokumentyWiadomosci";
        public DokumentyWiadomosciParams(Context cx) : base(cx)
        {
            Load();
        }
        [Context]
        [Caption("Definicja")]
        public DefDokHandlowego Definicja
        {
            get
            {
                if (Context.Contains(typeof(DefDokHandlowego)))
                    return (DefDokHandlowego)Context[typeof(DefDokHandlowego)];
                return null;
            }
            set
            {
                Context[typeof(DefDokHandlowego)] = value;
                SaveProperty("Definicja", Key);
            }
        }
        protected void Load()
        {
            SetContext(typeof(DefDokHandlowego), LoadProperty("Definicja", Key));
        }
    }
}