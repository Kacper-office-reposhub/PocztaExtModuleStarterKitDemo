using Soneta.Business;
using Soneta.Business.App;
using Soneta.Handel;
using PocztaExtModuleStarterKitDemo.businessObjectsRepresentationClasses;
using enova365.PocztaExt;

[assembly: NewRow(typeof(WydrukWiadomosci))]

namespace PocztaExtModuleStarterKitDemo.businessObjectsRepresentationClasses
{
    public class WydrukWiadomosci : PocztaExtModule.WydrukWiadomosciRow
    {
        public WydrukWiadomosci(RowCreator creator) : base(creator)
        {
        }
        public WydrukWiadomosci(DefDokHandlowego def, Operator op) : base(def, op)
        {
        }
        protected override void OnAdded()
        {
            base.OnAdded();
        }
        public override string ToString()
        {
            return Wzorzec;
        }
    }
}