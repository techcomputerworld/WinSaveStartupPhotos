﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinSaveStartupPhotos
{
    public class SavePhotos
    {
        public string PathStartupPhotos { get; set; }
        public string PathUser { get; set; }
        public string FileStartupPhoto { get; set; }
        public string FileUserPhoto { get; set; }
        //string folder will be to say to which folder we are going to copy all the photos
        //string carpeta va a ser para decir a que carpeta vamos a copiar todas las fotos
        //this method for a console aplication
        //este metodo para una aplicación de consola
        public void SavePhotoWindows()
        {
            string userName = Environment.UserName;
            PathStartupPhotos = Path.GetFullPath("C:\\Users\\" + userName + "\\AppData\\Local\\Packages"
                + "\\Microsoft.Windows.ContentDeliveryManager_cw5n1h2txyewy\\" +
                 "LocalState\\Assets");
            PathUser = Path.GetFullPath("C:\\Users\\" + userName);
            TryCopy();
        }
        public void SavePhotoWindows(string folder)
        {
            string userName = Environment.UserName;
            PathStartupPhotos = Path.GetFullPath("C:\\Users\\" + userName + "\\AppData\\Local\\Packages"
                + "\\Microsoft.Windows.ContentDeliveryManager_cw5n1h2txyewy\\" +
                 "LocalState\\Assets");
            PathUser = Path.GetFullPath("C:\\Users\\" + userName);
            if (folder == "documents")
            {
                PathUser = Path.GetFullPath("C:\\Users\\" + userName + "\\Documents");
            }
            else if (folder == "Downloads")
            {
                PathUser = Path.GetFullPath("C:\\Users\\" + userName + "\\Downloads");
            }
            else
            {
                PathUser = Path.GetFullPath("C:\\Users\\" + userName + "\\" + folder);

            }
            //check that the directory exists
            //comprobar que existe el directorio
            try
            {
                DirectoryInfo directory = new DirectoryInfo(PathUser);
                if (!directory.Exists)
                {
                    Directory.CreateDirectory(PathUser);
                }

            }
            catch (Exception e)
            {
                MessageBox.Show( e.ToString(), "Error to create the folder");
            }
            TryCopy();

        }
        private void TryCopy()
        {
            try
            {
                string[] fileList = Directory.GetFiles(PathStartupPhotos);
                foreach (string file in fileList)
                {
                    FileStartupPhoto = Path.GetFileName(file.ToString());
                    FileUserPhoto = Path.GetFileName(FileStartupPhoto + ".jpg");
                    File.Copy(Path.Combine(PathStartupPhotos, FileStartupPhoto), Path.Combine(PathUser, FileUserPhoto), true);
                }
                Console.WriteLine("images copied successfully");

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error");
            }
        }
    }//final class SavePhotos
}

