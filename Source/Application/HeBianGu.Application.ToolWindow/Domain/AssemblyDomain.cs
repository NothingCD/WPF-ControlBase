﻿using HeBianGu.Base.WpfBase;
using HeBianGu.Common.LocalConfig;
using HeBianGu.General.WpfControlLib;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace HeBianGu.Application.ToolWindow
{
    public class AssemblyDomain : IAssemblyDomain
    {
        string filePath = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), SysTemConfiger.ConfigerFolder);

        public ObservableCollection<FileBindModel> GetCommons()
        {
           string _configerPath = System.IO.Path.Combine(filePath, "myDoc.configer");

            Directory.CreateDirectory(filePath);

            if (!File.Exists(_configerPath))
            {
                File.WriteAllText(_configerPath, string.Empty);
            }

            string s = File.ReadAllText(_configerPath);

            ObservableCollection<FileBindModel> b = s.SerializeDeJson<ObservableCollection<FileBindModel>>();

            return b??new ObservableCollection<FileBindModel>();
        }

       public void SaveCommons(ObservableCollection<FileBindModel> collection)
        {
            string s = collection.SerializeJson<ObservableCollection<FileBindModel>>();

            string _configerPath = System.IO.Path.Combine(filePath, "myDoc.configer");

            File.WriteAllText(_configerPath, s);
        }

        public FileBindModel GetClipBoardFile()
        {
            // HTodo  ：复制的文件路径 
            string text = System.Windows.Clipboard.GetText();

            if (!string.IsNullOrEmpty(text))
            {
                if (Directory.Exists(text))
                {
                    return new FileBindModel(Directory.CreateDirectory(text));
                }

                if (File.Exists(text))
                {
                    FileInfo file = new FileInfo(text);
                    return new FileBindModel(file);
                }
            }

            // HTodo  ：复制的文件 
            System.Collections.Specialized.StringCollection list = System.Windows.Clipboard.GetFileDropList();

            foreach (var item in list)
            {

                if (Directory.Exists(item))
                {
                    return new FileBindModel(Directory.CreateDirectory(item));
                }

                if (File.Exists(item))
                {
                    FileInfo file = new FileInfo(item);
                    return new FileBindModel(file);
                }
            }

            return null;
        }



        public ObservableCollection<FileBindModel> GetFavorites()
        {

            ObservableCollection<FileBindModel> result = new ObservableCollection<FileBindModel>();

            string recent = Environment.GetFolderPath(Environment.SpecialFolder.Favorites);

            var files = recent.GetAllFile();

            foreach (var item in files)
            {
                FileBindModel f = new FileBindModel(item);

                if (string.IsNullOrEmpty(f.FilePath)) continue;

                result.Add(f);
            }

            return result;
        }

    }
}
