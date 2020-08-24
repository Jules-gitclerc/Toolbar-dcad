using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignCAD;

namespace DcadToolBar
{
    class Macro     //unused for now
    {
        public string Name { get; set; }

        public int ID { get; set; }

        public string Path { get; }

        public Macro(string name, int id, string path)
        {
            Name = name;
            ID = id;
            Path = path;
        }

        public void CallMacro(Document dcDoc)
        {
            dcDoc.RunBasicCAD(Path);
        }
    }

    public static class MacroTools
    {
        public static string CabinToString(CabinModel? model)
        {
            string newStr;

            switch (model)
            {
                case CabinModel.NullModel:
                    newStr = null;
                    break;
                case CabinModel.PrimoExel:
                    newStr = "Primo exel";
                    break;
                case CabinModel.DuoExel:
                    newStr = "Duo exel";
                    break;
                case CabinModel.BrioExel:
                    newStr = "Brio exel";
                    break;
                case CabinModel.Exeleo:
                    newStr = "Exéléo";
                    break;
                default:
                    newStr = model.ToString();
                    break;
            }

            return newStr;
        }

        public static string MaterialToString(MaterialType? material)
        {
            string newStr;

            switch (material)
            {
                case MaterialType.NullMaterial:
                    newStr = null;
                    break;
                default:
                    newStr = material.ToString();
                    break;
            }

            return newStr;
        }

        public static CabinModel ToCabin(string model)
        {
            CabinModel newModel;

            switch (model)
            {
                case "Primo":
                    newModel = CabinModel.Primo;
                    break;
                case "Primo exel":
                    newModel = CabinModel.PrimoExel;
                    break;
                case "Duo":
                    newModel = CabinModel.Duo;
                    break;
                case "Duo exel":
                    newModel = CabinModel.DuoExel;
                    break;
                case "Brio":
                    newModel = CabinModel.Brio;
                    break;
                case "Brio exel":
                    newModel = CabinModel.BrioExel;
                    break;
                case "Hauzeo":
                    newModel = CabinModel.Hauzeo;
                    break;
                case "Bambino":
                    newModel = CabinModel.Bambino;
                    break;
                case "Exéléo":
                    newModel = CabinModel.Exeleo;
                    break;
                default:
                    newModel = CabinModel.NullModel;
                    break;
            }
            return newModel;
        }

        public static MaterialType ToMaterial(string material)
        {
            MaterialType newMaterial;

            switch (material)
            {
                case "Nylon":
                    newMaterial = MaterialType.Nylon;
                    break;
                case "Aluminium":
                    newMaterial = MaterialType.Aluminium;
                    break;
                case "Inox":
                    newMaterial = MaterialType.Inox;
                    break;
                default:
                    newMaterial = MaterialType.NullMaterial;
                    break;
            }

            return newMaterial;
        }
    }

    public enum CabinModel
    {
        Primo,
        PrimoExel,
        Duo,
        DuoExel,
        Brio,
        BrioExel,
        Hauzeo,
        Bambino,
        Exeleo,
        NullModel
    }

    public enum MaterialType
    {
        Nylon,
        Aluminium,
        Inox,
        NullMaterial
    }
}
