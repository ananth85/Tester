using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Automation.Controls
{
    public partial class AddObject : UserControl
    {
        public AddObject()
        {
            InitializeComponent();
            T_ObjectName.TextChanged += T_ObjectName_TextChanged;
            C_FindBy.SelectedValueChanged += C_FindBy_SelectedValueChanged;
            C_FrameBy.SelectedValueChanged += C_FrameBy_SelectedValueChanged;
            T_Property.TextChanged += T_Property_TextChanged;
            T_ObjDesc.TextChanged += T_ObjDesc_TextChanged;
            T_FrameProperty.TextChanged += T_FrameProperty_TextChanged;
            btn_Action.Click += Btn_Action_Click;
        }

        private void Btn_Action_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(ScreenName))
            {
                string InsertData = "Insert into ";
            }
        }

        private void T_FrameProperty_TextChanged(object sender, EventArgs e)
        {
            FrameProperty = T_FrameProperty.Text;
        }

        private void T_ObjDesc_TextChanged(object sender, EventArgs e)
        {
            ObjectDesc = T_ObjDesc.Text;
        }

        private void T_Property_TextChanged(object sender, EventArgs e)
        {
            ObjProperty = T_Property.Text;
        }

        private void C_FrameBy_SelectedValueChanged(object sender, EventArgs e)
        {
            FrameProperty = C_FrameBy.Text;
        }

        private void C_FindBy_SelectedValueChanged(object sender, EventArgs e)
        {
            FindBy = C_FindBy.Text;
        }

        private void T_ObjectName_TextChanged(object sender, EventArgs e)
        {
            ObjectName = T_ObjectName.Text;
        }

        internal int ProjectID { get; set; }
        internal int ScreenID { get; set; }
        internal string ScreenName { get; set; }
        internal int ObjectID { get; set; }
        internal string ObjectName { get; set; }
        internal List<string> FindByList { get; set; }
        internal string FindBy { get; set; }
        internal string ObjProperty { get; set; }
        internal string ObjectDesc { get; set; }
        internal List<string> FrameByList { get; set; }
        internal string FrameBy { get; set; }
        internal string FrameProperty { get; set; }
        
        
    }
}
