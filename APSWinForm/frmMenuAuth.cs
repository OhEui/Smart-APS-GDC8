using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using APSUtil.Http;
using APSVO;

namespace APSWinForm
{
    public partial class frmMenuAuth : Form
    {
        //MenuDAC db = new MenuDAC();
        DataTable dtMenuAuth = null;
        int sel_menu_id = 0;
        List<MenuVO> Menulist = null;
        ServiceHelp srv = new ServiceHelp();



        public frmMenuAuth()
        {
            InitializeComponent();
        }

        

        //private void MenuAuthBinding()
        //{
        //    dtMenuAuth = db.GetMenuAuthList();
        //}

        private void frmMenuAuth_Load(object sender, EventArgs e)
        {
            MenuBinding(); //트리뷰컨트롤에 메뉴를 바인딩
            //AuthBinding(); //리스트박스컨트롤에 모든 권한을 바인딩
           // MenuAuthBinding(); //모든 메뉴의 권한정보를 조회
        }

        //private void AuthBinding()
        //{
        //    DataTable dtAuth = db.GetAuthList();

        //    lstAll.Items.Clear();
        //    foreach (DataRow dr in dtAuth.Rows)
        //    {
        //        lstAll.Items.Add($"{dr["auth_id"].ToString()}|{dr["auth_name"].ToString()}");
        //    }
        //}


       public async void Databinding()
        {
            Menulist = await srv.GetListAsync("api/Menu/Menulist", Menulist);
            
        }

        
        private async void MenuBinding()
        {

            
            Menulist = await srv.GetListAsync("api/Menu/Menulist", Menulist);
            // DataTable dtMenu = db.GetMenuList();

            var list = (from Menu in Menulist
                        where Menu.MENU_LEVEL == 1
                        orderby Menu.MENU_SORT
                        select Menu 
                         ).ToList();

            //dv1.RowFilter = "menu_level=1"; // where절 
            //dv1.Sort = "menu_sort";

            for (int i = 0; i < list.Count; i++)
            {
                TreeNode node = new TreeNode(list[i].MENU_NAME);
                node.Tag = $"{list[i].MENU_LEVEL}|{list[i].MENU_ID}";
                tvMenu.Nodes.Add(node);


                var list2 = (from Menu in Menulist
                             where Menu.MENU_LEVEL == 2 && Menu.PNT_MENU_ID == list[i].MENU_ID
                             orderby Menu.MENU_SORT
                             select Menu).ToList();

                //DataView dv2 = new DataView(dtMenu);
                //dv2.RowFilter = "menu_level=2 and pnt_menu_id=" + dv1[i]["menu_id"].ToString();
                //dv2.Sort = "menu_sort";

                for (int k = 0; k < list2.Count; k++)
                {
                    TreeNode c_node = new TreeNode(list2[k].MENU_NAME);
                    c_node.Tag = $"{list2[k].MENU_LEVEL}|{list2[k].MENU_ID}";
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
