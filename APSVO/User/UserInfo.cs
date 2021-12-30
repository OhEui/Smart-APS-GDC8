﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APSVO
{
    public class UserInfo
    {
        // 회원가입 시 입력하는 항목들
        public string User_ID { get; set; }
        public string User_PWD { get; set; }
        public string User_Name { get; set; }
        public string User_Email { get; set; }
        public string User_phone { get; set; }
        public DateTime User_Birth { get; set; }
        public int Dept_ID { get; set; }

        // 비밀번호 확인 (DB에는 저장 안 됨)
        public string User_PWD_Repeat { get; set; } 

        // 회원가입 시 입력하면 안되는 항목들
        public int? User_NO { get; set; }
        public bool User_IsAdmin { get; set; }
    }

}