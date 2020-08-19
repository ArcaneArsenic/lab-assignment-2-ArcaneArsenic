/*UserInterface.cs
 *Author: TC Levi
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ksu.Cis300.TextEditor
{
    /// <summary>
    /// textbox form load seq.
    /// </summary>
    public partial class UserInterface : Form
    {
        /// <summary>
        /// loads GUI?
        /// </summary>
        public UserInterface()
        {
            InitializeComponent();
        }
        /// <summary>
        /// displays open file dialog 
        /// and message box (if a file is selected)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxOpenTSMI_Click(object sender, EventArgs e)
        {
            if (uxOpenFD.ShowDialog() == DialogResult.OK) 
            { 
                string fileName = uxOpenFD.FileName;
                if (fileName != null) 
                { MessageBox.Show("Unable to open " + fileName + "."); }
            }
                //file manip.
        }
        /// <summary>
        /// display save file dialog
        /// cannot save new files in present state
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxSaveFD_FileOk(object sender, CancelEventArgs e)
        {
            if (uxSaveFD.ShowDialog() == DialogResult.OK)
            {
                string fileName = uxSaveFD.FileName;
                if (fileName != null)
                { MessageBox.Show("Unable to open " + fileName + "."); }
            }
        }
    }
}
