using APSVO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APSWinForm
{
    public static class CommonUtil
    {
        /// <summary>
        /// 입력받은 문자열을 int로 변환 불가능할 경우 null, 변환 가능하면 해당 값을 int로 반환합니다.
        /// </summary>
        /// <param name="txt"></param>
        /// <returns></returns>
        public static int? CvtIntorNull(string str)
        {
            if (!int.TryParse(str, out int result))
            {
                return null;
            }
            else
            {
                return result;
            }
        }
        /// <summary>
        /// 입력받은 값을 int로 변환 불가능할 경우 null, 변환 가능하면 해당 값을 int로 반환합니다.
        /// </summary>
        /// <param name="txt"></param>
        /// <returns></returns>
        public static int? CvtIntorNull(object obj) => CvtIntorNull(obj?.ToString());

        /// <summary>
        /// ComBoItemVO의 리스트를 콤보박스에 바인딩합니다.<br/>
        /// gubun = null 인 경우 category 전체에서 값을 가져오고, gubun의 값이 주어지면 해당 category만 가져옵니다.<br/>
        /// Int값을 ComboItemVO에 넣기 위해 문자열로 형변환했으면 나중에 값을 사용할 때 다시 형변환을 해야 합니다.
        /// </summary>
        /// <param name="cbo"></param>
        /// <param name="list"></param>
        /// <param name="gubun"></param>
        /// <param name="blankItem"></param>
        /// <param name="blankText"></param>
        public static void ComboBinding(ComboBox cbo, List<ComboItemVO> list, string gubun = null,
            bool blankItem=true, string blankText="")
        {
            List<ComboItemVO> codeList;
            if (gubun != null) 
            {
                codeList = list.Where((item) => item.Category.Equals(gubun)).ToList();
            }
            else
            {
                codeList = list;
            }

            if (blankItem)
            {
                ComboItemVO blank = new ComboItemVO
                {
                    Code = "",
                    CodeName = blankText,
                    Category = gubun
                };
                codeList.Insert(0, blank);
            }

            cbo.DisplayMember = "CodeName";
            cbo.ValueMember = "Code";
            cbo.DataSource = codeList;
        }


        public static Image ByteToImage(byte[] data)
        {
            TypeConverter tc = TypeDescriptor.GetConverter(typeof(Bitmap));
            if (data == null || data.Length < 10) return null;
            return (Bitmap)tc.ConvertFrom(data);
        }

        public static byte[] ImageToByte(Image img)
        {
            if (img == null) return null;
            ImageConverter ic = new ImageConverter();
            return (byte[])ic.ConvertTo(img, typeof(byte[]));
        }


        /// <summary>
        /// source를 복사해서 생성한 객체를 반환합니다.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <returns></returns>
        public static T CopyVO<T>(T source) where T : class, new()
        {
            T instance = new T();
            foreach (var info in source.GetType().GetProperties())
            {
                info.SetValue(instance, info.GetValue(source));
            }
            return instance;
        }
    }
}
