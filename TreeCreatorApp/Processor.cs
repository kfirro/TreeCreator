using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TreeCreatorApp
{
    public class Processor
    {
        public Processor()
        {

        }
        public bool StartProcessing(string[] args,TreeCreator app)
        {            
            string packageDirectoryTreePath = args[0];
            string rollbackDirectoryTreePath = args[1];
            string rollbackDirectoryDestinationPath = args[2];
            bool IsRollbackSuccess = true;
            FileSystemManager fsm = new FileSystemManager(app);
            //app.AppendToConsole(string.Format("DEBUG - Deployment package contains {0} files, Production folder contains {1} files", fsm.GetFilesCountByDirectory(packageDirectoryTreePath), fsm.GetFilesCountByDirectory(rollbackDirectoryTreePath)));
            app.AppendToConsole("Starting...");
            List<string> files = fsm.GetDirectoryFiles(packageDirectoryTreePath);
            int copiedFilesCounter = 0;
            foreach (string fileFullPath in files)
            {
                //Extract the file name
                string fileName = fsm.FileNameExtract(fileFullPath);
                //Get the file's full path 
                string destinationFileFullPath = fsm.PathReplace(packageDirectoryTreePath, rollbackDirectoryDestinationPath, fileFullPath);
                string sourceFileFullPath = fsm.PathReplace(packageDirectoryTreePath, rollbackDirectoryTreePath, fileFullPath);
                //Get the relative file's directory                    
                string destinationFileDir = fsm.GetNonCreatedFileDirectory(destinationFileFullPath, fileName);
                string sourceFileDir = fsm.GetNonCreatedFileDirectory(sourceFileFullPath, fileName);
                string packageFileDir = fsm.GetNonCreatedFileDirectory(fileFullPath, fileName);
                //Copy from the rollback directory to rollback directory destination
                string errMsg = string.Empty;
                if (!fsm.CopyFile(sourceFileDir, sourceFileFullPath, destinationFileDir, destinationFileFullPath, fileFullPath, packageFileDir,out errMsg,simulation: app.Simulation))
                {
                    if (!errMsg.EndsWith("does not exist! Skipping.."))
                    {
                        IsRollbackSuccess = false;
                        break;
                    }
                }
                else
                {
                    app.AppendToConsole(string.Format("INFO - Copied file: {0} to: {1}", fileName, destinationFileDir));
                    copiedFilesCounter++;
                }
            }
            app.AppendToConsole(app.Simulation.Equals(Simulation.Yes) ? 
                string.Format("Total files should be copied: {0}", copiedFilesCounter) 
                : string.Format("Total files copied: {0}", copiedFilesCounter));
            return IsRollbackSuccess;
        }
    }

}
