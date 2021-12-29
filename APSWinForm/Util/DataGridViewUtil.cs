using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APSWinForm
{
    public class DataGridViewUtil
    {
        public static void SetInitGridView(DataGridView dgv)
        {
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // 특정 cell 하나를 클릭해도, 줄 전체가 선택
            dgv.AllowUserToAddRows = false;  //맨 마지막 줄에 * 표시된 빈 줄 생성 방지
            dgv.AutoGenerateColumns = false; //DataSource를 바인딩해도 자동으로 컬럼이 추가되지 않는다. 수동컬럼추가해서 생성하겠다

            dgv.AllowUserToResizeRows = false;
            dgv.AllowUserToResizeColumns = false;
            dgv.MultiSelect = false;
        }

        //문자열(가변인 문자열) => 왼쪽정렬 : (기본값)
        //문자열(고정인 문자열) => 가운데정렬
        //숫자 => 수량, 재고량, 금액, 합계금액 등 => 오른쪽정렬
        public static void AddGridTextColumn(DataGridView dgv, 
            string headerText, 
            string propertyName, 
            DataGridViewContentAlignment align=DataGridViewContentAlignment.MiddleLeft, 
            int colWidth=100,
            bool visibility=true,
            bool frozen=false)
        {
            DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();
            dgv.Columns.Add(col);
            col.Name = propertyName;
            col.HeaderText = headerText;
            col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col.DataPropertyName = propertyName;
            col.DefaultCellStyle.Alignment = align;
            col.Width = colWidth;
            col.Visible = visibility;
            col.Frozen = frozen;
            col.ReadOnly = true; //그리드뷰에서 데이터수정불가
            
        }
    }
}
