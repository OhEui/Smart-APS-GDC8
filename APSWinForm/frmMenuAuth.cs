using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using APSVO;

namespace APSWinForm
{
    public partial class frmMenuAuth : Form
    {
        MenuDAC db = new MenuDAC();
        DataTable dtMenuAuth = null;
        int sel_menu_id = 0;
        List<MenuVO> list = null;
        ServiceHelp srv = new ServiceHelp("");
        


        public frmMenuAuth()
        {
            InitializeComponent();
        }

        

        private void MenuAuthBinding()
        {
            dtMenuAuth = db.GetMenuAuthList();
        }

        private void frmMenuAuth_Load(object sender, EventArgs e)
        {
            MenuBinding(); //트리뷰컨트롤에 메뉴를 바인딩
            AuthBinding(); //리스트박스컨트롤에 모든 권한을 바인딩
            MenuAuthBinding(); //모든 메뉴의 권한정보를 조회
        }

        private void AuthBinding()
        {
            DataTable dtAuth = db.GetAuthList();

            lstAll.Items.Clear();
            foreach (DataRow dr in dtAuth.Rows)
            {
                lstAll.Items.Add($"{dr["auth_id"].ToString()}|{dr["auth_name"].ToString()}");
            }
        }


        private async void databinding()
        {
            list = await srv.GetListAsync("api/Menu/Menulist", list);
        }
        private void MenuBinding()
        {

            
            DataTable dtMenu = db.GetMenuList();

            DataView dv1 = new DataView(dtMenu);
            dv1.RowFilter = "menu_level=1";
            dv1.Sort = "menu_sort";
            for (int i = 0; i < dv1.Count; i++)
            {
                TreeNode node = new TreeNode(dv1[i]["menu_name"].ToString());
                node.Tag = $"{dv1[i]["menu_level"].ToString()}|{dv1[i]["menu_id"].ToString()}";
                tvMenu.Nodes.Add(node);

                DataView dv2 = new DataView(dtMenu);
                dv2.RowFilter = "menu_level=2 and pnt_menu_id=" + dv1[i]["menu_id"].ToString();
                dv2.Sort = "menu_sort";

                for (int k = 0; k < dv2.Count; k++)
                {
                    TreeNode c_node = new TreeNode(dv2[k]["menu_name"].ToString());
                    c_node.Tag = $"{dv2[k]["menu_level"].ToString()}|{dv2[k]["menu_id"].ToString()}";
                    node.Nodes.Add(c_node);
                }
            }

            tvMenu.ExpandAll();
        }

        private void tvMenu_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void tvMenu_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {

        }

        private void ClearRecursive(TreeNode node)
        {
            foreach (TreeNode c_node in node.Nodes)
            {
                c_node.BackColor = Color.White;
                ClearRecursive(c_node);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnDel_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        
    }
}
