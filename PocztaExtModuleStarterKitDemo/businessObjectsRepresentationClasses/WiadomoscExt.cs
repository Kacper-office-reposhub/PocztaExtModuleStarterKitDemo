using Soneta.Business;
using Soneta.CRM;
using Soneta.Handel;
using enova365.PocztaExt;
using PocztaExtModuleStarterKitDemo.businessObjectsRepresentationClasses;

[assembly: NewRow(typeof(WiadomoscExt))]

namespace PocztaExtModuleStarterKitDemo.businessObjectsRepresentationClasses
{
    public class WiadomoscExt : PocztaExtModule.WiadomoscExtRow
    {
        public WiadomoscExt(RowCreator creator) : base(creator)
        {
        }
        public WiadomoscExt(WiadomoscEmail wiadomosc, DokumentHandlowy dokument) :
       base(wiadomosc, dokument)
        {
        }
        public override string ToString()
        {
            return Wiadomosc == null ? "" : Wiadomosc.ToString();
        }
    }
}