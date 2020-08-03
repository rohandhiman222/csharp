using System;
using System.IO;

namespace FirstFile
{
    public class FilesAndDirectory
    {
        /*
         * System.IO
         *  File, FileInfo
         *  Directory, DirectoryInfo
         *  Path
         *  File, FileInfo =>
         *     Provide methods for creating, copying, deleting, moving, and opening of files
         *     FileInfo: provides instance method
         *     File: provides static methods
         *     use with instance once object created youcan do anything
         *     Create(), Copy(), Delete(), Exists(), GetAttributes(), Move(), ReadAllText()
         *
         *  Directory, DirectoryInfo
         *  Directory: provides static methods
         *  DirectoryInfo: provides instance method
         *  CreateDirectory(), Delete(), Exists(), GetCurrentDirectory(), GetFiles(), Move(), GetLogicalDrivers()
         *
         *  Path
         *   GetDirectoryName(), GetFileName(), GetExtension(), GetTempPath();
         * 
         */

        static void hello()
        {
            // system security check this is system slow performance
            File.Copy("c:\\temp\\filename.jpg", "d:\\temp\\file.jpg", true);
            var path = @"c:\somefile.jpg";
            File.Delete(path);
            if (File.Exists(path))
            {
                
            }

           var content = File.ReadAllText(path);
            
           
           var fileInfo = new FileInfo(path);
           fileInfo.CopyTo("...");
           fileInfo.Delete();
           if (fileInfo.Exists)
           {
               
           }
           
           
      // Directory
      Directory.CreateDirectory(@"c:\temp\foldername");
    var files =  Directory.GetFiles(@"c:\projects\csharp", "*.*", SearchOption.AllDirectories);

      foreach (var file in files)
      {
          Console.WriteLine(file);         
      }


      var directories = Directory.GetDirectories(@"c:\project/", "*.*", SearchOption.AllDirectories);

      var directoryInfo = new DirectoryInfo("....");
      directoryInfo.GetFiles();
      directoryInfo.GetDirectories();


        }
        
    }
}