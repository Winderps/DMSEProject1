using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Reflection;
using Xceed.Chart.GraphicsCore;
using Xceed.Chart.Standard;
using Xceed.Chart;
using Xceed.Chart.Core;

namespace Xceed.Chart
{
    public class LegendGeneral : Form1
    {
        private System.ComponentModel.Container components = null;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox LegendModeComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox HeaderTextBox;
        private System.Windows.Forms.TextBox FooterTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.HScrollBar MarkSizeScrollBar;
        private System.Windows.Forms.ComboBox ExpandModeComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown RowCountUpDown;
        private System.Windows.Forms.NumericUpDown ColCountUpDown;
        private System.Windows.Forms.ComboBox PredefinedPositionsComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button MarkFEButton;
        private System.Windows.Forms.Button MarkLinePropsButton;
        private System.Windows.Forms.Button ItemLinePropsButton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button AddCustomLegendMark;
        private System.Windows.Forms.Button DeleteCustomLegendMarkButton;
        private System.Windows.Forms.TextBox CustomLegendMarkTextBox;
        private System.Windows.Forms.ListBox CustomLegendMarksListBox;
        private System.Windows.Forms.ComboBox MarkShapeComboBox;
        private System.Windows.Forms.GroupBox ManualMarksGroupBox;
        private System.Windows.Forms.GroupBox TitlesGroupBox;
        private System.Windows.Forms.GroupBox LayoutGroupBox;
        public Xceed.Chart.Core.Legend m_Legend;

     

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }
    }
}
