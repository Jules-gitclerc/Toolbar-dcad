using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DcadToolBar
{
    static class InitializeMenu
    {
        public static List<Macro> InitMacros()      //unused for now
        {
            List<Macro> newList = new List<Macro>()
            {
                new Macro("Primo", 0, @"\\serv-kalysse\BE\Macros et interface\Kalysse DesignCAD\Cabines\Modele\primo.d3m"),
                new Macro("Primo exel", 1, @"\\serv-kalysse\BE\Macros et interface\Kalysse DesignCAD\Cabines\Modele\primo_exel.d3m"),
                new Macro("Duo", 2, @"\\serv-kalysse\BE\Macros et interface\Kalysse DesignCAD\Cabines\Modele\duo.d3m"),
                new Macro("Duo exel", 3, @"\\serv-kalysse\BE\Macros et interface\Kalysse DesignCAD\Cabines\Modele\duo_exel.d3m"),
                new Macro("Brio", 4, @"\\serv-kalysse\BE\Macros et interface\Kalysse DesignCAD\Cabines\Modele\brio.d3m"),
                new Macro("Brio exel", 5, @"\\serv-kalysse\BE\Macros et interface\Kalysse DesignCAD\Cabines\Modele\brio_exel.d3m"),
                new Macro("Hauzeo", 6, @"\\serv-kalysse\BE\Macros et interface\Kalysse DesignCAD\Cabines\Modele\hauzeo.d3m"),
                new Macro("Bambino", 7, @"\\serv-kalysse\BE\Macros et interface\Kalysse DesignCAD\Cabines\Modele\bambino.d3m"),
                new Macro("Exéléo", 8, @"\\serv-kalysse\BE\Macros et interface\Kalysse DesignCAD\Cabines\Modele\exeleo.d3m"),
                new Macro("Nylon", 9, @"\\serv-kalysse\BE\Macros et interface\Kalysse DesignCAD\Cabines\Modele\nylon.d3m"),
                new Macro("Aluminium", 10, @"\\serv-kalysse\BE\Macros et interface\Kalysse DesignCAD\Cabines\Modele\alu.d3m"),
                new Macro("Inox", 11, @"\\serv-kalysse\BE\Macros et interface\Kalysse DesignCAD\Cabines\Modele\inox.d3m")
            };
            return newList;
        }

        public static Dictionary<string, string> InitMacroDict()
        {
            Dictionary<string, string> newDict = new Dictionary<string, string>()
            {
                {"Primo", @"\\serv-kalysse\BE\Macros et interface\Kalysse DesignCAD\Cabines\Modele\primo.d3m"},
                {"Primo exel", @"\\serv-kalysse\BE\Macros et interface\Kalysse DesignCAD\Cabines\Modele\primo_exel.d3m"},
                {"Duo", @"\\serv-kalysse\BE\Macros et interface\Kalysse DesignCAD\Cabines\Modele\duo.d3m"},
                {"Duo exel", @"\\serv-kalysse\BE\Macros et interface\Kalysse DesignCAD\Cabines\Modele\duo_exel.d3m"},
                {"Brio", @"\\serv-kalysse\BE\Macros et interface\Kalysse DesignCAD\Cabines\Modele\brio.d3m"},
                {"Brio exel", @"\\serv-kalysse\BE\Macros et interface\Kalysse DesignCAD\Cabines\Modele\brio_exel.d3m"},
                {"Hauzeo", @"\\serv-kalysse\BE\Macros et interface\Kalysse DesignCAD\Cabines\Modele\hauzeo.d3m"},
                {"Bambino", @"\\serv-kalysse\BE\Macros et interface\Kalysse DesignCAD\Cabines\Modele\bambino.d3m"},
                {"Exéléo", @"\\serv-kalysse\BE\Macros et interface\Kalysse DesignCAD\Cabines\Modele\exeleo.d3m"},
                {"Nylon", @"\\serv-kalysse\BE\Macros et interface\Kalysse DesignCAD\Cabines\Modele\nylon.d3m"},
                {"Aluminium", @"\\serv-kalysse\BE\Macros et interface\Kalysse DesignCAD\Cabines\Modele\alu.d3m"},
                {"Inox", @"\\serv-kalysse\BE\Macros et interface\Kalysse DesignCAD\Cabines\Modele\inox.d3m"},
                //{"BambinoP",@"\\serv-kalysse\BE\Macros et interface\Kalysse DesignCAD\Accessoires\Macros accessoires/Poteau bambino.d3m"},
                //{"BambinoPc", @"\\serv-kalysse\BE\Macros et interface\Kalysse DesignCAD\Accessoires\Macros accessoires\Poignee Carre Cabine Bambino Ref.221.310.d3m"},
                //{"BambinoPl", @"\\serv-kalysse\BE\Macros et interface\Kalysse DesignCAD\Accessoires\Macros accessoires\Poignee Lune Cabine Bambino Ref.221.314.d3m"},
                //{"BambinoPo", @"\\serv-kalysse\BE\Macros et interface\Kalysse DesignCAD\Accessoires\Macros accessoires\Poignee Ovale Cabine Bambino Ref.221.313.d3m"},
                //{"BambinoPr", @"\\serv-kalysse\BE\Macros et interface\Kalysse DesignCAD\Accessoires\Macros accessoires\Poignee Ronde Cabine Bambino Ref.221.311.d3m"},
                //{"BambinoPt", @"\\serv-kalysse\BE\Macros et interface\Kalysse DesignCAD\Accessoires\Macros accessoires\Poignee Triangle Cabine Bambino Ref.221.312.d3m"},
                {"PtCollectif", @"\\Serv-kalysse\be\Macros et interface\Kalysse DesignCAD\Equipement\plan_toilette_collectif.d3m"},
                //{"PtSimple", @"\\Serv-kalysse\be\Macros et interface\Kalysse DesignCAD\Equipement\plan_toilette_simple.d3m"},
                //{"PtEnfant", @"\\Serv-kalysse\be\Macros et interface\Kalysse DesignCAD\Equipement\plan_toilette_enfant.d3m"},
                {"Bc60", @"C:\Users\DevKalysse\Desktop\C#_Jules_Clerc\tmp\Basic CAD/Banc_C60.d3m"},
                {"CasierHDiplo", @"\\Serv-kalysse\be\Macros et interface\Kalysse DesignCAD\Vestiaires\casier_h.d3m"},
                {"CasierZDiplo", @"\\Serv-kalysse\be\Macros et interface\Kalysse DesignCAD\Vestiaires\casier_z.d3m"},
                {"CasierHBanc", @"\\Serv-kalysse\be\Macros et interface\Kalysse DesignCAD\Vestiaires\casier_h_banc.d3m"},
                {"CasiersBancCompact", @"\\Serv-kalysse\be\Macros et interface\Kalysse DesignCAD\Vestiaires\casier_h_banc_compact.d3m"},
                {"Lisse100", @"\\serv-kalysse\BE\Macros et interface\Kalysse DesignCAD\Bancs\lisse_serie_c100.d3m"},
                {"BancCompact1", @"\\Serv-kalysse\be\Macros et interface\Kalysse DesignCAD\Bancs\Banc_C1.d3m"},
                {"BancCompact20", @"\\Serv-kalysse\be\Macros et interface\Kalysse DesignCAD\Bancs\Banc_C20.d3m"},
                {"BancCompact50", @"\\Serv-kalysse\be\Macros et interface\Kalysse DesignCAD\Bancs\Banc_C50.d3m"},
                {"BancCompact60", @"\\Serv-kalysse\be\Macros et interface\Kalysse DesignCAD\Bancs\Banc_C60.d3m"},
                {"BancCompact500", @"\\Serv-kalysse\be\Macros et interface\Kalysse DesignCAD\Bancs\Banc_C500.d3m"},
                {"BancCompact550", @"\\Serv-kalysse\be\Macros et interface\Kalysse DesignCAD\Bancs\Banc_C550.d3m"}, 
                {"BancCompact700", @"\\Serv-kalysse\be\Macros et interface\Kalysse DesignCAD\Bancs\Banc_C700.d3m"},
                {"BancCompact600", @"\\Serv-kalysse\be\Macros et interface\Kalysse DesignCAD\Bancs\Banc_C600.d3m"},
                {"BancCompact750", @"\\Serv-kalysse\be\Macros et interface\Kalysse DesignCAD\Bancs\Banc_C750.d3m"},
                {"BancBoisB1", @"\\Serv-kalysse\be\Macros et interface\Kalysse DesignCAD\Bancs\Banc_B1.d3m"},
                {"BancBoisB50", @"\\Serv-kalysse\be\Macros et interface\Kalysse DesignCAD\Bancs\Banc_B50.d3m"},
                {"BancBoisB450", @"\\Serv-kalysse\be\Macros et interface\Kalysse DesignCAD\Bancs\Banc_B450.d3m"},
                {"ReperageFacade", @"\\serv-kalysse\BE\Macros et interface\Kalysse DesignCAD\Cabines\Nouveau_reperage\reperage_facade.d3m"},
                {"ReperageRefend", @"\\serv-kalysse\BE\Macros et interface\Kalysse DesignCAD\Cabines\Nouveau_reperage\reperage_refend.d3m"},
                {"AjusterRefend", @"\\serv-kalysse\BE\Macros et interface\Kalysse DesignCAD\Cabines\ajustement_refend.d3m"},
                {"FacadeD", @"\\serv-kalysse\BE\Macros et interface\Kalysse DesignCAD\Cabines\facade_d.d3m"},
                {"FacadeK", @"\\serv-kalysse\BE\Macros et interface\Kalysse DesignCAD\Cabines\facade_depart_k.d3m"},
                {"FacadeL", @"\\serv-kalysse\BE\Macros et interface\Kalysse DesignCAD\Cabines\facade_depart_l.d3m"},
            };

            return newDict;
        }
    }
}
