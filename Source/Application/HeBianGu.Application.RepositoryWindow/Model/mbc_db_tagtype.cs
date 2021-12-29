﻿using HeBianGu.Base.WpfBase;
using System.ComponentModel.DataAnnotations;

namespace HeBianGu.Application.RepositoryWindow
{
    public class mbc_db_tagtype : mbc_db_modelbase
    {
        [Display(Name = "类型名称")]
        public string Name { get; set; } 

        [Display(Name = "报警类型ID")]
        public string Value { get; set; }

        [Display(Name = "数据类型")]
        public string Text { get; set; } 

    }
}
