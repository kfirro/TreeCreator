using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.IO;

namespace TreeCreatorApp
{
    public class FileSystemManager
    {
        public TreeCreator Tree { get; private set; }
        public FileSystemManager(TreeCreator tree)
        {
            Tree = tree;
        }
        public static bool QuickCreateDirectory(string dir,out string errMsg)
        {
            errMsg = string.Empty;
            if (string.IsNullOrEmpty(dir))
                return false;
            try
            {
                DirectoryInfo info = Directory.CreateDirectory(dir);
                return info != null;
            }
            catch (Exception e)
            {
                errMsg = string.Format("Couldn't create directory: {0}\nException: {1}",dir,e.Message);
                return false;
            }
        }
        public int GetFilesCountByDirectory(string dir)
        {
            if (string.IsNullOrEmpty(dir))
                return -1;
            try
            {
                DirectoryInfo info = Directory.CreateDirectory(dir);
                if (info == null)
                    return -1;
                return GetDirectoryFiles(dir).Count;
            }
            catch (Exception e)
            {
                Tree.AppendToConsole(string.Format("Couldn't Get directory info! Directory: {0}\nException: {1}", dir, e.Message));
                return -1;
            }
        }
        public bool CreateDirectory(string dir)
        {
            if (string.IsNullOrEmpty(dir))
                return false;
            try
            {
                DirectoryInfo info = Directory.CreateDirectory(dir);
                return info != null;
            }
            catch (Exception e)
            {
                Tree.AppendToConsole(string.Format("Couldn't create directory {0}\nException: {1}", dir, e.Message));
                return false;
            }
        }
        public bool CopyFile(string sourceDir, string sourceFileFullPath, string destDir, string destFileFullPath, string packageFileFullPath, string packageDir,out string errMsg, bool overwrite = true,Simulation simulation = Simulation.No)
        {
            errMsg = string.Empty;
            if (string.IsNullOrEmpty(sourceDir) || string.IsNullOrEmpty(sourceFileFullPath) || string.IsNullOrEmpty(destDir) || string.IsNullOrEmpty(destFileFullPath) || string.IsNullOrEmpty(packageFileFullPath) || string.IsNullOrEmpty(packageDir))
                return false;
            if (!Directory.Exists(sourceDir))
            {
                Tree.AppendToConsole(string.Format("Directory {0} does not exist!", sourceDir));
                return false;
            }
            if (!File.Exists(sourceFileFullPath))
            {
                //In case of new files, add them and warn us
                errMsg = string.Format("WARN - File {0} does not exist! Skipping..", sourceFileFullPath);
                Tree.AppendToConsole(errMsg);
                return false; 
                //Copy the file from the package straight to the rollback folder 
                //sourceDir = packageDir;
                //sourceFileFullPath = packageFileFullPath;
                //CopyFile(packageDir, packageFileFullPath, destDir, destFileFullPath, "whatever", "whatever",out errMsg);
                
            }
            string sourceFileName = FileNameExtract(sourceFileFullPath);
            try
            {
                //First check for existence of the directories required for the copy - if the don't exists just create them
                if (!Directory.Exists(destDir) && simulation.Equals(Simulation.No))
                    Directory.CreateDirectory(destDir);
                //Copy the requested file
                if(simulation.Equals(Simulation.No))
                    File.Copy(sourceFileFullPath, destFileFullPath, overwrite);
            }
            catch (Exception e)
            {
                Tree.AppendToConsole(string.Format("Could not copy file: {0}\nException: {1}", sourceFileName, e.Message));
                return false;
            }
            return true;
        }
        public List<string> GetDirectoryFiles(string dir, string searchPattern = "*.*")
        {
            List<string> files = new List<string>();
            if (string.IsNullOrEmpty(dir) || !Directory.Exists(dir))
                return files;
            try
            {
                string[] filesArr = Directory.GetFiles(dir, searchPattern, SearchOption.AllDirectories);
                if (filesArr != null)
                    files = filesArr.ToList();
            }
            catch (Exception e)
            {
                Tree.AppendToConsole(string.Format("Couldn't get directories files for directory (recursive) : {0}\nException: {1}", dir, e.Message));
            }
            return files;
        }
        public string PathExtract(string fullPath)
        {
            if (string.IsNullOrEmpty(fullPath))
                return string.Empty;
            return File.Exists(fullPath) ? Path.GetDirectoryName(fullPath) : string.Empty;
        }
        public string FileNameExtract(string fullPath)
        {
            if (string.IsNullOrEmpty(fullPath))
                return string.Empty;
            return File.Exists(fullPath) ? Path.GetFileName(fullPath) : string.Empty;
        }
        public string PathReplace(string dir, string dirReplacement, string fullPath)
        {
            if (string.IsNullOrEmpty(dir) || string.IsNullOrEmpty(dirReplacement) || string.IsNullOrEmpty(fullPath))
                return string.Empty;
            //Used it to replace only the first occurrence of the dir string
            return new Regex(Regex.Escape(dir)).Replace(fullPath, dirReplacement, 1);
        }
        public string GetNonCreatedFileDirectory(string fullPath, string fileName)
        {
            if (string.IsNullOrEmpty(fullPath) || string.IsNullOrEmpty(fileName))
                return string.Empty;
            return fullPath.Substring(0, fullPath.Length - fileName.Length);
        }
        private string GetFullPath(string dir, string fileName)
        {
            return string.IsNullOrEmpty(dir) || string.IsNullOrEmpty(fileName) ? string.Empty : string.Concat(dir, "\\", fileName);
        }

    }
}
