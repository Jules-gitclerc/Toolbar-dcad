﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolBarDcad.Paths
{
    static class InitializeMenu
    {
        public static Dictionary<string, string> InitMacroDict()
        {
            Dictionary<string, string> newDict = new Dictionary<string, string>()
            {
                // Modèles

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

                // Outils Kalysse

                {"CartoucheK", @"\\Serv-kalysse\be\Macros et interface\Kalysse DesignCAD\cartouche.d3m"},
                {"CotationB", @"\\Serv-kalysse\be\Macros et interface\Kalysse DesignCAD\Cotation\cotation_bandeau.d3m"},
                {"CotationF", @"\\Serv-kalysse\be\Macros et interface\Kalysse DesignCAD\Cotation\cotation_facade.d3m"},
                {"CotationA", @"\\Serv-kalysse\be\Macros et interface\Kalysse DesignCAD\Cotation\cotation_axe.d3m"},
                {"EclaterSelection", @"\\Serv-kalysse\be\Macros et interface\Kalysse DesignCAD\outils_couche\explode_selection.d3m"},
                {"OutilCouche", @"\\Serv-kalysse\be\Macros et interface\Kalysse DesignCAD\outils_couche\couche.d3m"},
                {"AfficherAttr", @"\\Serv-kalysse\be\Macros et interface\Kalysse DesignCAD\Attributs\afficher_attributs.d3m"},
                {"MasquerAttr", @"\\Serv-kalysse\be\Macros et interface\Kalysse DesignCAD\Attributs\masquer_attributs.d3m"},
                {"AjouterAttr", @"\\Serv-kalysse\be\Macros et interface\Kalysse DesignCAD\Attributs\ajouter_attribut.d3m"},
                {"ChangerAttr", @"\\Serv-kalysse\be\Macros et interface\Kalysse DesignCAD\Attributs\changement_attribut.d3m"},
                {"ChercherAttr", @"\\Serv-kalysse\be\Macros et interface\Kalysse DesignCAD\Attributs\chercher_attribut.d3m"},
                {"MultiplierAttr", @"\\Serv-kalysse\be\Macros et interface\Kalysse DesignCAD\Attributs\multiplier_attributs.d3m"},
                {"SupprimerAttr", @"\\Serv-kalysse\be\Macros et interface\Kalysse DesignCAD\Attributs\supprimer_attributs.d3m"},
                {"ChangerMateriau", @"\\serv-kalysse\BE\Macros et interface\Kalysse DesignCAD\material_swap.d3m"},
                {"FacadeBambino", @"\\serv-kalysse\BE\Macros et interface\Kalysse DesignCAD\Cabines\Facade_bambino_dxf.d3m"},
                {"PorteBambino", @"\\serv-kalysse\BE\Macros et interface\Kalysse DesignCAD\Cabines\Porte_bambino_dxf.d3m"},
                {"AnnulerReperage", @"\\Serv-kalysse\be\Macros et interface\Kalysse DesignCAD\reset_reperage.d3m"},

                // Vestiaire

                {"CasierHDiplo", @"\\Serv-kalysse\be\Macros et interface\Kalysse DesignCAD\Vestiaires\casier_h.d3m"},
                {"CasierZDiplo", @"\\Serv-kalysse\be\Macros et interface\Kalysse DesignCAD\Vestiaires\casier_z.d3m"},
                {"CasierHBanc", @"\\Serv-kalysse\be\Macros et interface\Kalysse DesignCAD\Vestiaires\casier_h_banc.d3m"},
                {"CasiersBancCompact", @"\\Serv-kalysse\be\Macros et interface\Kalysse DesignCAD\Vestiaires\casier_h_banc_compact.d3m"},
                {"CotationAxeCasier", @"\\Serv-kalysse\be\Macros et interface\Kalysse DesignCAD\Vestiaires\cotation_axe.d3m"},
                {"CotationFacadeCasier", @"\\Serv-kalysse\be\Macros et interface\Kalysse DesignCAD\Vestiaires\cotation_facade.d3m"},
                {"BancCompact1", @"\\Serv-kalysse\be\Macros et interface\Kalysse DesignCAD\Bancs\Banc_C1.d3m"},
                {"BancCompact20", @"\\Serv-kalysse\be\Macros et interface\Kalysse DesignCAD\Bancs\Banc_C20.d3m"},
                {"BancCompact50", @"\\Serv-kalysse\be\Macros et interface\Kalysse DesignCAD\Bancs\Banc_C50.d3m"},
                {"BancCompact60", @"\\Serv-kalysse\be\Macros et interface\Kalysse DesignCAD\Bancs\Banc_C60.d3m"},
                {"Lisse100", @"\\serv-kalysse\BE\Macros et interface\Kalysse DesignCAD\Bancs\lisse_serie_c100.d3m"},
                {"LisseCompactC150", @"\\serv-kalysse\BE\Macros et interface\Kalysse DesignCAD\Bancs\Lisse_C150.d3m"},
                {"BancCompact500", @"\\Serv-kalysse\be\Macros et interface\Kalysse DesignCAD\Bancs\Banc_C500.d3m"},
                {"BancCompact550", @"\\Serv-kalysse\be\Macros et interface\Kalysse DesignCAD\Bancs\Banc_C550.d3m"},
                {"BancCompact700", @"\\Serv-kalysse\be\Macros et interface\Kalysse DesignCAD\Bancs\Banc_C700.d3m"},
                {"BancCompact600", @"\\Serv-kalysse\be\Macros et interface\Kalysse DesignCAD\Bancs\Banc_C600.d3m"},
                {"BancCompact750", @"\\Serv-kalysse\be\Macros et interface\Kalysse DesignCAD\Bancs\Banc_C750.d3m"},
                {"BancBoisB1", @"\\Serv-kalysse\be\Macros et interface\Kalysse DesignCAD\Bancs\Banc_B1.d3m"},
                {"BancBoisB50", @"\\Serv-kalysse\be\Macros et interface\Kalysse DesignCAD\Bancs\Banc_B50.d3m"},
                {"LissePatereB100", @"\\Serv-kalysse\be\Macros et interface\Kalysse DesignCAD\Bancs\Lisse_B100.d3m"},
                {"BancBoisB450", @"\\Serv-kalysse\be\Macros et interface\Kalysse DesignCAD\Bancs\Banc_B450.d3m"},
                {"BancBoisB500", @"\\Serv-kalysse\be\Macros et interface\Kalysse DesignCAD\Bancs\Banc_B500.d3m"},
                {"BancBoisB750", @"\\Serv-kalysse\be\Macros et interface\Kalysse DesignCAD\Bancs\Banc_B750.d3m"},
                {"ArmoiresCollectives", @"\\serv-kalysse\BE\Macros et interface\Kalysse DesignCAD\Vestiaires\armoires_collectives.d3m"},
                {"LongeronsCollectifs", @"\\serv-kalysse\BE\Macros et interface\Kalysse DesignCAD\Vestiaires\longerons_collectif.d3m"},
                {"BarrePenderie", @"\\Serv-kalysse\BE\Macros et interface\Kalysse DesignCAD\Cotation\cotation_penderie.d3m"},
                {"PoseSerr001", @"\\serv-kalysse\BE\Macros et interface\Kalysse DesignCAD\Vestiaires\serrure_collectif_001.d3m"},
                {"PoseSerr006", @"\\serv-kalysse\BE\Macros et interface\Kalysse DesignCAD\Vestiaires\serrure_collectif_006.d3m"},
                {"PoseSerr015", @"\\serv-kalysse\BE\Macros et interface\Kalysse DesignCAD\Vestiaires\serrure_collectif_015.d3m"},
                {"ComposeLocker", @"\\serv-kalysse\BE\Macros et interface\Kalysse DesignCAD\Vestiaires\locker_constructor.d3m" },

                // Bloc-Portes

                {"BpC17Sc", @"\\Serv-kalysse\be\Macros et interface\Kalysse DesignCAD\Bloc Portes\bloc_porte _SC.d3m"},
                {"BpC17C18Ac", @"\\Serv-kalysse\be\Macros et interface\Kalysse DesignCAD\Bloc Portes\bloc_porte _AC_25mm.d3m"},
                {"BpC13", @"\\Serv-kalysse\be\Macros et interface\Kalysse DesignCAD\Bloc Portes\bloc_porte_BC.d3m"},
                {"BpBb", @"\\Serv-kalysse\be\Macros et interface\Kalysse DesignCAD\Bloc Portes\bloc_porte _BB.d3m"},
                {"BpVev", @"\\Serv-kalysse\be\Macros et interface\Kalysse DesignCAD\Bloc Portes\porte_va_et_vien.d3m"},
                {"Bpc", @"\\Serv-kalysse\be\Macros et interface\Kalysse DesignCAD\Bloc Portes\porte_coulissante.d3m"},

                // Accessoires

                {"PoseSerrurePiston", @"\\Serv-kalysse\be\Macros et interface\Kalysse DesignCAD\Accessoires\Macros accessoires\pose_serrure.d3m"},
                {"PaterePx10", @"\\Serv-kalysse\be\Macros et interface\Kalysse DesignCAD\Accessoires\Macros accessoires\Patère px10.d3m"},
                {"PaterePx13", @"\\Serv-kalysse\be\Macros et interface\Kalysse DesignCAD\Accessoires\Macros accessoires\Patère px13.d3m"},
                {"PatereMur", @"\\Serv-kalysse\be\Macros et interface\Kalysse DesignCAD\Accessoires\Macros accessoires\Patère mur.d3m"},
                {"PM300Px10", @"\\Serv-kalysse\be\Macros et interface\Kalysse DesignCAD\Accessoires\Macros accessoires\Poignée maintien 300 px10.d3m"},
                {"PM300Px13", @"\\Serv-kalysse\be\Macros et interface\Kalysse DesignCAD\Accessoires\Macros accessoires\Poignée maintien 300 px13.d3m"},
                {"PM300Mur", @"\\Serv-kalysse\be\Macros et interface\Kalysse DesignCAD\Accessoires\Macros accessoires\Poignée maintien 300 mur.d3m"},
                {"P300Mur", @"\\Serv-kalysse\be\Macros et interface\Kalysse DesignCAD\Accessoires\Macros accessoires\Poignée 300 M.d3m"},
                {"P300Panneau", @"\\Serv-kalysse\be\Macros et interface\Kalysse DesignCAD\Accessoires\Macros accessoires\Poignée 300 P.d3m"},
                {"PM400Px10", @"\\Serv-kalysse\be\Macros et interface\Kalysse DesignCAD\Accessoires\Macros accessoires\Poignée maintien 400 px10.d3m"},
                {"PM400Px13", @"\\Serv-kalysse\be\Macros et interface\Kalysse DesignCAD\Accessoires\Macros accessoires\Poignée maintien 400 px13.d3m"},
                {"PM400Mur", @"\\Serv-kalysse\be\Macros et interface\Kalysse DesignCAD\Accessoires\Macros accessoires\Poignée maintien 400 mur.d3m"},
                {"PM500Px10", @"\\Serv-kalysse\be\Macros et interface\Kalysse DesignCAD\Accessoires\Macros accessoires\Poignée maintien 500 px10.d3m"},
                {"PM500Px13", @"\\Serv-kalysse\be\Macros et interface\Kalysse DesignCAD\Accessoires\Macros accessoires\Poignée maintien 500 px13.d3m"},
                {"PM500Mur", @"\\Serv-kalysse\be\Macros et interface\Kalysse DesignCAD\Accessoires\Macros accessoires\Poignée maintien 500 mur.d3m"},
                {"PM600Px10", @"\\Serv-kalysse\be\Macros et interface\Kalysse DesignCAD\Accessoires\Macros accessoires\Poignée maintien 600 px10.d3m"},
                {"PM600Px13", @"\\Serv-kalysse\be\Macros et interface\Kalysse DesignCAD\Accessoires\Macros accessoires\Poignée maintien 600 px13.d3m"},
                {"PM600Mur", @"\\Serv-kalysse\be\Macros et interface\Kalysse DesignCAD\Accessoires\Macros accessoires\Poignée maintien 600 mur.d3m"},
                {"PPmr135Px10", @"\\Serv-kalysse\be\Macros et interface\Kalysse DesignCAD\Accessoires\Macros accessoires\Poignée maintien 135° px10.d3m"},
                {"PPmr135Px13", @"\\Serv-kalysse\be\Macros et interface\Kalysse DesignCAD\Accessoires\Macros accessoires\Poignée maintien 135° px13.d3m"},
                {"PPmr135Mur", @"\\Serv-kalysse\be\Macros et interface\Kalysse DesignCAD\Accessoires\Macros accessoires\Poignée maintien 135° mur.d3m"},
                {"PrL850Px10", @"\\Serv-kalysse\be\Macros et interface\Kalysse DesignCAD\Accessoires\Macros accessoires\Poignée maintien relevable px10.d3m"},
                {"PrL850Px13", @"\\Serv-kalysse\be\Macros et interface\Kalysse DesignCAD\Accessoires\Macros accessoires\Poignée maintien relevable px13.d3m"},
                {"PrL850Mur", @"\\Serv-kalysse\be\Macros et interface\Kalysse DesignCAD\Accessoires\Macros accessoires\Poignée maintien relevable mur.d3m"},
                {"SiegePx10", @"\\Serv-kalysse\be\Macros et interface\Kalysse DesignCAD\Accessoires\Macros accessoires\Siège relevable px10.d3m"},
                {"SiegePx13", @"\\Serv-kalysse\be\Macros et interface\Kalysse DesignCAD\Accessoires\Macros accessoires\Siège relevable px13.d3m"},
                {"SiegeMur", @"\\Serv-kalysse\be\Macros et interface\Kalysse DesignCAD\Accessoires\Macros accessoires\Siège relevable mur.d3m"},
                {"MiroirPx10", @"\\Serv-kalysse\be\Macros et interface\Kalysse DesignCAD\Accessoires\Macros accessoires\Miroir 600x400 px10.d3m"},
                {"MiroirPx13", @"\\Serv-kalysse\be\Macros et interface\Kalysse DesignCAD\Accessoires\Macros accessoires\Miroir 600x400 px13.d3m"},
                {"MiroirMur", @"\\Serv-kalysse\be\Macros et interface\Kalysse DesignCAD\Accessoires\Macros accessoires\Miroir 600x400 sur mur.d3m"},
                {"Miroir600Px10", @"\\Serv-kalysse\be\Macros et interface\Kalysse DesignCAD\Accessoires\Macros accessoires\Miroir Ø600 px10.d3m"},
                {"Miroir600Px13", @"\\Serv-kalysse\be\Macros et interface\Kalysse DesignCAD\Accessoires\Macros accessoires\Miroir Ø600 px13.d3m"},
                {"Miroir600Mur", @"\\Serv-kalysse\be\Macros et interface\Kalysse DesignCAD\Accessoires\Macros accessoires\Miroir Ø600 sur mur.d3m"},
                {"Miroir400Px10", @"\\Serv-kalysse\be\Macros et interface\Kalysse DesignCAD\Accessoires\Macros accessoires\Miroir Ø400 px10.d3m"},
                {"Miroir400Px13", @"\\Serv-kalysse\be\Macros et interface\Kalysse DesignCAD\Accessoires\Macros accessoires\Miroir Ø400 px13.d3m"},
                {"Miroir400Mur", @"\\Serv-kalysse\be\Macros et interface\Kalysse DesignCAD\Accessoires\Macros accessoires\Miroir Ø400 sur mur.d3m"},
                {"PorteSavonCompact", @"\\Serv-kalysse\be\Macros et interface\Kalysse DesignCAD\Accessoires\Macros accessoires\Porte savon compact.d3m"},
                {"PorteSavonPx10", @"\\Serv-kalysse\be\Macros et interface\Kalysse DesignCAD\Accessoires\Macros accessoires\Porte savon px10.d3m"},
                {"PorteSavonPx13", @"\\Serv-kalysse\be\Macros et interface\Kalysse DesignCAD\Accessoires\Macros accessoires\Porte savon px13.d3m"},
                {"PorteSavonMur", @"\\Serv-kalysse\be\Macros et interface\Kalysse DesignCAD\Accessoires\Macros accessoires\Porte savon mur.d3m"},
                {"DistribPQPx10", @"\\Serv-kalysse\be\Macros et interface\Kalysse DesignCAD\Accessoires\Macros accessoires\Distributeur papier toilette px10.d3m"},
                {"DistribPQPx13", @"\\Serv-kalysse\be\Macros et interface\Kalysse DesignCAD\Accessoires\Macros accessoires\Distributeur papier toilette px13mm.d3m"},
                {"DistribPQMur", @"\\Serv-kalysse\be\Macros et interface\Kalysse DesignCAD\Accessoires\Macros accessoires\Distributeur papier toilette sur mur.d3m"},
                {"MitigeurColCygne", @"\\Serv-kalysse\be\Macros et interface\Kalysse DesignCAD\Accessoires\Macros accessoires\Mitigeur retombee et col de cygne (790970 + 123503).d3m"},
                {"MitigeurMecanique", @"\\Serv-kalysse\be\Macros et interface\Kalysse DesignCAD\Accessoires\Macros accessoires\Mitigeur mecanique a douchette extractible (2211).d3m"},
                {"MitigeurLavabo", @"\\Serv-kalysse\be\Macros et interface\Kalysse DesignCAD\Accessoires\Macros accessoires\Mitigeur lavabo déclenchement souple (742500).d3m"},
                {"RobinetLavabo", @"\\Serv-kalysse\be\Macros et interface\Kalysse DesignCAD\Accessoires\Macros accessoires\Robinet monofluide lavabo déclenchement souple (740500).d3m"},
                {"RobinetDelabie", @"\\Serv-kalysse\be\Macros et interface\Kalysse DesignCAD\Accessoires\Macros accessoires\Robinet monofluide delabie dans retombee et col de cygne.d3m"},
                {"BambinoP",@"\\serv-kalysse\BE\Macros et interface\Kalysse DesignCAD\Accessoires\Macros accessoires\Poteau bambino.d3m"},
                {"BambinoPc", @"\\serv-kalysse\BE\Macros et interface\Kalysse DesignCAD\Accessoires\Macros accessoires\Poignee Carre Cabine Bambino Ref.221.310.d3m"},
                {"BambinoPl", @"\\serv-kalysse\BE\Macros et interface\Kalysse DesignCAD\Accessoires\Macros accessoires\Poignee Lune Cabine Bambino Ref.221.314.d3m"},
                {"BambinoPo", @"\\serv-kalysse\BE\Macros et interface\Kalysse DesignCAD\Accessoires\Macros accessoires\Poignee Ovale Cabine Bambino Ref.221.313.d3m"},
                {"BambinoPr", @"\\serv-kalysse\BE\Macros et interface\Kalysse DesignCAD\Accessoires\Macros accessoires\Poignee Ronde Cabine Bambino Ref.221.311.d3m"},
                {"BambinoPt", @"\\serv-kalysse\BE\Macros et interface\Kalysse DesignCAD\Accessoires\Macros accessoires\Poignee Triangle Cabine Bambino Ref.221.312.d3m"},
                {"DispositifAntiMistral", @"\\serv-kalysse\BE\Macros et interface\Kalysse DesignCAD\Accessoires\Macros accessoires\Dispositif anti-mistral.d3m"},
                {"GacheC33Mur", @"\\serv-kalysse\BE\Macros et interface\Kalysse DesignCAD\Accessoires\Macros accessoires\Gache C33 sur mur.d3m"},

                // Equipement

                {"BancCabinePre", @"\\Serv-kalysse\be\Macros et interface\Kalysse DesignCAD\Bancs\Banc cabine prévalidation.d3m"},
                {"BancCabinePost", @"\\Serv-kalysse\be\Macros et interface\Kalysse DesignCAD\Bancs\Banc cabine postvalidation.d3m"},
                {"PareDoucheSimple", @"\\serv-kalysse\BE\Macros et interface\Kalysse DesignCAD\Equipement\pare_douche.d3m"},
                {"PareDoucheDosADos", @"\\serv-kalysse\BE\Macros et interface\Kalysse DesignCAD\Equipement\pare_douche_dad.d3m"},
                {"Ecran", @"\\Serv-kalysse\be\Macros et interface\Kalysse DesignCAD\Equipement\ecran.d3m"},
                {"PtSimple", @"\\Serv-kalysse\be\Macros et interface\Kalysse DesignCAD\Equipement\plan_toilette_simple.d3m"},
                {"PtCollectif", @"\\Serv-kalysse\be\Macros et interface\Kalysse DesignCAD\Equipement\plan_toilette_collectif.d3m"},
                {"PlanVaisselle", @"\\Serv-kalysse\be\Macros et interface\Kalysse DesignCAD\Equipement\plan_vaisselle.d3m"},
                {"PtLinge", @"\\Serv-kalysse\be\Macros et interface\Kalysse DesignCAD\Equipement\plan_linge.d3m"},
                {"PtBaignoire", @"\\Serv-kalysse\be\Macros et interface\Kalysse DesignCAD\Equipement\plan_baignoire.d3m"},
                {"PQuartDeCercle", @"\\Serv-kalysse\be\Macros et interface\Kalysse DesignCAD\Equipement\plan_toilette_cercle.d3m"},
                {"RaccordPlan600", @"\\Serv-kalysse\be\Macros et interface\Kalysse DesignCAD\Equipement\Raccord plan 600.d3m"},
                {"FixationPlan", @"\\Serv-kalysse\be\Macros et interface\Kalysse DesignCAD\Equipement\fixations_plans.d3m"},
                {"JouePlan", @"\\Serv-kalysse\be\Macros et interface\Kalysse DesignCAD\Equipement\joue.d3m"},
                {"EcranUrinoir", @"\\Serv-kalysse\be\Macros et interface\Kalysse DesignCAD\Equipement\ecran_urinoir.d3m"},
                {"PanneauDoucheCentraux", @"\\Serv-kalysse\be\Macros et interface\Kalysse DesignCAD\Equipement\panneauxDouche_centraux.d3m"},
                {"PanneauDouchePDI", @"\\Serv-kalysse\be\Macros et interface\Kalysse DesignCAD\Equipement\panneau_douche.d3m"},
                {"Habillage", @"\\Serv-kalysse\be\Macros et interface\Kalysse DesignCAD\Equipement\habillage_bati_support.d3m"},
                {"BandeauCacheLuminaire", @"\\Serv-kalysse\be\Macros et interface\Kalysse DesignCAD\Equipement\Bandeau_Cache_Luminaire.d3m"},
                {"RobinetDouche", @"\\Serv-kalysse\be\Macros et interface\Kalysse DesignCAD\Equipement\Robinet_douche_dans_fond.d3m"},
                {"TrappePoubelle", @"\\Serv-kalysse\be\Macros et interface\Kalysse DesignCAD\Equipement\Trappe_dans_fond.d3m"},

                // Cabine

                {"ReperageFacade", @"\\serv-kalysse\BE\Macros et interface\Kalysse DesignCAD\Cabines\Nouveau_reperage\reperage_facade.d3m"},
                {"ReperageRefend", @"\\serv-kalysse\BE\Macros et interface\Kalysse DesignCAD\Cabines\Nouveau_reperage\reperage_refend.d3m"},
                {"AjusterRefend", @"\\serv-kalysse\BE\Macros et interface\Kalysse DesignCAD\Cabines\ajustement_refend.d3m"},
                {"AjusterFacade", @"\\serv-kalysse\BE\Macros et interface\Kalysse DesignCAD\Cabines\ajustement_facade.d3m"},
                {"FacadeD", @"\\serv-kalysse\BE\Macros et interface\Kalysse DesignCAD\Cabines\facade_d.d3m"},
                {"FacadeK", @"\\serv-kalysse\BE\Macros et interface\Kalysse DesignCAD\Cabines\facade_depart_k.d3m"},
                {"FacadeL", @"\\serv-kalysse\BE\Macros et interface\Kalysse DesignCAD\Cabines\facade_depart_l.d3m"},
                {"FondAjusterRefend", @"\\Serv-kalysse\be\Macros et interface\Kalysse DesignCAD\Cabines\ajustement_refend_Fond.d3m"},
                {"AjoutFondCabine", @"\\Serv-kalysse\be\Macros et interface\Kalysse DesignCAD\Cabines\ajout_fond_cabine.d3m"},
                {"AjoutFondAngle", @"\\Serv-kalysse\be\Macros et interface\Kalysse DesignCAD\Cabines\Fond_Cabine_d.d3m"},
                {"FondRepererRefend", @"\\Serv-kalysse\be\Macros et interface\Kalysse DesignCAD\Cabines\reperage_refend_fond.d3m"},
                {"PoserPorte", @"\\Serv-kalysse\be\Macros et interface\Kalysse DesignCAD\Cabines\depart_porte.d3m"},
                {"AjusterPorte", @"\\Serv-kalysse\be\Macros et interface\Kalysse DesignCAD\Cabines\ajustement_porte.d3m"},
                {"ProfilAuSol", @"\\Serv-kalysse\be\Macros et interface\Kalysse DesignCAD\Cabines\profil_sol.d3m"},
                {"PoserFlasque", @"\\serv-kalysse\BE\Macros et interface\Kalysse DesignCAD\Cabines\Flasque.d3m"},
                {"PoserCabinePNPC", @"\\serv-kalysse\BE\Macros et interface\Kalysse DesignCAD\PNPC\cabine_pnpc.d3m"},
                {"PoserPNPCdosAdos", @"\\serv-kalysse\BE\Macros et interface\Kalysse DesignCAD\PNPC\cabine_pnpc_dos_a_dos.d3m"},
                {"PoserRefendTerminaison", @"\\serv-kalysse\BE\Macros et interface\Kalysse DesignCAD\PNPC\cabine_pnpc_sans_portex.d3m"},
                {"AjusterCabinePNPC", @"\\serv-kalysse\BE\Macros et interface\Kalysse DesignCAD\PNPC\banc_pnpc.d3m"},
                {"RepererCabinePNPC", @"\\serv-kalysse\BE\Macros et interface\Kalysse DesignCAD\PNPC\reperage_pnpc.d3m"},

                // Logo

                {"LogoAccesPrive", @"\\Serv-kalysse\be\Macros et interface\Kalysse DesignCAD\Accessoires\Macros accessoires\logo porte\poser_logo_acces_prive.d3m"},
                {"LogoBebe", @"\\Serv-kalysse\be\Macros et interface\Kalysse DesignCAD\Accessoires\Macros accessoires\logo porte\poser_logo_bebe.d3m"},
                {"LogoDouche", @"\\Serv-kalysse\be\Macros et interface\Kalysse DesignCAD\Accessoires\Macros accessoires\logo porte\poser_logo_douche.d3m"},
                {"LogoEnfant", @"\\Serv-kalysse\be\Macros et interface\Kalysse DesignCAD\Accessoires\Macros accessoires\logo porte\poser_logo_enfant.d3m"},
                {"LogoFamille", @"\\Serv-kalysse\be\Macros et interface\Kalysse DesignCAD\Accessoires\Macros accessoires\logo porte\poser_logo_famille.d3m"},
                {"LogoFemme", @"\\Serv-kalysse\be\Macros et interface\Kalysse DesignCAD\Accessoires\Macros accessoires\logo porte\poser_logo_femme.d3m"},
                {"LogoHomme", @"\\Serv-kalysse\be\Macros et interface\Kalysse DesignCAD\Accessoires\Macros accessoires\logo porte\poser_logo_homme.d3m"},
                {"LogoLavabo", @"\\Serv-kalysse\be\Macros et interface\Kalysse DesignCAD\Accessoires\Macros accessoires\logo porte\poser_logo_lavabo.d3m"},
                {"LogoLaverie", @"\\Serv-kalysse\be\Macros et interface\Kalysse DesignCAD\Accessoires\Macros accessoires\logo porte\poser_logo_laverie.d3m"},
                {"LogoLocalTech", @"\\Serv-kalysse\be\Macros et interface\Kalysse DesignCAD\Accessoires\Macros accessoires\logo porte\poser_logo_local_tech.d3m"},
                {"LogoPmr", @"\\Serv-kalysse\be\Macros et interface\Kalysse DesignCAD\Accessoires\Macros accessoires\logo porte\poser_logo_pmr.d3m"},
                {"LogoPoubelle", @"\\Serv-kalysse\be\Macros et interface\Kalysse DesignCAD\Accessoires\Macros accessoires\logo porte\poser_logo_poubelle.d3m"},
                {"LogoUrinoir", @"\\Serv-kalysse\be\Macros et interface\Kalysse DesignCAD\Accessoires\Macros accessoires\logo porte\poser_logo_urinoir.d3m"},
                {"LogoVestiaire", @"\\Serv-kalysse\be\Macros et interface\Kalysse DesignCAD\Accessoires\Macros accessoires\logo porte\poser_logo_vestiaire.d3m"},
                {"LogoVidoir", @"\\Serv-kalysse\be\Macros et interface\Kalysse DesignCAD\Accessoires\Macros accessoires\logo porte\poser_logo_vidoir.d3m"},
                {"LogoWC", @"\\Serv-kalysse\be\Macros et interface\Kalysse DesignCAD\Accessoires\Macros accessoires\logo porte\poser_logo_wc.d3m"},

                // Boîtes à outils

                {"PoserRag", @"\\serv-kalysse\BE\Macros et interface\Kalysse DesignCAD\macros_symboles\refend_apg.d3m"},
                {"PoserRad", @"\\serv-kalysse\BE\Macros et interface\Kalysse DesignCAD\macros_symboles\refend_apd.d3m"},
                {"PoserRb", @"\\serv-kalysse\BE\Macros et interface\Kalysse DesignCAD\macros_symboles\refend_b.d3m"},
                {"PoserRcg", @"\\serv-kalysse\BE\Macros et interface\Kalysse DesignCAD\macros_symboles\refend_cpg.d3m"},
                {"PoserRcd", @"\\serv-kalysse\BE\Macros et interface\Kalysse DesignCAD\macros_symboles\refend_cpd.d3m"},
                {"PoserRc", @"\\serv-kalysse\BE\Macros et interface\Kalysse DesignCAD\macros_symboles\refend_c.d3m"},
                {"PoserRcfig", @"\\serv-kalysse\BE\Macros et interface\Kalysse DesignCAD\macros_symboles\refend_cfig.d3m"},
                {"PoserRcfid", @"\\serv-kalysse\BE\Macros et interface\Kalysse DesignCAD\macros_symboles\refend_cfid.d3m"},
                {"PoserRcfi", @"\\serv-kalysse\BE\Macros et interface\Kalysse DesignCAD\macros_symboles\refend_cfi.d3m"},
                {"PoserRcfeg", @"\\serv-kalysse\BE\Macros et interface\Kalysse DesignCAD\macros_symboles\refend_cfeg.d3m"},
                {"PoserRcfed", @"\\serv-kalysse\BE\Macros et interface\Kalysse DesignCAD\macros_symboles\refend_cfed.d3m"},
                {"PoserRcfe", @"\\serv-kalysse\BE\Macros et interface\Kalysse DesignCAD\macros_symboles\refend_cfe.d3m"},
                {"PoserPied", @"\\serv-kalysse\BE\Macros et interface\Kalysse DesignCAD\macros_symboles\pied.d3m"},
                {"PoserChape", @"\\serv-kalysse\BE\Macros et interface\Kalysse DesignCAD\macros_symboles\chape.d3m"},
                {"Repere10", @"\\serv-kalysse\BE\Macros et interface\Kalysse DesignCAD\Profils\Macros\ImportRep.10.d3m"},
                {"Repere12", @"\\serv-kalysse\BE\Macros et interface\Kalysse DesignCAD\Profils\Macros\ImportRep.12.d3m"},
                {"Repere12P", @"\\serv-kalysse\BE\Macros et interface\Kalysse DesignCAD\Profils\Macros\ImportRep.12P.d3m"},
                {"Repere14", @"\\serv-kalysse\BE\Macros et interface\Kalysse DesignCAD\Profils\Macros\ImportRep.14.d3m"},


                // BAncs bois
                { "BancsBoisConfig", @"\\serv-kalysse\BE\Macros et interface\Kalysse DesignCAD\Bancs\Modele\set_config_bancs.d3m" }
            };

            return newDict;
        }
    }
}
