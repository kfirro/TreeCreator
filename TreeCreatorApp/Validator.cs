using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace TreeCreatorApp
{
    class Validator
    {
        public static string Usage(bool IsFirstTime)
        {
            StringBuilder sb = new StringBuilder();
            if (IsFirstTime) {
                sb.AppendLine("\t\t\t\t*** Welcome To Tree Creator ***\t\t");
                sb.AppendLine("\t\tThis app let you create a recovery / backup folder according to yours deployment package");
                sb.AppendLine(string.Empty);
            }
            //sb.AppendLine(string.Format("Please choose 3 valid directories!"));
            sb.AppendLine(string.Format("Example:\nC:/Temp/package_sprint213 C:/hshome/production_folder C:/Temp/backup_07052018"));
            return sb.ToString();
        }
        public static bool IsValid(string[] args,out string errMsg,Simulation simulation = Simulation.No)
        {
            errMsg = string.Empty;
            if (!CouldParseParameters(args,out errMsg))
                return false;

            string packageDirectoryTreePath = args[0];
            string rollbackDirectoryTreePath = args[1];
            string rollbackDirectoryDestinationPath = args[2];
            if (string.IsNullOrEmpty(packageDirectoryTreePath) || string.IsNullOrEmpty(rollbackDirectoryTreePath) || string.IsNullOrEmpty(rollbackDirectoryDestinationPath))
            {
                errMsg = "Parameters are missing!";                
                return false;
            }
            if (!Directory.Exists(packageDirectoryTreePath))
            {
                errMsg = string.Format("Directory: {0} does not exists!", packageDirectoryTreePath);
                return false;
            }
            if (!Directory.Exists(rollbackDirectoryTreePath))
            {
                errMsg = string.Format("Directory: {0} does not exists!", rollbackDirectoryTreePath);
                return false;
            }
            if (!Directory.Exists(rollbackDirectoryDestinationPath) && simulation.Equals(Simulation.No))
            {                
                return FileSystemManager.QuickCreateDirectory(rollbackDirectoryDestinationPath,out errMsg);
            }
            return true;
        }
        private static bool CouldParseParameters(string[] args,out string errMsg)
        {
            errMsg = string.Empty;
            if (args == null || args.Length != 3)
            {
                errMsg = "Too many / Not enough parameters!";
                return false;
            }
            return true;
        }
    }
}
