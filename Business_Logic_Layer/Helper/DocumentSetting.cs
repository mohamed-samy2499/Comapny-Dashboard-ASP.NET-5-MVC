using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic_Layer.Helper
{
    public static class DocumentSetting
    {
        public static string UploadFile(IFormFile File, string FolderName) 
        {
            //1- Get the Folder that hold the personal CVS of Employees
            string FolderPath = Path.Combine(Directory.GetCurrentDirectory(),"wwwroot/files/",FolderName);
            //2- Get a unique name for the CV file
            string FileName = Guid.NewGuid() + Path.GetFileName(File.FileName);
            //3- the whole file path
            string FilePath = Path.Combine(FolderPath, FileName);
            //4- save the file as stream ,, File is an unmanaged resourse so we use using
            using (var fs = new FileStream(FilePath, FileMode.Create)) //try{var fs = new FileStream(FilePath, FileMode.Create)} finally{fs.dispose();}
            {
                File.CopyTo(fs);
            }
            return FileName;
        }
    }
}
