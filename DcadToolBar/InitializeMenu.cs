﻿using System;
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
                {"BambinoP",@"\\serv-kalysse\BE\Macros et interface\Kalysse DesignCAD\Accessoires\Macros accessoires/Poteau bambino.d3m"},
                {"BambinoPc", @"\\serv-kalysse\BE\Macros et interface\Kalysse DesignCAD\Accessoires\Macros accessoires\Poignee Carre Cabine Bambino Ref.221.310.d3m"},
                {"BambinoPl", @"\\serv-kalysse\BE\Macros et interface\Kalysse DesignCAD\Accessoires\Macros accessoires\Poignee Lune Cabine Bambino Ref.221.314.d3m"},
                {"BambinoPo", @"\\serv-kalysse\BE\Macros et interface\Kalysse DesignCAD\Accessoires\Macros accessoires\Poignee Ovale Cabine Bambino Ref.221.313.d3m"},
                {"BambinoPr", @"\\serv-kalysse\BE\Macros et interface\Kalysse DesignCAD\Accessoires\Macros accessoires\Poignee Ronde Cabine Bambino Ref.221.311.d3m"},
                {"BambinoPt", @"\\serv-kalysse\BE\Macros et interface\Kalysse DesignCAD\Accessoires\Macros accessoires\Poignee Triangle Cabine Bambino Ref.221.312.d3m"},
                {"PtCollectif", @"C:\Users\DevKalysse\Desktop\plan_toilette_collectif.d3m"},
            };

            return newDict;
        }
    }
}
