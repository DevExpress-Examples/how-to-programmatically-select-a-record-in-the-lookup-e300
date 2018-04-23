namespace AuditDemo.Module.Win {
    partial class SelectRecordInLookupViewController {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.saSelectRecordInLookup = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            // 
            // saSelectRecordInLookup
            // 
            this.saSelectRecordInLookup.ActionMeaning = DevExpress.ExpressApp.Actions.ActionMeaning.Accept;
            this.saSelectRecordInLookup.Caption = "Select Record";
            this.saSelectRecordInLookup.Category = "PopupActions";
            this.saSelectRecordInLookup.Id = "SelectRecordInLookup";
            this.saSelectRecordInLookup.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.saSelectRecordInLookup_Execute);

        }

        #endregion

        private DevExpress.ExpressApp.Actions.SimpleAction saSelectRecordInLookup;
    }
}
