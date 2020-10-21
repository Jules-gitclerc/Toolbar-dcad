using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignCAD;

namespace DcadToolBar
{
    public class DocumentsManager
    {
        public Application App { get; }

        List<DcDocument> DocList = new List<DcDocument>();

        public Documents _dcDocs;

        public Documents DcDocs
        {
            get => _dcDocs;
            set
            {
                _dcDocs = value;
                foreach (Document document in _dcDocs)
                {
                    if (!DocList.Exists(doc => doc.Name == document.Name)) 
                        DocList.Add(new DcDocument(document.Name));
                }
            }
        }

        public Document ActiveDoc { get; set; }

        public event EventHandler RaiseDialogBoxEvent;

        public event EventHandler<LaunchMacroEventArgs> RaiseLaunchMacrosEvent;

        public DocumentsManager(Application app)
        {
            App = app;
            DcDocs = app.Documents();
            ActiveDoc = null;
            foreach (Document document in DcDocs)
            {
                DocList.Add(new DcDocument(document.Name));
            }
        }

        /// <summary>
        /// Replace the document taken in charge by the toolbar by the active document.
        /// </summary>
        /// <returns>
        /// <para><see langword="true" /> if the change is successful.</para>
        /// <para><see langword="false" /> if not.</para>
        /// </returns>

        public bool SetActiveDoc()
        {
            DcDocs = GetAppDocuments();

            if (DcDocs.Count < 1) return false;
            ActiveDoc = App.ActiveDocument;

            DcDocument document = DocList.Find(doc => doc.Name == ActiveDoc.Name);

            if (document.Model == null)
                OnRaiseDialogBoxEvent(new EventArgs());
            else
                OnRaiseLaunchMacrosEvent(new LaunchMacroEventArgs(document.Model, document.Type));
            return true;
        }

        public void RefreshDocList(string model, string material)
        {
            DcDocument document = DocList.Find(doc => doc.Name == ActiveDoc.Name);

            document.Model = MacroTools.ToCabin(model);
            document.Type = MacroTools.ToMaterial(material);
        }

        protected virtual void OnRaiseDialogBoxEvent(EventArgs e)
        {
            EventHandler raiseEvent = RaiseDialogBoxEvent;

            raiseEvent?.Invoke(this, e);
        }

        protected virtual void OnRaiseLaunchMacrosEvent(LaunchMacroEventArgs e)
        {
            EventHandler<LaunchMacroEventArgs> raiseEvent = RaiseLaunchMacrosEvent;

            raiseEvent?.Invoke(this, e);
        }

        private Documents GetAppDocuments()
        {
            return App.Documents();
        }

        /// <summary>
        /// Runs the specified macro designed by the specified path.
        /// </summary>
        /// <param name="macroPath"></param>
        /// <returns>
        /// <para>1 if the macro has been successfully launched on the active document.</para>
        /// <para>2 if the macro could not be launched.</para>
        /// <para>3 if the macro path could not be found.</para>
        /// </returns>

        public int RunMacroOnActiveDoc(string macroPath, string macroName)
        {
            DcDocs = GetAppDocuments();

            if (DcDocs.Count < 1) return 2;
            if (ActiveDoc == null) return 2;
            try
            {
                ActiveDoc.RunBasicCAD(macroPath);
                if (MacroTools.ToCabin(macroName) != CabinModel.NullModel)
                {
                    DcDocument document = DocList.Find(doc => doc.Name == ActiveDoc.Name);

                    document.Model = MacroTools.ToCabin(macroName);
                }
                else if (MacroTools.ToMaterial(macroName) != MaterialType.NullMaterial)
                {
                    DcDocument document = DocList.Find(doc => doc.Name == ActiveDoc.Name);

                    document.Type = MacroTools.ToMaterial(macroName);
                }
                return 1;
            }
            catch
            {
                return 3;
            }
        }
    }
}
