using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TOPUPGAME.Model.Repository;
using TOPUPGAME.Model.Context;
using TOPUPGAME.Model.Entity;
using TOPUPGAME.Controller;
using System.Data.SqlClient;

namespace TOPUPGAME.All_Form.Form_Lupa_Password
{
    public partial class FrmLupaPasswordPart1 : Form
    {
        private UserController _userController;

        public FrmLupaPasswordPart1(UserController userController)
        {
            InitializeComponent();
            this.MinimumSize = new Size(900, 600);
            _userController = userController;
        }

        private void btnMencariEmail_Click(object sender, EventArgs e)
        {
            string usernameOrEmail = txtEmailLupaPasswordPart1.Text;
            _userController.CariEmaildanUsername(usernameOrEmail, this);



        }

        private void btnkembaliLupapasswordpart1_Click(object sender, EventArgs e)
        {
            frmlogin Frmlogin = new frmlogin(_userController);
            Frmlogin.Show();
            this.Hide();
        }
    }
}
