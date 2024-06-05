namespace WinFormsControlLibrary1
{
    [ToolboxBitmap(@"C:\Users\user\source\repos\.NET\Lab_1\WinFormsControlLibrary1\LockButton.ico")]
    partial class LockButton : Button
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            timer = new System.Windows.Forms.Timer(components);
            
            timer.Interval = 1000;

            timer.Tick += (sender, e) =>
            {
                LockButtonTick();
            };

            Click += (sender, e) =>
            {
                LockButtonClick();
            };
        }
        #endregion
    }
}
